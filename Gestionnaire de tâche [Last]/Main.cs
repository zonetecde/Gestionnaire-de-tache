using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;
using System.Text;

namespace Gestionnaire_de_tâche__Last_
{
    public partial class Main : Form
    {
        public static Panel panel_projet;
        public static Panel panel_info;
        public static Utilities Utilities = new Utilities();
        public static Projet selected_Projet;
        public static bool FirstLaunch_ { get; internal set; }
        public static bool majDispo { get; internal set; }

        [DllImport("kernel32.dll",
                    EntryPoint = "GetStdHandle",
                    SetLastError = true,
                    CharSet = CharSet.Auto,
                    CallingConvention = CallingConvention.StdCall)]
        private static extern IntPtr GetStdHandle(int nStdHandle);
        [DllImport("kernel32.dll",
            EntryPoint = "AllocConsole",
            SetLastError = true,
            CharSet = CharSet.Auto,
            CallingConvention = CallingConvention.StdCall)]
        private static extern int AllocConsole();
        private const int STD_OUTPUT_HANDLE = -11;
        private const int MY_CODE_PAGE = 437;

        public Main()
        {
            InitializeComponent();

            Icon = Gestionnaire_de_tâche__Last_.Properties.Resources.Main_Icon;
        }

        private void Main_Load(object sender, EventArgs e)
        {
            panel_projet = panel_projets;
            panel_info = panel_informations;

            Utilities.InitializeResourcesPath();
            Utilities.LoadResources();

            Gestion_des_UserControls.LoadList(Main.selected_Projet);

            if (Properties.Settings.Default.checkMaj)
            {
                // MISE A JOUR
                if (Utilities.MajDispo())
                {
                    majDispo = true;
                }
            }
        }

