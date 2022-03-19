using System;
using System.Drawing;
using System.Windows.Forms;

namespace Gestionnaire_de_tâche__Last_
{
    public partial class UserControl_Projet : UserControl
    {
        public Projet attachedProject { get; set; }
        public bool V { get; set; }

        public UserControl_Projet(Projet projet, bool v = false)
        {
            InitializeComponent();

            attachedProject = projet;
            V = v;
            if (v)
            {
                UserControl_Projet_MouseDown(this, new MouseEventArgs(MouseButtons.Left, 0, 0, 0, 0));
            }
        }

        private void UserControl_Projet_Load(object sender, EventArgs e)
        {
            label_title.Text = attachedProject.Nom_du_projet;

            panel_color.BackColor = Color.FromArgb(Convert.ToInt32(attachedProject.Couleur_du_projet));
        }

        /// <summary>
        /// Effet lors de l'entrer de la souris si celui-ci n'est pas séléctionner
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void label_title_MouseEnter(object sender, EventArgs e)
        {
            if (BackColor != Color.FromName("LightGray"))
            {
                BackColor = Color.FromName("Control");
            }
        }

        /// <summary>
        /// Effet lors de la sortie de la souris si celui-ci n'est pas séléctionner
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void label_title_MouseLeave(object sender, EventArgs e)
        {
            if (BackColor == Color.FromName("Control"))
            {
                BackColor = Color.FromName("White");
            }
        }

        /// <summary>
        /// Change la couleur au UC séléctionné
        /// Affiche ces infos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void UserControl_Projet_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (attachedProject != Main.selected_Projet || V)
                {
                    BackColor = Color.FromName("LightGray");

                    foreach (Control ctrl in Main.panel_projet.Controls)
                    {
                        if (ctrl != this)
                        {
                            ctrl.BackColor = Color.White;
                        }
                    }

                    Main.selected_Projet = attachedProject;
                    Main.projectToErase = attachedProject;

                    V = false;
                }
            }
        }

        private void supprimerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Main.projectToErase = attachedProject;
            Main main = (Main)Application.OpenForms["Main"];

            Main.ifIsTheShowingProject = false;
            if (BackColor == Color.FromName("LightGray"))
            {
                Main.ifIsTheShowingProject = true;
            }

            main.pictureBox_delete_MouseDown_1(this, new MouseEventArgs(MouseButtons.Left, 1, 0, 0, 0));

            Gestion_des_UserControls.ActualizeNbOfSousProjetAndTache();
        }

        private void modifierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Main.selected_Projet = attachedProject;
            Main main = (Main)Application.OpenForms["Main"];
            main.PictureBox_edit_MouseDown(this, new MouseEventArgs(MouseButtons.Left, 1, 0, 0, 0));
        }

        private void UserControl_Projet_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Main main = (Main)Application.OpenForms["Main"];
                main.showInformations();
            }
        }
    }
}