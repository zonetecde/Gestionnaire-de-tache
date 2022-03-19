using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Gestionnaire_de_tâche__Last_
{
    public partial class Ajouter_un_projet : Form
    {
        public Projet Projet_a_modifier_ou_a_dupliquer { get; }
        public bool IsDuplicate { get; }

        private string lastOptionMode = "Terminer";

        public Ajouter_un_projet(Projet modifyProject = null, bool isDuplicate = false)
        {
            InitializeComponent();

            Icon = Gestionnaire_de_tâche__Last_.Properties.Resources.icon_add;
            Projet_a_modifier_ou_a_dupliquer = modifyProject;
            IsDuplicate = isDuplicate;
        }

        private void Ajouter_un_projet_Load(object sender, EventArgs e)
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

            Datepicker_creationDate.Value = DateTime.Now;
            bunifuDatepicker_fin.Value = DateTime.Now;

            // Set les paramètres du projet séléctionné si on l'ouvre en mode "modifié"
            if (Projet_a_modifier_ou_a_dupliquer != null)
            {
                if (!IsDuplicate)
                    lastOptionMode = "Enregistrer";
                else
                    lastOptionMode = "Dupliquer";

                text_projectName.Text = Projet_a_modifier_ou_a_dupliquer.Nom_du_projet;
                richTextBox_desc.Text = Projet_a_modifier_ou_a_dupliquer.Desc_du_projet;

                panel_color.BackColor = Color.FromArgb(Convert.ToInt32(Projet_a_modifier_ou_a_dupliquer.Couleur_du_projet));

                setPath(button_solution, Projet_a_modifier_ou_a_dupliquer.Solution_path);
                solution_path = Projet_a_modifier_ou_a_dupliquer.Solution_path;

                setPath(button_debug, Projet_a_modifier_ou_a_dupliquer.Executable_debug_path);
                executable_debug_path = Projet_a_modifier_ou_a_dupliquer.Executable_debug_path;

                setPath(button_release, Projet_a_modifier_ou_a_dupliquer.Executable_release_path);
                executable_debug_path = Projet_a_modifier_ou_a_dupliquer.Executable_release_path;

                Datepicker_creationDate.Value = Projet_a_modifier_ou_a_dupliquer.Date_creation_du_projet;

                if (Projet_a_modifier_ou_a_dupliquer.Fin_du_projet != null)
                {
                    Checkbox_date.Checked = true;
                    panel_hidedate.Visible = false;
                    bunifuDatepicker_fin.Value = Projet_a_modifier_ou_a_dupliquer.Fin_du_projet.Value;
                }
            }
        }

        private void setPath(Button button, string path)
        {
            if (!String.IsNullOrEmpty(path))
            {
                List<string> fileName = path.Split('\\').ToList();
                button.Text = fileName[fileName.Count - 1];
                button.Font = new Font("Verdana", 9, FontStyle.Regular);
            }
        }

        /// <summary>
        /// Supprime le contenu de la textbox si son texte est celui par défault
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void text_projectName_Enter(object sender, EventArgs e)
        {
            if (text_projectName.Text.Equals("Nom du projet"))
            {
                text_projectName.Text = string.Empty;
            }
        }

        /// <summary>
        /// Si la textbox est vide, on remet le waterMark
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void text_projectName_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(text_projectName.Text))
            {
                text_projectName.Text = "Nom du projet";
            }
        }

        /// <summary>
        /// Supprime le contenu de la richtextbox si son texte est celui par défault
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void richTextBox_desc_Enter(object sender, EventArgs e)
        {
            if (richTextBox_desc.Text.Equals("Description du projet"))
            {
                richTextBox_desc.Text = string.Empty;
            }
        }

        /// Si la richtextbox est vide, on remet le waterMark
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void richTextBox_desc_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(richTextBox_desc.Text))
            {
                richTextBox_desc.Text = "Description du projet";
            }
        }

        /// <summary>
        /// Montre la suivante/précédente groupbox
        /// </summary>
        /// <param name="sender">Bouton suivant ou précédent</param>
        /// <param name="e"></param>
        /// <var name="page">Page actuelle</var>
        /// <var name="pageMax">Nombre de groupBox dans la form, soit le nombre de page</var>
        private int page = 0;

        private int pageMax = 0;

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
            else if (bouton.ButtonText.Equals("Terminer"))
            {
                saveProject();
            }
            else if (bouton.ButtonText.Equals("Enregistrer"))
            {
                modifyProject();
            }
            else if (bouton.ButtonText.Equals("Dupliquer"))
            {
                saveProject(true);
            }
        }

        private void modifyProject()
        {
            if (!(String.IsNullOrEmpty(text_projectName.Text) || text_projectName.Text.Equals("Nom du projet")))
            {
                for (int i = 0; i < Main.Utilities.resource.projets.Count; i++)
                {
                    if (Main.Utilities.resource.projets[i].Id_du_projet == Projet_a_modifier_ou_a_dupliquer.Id_du_projet)
                    {
                        if (richTextBox_desc.Text.Equals("Description du projet"))
                        {
                            richTextBox_desc.Text = string.Empty;
                        }

                        DateTime? date_fin = null;
                        if (Checkbox_date.Checked)
                        {
                            date_fin = bunifuDatepicker_fin.Value;
                        }

                        var projet = new Projet(panel_color.BackColor.ToArgb().ToString(), text_projectName.Text, richTextBox_desc.Text, Projet_a_modifier_ou_a_dupliquer.Id_du_projet, Datepicker_creationDate.Value, date_fin, solution_path, executable_debug_path, executable_release_path);
                        projet.sous_Projets = Projet_a_modifier_ou_a_dupliquer.sous_Projets;

                        Main.Utilities.resource.projets[i] = projet;
                        Gestion_des_UserControls.LoadList(projet);
                        Gestion_des_UserControls.ActualizeProjectVue(projet);

                        Main.Utilities.SaveResources();

                        Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Nom du projet obligatoire", "Erreur !",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Sauvgarde le projet
        /// </summary>
        private void saveProject(bool conserverLesSousProjets = false)
        {
            if (!(String.IsNullOrEmpty(text_projectName.Text) || text_projectName.Text.Equals("Nom du projet")))
            {
                if (richTextBox_desc.Text.Equals("Description du projet"))
                {
                    richTextBox_desc.Text = string.Empty;
                }

                Random rdn = new Random();
                int id = rdn.Next(0, 2_147_483_647);
                DateTime? date_fin = null;
                if (Checkbox_date.Checked)
                {
                    date_fin = bunifuDatepicker_fin.Value;
                }

                var projet = new Projet(panel_color.BackColor.ToArgb().ToString(), text_projectName.Text, richTextBox_desc.Text, id, Datepicker_creationDate.Value, date_fin, solution_path, executable_debug_path, executable_release_path);

                if (conserverLesSousProjets)
                {
                    projet.sous_Projets = Projet_a_modifier_ou_a_dupliquer.sous_Projets;

                    Main.Utilities.resource.projets.Insert(Main.Utilities.resource.projets.IndexOf(Main.selected_Projet), projet);
                }
                else
                {
                    Main.Utilities.resource.projets.Insert(0, projet);
                }

                Main.Utilities.SaveResources();
                Main.Utilities.LoadResources();

                Gestion_des_UserControls.LoadList(Main.selected_Projet);

                Close();
            }
            else
            {
                MessageBox.Show("Nom du projet obligatoire", "Erreur !",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void showPage(int page)
        {
            switch (page)
            {
                case 0:
                    Groupbox_info.Visible = true;
                    GroupBox_couleur.Visible = false;
                    break;

                case 1:
                    Groupbox_info.Visible = false;
                    GroupBox_couleur.Visible = true;
                    Groupbox_date.Visible = false;
                    Button_next.ButtonText = "Suivant";
                    break;

                case 2:
                    GroupBox_couleur.Visible = false;
                    Groupbox_date.Visible = true;
                    Button_next.ButtonText = lastOptionMode;
                    break;
            }
        }

        /// <summary>
        /// Actualise la couleur du panel de séléction de couleur
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e">Bouton de la souris utilisé</param>
        private void xuiColorPicker_couleur_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                panel_color.BackColor = ColorPicker_couleur.SelectedColor;
            }
        }

        private void bunifuCheckbox_date_OnChange(object sender, EventArgs e)
        {
            if (Checkbox_date.Checked)
            {
                panel_hidedate.Visible = false;
                bunifuDatepicker_fin.Format = DateTimePickerFormat.Long;
            }
            else
            {
                panel_hidedate.Visible = true;
                bunifuDatepicker_fin.Format = DateTimePickerFormat.Short;
            }
        }

        private string solution_path = null;
        private string executable_debug_path = null;
        private string executable_release_path = null;

        private void button_solution_MouseDown(object sender, MouseEventArgs e)
        {
            solution_path = openFileDialogFor("Solution Visual Studio(*.sln) | *.sln", button_solution);
        }

        private void button_debug_MouseDown(object sender, MouseEventArgs e)
        {
            executable_debug_path = openFileDialogFor("Application(*.exe) | *.exe", button_debug);
        }

        private void button_release_MouseDown(object sender, MouseEventArgs e)
        {
            executable_release_path = openFileDialogFor("Application(*.exe) | *.exe", button_release);
        }

        /// <summary>
        /// Ouvre l'explorateur de fichier avec de bon paramètre
        /// </summary>
        /// <param name="filter">Filtre les extenstions à choisir</param>
        /// <param name="button">Le bouton où le texte doit être changer</param>
        /// <returns>Retourne le chemin à l'élément choisit</returns>
        private string openFileDialogFor(string filter, Button button)
        {
            string fileNameVar;

            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            string defaultPath = "c:\\Users\\" + Environment.UserName +
                "\\source\\repos";

            openFileDialog1.InitialDirectory = defaultPath;
            openFileDialog1.Filter = filter;
            openFileDialog1.FilterIndex = 0;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                fileNameVar = openFileDialog1.FileName;
                List<string> fileName = fileNameVar.Split('\\').ToList();
                button.Text = fileName[fileName.Count - 1];
                button.Font = new Font("Verdana", 9, FontStyle.Regular);

                return fileNameVar;
            }
            else
            {
                return null;
            }
        }

        private void pictureBox_deleteSln_Click(object sender, EventArgs e)
        {
            solution_path = string.Empty;
            button_solution.Text = "Solution du projet";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            executable_debug_path = string.Empty;
            button_debug.Text = "Éxecutable (DEBUG)";
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            executable_release_path = string.Empty;
            button_release.Text = "Éxecutable (RELEASE)";
        }
    }
}