        /// <summary>
        /// Quitte l'application et sauvegarde les resources
        /// </summary>
        /// <param name="sender">Le bouton pour quitter</param>
        /// <param name="e">Le bouton de la souris utilisé</param>
        private void btn_exit_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Application.Exit();
            }
        }

        /// <summary>
        /// Minimise l'application dans la barre des tâches
        /// </summary>
        /// <param name="sender">Le bouton pour minimiser</param>
        /// <param name="e">Le bouton de la souris utilisé</param>
        private void btn_minimize_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                WindowState = FormWindowState.Minimized;
            }
        }

        /// <summary>
        /// Rend la forme sizible
        /// </summary>
        #region
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void panel_topBar_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        #endregion

        internal void hideWarningLabel()
        {
            label_warning.Visible = false;
            label_warning2.Visible = false;
            label_warning3.Visible = false;
        }

        /// <summary>
        /// Affiche les informations du projet séléctionné
        /// </summary>
        internal void showInformations()
        {
            foreach (Control ctrl in panel_informations.Controls)
            {
                ctrl.Visible = false;
            }

            if (selected_Projet.sous_Projets == null)
            {
                selected_Projet.sous_Projets = new List<Sous_Projet>();
            }
            if (selected_Projet.sous_Projets.Count == 0)
            {
                Gestion_des_UserControls.LoadOnlyProjectVue(selected_Projet);
                label_warning.Text = "Aucun sous projet pour " + selected_Projet.Nom_du_projet;
                label_warning.Visible = true;
                label_warning2.Visible = true;
                label_warning3.Visible = true;
            }
            else
            {
                Gestion_des_UserControls.LoadAllSousProjetFor(selected_Projet);
            }
        }

        /// <summary>
        /// Ajoute un projet; ouvre la fenêtre d'ajout de projet
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBox_add_MouseDown_1(object sender, MouseEventArgs e)
        {
            Ajouter_un_projet ajouter_Un_Projet_form = new Ajouter_un_projet();
            ajouter_Un_Projet_form.ShowDialog();
        }

        /// <summary>
        /// Supprime le projet séléctionné
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public static bool ifIsTheShowingProject = false;

        public static bool resetFocus = true;
        internal static Projet projectToErase;
        public void pictureBox_delete_MouseDown_1(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (projectToErase != null)
                {
                    DialogResult dialogResult = MessageBox.Show("Voulez-vous vraiment supprimer le projet " + projectToErase.Nom_du_projet + " ?", "Avertissement", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        for (int i = 0; i < Utilities.resource.projets.Count; i++)
                        {
                            if (Utilities.resource.projets[i].Equals(projectToErase))
                            {
                                Utilities.resource.projets.RemoveAt(i);
                                Gestion_des_UserControls.LoadList(Main.selected_Projet);
                            }
                        }

                        if (ifIsTheShowingProject)
                        {
                            foreach (Control ctrl in panel_informations.Controls)
                            {
                                ctrl.Visible = false;
                            }
                            Main.ifIsTheShowingProject = false;
                        }

                        projectToErase = null;
                    }
                }
                else
                {
                    MessageBox.Show("Veuillez séléctionner un projet à supprimer", "Erreur !",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        /// <summary>
        /// Ouvre la fenetre d'edit d'un projet
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void PictureBox_edit_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (selected_Projet != null)
                {
                    Ajouter_un_projet ajouter_Un_Projet_window = new Ajouter_un_projet(selected_Projet);
                    ajouter_Un_Projet_window.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Veuillez séléctionner un projet à modifier", "Erreur !",
                         MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        /// <summary>
        /// Souligne le texte car la souris passe dessus
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void label_warning_MouseEnter(object sender, EventArgs e)
        {
            label_warning.Font = new Font(label_warning.Font, FontStyle.Underline);
            label_warning2.Font = new Font(label_warning.Font, FontStyle.Underline);
            label_warning3.Font = new Font(label_warning.Font, FontStyle.Underline);
        }

        /// <summary>
        /// Remet le texte sans le souligner car il n'est plus tracker par la souris
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void label_warning_MouseLeave(object sender, EventArgs e)
        {
            label_warning.Font = new Font(label_warning.Font, FontStyle.Regular);
            label_warning2.Font = new Font(label_warning.Font, FontStyle.Regular);
            label_warning3.Font = new Font(label_warning.Font, FontStyle.Regular);
        }

        /// <summary>
        /// Ouvre la fenêtre pour ajouter un sous projet
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void label_warning_MouseDown(object sender, MouseEventArgs e)
        {
            Ajouter_un_sous_projet ajouter_Un_Sous_Projet = new Ajouter_un_sous_projet(selected_Projet);
            ajouter_Un_Sous_Projet.ShowDialog();
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(Utilities.saveWhenExit)
                Utilities.SaveResources(true);
        }

        private void panel_informations_Scroll(object sender, ScrollEventArgs e)
        {
        }

        private void créerUnNouveauProjetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox_add_MouseDown_1(this, new MouseEventArgs(MouseButtons.Left, 0, 0, 0, 0));
        }

        private void créerUnSousProjetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (selected_Projet != null)
            {
                Ajouter_un_sous_projet ajouter_Un_Sous_Projet = new Ajouter_un_sous_projet(selected_Projet);
                ajouter_Un_Sous_Projet.ShowDialog();
            }
            else
            {
                MessageBox.Show("Vous devez séléctionner un projet !", "Erreur !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void modifierLeProjetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PictureBox_edit_MouseDown(this, new MouseEventArgs(MouseButtons.Left, 0, 0, 0, 0));
        }

        private void créeUnÉtatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ajouter_un_état ajouter_Un_État = new Ajouter_un_état();
            ajouter_Un_État.ShowDialog();
        }

        private void créeUnePrioritéeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ajouter_une_prioritée ajouter_Une_Prio = new Ajouter_une_prioritée();
            ajouter_Une_Prio.ShowDialog();
        }

        private void Btn_duplicate_MouseDown(object sender, MouseEventArgs e)
        {
            if (selected_Projet != null)
            {
                Ajouter_un_projet ajouter_Un_Projet = new Ajouter_un_projet(selected_Projet, true);
                ajouter_Un_Projet.ShowDialog();
            }
            else
            {
                MessageBox.Show("Vous devez séléctionner un projet à dupliquer !", "Erreur !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Main_Shown(object sender, EventArgs e)
        {
            Log.Mess("Affichage fenêtre principale");

            if (majDispo)
            {
                Log.Mess("Mise à jour disponible");

                Télécharger_mise_à_jour télécharger_Mise_À_Jour = new Télécharger_mise_à_jour();
                télécharger_Mise_À_Jour.ShowDialog();
            }        

            if (FirstLaunch_)
            {
                Log.Mess("Premier lancement");

                FirstLaunch firstLaunch = new FirstLaunch();
                firstLaunch.ShowDialog();
            }

            // Affiche tous les projets importés
            if (Properties.Settings.Default.ShowProjectVu)
            {
                Log.Mess("Affichage des projets importés après avoir charger une backup");

                Properties.Settings.Default.ShowProjectVu = false;
                Properties.Settings.Default.Save();

                Trie_du_projet_importé trie_Du_Projet_Importé = new Trie_du_projet_importé(Main.Utilities.resource.projets, true);
                trie_Du_Projet_Importé.ShowDialog();
            }
        }

        /// <summary>
        /// Importe le projet séléctionné
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bunifuImageButton_import_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                InitializeOpenFileDialog();

                if (openFileWindow.ShowDialog() == DialogResult.OK)
                {
                    string projectPath = openFileWindow.FileName;
                    string json = EncryptionHelper.Decrypt(File.ReadAllText(projectPath));
                    Projet projet_importé = JsonConvert.DeserializeObject<Projet>(json);

                    Log.Mess("Importation d'un projet \"" + projet_importé.Nom_du_projet + "\". Possibilité d'annuler.");

                    Trie_du_projet_importé trie_window = new Trie_du_projet_importé(new List<Projet> { projet_importé });
                    trie_window.ShowDialog();
                }
            }
        }

        private void InitializeOpenFileDialog()
        {
            Log.Mess("Initialisation de la boite de dialogue de dialog de séléction de fichier pour importer un projet");

            // Initialise la boite de dialog pour choisir des fichiers
            openFileWindow = new OpenFileDialog
            {
                Title = "Veuillez choisir un un projet à ajouter",
                InitialDirectory = "c:\\",
                Multiselect = false,
                Filter = "Fichier projet (*.proj) | *.proj",
                FilterIndex = 0,
                RestoreDirectory = true,
            };
        }

        /// <summary>
        /// Ouvre les paramètres
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBox_settings_MouseDown(object sender, MouseEventArgs e)
        {
            Log.Mess("Paramètre ouvert");

            Paramètres paramètres = new Paramètres();
            paramètres.Show();
        }

        /// <summary>
        /// Montre la console en cas de CTRL + C
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Main_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.C && (e.Control))
            {
                AllocConsole();
                IntPtr stdHandle = GetStdHandle(STD_OUTPUT_HANDLE);
                SafeFileHandle safeFileHandle = new SafeFileHandle(stdHandle, true);
                FileStream fileStream = new FileStream(safeFileHandle, FileAccess.Write);
                Encoding encoding = System.Text.Encoding.GetEncoding(MY_CODE_PAGE);
                StreamWriter standardOutput = new StreamWriter(fileStream, encoding);
                standardOutput.AutoFlush = true;
                Console.SetOut(standardOutput);

                Log.Mess("Console ouverte");
            }
        }
    }
}