using System;
using System.Windows.Forms;

namespace Gestionnaire_de_tâche__Last_
{
    public partial class Ajouter_un_sous_projet : Form
    {
        private string lastOptionMode = "Ajouter";

        public Ajouter_un_sous_projet(Projet selected_Projet, Sous_Projet sous_Projet_a_modifier_ou_a_dupliquer = null, bool isDuplicate = false)
        {
            InitializeComponent();
            Selected_Projet = selected_Projet;
            Sous_Projet_A_Modifier = sous_Projet_a_modifier_ou_a_dupliquer;
            Icon = Gestionnaire_de_tâche__Last_.Properties.Resources.icon_add;

            // On ajoute les paramètres pour modifier
            if (sous_Projet_a_modifier_ou_a_dupliquer != null)
            {
                text_projectName.Text = sous_Projet_a_modifier_ou_a_dupliquer.Nom_du_sous_projet;
                richTextBox_desc.Text = sous_Projet_a_modifier_ou_a_dupliquer.Description_du_sous_projet;
                panel_color.BackColor = sous_Projet_a_modifier_ou_a_dupliquer.Couleur_du_sous_projet;

                if (sous_Projet_a_modifier_ou_a_dupliquer.Date_de_fin != null)
                {
                    panel_hidedate.Visible = false;
                    Checkbox_date.Checked = true;
                    bunifuDatepicker_fin.Value = sous_Projet_a_modifier_ou_a_dupliquer.Date_de_fin.Value;
                }

                if (isDuplicate)
                {
                    lastOptionMode = "Dupliquer";
                }
                else
                {
                    lastOptionMode = "Enregistrer";
                }
            }
        }

        private void Ajouter_un_sous_projet_Load(object sender, EventArgs e)
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
                    break;

                case 1:
                    GroupBox_couleur.Visible = true;
                    Groupbox_info.Visible = false;
                    Groupbox_priorité.Visible = false;
                    Button_next.ButtonText = "Suivant";
                    break;

                case 2:
                    Groupbox_priorité.Visible = true;
                    GroupBox_couleur.Visible = false;
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
        private int pageMax;

        public Projet Selected_Projet { get; }
        public Sous_Projet Sous_Projet_A_Modifier { get; }

        /// <summary>
        /// Quand on appuie sur les boutons pour avancer/reculer d'une page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_prev_MouseDown(object sender, EventArgs e)
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
                saveSousProjet();
            }
            else if (bouton.ButtonText.Equals("Enregistrer"))
            {
                modifySousProjet(Sous_Projet_A_Modifier);
            }
            else if (bouton.ButtonText.Equals("Dupliquer"))
            {
                saveSousProjet(true);
            }
        }

        private void modifySousProjet(Sous_Projet sous_Projet_à_modifier)
        {
            if (!(text_projectName.Text.Equals("Nom du sous projet") || String.IsNullOrEmpty(text_projectName.Text)))
            {
                foreach (var projet in Main.Utilities.resource.projets)
                {
                    for (int i = 0; i < projet.sous_Projets.Count; i++)
                    {
                        if (projet.sous_Projets[i] == sous_Projet_à_modifier)
                        {
                            DateTime? date_fin = null;

                            if (Checkbox_date.Checked)
                            {
                                date_fin = bunifuDatepicker_fin.Value;
                            }

                            string desc = null;
                            if (!richTextBox_desc.Text.Equals("Description du sous projet"))
                            {
                                desc = richTextBox_desc.Text;
                            }

                            var sousProjet_remplacer = new Sous_Projet(text_projectName.Text, desc, sous_Projet_à_modifier.Id_du_sous_projet, Selected_Projet, date_fin, panel_color.BackColor);
                            sousProjet_remplacer.Tâches = projet.sous_Projets[i].Tâches;

                            Gestion_des_UserControls.UpdateInformationOf(sousProjet_remplacer, projet.sous_Projets[i]);

                            projet.sous_Projets[i] = sousProjet_remplacer;

                            Close();
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Le nom du sous projet doit être renseigné", "Erreur !",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void saveSousProjet(bool conserverLesTâches = false)
        {
            if (!(text_projectName.Text.Equals("Nom du sous projet") || String.IsNullOrEmpty(text_projectName.Text)))
            {
                int temp = Main.panel_info.VerticalScroll.Value;
                Main.panel_info.VerticalScroll.Value = 0;

                Random rdn = new Random();
                int Id = rdn.Next(0, 2_147_483_647);

                DateTime? date_fin = null;

                if (Checkbox_date.Checked)
                {
                    date_fin = bunifuDatepicker_fin.Value;
                }

                string desc = null;
                if (!richTextBox_desc.Text.Equals("Description du sous projet"))
                {
                    desc = richTextBox_desc.Text;
                }

                var sousProjet = new Sous_Projet(text_projectName.Text, desc, Id, Selected_Projet, date_fin, panel_color.BackColor);

                if (conserverLesTâches)
                {
                    sousProjet.Tâches = Sous_Projet_A_Modifier.Tâches;
                }

                Main.selected_Projet.sous_Projets.Insert(0, sousProjet);

                Gestion_des_UserControls.AddSousProjetInPanel(Main.selected_Projet.sous_Projets[0]);

                Main.Utilities.SaveResources();

                Main main = (Main)Application.OpenForms["Main"];
                main.hideWarningLabel();

                Gestion_des_UserControls.ActualizeNbOfSousProjetAndTache();

                Main.panel_info.VerticalScroll.Value = temp;

                Close();
            }
            else
            {
                MessageBox.Show("Le nom du sous projet doit être renseigné", "Erreur !",
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
            if (text_projectName.Text.Equals("Nom du sous projet"))
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
                text_projectName.Text = "Nom du sous projet";
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

        /// <summary>
        /// Active / Désactive l'option de la date de fin
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Checkbox_date_OnChange(object sender, EventArgs e)
        {
            if (Checkbox_date.Checked)
            {
                panel_hidedate.Visible = false;
            }
            else
            {
                panel_hidedate.Visible = true;
            }
        }
    }
}