using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Gestionnaire_de_tâche__Last_
{
    public partial class Tchat : Form
    {
        private UserControl_Séléctionner_couleur_texte colorPane;

        public Tchat(Tâche tâche, UserControl_Tâche UC)
        {
            InitializeComponent();

            this.Icon = Gestionnaire_de_tâche__Last_.Properties.Resources.tchat_ico;

            Tâche = tâche;
            this.UC = UC;
            label_titre.Text = "Informations sur la tâche " + tâche.Nom_de_la_tâche;

            colorPane = new UserControl_Séléctionner_couleur_texte(this);
            colorPane.Location = new Point(pictureBox_color.PointToScreen(Point.Empty).X - 9, pictureBox_color.PointToScreen(Point.Empty).Y + 262);
            colorPane.Hide();
            this.Controls.Add(colorPane);

            // Ajoute les messages
            AddAllMessages();           
        }

        private void AddAllMessages()
        {
            int temp = this.VerticalScroll.Value;
            this.VerticalScroll.Value = 0;

            List<Control> toremove = new List<Control>();
            foreach (Control ctrl in panel_message.Controls)
            {
                if (ctrl is UserControl_Message)
                {
                    toremove.Add(ctrl);
                }
            }

            foreach(var ctrl in toremove)
            {
                panel_message.Controls.Remove(ctrl);
            }

            int x = 0, y = 0;
            foreach (var message in Tâche.Messages)
            {
                UserControl_Message userControl_Message = new UserControl_Message(message, this);
                userControl_Message.Location = new Point(x, y);
                panel_message.Controls.Add(userControl_Message);
                y += userControl_Message.Height;
            }

            this.VerticalScroll.Value = temp;
        }

        public Tâche Tâche { get; }
        public UserControl_Tâche UC { get; }

        // Écrire un message
        // Hauteur à monter et la hauteur que doit monter le panel pour écrire un nouveau message
        private const int HAUTEUR_A_MONTER = 265;

        // La location de départ d'apparation du panel pour écrire un message
        private Point PANEL_MESSAGE_LOCATION_DE_DEPART = new Point(0, 598);

        // Si le panel de création de message est affiché
        private bool messagePanelIsShowing = false;

        internal void SetSelectedTextColorTo(Color selectedColor)
        {
            richTextBox_message.SelectionColor = selectedColor;
        }

        private void Tchat_Load(object sender, EventArgs e)
        {
            // Set la location du panel de message de départ automatiquement
            panel_nouveauMessage.Location = PANEL_MESSAGE_LOCATION_DE_DEPART;
        }

        private bool isEdited = false;
        private Message messageToEdit;

        /// <summary>
        /// Modifie un message
        /// </summary>
        /// <param name="message"></param>
        internal void Modify(Message message)
        {
            isEdited = true;

            messageToEdit = message;

            Button_add.Image = Gestionnaire_de_tâche__Last_.Properties.Resources.modify;

            textBox_objet.Text = message.Objet;
            richTextBox_message.Rtf = message.Corps;

            comboBox_images.Items.Clear();
            imagesPath.Clear();

            foreach (var img in message.Images)
            {
                imagesPath.Add(img);

                comboBox_images.Items.Add(System.IO.Path.GetFileName(img));

                comboBox_images.SelectedIndex = 0;
            }

            label_newMessage_MouseDown(this, new MouseEventArgs(MouseButtons.Left, 0, 0, 0, 0));
        }

        /// <summary>
        /// Supprime un message
        /// </summary>
        /// <param name="message"></param>
        internal void removeUC(Message message)
        {
            for (int i = panel_message.Controls.Count - 1; i > -1; i--)
            {
                if (panel_message.Controls[i] is UserControl_Message && panel_message.Controls[i].Visible == true)
                {
                    UserControl_Message ctrlA = panel_message.Controls[i] as UserControl_Message;
                    if (ctrlA.Message == message)
                    {
                        foreach (var img in message.Images)
                        {
                            File.Delete(img);
                        }

                        ctrlA.Visible = false;
                        Tâche.Messages.Remove(message);
                    }
                }
            }

            AddAllMessages();
            UC.UpdateTâche(Tâche);
        }

        /// <summary>
        /// Affiche le panel pour écrire un message
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void label_newMessage_MouseDown(object sender, MouseEventArgs e)
        {
            btn_hide.Visible = true;

            if (!messagePanelIsShowing)
            {
                messagePanelIsShowing = true;

                for (int i = PANEL_MESSAGE_LOCATION_DE_DEPART.Y; i > HAUTEUR_A_MONTER; i--)
                {
                    panel_nouveauMessage.Location = new Point(0, i);
                }
            }

            this.ActiveControl = textBox_objet;
        }

        /// <summary>
        /// Cache la panel pour écrire un message
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_hide_MouseDown(object sender, MouseEventArgs e)
        {
            if (messagePanelIsShowing)
            {
                messagePanelIsShowing = false;

                for (int i = HAUTEUR_A_MONTER; i < PANEL_MESSAGE_LOCATION_DE_DEPART.Y; i++)
                {
                    panel_nouveauMessage.Location = new Point(0, i);
                }
            }
        }

        /// <summary>
        /// Met le texte en gras en fonction du style déjà mis sur le texte
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBox_bold_MouseDown(object sender, MouseEventArgs e)
        {
            // Si il est gras, souligner et italique on le met en souligner et italique
            if (richTextBox_message.SelectionFont.Style == (FontStyle.Italic | FontStyle.Bold | FontStyle.Underline))
            {
                richTextBox_message.SelectionFont = new Font(richTextBox_message.Font, (FontStyle.Italic | FontStyle.Underline));
            }
            // Si il est souligner on le met en souligner et en gras
            else if (richTextBox_message.SelectionFont.Style == (FontStyle.Underline))
            {
                richTextBox_message.SelectionFont = new Font(richTextBox_message.Font, (FontStyle.Underline) | FontStyle.Bold);
            }
            // Si il est souligner et en gras on le met en souligner
            else if (richTextBox_message.SelectionFont.Style == (FontStyle.Underline | FontStyle.Bold))
            {
                richTextBox_message.SelectionFont = new Font(richTextBox_message.Font, (FontStyle.Underline));
            }
            // Si il est en italique et en souligner on le met en italique en grand et en souligner
            else if (richTextBox_message.SelectionFont.Style == (FontStyle.Italic | FontStyle.Underline))
            {
                richTextBox_message.SelectionFont = new Font(richTextBox_message.Font, (FontStyle.Italic | FontStyle.Underline) | FontStyle.Bold);
            }
            // Si il est en italique et en gras on le met en italique
            else if (richTextBox_message.SelectionFont.Style == (FontStyle.Italic | FontStyle.Bold))
            {
                richTextBox_message.SelectionFont = new Font(richTextBox_message.Font, (FontStyle.Italic));
            }
            // Si il est en italique on le met en italique et en gras
            else if (richTextBox_message.SelectionFont.Style == FontStyle.Italic)
            {
                richTextBox_message.SelectionFont = new Font(richTextBox_message.Font, (FontStyle.Bold | FontStyle.Italic));
            }
            // Si il est en gras on le met en normal
            else if (richTextBox_message.SelectionFont.Style == FontStyle.Bold)
            {
                richTextBox_message.SelectionFont = new Font(richTextBox_message.Font, FontStyle.Regular);
            }
            // Sinon on le met en gras
            else
            {
                richTextBox_message.SelectionFont = new Font(richTextBox_message.Font, FontStyle.Bold);
            }

            if (richTextBox_message.SelectionFont.Style == (FontStyle.Bold | richTextBox_message.SelectionFont.Style))
            {
                pictureBox_bold.BackColor = Color.FromName("PeachPuff");
            }
            else
            {
                pictureBox_bold.BackColor = Color.FromName("Linen");
            }
        }

        /// <summary>
        /// Met le texte en italique en fonction du style déjà mis sur le texte
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBox_italic_MouseDown(object sender, MouseEventArgs e)
        {
            if (richTextBox_message.SelectionFont.Style == (FontStyle.Italic | FontStyle.Bold | FontStyle.Underline))
            {
                richTextBox_message.SelectionFont = new Font(richTextBox_message.Font, (FontStyle.Bold | FontStyle.Underline));
            }
            else if (richTextBox_message.SelectionFont.Style == (FontStyle.Underline))
            {
                richTextBox_message.SelectionFont = new Font(richTextBox_message.Font, (FontStyle.Italic | FontStyle.Underline));
            }
            else if (richTextBox_message.SelectionFont.Style == (FontStyle.Bold | FontStyle.Underline))
            {
                richTextBox_message.SelectionFont = new Font(richTextBox_message.Font, (FontStyle.Italic | FontStyle.Underline) | FontStyle.Bold);
            }
            else if (richTextBox_message.SelectionFont.Style == (FontStyle.Italic | FontStyle.Bold))
            {
                richTextBox_message.SelectionFont = new Font(richTextBox_message.Font, (FontStyle.Bold));
            }
            else if (richTextBox_message.SelectionFont.Style == FontStyle.Bold)
            {
                richTextBox_message.SelectionFont = new Font(richTextBox_message.Font, (FontStyle.Bold | FontStyle.Italic));
            }
            else if (richTextBox_message.SelectionFont.Style == FontStyle.Italic)
            {
                richTextBox_message.SelectionFont = new Font(richTextBox_message.Font, FontStyle.Regular);
            }
            else if (richTextBox_message.SelectionFont.Style == (FontStyle.Italic | FontStyle.Underline))
            {
                richTextBox_message.SelectionFont = new Font(richTextBox_message.Font, (FontStyle.Underline));
            }
            else
            {
                richTextBox_message.SelectionFont = new Font(richTextBox_message.Font, FontStyle.Italic);
            }

            if (richTextBox_message.SelectionFont.Style == (FontStyle.Italic | richTextBox_message.SelectionFont.Style))
            {
                pictureBox_italic.BackColor = Color.FromName("PeachPuff");
            }
            else
            {
                pictureBox_italic.BackColor = Color.FromName("Linen");
            }
        }

        /// <summary>
        /// Souligne le texte en fonction du style déjà mis sur le texte
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBox_underline_MouseDown(object sender, MouseEventArgs e)
        {
            if (richTextBox_message.SelectionFont.Style == (FontStyle.Italic | FontStyle.Bold | FontStyle.Underline))
            {
                richTextBox_message.SelectionFont = new Font(richTextBox_message.Font, (FontStyle.Bold | FontStyle.Italic));
            }
            else if (richTextBox_message.SelectionFont.Style == (FontStyle.Italic))
            {
                richTextBox_message.SelectionFont = new Font(richTextBox_message.Font, (FontStyle.Italic | FontStyle.Underline));
            }
            else if (richTextBox_message.SelectionFont.Style == (FontStyle.Bold | FontStyle.Italic))
            {
                richTextBox_message.SelectionFont = new Font(richTextBox_message.Font, (FontStyle.Italic | FontStyle.Underline) | FontStyle.Bold);
            }
            else if (richTextBox_message.SelectionFont.Style == (FontStyle.Italic | FontStyle.Underline))
            {
                richTextBox_message.SelectionFont = new Font(richTextBox_message.Font, (FontStyle.Bold));
            }
            else if (richTextBox_message.SelectionFont.Style == FontStyle.Bold)
            {
                richTextBox_message.SelectionFont = new Font(richTextBox_message.Font, (FontStyle.Bold | FontStyle.Underline));
            }
            else if (richTextBox_message.SelectionFont.Style == FontStyle.Underline)
            {
                richTextBox_message.SelectionFont = new Font(richTextBox_message.Font, FontStyle.Regular);
            }
            else if (richTextBox_message.SelectionFont.Style == (FontStyle.Bold | FontStyle.Underline))
            {
                richTextBox_message.SelectionFont = new Font(richTextBox_message.Font, (FontStyle.Bold));
            }
            else if (richTextBox_message.SelectionFont.Style == (FontStyle.Italic | FontStyle.Underline))
            {
                richTextBox_message.SelectionFont = new Font(richTextBox_message.Font, (FontStyle.Italic));
            }
            else
            {
                richTextBox_message.SelectionFont = new Font(richTextBox_message.Font, FontStyle.Underline);
            }

            if (richTextBox_message.SelectionFont.Style == (FontStyle.Underline | richTextBox_message.SelectionFont.Style))
            {
                pictureBox_underline.BackColor = Color.FromName("PeachPuff");
            }
            else
            {
                pictureBox_underline.BackColor = Color.FromName("Linen");
            }
        }

        private void richTextBox_message_MouseMove(object sender, MouseEventArgs e)
        {
            if (richTextBox_message.SelectionFont.Style == (FontStyle.Underline | richTextBox_message.SelectionFont.Style))
            {
                pictureBox_underline.BackColor = Color.FromName("PeachPuff");
            }
            else
            {
                pictureBox_underline.BackColor = Color.FromName("Linen");
            }

            if (richTextBox_message.SelectionFont.Style == (FontStyle.Bold | richTextBox_message.SelectionFont.Style))
            {
                pictureBox_bold.BackColor = Color.FromName("PeachPuff");
            }
            else
            {
                pictureBox_bold.BackColor = Color.FromName("Linen");
            }

            if (richTextBox_message.SelectionFont.Style == (FontStyle.Italic | richTextBox_message.SelectionFont.Style))
            {
                pictureBox_italic.BackColor = Color.FromName("PeachPuff");
            }
            else
            {
                pictureBox_italic.BackColor = Color.FromName("Linen");
            }

            if (richTextBox_message.SelectionFont.Style == (FontStyle.Underline | richTextBox_message.SelectionFont.Style))
            {
                pictureBox_underline.BackColor = Color.FromName("PeachPuff");
            }
            else
            {
                pictureBox_underline.BackColor = Color.FromName("Linen");
            }
        }

        private void pictureBox_color_MouseDown(object sender, MouseEventArgs e)
        {
            if (!colorPane.Visible)
            {
                colorPane.Show();
                colorPane.BringToFront();
            }
            else
            {
                colorPane.Hide();
            }
        }

        private List<string> imagesPath = new List<string>();

        private void button_addImg_MouseDown(object sender, MouseEventArgs e)
        {
            InitializeOpenFileDialog();

            if (openFileWindow.ShowDialog() == DialogResult.OK)
            {
                // On ajoute le chemin d'accès aux fichiers à la List
                foreach (String file in openFileWindow.FileNames)
                {
                    imagesPath.Add(file);

                    comboBox_images.Items.Add(System.IO.Path.GetFileName(file));

                    comboBox_images.SelectedIndex = 0;
                }
            }
        }

        private void InitializeOpenFileDialog()
        {
            // Initialise la boite de dialog pour choisir des fichiers
            openFileWindow = new OpenFileDialog
            {
                Title = "Veuillez choisir une ou plusieurs images",
                InitialDirectory = "c:\\",
                Multiselect = true,
                Filter = "Fichier image (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png",
                FilterIndex = 0,
                RestoreDirectory = true,
            };
        }

        private void pictureBox_delete_MouseDown(object sender, MouseEventArgs e)
        {
            imagesPath.RemoveAt(comboBox_images.SelectedIndex);
            comboBox_images.Items.RemoveAt(comboBox_images.SelectedIndex);

            if (comboBox_images.Items.Count > 0)
                comboBox_images.SelectedIndex = 0;
        }

        /// <summary>
        /// Crée le message
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_add_MouseDown(object sender, MouseEventArgs e)
        {
            if (!(String.IsNullOrEmpty(textBox_objet.Text) || String.IsNullOrEmpty(richTextBox_message.Text)))
            {
                if (!isEdited)
                {
                    string rtfMessage = richTextBox_message.Rtf;
                    string objet = textBox_objet.Text;

                    Random rdn = new Random();
                    for (int i = 0; i < imagesPath.Count; i++)
                    {
                        int Id = rdn.Next(0, 972659601);
                        string file = Path.GetFileNameWithoutExtension(imagesPath[i]);
                        string NewPath = imagesPath[i].Replace(file, file + Id.ToString());

                        File.Copy(imagesPath[i], Utilities.imagesPath + Path.GetFileName(NewPath));

                        imagesPath[i] = Utilities.imagesPath + Path.GetFileName(NewPath);
                    }

                    DateTime date_de_publication = DateTime.Now;
                    string texteEtat = Main.Utilities.resource.etats[Tâche.State_de_la_tâche].Texte_de_l_etat;
                    Color couleurEtat = Main.Utilities.resource.etats[Tâche.State_de_la_tâche].Couleur_de_l_etat;

                    string[] vs = imagesPath.ToArray();
                    Message message = new Message(objet, rtfMessage, vs.ToList(), date_de_publication, texteEtat, couleurEtat);

                    Tâche.Messages.Insert(0, message);

                    AddMessage(Tâche.Messages[0]);
                    Main.Utilities.SaveResources();

                    btn_hide_MouseDown(this, new MouseEventArgs(MouseButtons.Left, 0, 0, 0, 0));

                    richTextBox_message.Clear();
                    textBox_objet.Clear();
                    imagesPath.Clear();
                    comboBox_images.Items.Clear();

                    UC.UpdateTâche(Tâche);
                }
                else
                {
                    isEdited = false;
                    Button_add.Image = Gestionnaire_de_tâche__Last_.Properties.Resources.add2;

                    string rtfMessage = richTextBox_message.Rtf;
                    string objet = textBox_objet.Text;

                    Random rdn = new Random();

                    for (int i = 0; i < imagesPath.Count; i++)
                    {
                        if (!File.Exists(imagesPath[i]))
                        {
                            int Id = rdn.Next(0, 972659601);
                            string file = Path.GetFileNameWithoutExtension(imagesPath[i]);
                            string NewPath = imagesPath[i].Replace(file, file + Id.ToString());

                            File.Copy(imagesPath[i], Utilities.imagesPath + Path.GetFileName(NewPath));
                            imagesPath[i] = Utilities.imagesPath + Path.GetFileName(NewPath);
                        }
                    }

                    DateTime date_de_publication = DateTime.Now;
                    string texteEtat = Main.Utilities.resource.etats[Tâche.State_de_la_tâche].Texte_de_l_etat;
                    Color couleurEtat = Main.Utilities.resource.etats[Tâche.State_de_la_tâche].Couleur_de_l_etat;

                    string[] vs = imagesPath.ToArray();
                    Message message = new Message(objet, rtfMessage, vs.ToList(), messageToEdit.Date_De_Publication, texteEtat, couleurEtat);
                    message.Date_De_Modification = DateTime.Now;

                    ActualizeMessage(message, messageToEdit); ;

                    Tâche.Messages[Tâche.Messages.IndexOf(messageToEdit)] = message;

                    Main.Utilities.SaveResources();
                    btn_hide_MouseDown(this, new MouseEventArgs(MouseButtons.Left, 0, 0, 0, 0));

                    richTextBox_message.Clear();
                    textBox_objet.Clear();
                    imagesPath.Clear();
                    comboBox_images.Items.Clear();
                }
            }
            else
            {
                MessageBox.Show("Vous devez renseigner l'objet et le corps du message !", "Erreur !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ActualizeMessage(Message nouveauMessage, Message AncienMessage)
        {
            foreach (Control ctrl in panel_message.Controls)
            {
                if (ctrl is UserControl_Message)
                {
                    UserControl_Message UC = ctrl as UserControl_Message;

                    if (UC.Message == AncienMessage)
                    {
                        UC.ActualizeInformation(nouveauMessage);
                    }
                }
            }
        }

        private void AddMessage(Message message)
        {
            int temp = panel_message.VerticalScroll.Value;
            panel_message.VerticalScroll.Value = 0;

            int x = 0, y = 0;
            UserControl_Message userControl_Message = new UserControl_Message(message, this);
            userControl_Message.Location = new Point(x, y);
            panel_message.Controls.Add(userControl_Message);
            y += userControl_Message.Height;

            foreach (var ctrl in panel_message.Controls)
            {
                if (ctrl is UserControl_Message)
                {
                    UserControl_Message userControl = ctrl as UserControl_Message;
                    if (userControl != userControl_Message)
                    {
                        userControl.Location = new Point(x, y);
                        y += userControl.Height;
                    }
                }
            }

            panel_message.VerticalScroll.Value = temp;
        }
    }
}