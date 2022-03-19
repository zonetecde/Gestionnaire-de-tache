using Newtonsoft.Json;
using System;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace Gestionnaire_de_tâche__Last_
{
    public partial class UserControl_Tâche : UserControl
    {
        private UserControl_state userControl_State;
        private UserControls_Prioritécs userControl_Priorité;
        internal bool isShowing = false;
        internal Tâche Tâche { get; set; }
        public Projet Projet { get; }
        public Sous_Projet Sous_Projet { get; }
        public UserControl_Sous_Projet UC { get; }

        private TextInfo myTI = new CultureInfo("fr-FR", false).TextInfo;

        public UserControl_Tâche(Tâche tâche, Projet projet, Sous_Projet sousProjet, UserControl_Sous_Projet UC)
        {
            InitializeComponent();

            Tâche = tâche;
            Projet = projet;
            Sous_Projet = sousProjet;
            this.UC = UC;

            // Permet de rendre le label transparent sur la PB
            var pos = this.PointToScreen(label_counter.Location);
            pos = PictureBox_tchat.PointToClient(pos);
            label_counter.Parent = PictureBox_tchat;
            label_counter.Location = pos;
            label_counter.BackColor = Color.Transparent;

            if (tâche.Messages.Count != 0)
            {
                label_counter.Text = tâche.Messages.Count.ToString();
                label_counter.Visible = true;
            }

            this.Size = new Size(993, 42);

            initializeAll();
        }

        private void initializeAll()
        {
            richtextBox_nom.BorderStyle = BorderStyle.None;
            richtextBox_nom.BackColor = System.Drawing.Color.White;
            richtextBox_nom.ReadOnly = true;
            richtextBox_nom.GotFocus += (s, ea) => { label_priorité.Focus(); };

            userControl_State = new UserControl_state(Tâche, this);
            userControl_State.Visible = false;
            Main.panel_info.Controls.Add(userControl_State);

            userControl_Priorité = new UserControls_Prioritécs(Tâche, this);
            userControl_Priorité.Visible = false;
            Main.panel_info.Controls.Add(userControl_Priorité);

            foreach (var motClé in Tâche.Mots_Clés)
            {
                comboBox_motsClés.Items.Add(motClé);

                comboBox_motsClés.SelectedIndex = 0;
            }

            SetInformation(Tâche);
        }

        /// <summary>
        /// Update la progression de ma tâche
        /// </summary>
        internal void UpdateProgression()
        {
            progressBar_progression.Value = Tâche.Progression;
        }

        /// <summary>
        /// Ajoute un mot clé en haut de la comboBox
        /// </summary>
        /// <param name="v"></param>
        internal void AddMotClé(string v)
        {
            comboBox_motsClés.Items.Insert(0, v);

            comboBox_motsClés.SelectedIndex = 0;
        }

        private Label label_state = new Label();
        private Label label_priorité = new Label();

        /// <summary>
        /// Set les infos
        /// Le nom, la couleur, le state, la prio, les persos...
        /// 
        /// ATTENTION ! NE PAS APPELLER A PARTIE D'UN UC, L'EVENT DE CLIC DE SOURIT SUR LETAT ET LA PRIORITEE SERA PRIS EN CONSIDERATION DEUX FOIS
        /// </summary>
        /// <param name="tâche"></param>
        private void SetInformation(Tâche tâche)
        {
            Log.Mess("Ajout des informations de la tâche " + tâche.Nom_de_la_tâche);

            if (tâche != null)
            {
                richtextBox_nom.Text = tâche.Nom_de_la_tâche;
                if (richtextBox_nom.Text.Length > 41)
                {
                    richtextBox_nom.Location = new Point(29, 8);
                    richtextBox_nom.Font = new Font("Verdana", 9);
                }
                else
                {
                    richtextBox_nom.Location = new Point(29, 12);
                    richtextBox_nom.Font = new Font("Verdana", 11);
                }

                panel_color.BackColor = tâche.Couleur_de_la_tâche;
            }

            try
            {
                panel_state.BackColor = Main.Utilities.resource.etats[tâche.State_de_la_tâche].Couleur_de_l_etat;
            }
            catch
            {
                tâche.State_de_la_tâche = 0;
                panel_state.BackColor = Main.Utilities.resource.etats[tâche.State_de_la_tâche].Couleur_de_l_etat;
            }

            label_state.Text = Main.Utilities.resource.etats[tâche.State_de_la_tâche].Texte_de_l_etat;
            label_state.Font = new Font("Verdana", 12, FontStyle.Regular);
            label_state.TextAlign = ContentAlignment.MiddleCenter;
            label_state.Dock = DockStyle.Fill;
            label_state.MouseDown += new System.Windows.Forms.MouseEventHandler(label_state_Click);

            panel_state.Controls.Add(label_state);

            try
            {
                panel_priorité.BackColor = Main.Utilities.resource.priorités[tâche.Priorité_de_la_tâche].Couleur_de_l_etat;
            }
            catch
            {
                panel_priorité.BackColor = Color.FromName("Gainsboro");
            }

            try
            {
                label_priorité.Text = Main.Utilities.resource.priorités[tâche.Priorité_de_la_tâche].Texte_de_l_etat;
            }
            catch
            {
                label_priorité.Text = Main.Utilities.resource.priorités[0].Texte_de_l_etat;
            }

            label_priorité.Font = new Font("Verdana", 12, FontStyle.Regular);
            label_priorité.TextAlign = ContentAlignment.MiddleCenter;
            label_priorité.Dock = DockStyle.Fill;
            label_priorité.MouseDown += new System.Windows.Forms.MouseEventHandler(label_priorité_Click);

            panel_priorité.Controls.Add(label_priorité);

            // Date d'échéance

            if (tâche.Date_d_echeance == null)
                label_date.Text = string.Empty;
            else
            {
                label_date.Text = tâche.Date_d_echeance.Value.Day.ToString().PadLeft(1, '0') + " " + myTI.ToTitleCase(tâche.Date_d_echeance.Value.ToString("MMMM", new CultureInfo("fr-FR")));

                if(tâche.Date_d_echeance.Value < DateTime.Now)
                {
                    label_date.Font = new Font(label_date.Font, FontStyle.Strikeout);
                }
                else
                {
                    label_date.Font = new Font(label_date.Font, FontStyle.Regular);
                }                
            }

            if(!tâche.Texte.Equals(string.Empty))
                richTextBox_texte.Text = Tâche.Texte;

            UpdateProgression();
        }


        /// <summary>
        /// Actuallize uniquement le nom est la couleur du projet
        /// </summary>
        internal void ActualizePrincipaleInformation()
        {
            Log.Mess("Actualisation des principales informations de la tâche " + Tâche.Nom_de_la_tâche);

            richtextBox_nom.Text = Tâche.Nom_de_la_tâche;
            if (richtextBox_nom.Text.Length > 41)
            {
                richtextBox_nom.Location = new Point(29, 8);
                richtextBox_nom.Font = new Font("Verdana", 9);
            }
            else
            {
                richtextBox_nom.Location = new Point(29, 12);
                richtextBox_nom.Font = new Font("Verdana", 11);
            }

            panel_color.BackColor = Tâche.Couleur_de_la_tâche;
        }

        /// <summary>
        /// Quand on clique sur la propriétée pour le changer, on ouvre le UC
        /// On actualise tous ces propriétées, on lui set la pos
        /// Et on l'affiche
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private int tempA = Main.Utilities.resource.priorités.Count;

        private void label_priorité_Click(object sender, MouseEventArgs e)
        {
            this.ActiveControl = label_priorité;

            if (e.Button == MouseButtons.Left)
            {
                foreach (var ctrl in UC.Controls)
                {
                    if (ctrl is UserControl_Tâche && ctrl != this)
                    {
                        UserControl_Tâche UCA = ctrl as UserControl_Tâche;
                        UCA.hideUC();
                    }
                }

                if (tempA == Main.Utilities.resource.priorités.Count)
                {
                    if (!userControl_Priorité.Visible)
                    {
                        Log.Mess("Montre le UC de priorité pour la tâche " + Tâche.Nom_de_la_tâche);

                        userControl_Priorité.Location = new Point(Main.panel_info.PointToClient(Cursor.Position).X, Main.panel_info.PointToClient(Cursor.Position).Y);
                        userControl_Priorité.Show();
                        userControl_Priorité.BringToFront();
                        userControl_State.Hide();
                    }
                    else
                    {
                        Log.Mess("Cache le UC de priorité pour la tâche " + Tâche.Nom_de_la_tâche);

                        userControl_Priorité.Hide();
                    }
                }
                else
                {
                    // Actualize si une nouvelle prio est rajouter
                    foreach (Control ctrl in Main.panel_info.Controls)
                    {
                        if (ctrl is UserControl_Sous_Projet)
                        {
                            foreach (Control ctrlA in ctrl.Controls)
                            {
                                if (ctrlA is UserControl_Tâche)
                                {
                                    UserControl_Tâche ctrlB = ctrlA as UserControl_Tâche;
                                    ctrlB.userControl_Priorité.AddState();
                                }
                            }
                        }
                    }

                    tempA = Main.Utilities.resource.priorités.Count;

                    if (!userControl_Priorité.Visible)
                    {
                        Log.Mess("Montre le UC de priorité pour la tâche " + Tâche.Nom_de_la_tâche);

                        userControl_Priorité.Show();
                        userControl_Priorité.BringToFront();
                        userControl_State.Hide();
                    }
                    else
                    {
                        Log.Mess("Cache le UC de priorité pour la tâche " + Tâche.Nom_de_la_tâche);

                        userControl_Priorité.Hide();
                    }
                }
            }
        }

        internal void hideUC()
        {
            if (userControl_Priorité != null)
            {
                userControl_Priorité.Hide();
            }

            if(userControl_State != null)
            {
                userControl_State.Hide();
            }
        }

        /// <summary>
        /// Modifie le state uniquement si il est définit
        /// </summary>
        /// <param name="etat"></param>
        internal void setStateIfIsDefinied_Priorité(Priorité priorité, Priorité etat)
        {
            if (label_priorité.Text.Equals(etat.Texte_de_l_etat))
            {
                label_priorité.Text = priorité.Texte_de_l_etat;
                panel_priorité.BackColor = priorité.Couleur_de_l_etat;
            }

            Tâche.Priorité_de_la_tâche = Main.Utilities.resource.priorités.IndexOf(priorité);
        }

        /// <summary>
        /// Set la prioritée
        /// </summary>
        /// <param name="etat"></param>
        internal void setPriorité(Priorité priorité)
        {
            panel_priorité.BackColor = priorité.Couleur_de_l_etat;
            label_priorité.Text = priorité.Texte_de_l_etat;

            isShowing = false;
            userControl_Priorité.Hide();

            foreach (Control ctrl in Main.panel_info.Controls)
            {
                if (ctrl is UserControl_Sous_Projet)
                {
                    foreach (Control ctrlA in ctrl.Controls)
                    {
                        if (ctrlA is UserControl_Tâche)
                        {
                            UserControl_Tâche ctrlB = ctrlA as UserControl_Tâche;
                            ctrlB.userControl_Priorité.AddState();
                        }
                    }
                }
            }

            Tâche.Priorité_de_la_tâche = Main.Utilities.resource.priorités.IndexOf(priorité);
            Log.Mess("Set d'une nouvelle priorité \"" + Main.Utilities.resource.priorités[Tâche.Priorité_de_la_tâche].Texte_de_l_etat +  "\" pour la tâche " + Tâche.Nom_de_la_tâche);
        }

        /// <summary>
        /// Set le state
        /// </summary>
        /// <param name="etat"></param>
        internal void setState(Etat etat)
        {
            panel_state.BackColor = etat.Couleur_de_l_etat;
            label_state.Text = etat.Texte_de_l_etat;

            userControl_State.Hide();
            userControl_Priorité.Hide();

            foreach (Control ctrl in Main.panel_info.Controls)
            {
                if (ctrl is UserControl_Sous_Projet)
                {
                    foreach (Control ctrlA in ctrl.Controls)
                    {
                        if (ctrlA is UserControl_Tâche)
                        {
                            UserControl_Tâche ctrlB = ctrlA as UserControl_Tâche;
                            ctrlB.userControl_State.AddState();
                        }
                    }
                }
            }

            Tâche.State_de_la_tâche = Main.Utilities.resource.etats.IndexOf(etat);
            Log.Mess("Set d'un nouvel état \"" + Main.Utilities.resource.etats[Tâche.State_de_la_tâche].Texte_de_l_etat + "\" pour la tâche " + Tâche.Nom_de_la_tâche);
        }

        /// <summary>
        /// Modifie le state uniquement si il est définit
        /// </summary>
        /// <param name="etat"></param>
        internal void setStateIfIsDefinied(Etat etat, Etat ancienneEtat)
        {
            if (label_state.Text.Equals(ancienneEtat.Texte_de_l_etat))
            {
                label_state.Text = etat.Texte_de_l_etat;
                panel_state.BackColor = etat.Couleur_de_l_etat;
            }

            Tâche.State_de_la_tâche = Main.Utilities.resource.etats.IndexOf(etat);
        }

        /// <summary>
        /// Quand on clique sur l'état pour le changer, on ouvre le UC
        /// On actualise tous ces états, on lui set la pos
        /// Et on l'affiche
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private int temp = Main.Utilities.resource.etats.Count;

        private void label_state_Click(object sender, MouseEventArgs e)
        {
            this.ActiveControl = PictureBox_tchat;
            
            if (temp == Main.Utilities.resource.etats.Count)
            {
                if (e.Button == MouseButtons.Left)
                {
                    foreach(var ctrl in UC.Controls)
                    {
                        if(ctrl is UserControl_Tâche && ctrl != this)
                        {
                            UserControl_Tâche UCA = ctrl as UserControl_Tâche;
                            UCA.hideUC();
                        }
                    }

                    if (!userControl_State.Visible)
                    {
                        Log.Mess("Affiche le UC état pour la tâche " + Tâche.Nom_de_la_tâche);

                        userControl_State.Location = new Point(Main.panel_info.PointToClient(Cursor.Position).X, Main.panel_info.PointToClient(Cursor.Position).Y);
                        userControl_State.Show();
                        userControl_State.BringToFront();
                        userControl_Priorité.Hide();
                    }
                    else
                    {
                        Log.Mess("Cache le UC état pour la tâche " + Tâche.Nom_de_la_tâche);

                        userControl_State.Visible = false;
                    }
                }
            }
            else
            {
                foreach (Control ctrl in Main.panel_info.Controls)
                {
                    if (ctrl is UserControl_Sous_Projet)
                    {
                        foreach (Control ctrlA in ctrl.Controls)
                        {
                            if (ctrlA is UserControl_Tâche)
                            {
                                UserControl_Tâche ctrlB = ctrlA as UserControl_Tâche;
                                ctrlB.userControl_State.AddState();
                            }
                        }
                    }
                }

                temp = Main.Utilities.resource.etats.Count;

                if (e.Button == MouseButtons.Left)
                {
                    if (!userControl_State.Visible)
                    {
                        Log.Mess("Affiche le UC état pour la tâche " + Tâche.Nom_de_la_tâche);

                        userControl_State.Show();
                        userControl_State.BringToFront();
                        userControl_Priorité.Hide();
                    }
                    else
                    {
                        Log.Mess("Cache le UC état pour la tâche " + Tâche.Nom_de_la_tâche);

                        userControl_State.Hide();
                    }
                }
            }
        }

        /// <summary>
        /// Update le state de la tâche
        /// Car il a été modifié
        /// </summary>
        /// <param name="tâche"></param>
        internal void UpdateTâche(Tâche tâche)
        {
            label_state.Text = Main.Utilities.resource.etats[tâche.State_de_la_tâche].Texte_de_l_etat;
            panel_state.BackColor = Main.Utilities.resource.etats[tâche.State_de_la_tâche].Couleur_de_l_etat;

            label_priorité.Text = Main.Utilities.resource.priorités[tâche.Priorité_de_la_tâche].Texte_de_l_etat;
            panel_priorité.BackColor = Main.Utilities.resource.priorités[tâche.Priorité_de_la_tâche].Couleur_de_l_etat;

            if (Tâche.Date_d_echeance != null)
            {
                label_date.Text = tâche.Date_d_echeance.Value.Day.ToString().PadLeft(1, '0') + " " + myTI.ToTitleCase(tâche.Date_d_echeance.Value.ToString("MMMM", new CultureInfo("fr-FR")));
                if (tâche.Date_d_echeance.Value < DateTime.Now)
                {
                    label_date.Font = new Font(label_date.Font, FontStyle.Strikeout);
                }
                else
                {
                    label_date.Font = new Font(label_date.Font, FontStyle.Regular);
                }
            }
            else
                label_date.Text = string.Empty;

            if (tâche.Messages.Count != 0)
            {
                label_counter.Text = tâche.Messages.Count.ToString();
                label_counter.Visible = true;
            }
        }

        /// <summary>
        /// Ouvre la fenetre de date d'échéance
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void label_date_DoubleClick(object sender, EventArgs e)
        {
            Log.Mess("Affiche la fenêtre pour set une date d'échéance pour la tâche " + Tâche.Nom_de_la_tâche);

            Ajouter_une_date_d_échéance ajouter_Une_Date_D_Échéance = new Ajouter_une_date_d_échéance(Tâche, this);
            ajouter_Une_Date_D_Échéance.ShowDialog();
        }

        /// <summary>
        /// Set le tooltip qui display la date sous cette form
        /// Lun. 24 Mar. 2019
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private ToolTip toolTip = new ToolTip();

        private void label_date_MouseHover(object sender, EventArgs e)
        {
            if (Tâche.Date_d_echeance != null)
            {
                toolTip.SetToolTip(label_date, myTI.ToTitleCase(Tâche.Date_d_echeance.Value.ToString("ddd d MMM yyyy",
                      CultureInfo.CreateSpecificCulture("fr-FR"))));
            }
            else
            {
                toolTip.SetToolTip(label_date, string.Empty);
            }
        }

        /// <summary>
        /// Ouvre la fenetre d'ajout de date d'échéance
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ajouterUneDateDéchéanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Log.Mess("Affiche la fenêtre pour set une date d'échéance pour la tâche " + Tâche.Nom_de_la_tâche);

            Ajouter_une_date_d_échéance ajouter_Une_Date_D_Échéance = new Ajouter_une_date_d_échéance(Tâche, this);
            ajouter_Une_Date_D_Échéance.ShowDialog();
        }

        /// <summary>
        /// Supprime la date d'échéance de la tâche
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void supprimerLaDateDéchéanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Log.Mess("Supprime la date d'échéance pour la tâche " + Tâche.Nom_de_la_tâche);

            Tâche.Date_d_echeance = null;
            UpdateTâche(Tâche);
        }

        /// <summary>
        /// Ouvre la page de tchat
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PictureBox_tchat_MouseDown(object sender, MouseEventArgs e)
        {
            this.ActiveControl = PictureBox_tchat;
            if (e.Button == MouseButtons.Left)
            {
                Log.Mess("Affiche la fenêtre de tchat pour la tâche " + Tâche.Nom_de_la_tâche);

                Tchat tchat_window = new Tchat(Tâche, this);
                tchat_window.Show();
            }
        }

        /// <summary>
        /// Met en surbrillance le texte qui est similaire
        /// </summary>
        /// <param name="wordToMakeSurbrillancer">Le texte à mettre en surbrillance</param>
        /// <param name="v">Si on enlève la survrillance ou pas</param>
        internal void Surbrillance(bool isTag, string wordToMakeSurbrillancer = null, bool v = true)
        {
            Log.Mess("Outil de recherche utilisé pour \"" + wordToMakeSurbrillancer +  "\" pour la tâche " + Tâche.Nom_de_la_tâche);

            if (!String.IsNullOrEmpty(wordToMakeSurbrillancer))
            {
                if (v)
                {
                    // Deminimize si on à trouver une tache et que c'est minimiser
                    if (UC.isMinimize)
                        UC.pictureBox_view_MouseDown(this, new MouseEventArgs(MouseButtons.Left, 0, 0, 0, 0));

                    if (isTag)
                    {
                        for (int i = 0; i < comboBox_motsClés.Items.Count; i++)
                        {
                            if (comboBox_motsClés.Items[i].ToString().Contains(wordToMakeSurbrillancer))
                            {
                                comboBox_motsClés.SelectedIndex = i;
                                comboBox_motsClés.ForeColor = Color.Red;
                            }
                        }
                    }
                    else
                    {
                        Main.Utilities.HighlightSearchText(wordToMakeSurbrillancer, richtextBox_nom, Color.Black);

                        bool tagOk = false;

                        for (int i = 0; i < comboBox_motsClés.Items.Count; i++)
                        {
                            if (comboBox_motsClés.Items[i].ToString().Contains(wordToMakeSurbrillancer))
                                tagOk = true;
                        }

                        if (!tagOk)
                            comboBox_motsClés.ForeColor = Color.Black;
                    }
                }
                else
                {
                    richtextBox_nom.SelectAll();
                    richtextBox_nom.SelectionColor = Color.Black;

                    bool tagOk = false;

                    for (int i = 0; i < comboBox_motsClés.Items.Count; i++)
                    {
                        if (comboBox_motsClés.Items[i].ToString().Contains(wordToMakeSurbrillancer))
                            tagOk = true;
                    }

                    if (!tagOk)
                        comboBox_motsClés.ForeColor = Color.Black;
                }
            }
            else
            {
                richtextBox_nom.SelectAll();
                richtextBox_nom.SelectionColor = Color.Black;
                comboBox_motsClés.ForeColor = Color.Black;
            }
        }

        private void UserControl_Tâche_Load(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// Affiche la page d'ajout de mot clé
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ajouterUnMotCléToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Log.Mess("Affiche la fenêtre de mot clé pour la tâche " + Tâche.Nom_de_la_tâche);

            Ajouter_un_mot_clé ajouter_Un_Mot_Clé = new Ajouter_un_mot_clé(Tâche, this);
            ajouter_Un_Mot_Clé.ShowDialog();
        }

        /// <summary>
        /// Supprime le mot clé affiché
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void supprimeCeMotCléToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(comboBox_motsClés.Text))
            {
                Log.Mess("Supprime le mot clé \"" + comboBox_motsClés.Text + "\" pour la tâche " + Tâche.Nom_de_la_tâche);

                Tâche.Mots_Clés.RemoveAt(comboBox_motsClés.SelectedIndex);
                comboBox_motsClés.Items.RemoveAt(comboBox_motsClés.SelectedIndex);

                if (comboBox_motsClés.Items.Count != 0)
                {
                    comboBox_motsClés.SelectedIndex = 0;
                }
            }
        }

        /// <summary>
        /// Modifie la tâche
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Ajouter_une_tâche ajouter_Une_Tâche = new Ajouter_une_tâche(Tâche, this);
            ajouter_Une_Tâche.ShowDialog();
        }

        /// <summary>
        /// Supprime la tâche
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Log.Mess("Suppression de la tâche " + Tâche.Nom_de_la_tâche);

            Gestion_des_UserControls.HideSpecificTache(Sous_Projet, Tâche);

            Sous_Projet.Tâches.Remove(Tâche);

            Gestion_des_UserControls.ActualizeNbOfSousProjetAndTache();
        }

        /// <summary>
        /// Duplique la tâche
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dupliquerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Log.Mess("Duplique la tâche " + Tâche.Nom_de_la_tâche);

            Ajouter_une_tâche ajouter_Une_Tâche = new Ajouter_une_tâche(tâche: Tâche, isDuplicate: true, sous_Projet: Sous_Projet, userControl_Tâche:this) ;
            ajouter_Une_Tâche.ShowDialog();
        }

        private void comboBox_motsClés_DropDownClosed(object sender, EventArgs e)
        {
            this.ActiveControl = label_state;
        }

        /// <summary>
        /// Modifie le nom
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void richtextBox_nom_DoubleClick(object sender, EventArgs e)
        {
            textBox_modify.Visible = true;
            this.ActiveControl = textBox_modify;
        }

        /// <summary>
        /// Ajoute le nom de la tâche pour la modifier
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox_modify_Enter(object sender, EventArgs e)
        {
            textBox_modify.Text = Tâche.Nom_de_la_tâche;
            textBox_modify.SelectAll();
        }

        /// <summary>
        /// Si on valide
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox_modify_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                if (!String.IsNullOrEmpty(textBox_modify.Text))
                {
                    Log.Mess("Changement de nom pour la tâche " + Tâche.Nom_de_la_tâche);

                    Tâche.Nom_de_la_tâche = textBox_modify.Text;
                    ActualizePrincipaleInformation();
                    textBox_modify.Visible = false;
                }
                else
                    this.ActiveControl = label_state;
            }
        }

        /// <summary>
        /// Enlève la textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox_modify_Leave(object sender, EventArgs e)
        {
            textBox_modify.Visible = false;
        }

        private void label_counter_MouseDown(object sender, MouseEventArgs e)
        {
            PictureBox_tchat_MouseDown(this, new MouseEventArgs(MouseButtons.Left, 0, 0, 0, 0));
        }

        private void label_date_MouseDown(object sender, MouseEventArgs e)
        {
            this.ActiveControl = label_date;
        }

        private void richtextBox_nom_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void panel_motClé_MouseUp(object sender, MouseEventArgs e)
        {

        }

        /// <summary>
        /// Déploie les autres fonctions
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        bool isDeployed = false;
        private void panel_color_MouseDown(object sender, MouseEventArgs e)
        {
            this.ActiveControl = panel_color;

            if (!isDeployed)
            {
                Log.Mess("Affiche la deuxieme partie de la tâche " + Tâche.Nom_de_la_tâche);

                this.Size = new Size(this.Width, this.Height + 42);

                UC.RepositionnerTous();

                isDeployed = true;
            }
            else
            {
                Log.Mess("Cache la deuxieme partie de la tâche " + Tâche.Nom_de_la_tâche);

                this.Size = new Size(this.Width, this.Height - 42);

                UC.RepositionnerTous();

                isDeployed = false;
            }
        }

        /// <summary>
        /// Affiche la fenetre pour modifier la progression
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panel_progressbar_Click(object sender, EventArgs e)
        {
            MouseEventArgs a = e as MouseEventArgs;

            if (a.Button == MouseButtons.Left)
            {
                Log.Mess("Affiche la fenêtre de progression pour la tâche " + Tâche.Nom_de_la_tâche);

                Modifier_la_progression modifier_La_Progression = new Modifier_la_progression(Tâche, this);
                modifier_La_Progression.ShowDialog();
            }
        }

        /// <summary>
        /// Update la descrirption/précision de la tâche
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void richTextBox_texte_TextChanged(object sender, EventArgs e)
        {
            Tâche.Texte = richTextBox_texte.Text;
        }

        private void richTextBox_texte_Enter(object sender, EventArgs e)
        {
            if(richTextBox_texte.Text.Equals("..."))
            {
                richTextBox_texte.Text = string.Empty;
            }
        }

        /// <summary>
        /// Applique toutes les tâches du sous projet actuelle à l'état de cette tâche
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void appliquerPourTousDansLeSousProjetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Log.Mess("Applique pour toutes les tâches du sous projet \"" + Sous_Projet.Nom_du_sous_projet+ "\" l'état \"" + Main.Utilities.resource.etats[Tâche.State_de_la_tâche].Texte_de_l_etat +"\" depuis la tâche " + Tâche.Nom_de_la_tâche);

            foreach (Control ctrl in Main.panel_info.Controls)
            {
                if(ctrl is UserControl_Sous_Projet)
                {
                    foreach(Control ctrlA in ctrl.Controls)
                    {
                        if(ctrlA is UserControl_Tâche)
                        {
                            UserControl_Tâche UC = ctrlA as UserControl_Tâche;
                            if(UC.Sous_Projet == Sous_Projet)
                            {
                                // Attribut le state et actualize la tâche
                                UC.Tâche.State_de_la_tâche = Tâche.State_de_la_tâche;
                                UC.UpdateTâche(UC.Tâche);
                            }
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Applique toutes les tâches du sous projet actuelle à la priorité de cette tâche
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripMenuItem3_appliquerPourTous_Click(object sender, EventArgs e)
        {
            Log.Mess("Applique pour toutes les tâches du sous projet \"" + Sous_Projet.Nom_du_sous_projet + "\" la propriétée \"" + Main.Utilities.resource.priorités[Tâche.Priorité_de_la_tâche].Texte_de_l_etat + "\" depuis la tâche " + Tâche.Nom_de_la_tâche);

            foreach (Control ctrl in Main.panel_info.Controls)
            {
                if (ctrl is UserControl_Sous_Projet)
                {
                    foreach (Control ctrlA in ctrl.Controls)
                    {
                        if (ctrlA is UserControl_Tâche)
                        {
                            UserControl_Tâche UC = ctrlA as UserControl_Tâche;
                            if (UC.Sous_Projet == Sous_Projet)
                            {
                                // Attribut le state et actualize la tâche
                                UC.Tâche.Priorité_de_la_tâche = Tâche.Priorité_de_la_tâche;
                                UC.UpdateTâche(UC.Tâche);
                            }
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Raccourcis lorsque on appuie sur entrer quand le focus est sur la combolist
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBox_motsClés_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                Ajouter_un_mot_clé ajouter_Un_Mot_Clé = new Ajouter_un_mot_clé(Tâche, this);
            }
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
        /// Copy dans le presse papier la tâche
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void copierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Log.Mess("Copie la tâche " + Tâche.Nom_de_la_tâche);

            // Serialize l'objet en json
            Clipboard.SetText(EncryptionHelper.Encrypt(JsonConvert.SerializeObject(Tâche, Formatting.Indented)));       
        }
    }
}