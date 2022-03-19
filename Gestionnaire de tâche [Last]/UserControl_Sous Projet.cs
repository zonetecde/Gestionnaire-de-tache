using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace Gestionnaire_de_tâche__Last_
{
    public partial class UserControl_Sous_Projet : UserControl
    {
        public Sous_Projet Sous_Projet { get; set; }
        public PictureBox image { get; set; }
        public Projet Projet { get; }

        private Panel basDuTableau = new Panel();

        private int temp = 0;

        public UserControl_Sous_Projet(Sous_Projet sous_Projet, Projet projet = null)
        {
            InitializeComponent();

            richtextBox_nom.BorderStyle = BorderStyle.None;
            richtextBox_nom.BackColor = System.Drawing.Color.White;
            richtextBox_nom.ReadOnly = true;
            richtextBox_nom.GotFocus += (s, ea) => { label_nbTache.Focus(); };

            richtextBox_nom.ForeColor = sous_Projet.Couleur_du_sous_projet;
            richtextBox_nom.Text = sous_Projet.Nom_du_sous_projet;
            Sous_Projet = sous_Projet;
            Projet = projet;

            InitializeAllTâche();
        }

        private void InitializeAllTâche()
        {
            switch (Sous_Projet.Tâches.Count)
            {
                case 0:
                    label_nbTache.Text = "Aucune tâche";
                    break;

                case 1:
                    label_nbTache.Text = "1 tâche";
                    break;

                default:
                    label_nbTache.Text = Sous_Projet.Tâches.Count + " tâches";
                    break;
            }

            image = pictureBox_view;

            Size = new Size(984, 38);
            int x = 0, y = Height;

            if (Sous_Projet.Tâches.Count != 0)
            {
                List<Control> toShow = new List<Control>();

                // On ajoute le haut du tableau
                UserControl_Haut_du_tableau userControl_Haut_Du_Tableau = new UserControl_Haut_du_tableau(Sous_Projet);
                Size = new Size(Width, Height + userControl_Haut_Du_Tableau.Height);
                userControl_Haut_Du_Tableau.Location = new Point(x, y);
                userControl_Haut_Du_Tableau.Visible = false;
                toShow.Add(userControl_Haut_Du_Tableau);
                Controls.Add(userControl_Haut_Du_Tableau);
                y += userControl_Haut_Du_Tableau.Height;

                // Puis toutes les tâches
                foreach (var tache in Sous_Projet.Tâches)
                {
                    UserControl_Tâche userControl_Tâche = new UserControl_Tâche(tache, Projet, Sous_Projet, this);
                    Size = new Size(Width, Height + userControl_Tâche.Height);
                    userControl_Tâche.Location = new Point(x, y);
                    userControl_Tâche.Visible = false;
                    toShow.Add(userControl_Tâche);
                    Controls.Add(userControl_Tâche);
                    y += userControl_Tâche.Height;
                }

                // Et enfin le bas du tableau
                basDuTableau.BorderStyle = BorderStyle.FixedSingle;
                basDuTableau.Size = new Size(932, 1);
                basDuTableau.Visible = false;
                toShow.Add(basDuTableau);
                Size = new Size(Width, Height + basDuTableau.Height);
                basDuTableau.Location = new Point(x + 11, y - 1);
                Controls.Add(basDuTableau);
                basDuTableau.BringToFront();

                foreach (Control ctrl in toShow)
                {
                    ctrl.Visible = true;
                }
            }
        }

        private void UserControl_Sous_Projet_Load(object sender, EventArgs e)
        {
        }

        internal bool isMinimize = false;

        internal void pictureBox_view_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                int temp = Main.panel_info.VerticalScroll.Value;
                Main.panel_info.VerticalScroll.Value = 0;

                if (isMinimize)
                {
                    // On enlève le sous projet à minimiser
                    Gestion_des_UserControls.sous_Projets_to_minimize.Remove(Sous_Projet);
                    Gestion_des_UserControls.Minimize(Sous_Projet, true);

                    isMinimize = false;
                }
                else
                {
                    // On ajoute un sous projet à minimiser
                    Gestion_des_UserControls.sous_Projets_to_minimize.Add(Sous_Projet);
                    Gestion_des_UserControls.Minimize(Sous_Projet, false);

                    isMinimize = true;
                }

                Main.panel_info.VerticalScroll.Value = temp;
            }
        }

        /// <summary>
        /// Ouvre la fenetre d'ajout de tache
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void label_nbTache_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Ajouter_une_tâche ajouter_Une_Tâche_window = new Ajouter_une_tâche(sous_Projet: Sous_Projet);
                ajouter_Une_Tâche_window.ShowDialog();
            }
        }

        /// <summary>
        /// Show toutes les tâches
        /// </summary>
        internal void ShowAllTâche()
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is UserControl_Tâche)
                {
                    UserControl_Tâche userControl_Tâche1 = ctrl as UserControl_Tâche;
                    userControl_Tâche1.hideUC();
                }
            }

            Size = new Size(Width, temp);
        }

        /// <summary>
        /// Met en surbrillance le texte qui est similaire
        /// </summary>
        /// <param name="wordToMakeSurbrillancer">Le texte à mettre en surbrillance</param>
        /// <param name="v">Si on enlève la survrillance ou pas</param>
        internal void Surbrillance(string wordToMakeSurbrillancer = null, bool v = true)
        {
            if (v)
            {
                Main.Utilities.HighlightSearchText(wordToMakeSurbrillancer, richtextBox_nom, Sous_Projet.Couleur_du_sous_projet);
            }
            else
            {
                richtextBox_nom.SelectAll();
                richtextBox_nom.SelectionColor = Sous_Projet.Couleur_du_sous_projet;
            }
        }

        /// <summary>
        /// Câche toutes les tâches
        /// </summary>
        internal void HideAllTâche()
        {
            temp = Height;
            Size = new Size(Width, 38);
        }

        private void supprimerCetteSousTâcheToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Projet temp = new Projet();

            foreach (var projet in Main.Utilities.resource.projets)
            {
                foreach (var sous_projet in projet.sous_Projets)
                {
                    if (sous_projet == Sous_Projet)
                    {
                        temp = projet;
                    }
                }
            }

            temp.sous_Projets.Remove(Sous_Projet);

            Gestion_des_UserControls.ActualizeNbOfSousProjetAndTache();
            Size = new Size(0, 0);
            Gestion_des_UserControls.HideSousProjet(Sous_Projet);
        }

        private void éditerCetteSousTâcheToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ajouter_un_sous_projet ajouter_Un_SousProjet_window = new Ajouter_un_sous_projet(Main.selected_Projet, Sous_Projet);
            ajouter_Un_SousProjet_window.ShowDialog();
        }

        private void label_nom_Click(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// Update les informations du UC
        /// Utile après avoir modifier le sous projet
        /// </summary>
        internal void UpdateInformation(Sous_Projet nouvelleInfo)
        {
            Sous_Projet = nouvelleInfo;

            richtextBox_nom.ForeColor = nouvelleInfo.Couleur_du_sous_projet;
            richtextBox_nom.Text = nouvelleInfo.Nom_du_sous_projet;
        }

        internal void HideOnlyOneTache(Tâche tâche)
        {
            switch (Sous_Projet.Tâches.Count - 1)
            {
                case 0:
                    label_nbTache.Text = "Aucune tâche";
                    break;

                case 1:
                    label_nbTache.Text = "1 tâche";
                    break;

                default:
                    label_nbTache.Text = Sous_Projet.Tâches.Count + " tâches";
                    break;
            }

            if (Sous_Projet.Tâches.Count == 1)
            {
                foreach (Control ctrl in this.Controls)
                {
                    if (ctrl is UserControl_Haut_du_tableau)
                    {
                        ctrl.Visible = false;
                    }
                    else if (ctrl is UserControl_Tâche)
                    {
                        ctrl.Visible = false;
                    }
                    else if (ctrl is Panel)
                    {
                        ctrl.Visible = false;
                    }
                }

                this.Size = new Size(984, 38);
            }
            else
            {
                bool repositionner = false;
                Point location = new Point();

                foreach (Control ctrl in this.Controls)
                {
                    if ((ctrl is UserControl_Tâche) && ctrl.Visible == true)
                    {
                        UserControl_Tâche UC = ctrl as UserControl_Tâche;

                        if (UC.Tâche == tâche)
                        {
                            location = ctrl.Location;

                            ctrl.Visible = false;
                            this.Size = new Size(this.Width, this.Height - ctrl.Height);

                            repositionner = true;
                        }
                    }

                    if (repositionner == true && ctrl.Visible == true && !(ctrl is UserControl_Haut_du_tableau))
                    {
                        ctrl.Location = location;
                        location.Y += ctrl.Height;
                    }
                }
            }

            basDuTableau.Location = new Point(12, this.Height - 1);
            Gestion_des_UserControls.RepositionnerTout();
        }

        internal void AddTache(Tâche tâche)
        {
            List<Control> toremove = new List<Control>();

            foreach (Control ctrl in this.Controls)
            {
                if (!(ctrl is Label || ctrl is PictureBox || ctrl is Bunifu.Framework.UI.BunifuImageButton || ctrl is RichTextBox))
                {
                    toremove.Add(ctrl);
                }
            }

            foreach(Control ctrl in toremove)
            {
                this.Controls.Remove(ctrl);
            }

            InitializeAllTâche();

            Gestion_des_UserControls.RepositionnerTout();
        }

        // Sinon il y a un bug; le panel met sa horizontal scroll à 10
        private void richtextBox_nom_MouseDown(object sender, MouseEventArgs e)
        {
            Main.panel_info.HorizontalScroll.Value = 0;
        }

        private ToolTip tt = new ToolTip();

        private void richtextBox_nom_MouseHover(object sender, EventArgs e)
        {
            string caption = Sous_Projet.Description_du_sous_projet;
            TextInfo maj = new CultureInfo("fr-Fr", false).TextInfo;

            if (Sous_Projet.Date_de_fin != null)
            {
                caption += "\n\nFin prévue le : " + maj.ToTitleCase(Sous_Projet.Date_de_fin.Value.ToString("D",
                CultureInfo.CreateSpecificCulture("fr-FR")));
            }

            tt.SetToolTip(richtextBox_nom, caption);
            tt.SetToolTip(label_nbTache, caption);
            tt.SetToolTip(Button_add, caption);
            tt.SetToolTip(pictureBox_view, caption);
        }

        /// <summary>
        /// Duplique le sous projet ainsi que toutes ces tâches
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dupliquerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ajouter_un_sous_projet ajouter_Un_Sous_Projet = new Ajouter_un_sous_projet(Projet, Sous_Projet, true);
            ajouter_Un_Sous_Projet.ShowDialog();
        }

        /// <summary>
        /// Active la modification du nom
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void richtextBox_nom_DoubleClick(object sender, EventArgs e)
        {
            textBox_modifyName.Text = Sous_Projet.Nom_du_sous_projet;
            textBox_modifyName.Visible = true;
            this.ActiveControl = textBox_modifyName;
        }

        /// <summary>
        /// Quand on rentre dans le controle
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox_modifyName_Enter(object sender, EventArgs e)
        {
            textBox_modifyName.SelectAll();
        }

        /// <summary>
        /// Enlève la modification du nom
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox_modifyName_Leave(object sender, EventArgs e)
        {
            textBox_modifyName.Visible = false;
        }

        /// <summary>
        /// Si on valide
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox_modifyName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!String.IsNullOrEmpty(textBox_modifyName.Text))
                {
                    Sous_Projet.Nom_du_sous_projet = textBox_modifyName.Text;
                    richtextBox_nom.Text = textBox_modifyName.Text;

                    textBox_modifyName.Visible = false;
                }
                else
                    textBox_modifyName.Visible = false;
            }
        }

        internal void RepositionnerTous()
        {
            Point location = new Point(0, 61);

            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is UserControl_Tâche)
                {
                    if (ctrl.Visible == true)
                    {
                        ctrl.Location = location;
                        location.Y += ctrl.Height;
                    }
                }
            }

            this.Size = new Size(this.Width, location.Y);

            basDuTableau.Location = new Point(11, this.Height - 1);

            Gestion_des_UserControls.RepositionnerToutAPartirDe(this);
        }

        private void richtextBox_nom_MouseEnter(object sender, EventArgs e)
        {
            richtextBox_nom.Enabled = false;
        }

        private void richtextBox_nom_MouseLeave(object sender, EventArgs e)
        {
            richtextBox_nom.Enabled = true;
        }

        /// <summary>
        /// Active / Désactive le coller
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        Tâche toPaste = null;
        private void contextMenuStrip_option_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            try
            {
                string json = EncryptionHelper.Decrypt(Clipboard.GetText());
                toPaste = JsonConvert.DeserializeObject<Tâche>(json);

                if (toPaste.Id_de_la_tâche != 0 || !String.IsNullOrEmpty(toPaste.Nom_de_la_tâche))
                {
                    Random rdn = new Random();
                    toPaste.Id_de_la_tâche = rdn.Next(0, 275694879);

                    contextMenuStrip_option.Items[3].Enabled = true;
                }
                else
                {
                    contextMenuStrip_option.Items[3].Enabled = false;
                }
            }
            catch
            {
                contextMenuStrip_option.Items[3].Enabled = false;
            }
        }

        /// <summary>
        /// Colle dans le sous projet actuelle la tâche copier
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void collerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sous_Projet.Tâches.Insert(0, toPaste);
            AddTache(toPaste);
        }

        /// <summary>
        /// Copie le sous projet
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void copierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Serialize l'objet en json
            Clipboard.SetText(EncryptionHelper.Encrypt(JsonConvert.SerializeObject(Sous_Projet, Formatting.Indented)));
        }
    }
}