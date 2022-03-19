using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Gestionnaire_de_tâche__Last_
{
    public partial class UserControls_Prioritécs : UserControl
    {
        public UserControl_Tâche UserControl_Tâche { get; }
        public Tâche Tache { get; }
        private const int STATE_HEIGHT = 37;

        public UserControls_Prioritécs(Tâche tâche, UserControl_Tâche userControl_Tâche)
        {
            InitializeComponent();
            UserControl_Tâche = userControl_Tâche;
            Tache = tâche;

            ajouterToutesLesStates();
        }

        /// <summary>
        /// Ajoute une prio dans la liste
        /// Ajoute le ContextMenuStrip uniquement si ce n'est pas une prio de base
        /// </summary>
        /// <param name="couleur_de_l_etat">La couleur de l'état</param>
        /// <param name="texte_de_l_etat">Le texte qui va avec</param>
        /// <param name="location">La location spécifique si il y en a</param>
        private void addOneMoreState(Color couleur_de_l_etat, string texte_de_l_etat, Point location = new Point())
        {
            // Ajout du panel de l'état
            Panel panel_etat = new Panel();
            panel_etat.BackColor = couleur_de_l_etat;
            panel_etat.Size = new Size(131, STATE_HEIGHT);
            panel_etat.BorderStyle = BorderStyle.FixedSingle;
            panel_etat.Name = texte_de_l_etat;

            if (location != new Point())
            {
                panel_etat.Location = location;
            }
            else if (!ligne)
            {
                panel_etat.Location = new Point(x, y);
                x += panel_etat.Width;
                ligne = true;

                // Si c'est celui pour custom, j'ajoute de la taille car sinon il ne ce fait pas
                if (texte_de_l_etat.Equals("Nouveau..."))
                    y += panel_etat.Height;
            }
            else
            {
                panel_etat.Location = new Point(x, y);
                y += panel_etat.Height;
                x = 0;
                ligne = false;
            }

            Label label_state = new Label();
            label_state.Text = texte_de_l_etat;
            label_state.Font = new Font("Verdana", 12, FontStyle.Regular);
            label_state.TextAlign = ContentAlignment.MiddleCenter;
            label_state.Dock = DockStyle.Fill;

            label_state.MouseDown += new System.Windows.Forms.MouseEventHandler(label_state_MouseDown);

            if (!(texte_de_l_etat.Equals("Urgent") || texte_de_l_etat.Equals("À faire") || texte_de_l_etat.Equals("Optionnel") ||
                texte_de_l_etat.Equals("À la fin") || texte_de_l_etat.Equals("Pas défini") || texte_de_l_etat.Equals("Nouveau...")))
            {
                label_state.ContextMenuStrip = contextMenuStrip_option;
            }

            panel_etat.Controls.Add(label_state);

            Controls.Add(panel_etat);
        }

        private int temp = Main.Utilities.resource.priorités.Count;

        /// <summary>
        /// Actualize toutes les prio si il y a eu des modifs
        /// </summary>
        internal void ActualizeAll()
        {
            if (temp != Main.Utilities.resource.priorités.Count)
            {
                ActualizeAll();
                temp = Main.Utilities.resource.priorités.Count;
            }

            this.Size = new Size(this.Width, y);
        }

        /// <summary>
        /// Ajoute une state car on en à ajouter
        /// </summary>
        internal void AddState()
        {
            ajouterToutesLesStates();
        }

        /// <summary>
        /// Séléctionne la priorité et l'attribut à la tâche
        /// Ou ouvre l'ajouteur de priorité
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void label_state_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Label label = sender as Label;

                if (!label.Text.Equals("Nouveau..."))
                {
                    for (int i = 0; i < Main.Utilities.resource.priorités.Count; i++)
                    {
                        if (Main.Utilities.resource.priorités[i].Texte_de_l_etat.Equals(label.Text))
                        {
                            Tache.Priorité_de_la_tâche = i;

                            UserControl_Tâche.UpdateTâche(Tache);

                            Main.Utilities.SaveResources();

                            Hide();
                        }
                    }
                }
                else
                {
                    // Customisation
                    Ajouter_une_prioritée ajouter_Un_État_popup = new Ajouter_une_prioritée(UserControl_Tâche);
                    ajouter_Un_État_popup.ShowDialog();
                }

                ajouterToutesLesStates();
            }
        }

        /// <summary>
        /// Supprime puis ajoute toutes les priorités
        /// </summary>
        private bool ligne = false;

        private int x = 0, y = 0;

        private void ajouterToutesLesStates()
        {
            foreach (Control ctrl in Controls)
            {
                ctrl.Visible = false;
            }

            ligne = false;
            x = 0;
            y = 0;

            for (int i = 0; i < Main.Utilities.resource.priorités.Count; i++)
            {
                addOneMoreState(Main.Utilities.resource.priorités[i].Couleur_de_l_etat, Main.Utilities.resource.priorités[i].Texte_de_l_etat);
            }

            // Ajoute la customisation
            addOneMoreState(Color.White, "Nouveau...");

            Size = new Size(Size.Width, y);
        }

        /// <summary>
        /// Supprime une priorité
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void supprimerToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Priorité temp = null;
            temp = getSelecteState(sender, temp);

            int index = Main.Utilities.resource.priorités.IndexOf(temp);
            int occurenceTrouver = 0;
            List<Tâche> occurenceTrouverList = new List<Tâche>();

            // On vérifie que aucune tâche n'utilise la priorité là
            foreach (var projet in Main.Utilities.resource.projets)
            {
                foreach (var sousProjet in projet.sous_Projets)
                {
                    foreach (var tache in sousProjet.Tâches)
                    {
                        if (tache.Priorité_de_la_tâche == index)
                        {
                            occurenceTrouver++;
                            occurenceTrouverList.Add(tache);
                        }
                    }
                }
            }

            if (occurenceTrouver == 0)
            {
                Main.Utilities.resource.priorités.Remove(temp);
                decraseAllPrority(temp);
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Cette priorité est utilisé dans " + occurenceTrouver + " tâche(s). Voulez-vous remplacer " +
                    "leur statut en \"Pas défini\" ?", "Erreur !",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Error);

                if (dialogResult == DialogResult.OK)
                {
                    foreach (var tache in occurenceTrouverList)
                    {
                        Tache.State_de_la_tâche = 0;

                        foreach (Control ctrl in Main.panel_info.Controls)
                        {
                            if (ctrl is UserControl_Sous_Projet)
                            {
                                foreach (Control ctrlA in ctrl.Controls)
                                {
                                    if (ctrlA is UserControl_Tâche)
                                    {
                                        UserControl_Tâche ctrlB = ctrlA as UserControl_Tâche;
                                        if (ctrlB.Tâche == tache)
                                        {
                                            tache.Priorité_de_la_tâche = 0;
                                            ctrlB.setPriorité(Main.Utilities.resource.priorités[0]);
                                        }
                                    }
                                }
                            }
                        }
                    }

                    decraseAllPrority(temp);
                    Main.Utilities.resource.priorités.Remove(temp);
                }
            }

            ajouterToutesLesStates();
        }

        /// <summary>
        /// Modifie la tâche
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void modifierToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Priorité temp = null;
            temp = getSelecteState(sender, temp);

            // Contient l'index de l'état modifié
            int index = Main.Utilities.resource.priorités.IndexOf(temp);

            Ajouter_une_prioritée ajouter_Une_Priorité = new Ajouter_une_prioritée(UserControl_Tâche, temp);
            ajouter_Une_Priorité.ShowDialog();

            foreach (Control ctrl in Controls)
            {
                if (ctrl is Panel)
                {
                    Panel panel = ctrl as Panel;

                    if (panel.Name.Equals(temp.Texte_de_l_etat))
                    {
                        panel.Name = Main.Utilities.resource.priorités[index].Texte_de_l_etat;
                        panel.BackColor = Main.Utilities.resource.priorités[index].Couleur_de_l_etat;

                        foreach (Label label in panel.Controls)
                        {
                            label.Text = Main.Utilities.resource.priorités[index].Texte_de_l_etat;
                        }
                    }
                }
            }
        }

        private void UserControls_Prioritécs_Load(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// Retourne la priorité sur laquel on a cliqué
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="temp"></param>
        /// <returns></returns>
        private static Priorité getSelecteState(object sender, Priorité temp)
        {
            Control sourceControl = null;

            ToolStripItem menuItem = sender as ToolStripItem;
            if (menuItem != null)
            {
                ContextMenuStrip owner = menuItem.Owner as ContextMenuStrip;
                if (owner != null)
                {
                    sourceControl = owner.SourceControl;
                }
            }

            foreach (var priorité in Main.Utilities.resource.priorités)
            {
                if (priorité.Texte_de_l_etat.Equals(sourceControl.Text))
                {
                    temp = priorité;
                }
            }

            return temp;
        }

        /// <summary>
        /// Avant tout, on diminue le nombre du state de toutes les tâches qui on un état supérieur au nombre de l'état qu'on va supp
        /// </summary>
        private void decraseAllPrority(Priorité temp)
        {
            int nbOfThePrioToDelete = Main.Utilities.resource.priorités.IndexOf(temp);

            foreach (var projet in Main.Utilities.resource.projets)
            {
                foreach (var sousProjet in projet.sous_Projets)
                {
                    foreach (var tache in sousProjet.Tâches)
                    {
                        if (tache.Priorité_de_la_tâche > nbOfThePrioToDelete)
                        {
                            tache.Priorité_de_la_tâche -= 1;
                        }
                    }
                }
            }
        }
    }
}