using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Gestionnaire_de_tâche__Last_
{
    public partial class UserControl_state : UserControl
    {
        private const int STATE_HEIGHT = 37;
        private int x = 0, y = 0;

        public UserControl_state(Tâche tâche, UserControl_Tâche userControl_Tâche)
        {
            InitializeComponent();

            Tâche = tâche;
            UserControl_Tâche = userControl_Tâche;

            ajouterToutesLesStates();
        }

        // Ligne est pour que ça soit en ligne
        private bool ligne = false;

        /// <summary>
        /// Ajoute un état dans la liste
        /// Ajoute le ContextMenuStrip uniquement si ce n'est pas une tâche de base
        /// </summary>
        /// <param name="couleur_de_l_etat">La couleur de l'état</param>
        /// <param name="texte_de_l_etat">Le texte qui va avec</param>
        /// <param name="location">La location spécifique si il y en a</param>
        private void addOneMoreState(Color couleur_de_l_etat, string texte_de_l_etat, Point location = new Point())
        {
            // 37 étant la hauteur d'un état
            int hauteur = 0;

            // Ajout du panel de l'état
            Panel panel_etat = new Panel();
            panel_etat.BackColor = couleur_de_l_etat;
            panel_etat.Size = new Size(131, STATE_HEIGHT);
            panel_etat.BorderStyle = BorderStyle.FixedSingle;
            panel_etat.Name = texte_de_l_etat;

            if (location != new Point())
            {
                panel_etat.Location = location;
                y += panel_etat.Height;
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
                hauteur += panel_etat.Height;
                y += panel_etat.Height;
                x = 0;

                Size = new Size(Size.Width, y);
                ligne = false;
            }

            Label label_state = new Label();
            label_state.Text = texte_de_l_etat;
            label_state.Font = new Font("Verdana", 12, FontStyle.Regular);
            label_state.TextAlign = ContentAlignment.MiddleCenter;
            label_state.Dock = DockStyle.Fill;

            label_state.MouseDown += new System.Windows.Forms.MouseEventHandler(label_state_MouseDown);

            if (!(texte_de_l_etat.Equals("Pas défini") || texte_de_l_etat.Equals("Terminer") || texte_de_l_etat.Equals("En cours") ||
                texte_de_l_etat.Equals("Échouer") || texte_de_l_etat.Equals("En attente") || texte_de_l_etat.Equals("Annuler") || texte_de_l_etat.Equals("Nouveau...")))
            {
                label_state.ContextMenuStrip = contextMenuStrip_option;
            }

            panel_etat.Controls.Add(label_state);

            Controls.Add(panel_etat);
        }

        private int temp = Main.Utilities.resource.etats.Count;

        /// <summary>
        /// Actualize toutes les states si il y a eu des modifs
        /// </summary>
        internal void ActualizeAll()
        {
            if (temp != Main.Utilities.resource.etats.Count)
            {
                temp = Main.Utilities.resource.etats.Count;
                ActualizeAll();
            }
        }

        /// <summary>
        /// Ajoute une state car on en à ajouter
        /// </summary>
        internal void AddState()
        {
            ajouterToutesLesStates();
        }

        /// <summary>
        /// Séléctionne le state et l'attribut à la tâche
        /// Ou ouvre l'ajouteur de state
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
                    for (int i = 0; i < Main.Utilities.resource.etats.Count; i++)
                    {
                        if (Main.Utilities.resource.etats[i].Texte_de_l_etat.Equals(label.Text))
                        {
                            Tâche.State_de_la_tâche = i;

                            UserControl_Tâche.UpdateTâche(Tâche);

                            Main.Utilities.SaveResources();

                            Hide();
                        }
                    }
                }
                else
                {
                    // Customisation
                    Ajouter_un_état ajouter_Un_État_popup = new Ajouter_un_état(UserControl_Tâche);
                    ajouter_Un_État_popup.ShowDialog();
                }
            }
        }

        public Tâche Tâche { get; }
        public UserControl_Tâche UserControl_Tâche { get; }

        /// <summary>
        /// Supprime puis ajoute à nouveau toutes les states
        /// </summary>
        private void ajouterToutesLesStates()
        {
            foreach (Control ctrl in Controls)
            {
                ctrl.Visible = false;
            }

            ligne = false;
            x = 0;
            y = 0;

            for (int i = 0; i < Main.Utilities.resource.etats.Count; i++)
            {
                addOneMoreState(Main.Utilities.resource.etats[i].Couleur_de_l_etat, Main.Utilities.resource.etats[i].Texte_de_l_etat);
            }

            // Ajoute la customisation
            addOneMoreState(Color.White, "Nouveau...");

            Size = new Size(Size.Width, y);
        }

        /// <summary>
        /// Retourne l'état sur lequel on a cliqué
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="temp"></param>
        /// <returns></returns>
        private static Etat getSelecteState(object sender, Etat temp)
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

            foreach (var etat in Main.Utilities.resource.etats)
            {
                if (etat.Texte_de_l_etat.Equals(sourceControl.Text))
                {
                    temp = etat;
                }
            }

            return temp;
        }

        /// <summary>
        /// Modifie la tâche
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void modifierToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Etat temp = null;
            temp = getSelecteState(sender, temp);

            // Contient l'index de l'état modifié
            int index = Main.Utilities.resource.etats.IndexOf(temp);

            Ajouter_un_état ajouter_Un_État = new Ajouter_un_état(UserControl_Tâche, temp);
            ajouter_Un_État.ShowDialog();

            foreach (Control ctrl in Controls)
            {
                if (ctrl is Panel)
                {
                    Panel panel = ctrl as Panel;

                    if (panel.Name.Equals(temp.Texte_de_l_etat))
                    {
                        panel.Name = Main.Utilities.resource.etats[index].Texte_de_l_etat;
                        panel.BackColor = Main.Utilities.resource.etats[index].Couleur_de_l_etat;

                        foreach (Label label in panel.Controls)
                        {
                            label.Text = Main.Utilities.resource.etats[index].Texte_de_l_etat;
                        }
                    }
                }
            }
        }

        private void UserControl_state_Load(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// Supprime une state
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void supprimerToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Etat temp = null;
            temp = getSelecteState(sender, temp);

            int index = Main.Utilities.resource.etats.IndexOf(temp);
            int occurenceTrouver = 0;
            List<Tâche> occurenceTrouverList = new List<Tâche>();

            // On vérifie que aucune tâche n'utilise la priorité là
            foreach (var projet in Main.Utilities.resource.projets)
            {
                foreach (var sousProjet in projet.sous_Projets)
                {
                    foreach (var tache in sousProjet.Tâches)
                    {
                        if (tache.State_de_la_tâche == index)
                        {
                            occurenceTrouver++;
                            occurenceTrouverList.Add(tache);
                        }
                    }
                }
            }

            if (occurenceTrouver == 0)
            {
                decraseAllState(temp);

                Main.Utilities.resource.etats.Remove(temp);
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Ce statut est utilisé dans " + occurenceTrouver + " tâche(s). Voulez-vous remplacer " +
                    "leur statut en \"Pas défini\" ?", "Erreur !",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Error);

                if (dialogResult == DialogResult.OK)
                {
                    foreach (var tache in occurenceTrouverList)
                    {
                        tache.State_de_la_tâche = 0;

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
                                            tache.State_de_la_tâche = 0;
                                            ctrlB.setState(Main.Utilities.resource.etats[0]);
                                        }
                                    }
                                }
                            }
                        }
                    }

                    decraseAllState(temp);

                    Main.Utilities.resource.etats.Remove(temp);

                    Gestion_des_UserControls.ActualizeNbOfSousProjetAndTache();
                }
            }

            ajouterToutesLesStates();
            Main.Utilities.SaveResources();

            Size = new Size(Size.Width, y);
        }

        /// <summary>
        /// Avant tout, on diminue le nombre du state de toutes les tâches qui on un état supérieur au nombre de l'état qu'on va supp
        /// </summary>
        private void decraseAllState(Etat temp)
        {
            int nbOfTheStateToDelete = Main.Utilities.resource.etats.IndexOf(temp);

            foreach (var projet in Main.Utilities.resource.projets)
            {
                foreach (var sousProjet in projet.sous_Projets)
                {
                    foreach (var tache in sousProjet.Tâches)
                    {
                        if (tache.State_de_la_tâche > nbOfTheStateToDelete)
                        {
                            tache.State_de_la_tâche -= 1;
                        }
                    }
                }
            }
        }
    }
}