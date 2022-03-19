using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Gestionnaire_de_tâche__Last_
{
    internal class Gestion_des_UserControls
    {
        public static List<Sous_Projet> sous_Projets_to_minimize = new List<Sous_Projet>();

        /// <summary>
        /// Load toutes la liste des projets
        /// </summary>
        public static void LoadList(Projet projet_à_séléctionné)
        {
            int temp = Main.panel_projet.VerticalScroll.Value;
            int tempI = Main.panel_info.VerticalScroll.Value;

            // Rend invisible les autres UC
            foreach (Control ctrl in Main.panel_projet.Controls)
            {
                if (ctrl is UserControl_Projet)
                    ctrl.Visible = false;
            }

            if (Main.Utilities.resource.projets.Count != 0)
            {
                int x = 0, y = 0;

                foreach (Projet projet in Main.Utilities.resource.projets)
                {
                    // Si le projet est à séléctionner, on crée le UC avec le paramètre en TRUE

                    if (projet_à_séléctionné != null)
                    {
                        if (projet.Id_du_projet.Equals(projet_à_séléctionné.Id_du_projet))
                        {
                            UserControl_Projet userControl_Projet = new UserControl_Projet(projet, true);
                            userControl_Projet.Location = new Point(x, y);
                            Main.panel_projet.Controls.Add(userControl_Projet);
                            y += userControl_Projet.Height;
                        }
                        else
                        {
                            // Sinon on le crée normal
                            UserControl_Projet userControl_Projet = new UserControl_Projet(projet);
                            userControl_Projet.Location = new Point(x, y);
                            Main.panel_projet.Controls.Add(userControl_Projet);
                            y += userControl_Projet.Height;
                        }
                    }
                    else
                    {
                        // Sinon on le crée normal
                        UserControl_Projet userControl_Projet = new UserControl_Projet(projet);
                        userControl_Projet.Location = new Point(x, y);
                        Main.panel_projet.Controls.Add(userControl_Projet);
                        y += userControl_Projet.Height;
                    }
                }
            }

            // On séléctionne le UC qui va bien
            if (Main.selected_Projet != null)
            {
                foreach (UserControl_Projet ctrl in Main.panel_projet.Controls)
                {
                    if (ctrl.attachedProject.Equals(Main.selected_Projet))
                    {
                        ctrl.UserControl_Projet_MouseDown(new object(), new MouseEventArgs(MouseButtons.Left, 0, 0, 0, 0));
                    }
                }
            }

            // On remet le scroll ou il était
            if (temp != 0)
            {
                Main.panel_projet.VerticalScroll.Value = temp += new UserControl_Projet(null).Height;
            }

            // Et si il n'y à plus de projet, on met le selected projet en null
            if (Main.Utilities.resource.projets.Count == 0)
            {
                Main.selected_Projet = null;
            }

            Main.panel_info.VerticalScroll.Value = tempI;
        }

        /// <summary>
        /// Minimize/Deminiser le sous projet
        /// </summary>
        /// <param name="sous_Projet">Le sous projet à minimiser/deminiser</param>
        /// <param name="rendreVisible">Minimise ou deniminise</param>
        internal static void Minimize(Sous_Projet sous_Projet, bool rendreVisible)
        {
            foreach (Control ctrl in Main.panel_info.Controls)
            {
                if (ctrl is UserControl_Sous_Projet)
                {
                    UserControl_Sous_Projet UC = ctrl as UserControl_Sous_Projet;

                    if (UC.Sous_Projet == sous_Projet && rendreVisible)
                    {
                        UC.image.Image = Gestionnaire_de_tâche__Last_.Properties.Resources.view_down;
                        UC.ShowAllTâche();
                    }
                    else if (UC.Sous_Projet == sous_Projet && !rendreVisible)
                    {
                        UC.image.Image = Gestionnaire_de_tâche__Last_.Properties.Resources.view_more;
                        UC.HideAllTâche();
                    }
                }
            }

            RepositionnerTout();
        }

        public static void ShowOnlyThis(List<string> toShow, string toSearch)
        {
            foreach (Control ctrl in Main.panel_info.Controls)
            {
                if (ctrl is UserControl_Sous_Projet)
                {
                    UserControl_Sous_Projet UC = ctrl as UserControl_Sous_Projet;
                    if (toShow.Contains(UC.Sous_Projet.Nom_du_sous_projet.ToLower() + " " + UC.Sous_Projet.Id_du_sous_projet))
                    {
                        UC.Surbrillance(toSearch);
                    }
                    else
                    {
                        UC.Surbrillance(toSearch, false);
                    }

                    foreach (Control ctrlA in UC.Controls)
                    {
                        if (ctrlA is UserControl_Tâche)
                        {
                            UserControl_Tâche UCA = ctrlA as UserControl_Tâche;
                            for (int i = 0; i < UCA.Tâche.Mots_Clés.Count; i++)
                            {
                                if (toShow.Contains(UCA.Tâche.Mots_Clés[i].ToLower()))
                                {
                                    bool isTag = false;
                                    foreach (var tag in UCA.Tâche.Mots_Clés)
                                    {
                                        if (toShow.Contains(tag))
                                        {
                                            isTag = true;
                                        }
                                    }

                                    if (isTag)
                                        UCA.Surbrillance(true, toSearch);
                                    else
                                        UCA.Surbrillance(false, toSearch);
                                }
                                else
                                {
                                    UCA.Surbrillance(false, toSearch, false);
                                }
                            }

                            if (toShow.Contains(UCA.Tâche.Nom_de_la_tâche.ToLower() + " " + UCA.Tâche.Id_de_la_tâche))
                            {
                                UCA.Surbrillance(false, toSearch, true);
                            }
                            else
                            {
                                UCA.Surbrillance(false, toSearch, false);
                            }
                        }
                    }
                }
            }
        }

        internal static void AddSousProjetInPanel(Sous_Projet sous_Projet)
        {
            int x = 0, y = new UserControl_Projet_Vue(null).Height;

            UserControl_Sous_Projet userControl_Sous_Projet = new UserControl_Sous_Projet(sous_Projet);
            userControl_Sous_Projet.Location = new Point(x, y);

            var prevIndex = 0;

            if (Main.selected_Projet.sous_Projets.Count > 1)
            {
                foreach (Control ctrl in Main.panel_info.Controls)
                {
                    if (ctrl is UserControl_Projet_Vue && ctrl.Visible)
                    {
                        prevIndex = Main.panel_info.Controls.IndexOf(ctrl);
                        prevIndex++;
                    }
                }

                Main.panel_info.Controls.Add(userControl_Sous_Projet);
                Main.panel_info.Controls.SetChildIndex(userControl_Sous_Projet, prevIndex);
            }
            else
            {
                Main.panel_info.Controls.Add(userControl_Sous_Projet);
            }

            RepositionnerTout();
        }

        /// <summary>
        /// Actualise les infos du projet vue
        /// </summary>
        /// <param name="projet"></param>
        internal static void ActualizeProjectVue(Projet projet)
        {
            foreach(var ctrl in Main.panel_info.Controls)
            {
                if(ctrl is UserControl_Projet_Vue)
                {
                    UserControl_Projet_Vue UC = ctrl as UserControl_Projet_Vue;
                    UC.setInformation(projet);
                }
            }
        }

        /// <summary>
        /// Repostionne tous les Usercontrols
        /// </summary>
        /* Utiliser car après avoir minimiser un UC de tâche,
         * on modifie ça taille pour cacher les éléments de tâche.
         * Cela permet de tout réordonner
         * */

        internal static void RepositionnerTout()
        {
            int temp = Main.panel_info.VerticalScroll.Value;
            Main.panel_info.VerticalScroll.Value = 0;

            // Ferme tous les UC pour ne pas avoir d'erreur
            foreach (Control userControl_Sous_Projet in Main.panel_info.Controls)
            {
                if (userControl_Sous_Projet is UserControl_Sous_Projet)
                {
                    foreach (Control userControl_Tâche in userControl_Sous_Projet.Controls)
                    {
                        if (userControl_Tâche is UserControl_Tâche)
                        {
                            UserControl_Tâche userControl_Tâche1 = userControl_Tâche as UserControl_Tâche;
                            userControl_Tâche1.hideUC();
                        }
                    }
                }
            }

            int y = 0;

            foreach (Control ctrl in Main.panel_info.Controls)
            {
                if (!(ctrl is Label) && ctrl.Visible == true)
                {
                    if (ctrl is UserControl_Sous_Projet)
                    {
                        y += 20;
                    }

                    ctrl.Location = new Point(ctrl.Location.X, y);
                    y += ctrl.Height;
                }
            }

            Main.panel_info.PerformLayout();
            Main.panel_info.VerticalScroll.Value = (temp);        
        }

        internal static void AddTâcheIn(Sous_Projet sous_Projet, Tâche tâche)
        {
            foreach (Control ctrl in Main.panel_info.Controls)
            {
                if (ctrl is UserControl_Sous_Projet)
                {
                    UserControl_Sous_Projet UC = ctrl as UserControl_Sous_Projet;
                    if (UC.Sous_Projet == sous_Projet)
                    {
                        UC.AddTache(tâche);
                    }
                }
            }
        }

        internal static void ActualizeNbOfSousProjetAndTache()
        {
            foreach (Control ctrl in Main.panel_info.Controls)
            {
                if (ctrl is UserControl_Projet_Vue)
                {
                    UserControl_Projet_Vue UC = ctrl as UserControl_Projet_Vue;
                    UC.actualizeNbOfSousPAndTache();
                }
            }

            foreach (Control ctrl in Main.panel_info.Controls)
            {
                if (ctrl is UserControl_Sous_Projet)
                {
                    foreach (Control ctrl1 in ctrl.Controls)
                    {
                        if (ctrl1 is UserControl_Tâche)
                        {
                            foreach (Control ctrl2 in ctrl1.Controls)
                            {
                                if (ctrl2 is UserControl_state)
                                {
                                    Main.panel_info.Controls.Remove(ctrl2);
                                }
                                else if (ctrl2 is UserControls_Prioritécs)
                                {
                                    Main.panel_info.Controls.Remove(ctrl2);
                                }
                            }
                        }
                    }
                }
            }
        }

        internal static void UpdateInformationOf(Sous_Projet sous_Projet_nouveau, Sous_Projet ancienSousProjet)
        {
            foreach (Control ctrl in Main.panel_info.Controls)
            {
                if (ctrl is UserControl_Sous_Projet)
                {
                    UserControl_Sous_Projet UC = ctrl as UserControl_Sous_Projet;
                    if (UC.Sous_Projet == ancienSousProjet)
                    {
                        UC.UpdateInformation(sous_Projet_nouveau);
                    }
                }
            }
        }

        internal static void HideSousProjet(Sous_Projet sous_Projet)
        {
            foreach (Control ctrl in Main.panel_info.Controls)
            {
                if (ctrl is UserControl_Sous_Projet)
                {
                    UserControl_Sous_Projet UC = ctrl as UserControl_Sous_Projet;
                    if (UC.Sous_Projet == sous_Projet)
                    {
                        Main.panel_info.Controls.Remove(UC);
                    }
                }
            }

            RepositionnerTout();
        }

        internal static void LoadOnlyProjectVue(Projet selected_Projet)
        {
            int x = 0, y = 0;

            // Le UC du projet en vue
            UserControl_Projet_Vue userControl_Projet_Vue = new UserControl_Projet_Vue(selected_Projet);
            userControl_Projet_Vue.Location = new Point(x, y);
            Main.panel_info.Controls.Add(userControl_Projet_Vue);
            y += userControl_Projet_Vue.Height + 20;
        }

        /// <summary>
        /// Affiche le projet en vue et le sous projet dans le panel information avec tous ces sous projets
        /// </summary>
        /// <param name="projet">Projet à afficher avec ces sous projets</param>
        internal static void LoadAllSousProjetFor(Projet projet)
        {
            Main main = (Main)Application.OpenForms["Main"];
            List<Control> toShow = new List<Control>();
            List<Control> toHide = new List<Control>();

            foreach (Control ctrl in Main.panel_info.Controls)
            {
                if (!(ctrl is Label))
                {
                    toHide.Add(ctrl);
                }
            }

            foreach (Control ctrl in toHide)
            {
                Main.panel_info.Controls.Remove(ctrl);
            }

            int x = 0, y = 0;

            // Le UC du projet en vue
            UserControl_Projet_Vue userControl_Projet_Vue = new UserControl_Projet_Vue(projet);
            userControl_Projet_Vue.Location = new Point(x, y);
            toShow.Add(userControl_Projet_Vue);
            userControl_Projet_Vue.Visible = false;
            Main.panel_info.Controls.Add(userControl_Projet_Vue);
            y += userControl_Projet_Vue.Height + 20;

            foreach (Sous_Projet sous_Projet in projet.sous_Projets)
            {
                // Et tous c'est sous projet
                UserControl_Sous_Projet userControl_Sous_Projet = new UserControl_Sous_Projet(sous_Projet, projet);
                userControl_Sous_Projet.Location = new Point(x, y);
                toShow.Add(userControl_Sous_Projet);
                userControl_Sous_Projet.Visible = false;
                Main.panel_info.Controls.Add(userControl_Sous_Projet);
                y += userControl_Sous_Projet.Height + 10;

                y += 10;
            }

            foreach (Control ctrl in toShow)
            {
                ctrl.Visible = true;
            }
        }

        internal static void RepositionnerToutAPartirDe(UserControl_Sous_Projet userControl_Sous_Projet)
        {
            bool repositionner = false;
            Point location = new Point();

            foreach(Control ctrl in Main.panel_info.Controls)
            {
                if (!(ctrl is Label || ctrl is UserControl_state || ctrl is UserControls_Prioritécs) && ctrl.Visible)
                {
                    if (ctrl == userControl_Sous_Projet)
                    {
                        repositionner = true;

                        location = ctrl.Location;
                        location.Y += ctrl.Height;
                    }

                    if (repositionner && ctrl != userControl_Sous_Projet)
                    {
                        ctrl.Location = location;
                        location.Y += ctrl.Height;
                    }

                    if(ctrl is UserControl_Sous_Projet)
                    {
                        location.Y += 20;
                    }
                }
            }
        }

        internal static void HideSpecificTache(Sous_Projet sous_Projet, Tâche tâche)
        {
            foreach (var ctrl in Main.panel_info.Controls)
            {
                if (ctrl is UserControl_Sous_Projet)
                {
                    UserControl_Sous_Projet UC = ctrl as UserControl_Sous_Projet;
                    if (UC.Sous_Projet == sous_Projet)
                    {
                        UC.HideOnlyOneTache(tâche);
                    }
                }
            }
        }
    }
}