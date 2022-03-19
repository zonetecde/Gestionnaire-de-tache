using System;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace Gestionnaire_de_tâche__Last_
{
    public partial class UserControl_Message : UserControl
    {
        public UserControl_Message(Message message, Tchat tchat)
        {
            InitializeComponent();

            Message = message;
            Tchat = tchat;
            this.UC = UC;
            initializeAll(message);
        }

        private void initializeAll(Message message)
        {
            richTextBox_message.Rtf = message.Corps;
            label_objet.Text = message.Objet;

            int x = 0, y = 0;
            int i = 0;

            foreach (Control ctrl in groupBox_img.Controls)
            {
                ctrl.Visible = false;
            }

            // On ajoute les images
            foreach (var image in Message.Images)
            {
                UserControl_Image userControl_Image = new UserControl_Image(image, i, message);
                userControl_Image.Location = new Point(x, y);
                x += userControl_Image.Width;
                groupBox_img.Controls.Add(userControl_Image);
                i++;
            }

            // Si il y a plusieurs on autorise le scroll
            int ligne = richTextBox_message.Lines.Length;
            if (ligne > 5)
                richTextBox_message.Enabled = true;

            // Set les deux dates
            TextInfo myTI = new CultureInfo("fr-FR", false).TextInfo;

            label_createThe.Text = "Crée le " + myTI.ToTitleCase(message.Date_De_Publication.ToString("ddd d MMM yyyy",
                      CultureInfo.CreateSpecificCulture("fr-FR")));

            if (message.Date_De_Modification != null)
            {
                label_modifiyThe.Text = "Modifier le " + myTI.ToTitleCase(message.Date_De_Modification.Value.ToString("ddd d MMM yyyy",
                      CultureInfo.CreateSpecificCulture("fr-FR")));

                label_modifiyThe.Visible = true;
            }

            // Set l'état
            panel_statutColor.BackColor = message.Etat_couleur;
            label_statutTexte.Text = message.Etat_texte;

            // Set l'image
            if (message.Images.Count == 0)
            {
                groupBox_img.Visible = false;
                label_createThe.Location = new Point(3, 160);
                label_modifiyThe.Location = new Point(3, 172);

                Size = new Size(this.Width, 161);
            }
        }

        public Message Message { get; set; }
        public Tchat Tchat { get; }
        public UserControl_Tâche UC { get; }
        public Tâche Tache { get; }

        private void richTextBox_message_MouseEnter(object sender, EventArgs e)
        {
        }

        private void UserControl_Message_Load(object sender, EventArgs e)
        {
        }

        private void modifierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tchat.Modify(Message);
        }

        internal void ActualizeInformation(Message nouveauMessage)
        {
            Message = nouveauMessage;
            initializeAll(nouveauMessage);
        }

        private void supprimerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (var ctrl in groupBox_img.Controls)
            {
                UserControl_Image UC = ctrl as UserControl_Image;
                UC.CloseViewWindow();
                UC.SetImageNoNull();
            }

            Tchat.removeUC(Message);
        }

        private void panel_statutColor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void richTextBox_message_ContentsResized(object sender, ContentsResizedEventArgs e)
        {

        }
    }
}