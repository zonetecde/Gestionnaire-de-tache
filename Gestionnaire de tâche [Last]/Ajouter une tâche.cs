using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Gestionnaire_de_tâche__Last_
{
    public partial class Ajouter_une_tâche : Form
    {
        private string lastOptionMode = "Ajouter";
        private int pageMax = 0;

        /// <summary>
        /// Initializateur pour modifier, dupliquer ou créer une tâche.
        /// </summary>
        /// <param name="tâche">Tâche à dupliquer / Créer : Obligatoire dans les deux cas</param>
        /// <param name="userControl_Tâche">Usercontrol à update après avoir modifier une tâche</param>
        /// <param name="sous_Projet">Sous projet obligatoire auquel on va ajouter la tâche sauf si on la modifie (la tâche)</param>
        /// <param name="isDuplicate">Si on souhaite dupliquer la tâche</param>
        public Ajouter_une_tâche(Tâche tâche = null, UserControl_Tâche userControl_Tâche = null, Sous_Projet sous_Projet = null, bool isDuplicate = false)
        {
            InitializeComponent();

            Icon = Gestionnaire_de_tâche__Last_.Properties.Resources.icon_add;
            Tâche = tâche;
            this.userControl_Tâche = userControl_Tâche;
            Sous_Projet = sous_Projet;

            // Modifier
            if(tâche != null)
            {
                text_projectName.Text = tâche.Nom_de_la_tâche;
                panel_color.BackColor = tâche.Couleur_de_la_tâche;

                richTextBox_desc.Text = tâche.Détail_de_la_tâche;

                lastOptionMode = "Enregistrer";
            }

            if(isDuplicate)
            {
                text_projectName.Text = tâche.Nom_de_la_tâche;
                panel_color.BackColor = tâche.Couleur_de_la_tâche;

                richTextBox_desc.Text = tâche.Détail_de_la_tâche;

                lastOptionMode = "Dupliquer";
            }

            // SET LA TAILLE MAXIMAL DU NOM
            SetMaximumLength(text_projectName, 80);
        }

        private void Ajouter_une_tâche_Load(object sender, EventArgs e)
        {
            ActiveControl = label_titre;

            // Nombre de page max = nombre de groupBox
            foreach (var ctrl in Controls)
            {
                if (ctrl is GroupBox)
                {
                    pageMax++;
                }
            }
        }

        /// <summary>
        /// Affiche le bon groupBox pour la page
        /// </summary>
        /// <param name="page"></param>
        private void showPage(int page)
        {
            switch (page)
            {
                case 0:
                    Groupbox_info.Visible = true;
                    GroupBox_couleur.Visible = false;
                    Button_next.ButtonText = "Suivant";
                    break;

                case 1:
                    GroupBox_couleur.Visible = true;
                    Groupbox_info.Visible = false;
                    Button_next.ButtonText = lastOptionMode;
                    break;
            }
        }

        /// <summary>
        /// Change la couleur du panel de couleur lorsque qu'elle change
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ColorPicker_couleur_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                panel_color.BackColor = ColorPicker_couleur.SelectedColor;
            }
        }

        private int page = 0;
        private UserControl_Tâche userControl_Tâche;

        public Tâche Tâche { get; }
        public Sous_Projet Sous_Projet { get; }

        /// <summary>
        /// Quand on appuie sur les boutons pour avancer/reculer d'une page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_next_MouseDown(object sender, EventArgs e)
        {
            Bunifu.Framework.UI.BunifuThinButton2 bouton = sender as Bunifu.Framework.UI.BunifuThinButton2;
            if (bouton.ButtonText.Equals("Suivant") && page != pageMax)
            {
                page++;
                showPage(page);
            }
            else if (bouton.ButtonText.Equals("Précédent") && page != 0)
            {
                page--;
                showPage(page);
            }
            else if (bouton.ButtonText.Equals("Ajouter"))
            {
                saveTâche();
            }
            else if(bouton.ButtonText.Equals("Enregistrer"))
            {
                modifyTâche();
            }
            else if(bouton.ButtonText.Equals("Dupliquer"))
            {
                saveTâche();
            }
        }

        private void modifyTâche()
        {
            if (!(text_projectName.Text.Equals("Nom de la tâche") || String.IsNullOrEmpty(text_projectName.Text)))
            {
                Tâche.Nom_de_la_tâche = text_projectName.Text;
                Tâche.Détail_de_la_tâche = richTextBox_desc.Text;

                Tâche.Couleur_de_la_tâche = panel_color.BackColor;

                userControl_Tâche.ActualizePrincipaleInformation();

                this.Close();
            }
            else
            {
                MessageBox.Show("Le nom de la tâche doit être renseigné", "Erreur !",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void saveTâche()
        {
            if (!(text_projectName.Text.Equals("Nom de la tâche") || String.IsNullOrEmpty(text_projectName.Text)))
            {
                Random rdn = new Random();
                int Id = rdn.Next(0, 2_147_483_647);

                var tâche = new Tâche(text_projectName.Text, richTextBox_desc.Text, panel_color.BackColor, Id, new List<string>
                {
                    Sous_Projet.Id_du_sous_projet.ToString(),
                    Sous_Projet.Nom_du_sous_projet,
                    Sous_Projet.Description_du_sous_projet
                }
                );
                tâche.State_de_la_tâche = 0;
                Sous_Projet.Tâches.Insert(0, tâche);

                Main.Utilities.SaveResources();
                Gestion_des_UserControls.AddTâcheIn(Sous_Projet, Sous_Projet.Tâches[0]);

                Gestion_des_UserControls.ActualizeNbOfSousProjetAndTache();

                Close();
            }
            else
            {
                MessageBox.Show("Le nom de la tâche doit être renseigné", "Erreur !",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Si le nom du projet est le watermark, on supprime le contenu de la textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void text_projectName_Enter(object sender, EventArgs e)
        {
            if (text_projectName.Text.Equals("Nom de la tâche"))
            {
                text_projectName.Text = string.Empty;
            }
        }

        /// <summary>
        /// Si le nom du projet est vide, on écrit le waterMark
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void text_projectName_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(text_projectName.Text))
            {
                text_projectName.Text = "Nom de la tâche";
            }
        }

        /// <summary>
        /// Si la description du projet est le watermark, on supprime le contenu de la richtextbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void richTextBox_desc_Enter(object sender, EventArgs e)
        {
            if (richTextBox_desc.Text.Equals("Description du sous projet"))
            {
                richTextBox_desc.Text = string.Empty;
            }
        }

        /// <summary>
        /// Si la description du projet est vide, on écrit la watermark
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void richTextBox_desc_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(richTextBox_desc.Text))
            {
                richTextBox_desc.Text = "Description du sous projet";
            }
        }

        private void text_projectName_OnValueChanged(object sender, EventArgs e)
        {
            int characterCounter = text_projectName.Text.Length;
            label_charCount.Text = "Caractère(s) : " + characterCounter + "/80";
        }

        /// <summary>
        /// Set la longueur maximum de la textbox
        /// </summary>
        /// <param name="metroTextbox">Le bouton</param>
        /// <param name="maximumLength">Le max</param>
        private void SetMaximumLength(Bunifu.Framework.UI.BunifuMaterialTextbox metroTextbox, int maximumLength)
        {
            foreach (Control ctl in metroTextbox.Controls)
            {
                if (ctl.GetType() == typeof(TextBox))
                {
                    var txt = (TextBox)ctl;
                    txt.MaxLength = maximumLength;
                }
            }
        }
    }
}
