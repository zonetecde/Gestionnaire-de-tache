using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Gestionnaire_de_tâche__Last_
{
    public partial class Statistique_nombre : Form
    {
        internal bool onlyMoreThan0 = false;

        public Statistique_nombre()
        {
            InitializeComponent();

            this.Icon = Gestionnaire_de_tâche__Last_.Properties.Resources.icon_stat;
        }

        private void Statistique_nombre_Load(object sender, EventArgs e)
        {
            int x = 0, y = 0;
            foreach (var etat in Main.Utilities.resource.etats)
            {
                x = addEtatInPanel(x, y, etat);
            }

        }

        private int addEtatInPanel(int x, int y, Etat etat)
        {
            UserControl_Statistic_etat_chiffre UC = new UserControl_Statistic_etat_chiffre(etat, Main.selected_Projet, this);
            UC.Location = new Point(x, y);
            panel_state.Controls.Add(UC);
            x += UC.Width;
            return x;
        }

        internal void SetAllComboBoxFor(int selectedIndex)
        {
            if (!checkBox_onlyMoreThan0.Checked || selectedIndex == 0)
            {
                foreach (Control ctrl in panel_state.Controls)
                {
                    if (ctrl is UserControl_Statistic_etat_chiffre)
                    {
                        UserControl_Statistic_etat_chiffre UC = ctrl as UserControl_Statistic_etat_chiffre;
                        UC.SetSelectedIndex(selectedIndex);
                    }
                }
            }
        }

        private void Switch__OnValueChange(object sender, EventArgs e)
        {
            panel_state.Controls.Clear();
            panel_state.HorizontalScroll.Value = 0;
            panel_state.PerformLayout();

            // Si Etat
            if (Switch_.Value)
            {
                int x = 0, y = 0;
                foreach (var etat in Main.Utilities.resource.etats)
                {
                    x = addEtatInPanel(x, y, etat);
                }
            }
            else
            {
                int xa = 0, ya = 0;
                foreach (var prio in Main.Utilities.resource.priorités)
                {
                    xa = addPrioInPanel(xa, ya, prio);

                }
            }

            panel_state.HorizontalScroll.Value = 0;
            panel_state.PerformLayout();

            if(checkBox_onlyMoreThan0.Checked)
                checkBox_onlyMoreThan0_CheckedChanged(this, null);
        }

        internal void SetAllComboBoxForPriority(int selectedIndex)
        {
            foreach (Control ctrl in panel_state.Controls)
            {
                if (ctrl is UserControl_Statistic_priorité_chiffre)
                {
                    UserControl_Statistic_priorité_chiffre UC = ctrl as UserControl_Statistic_priorité_chiffre;
                    UC.SetSelectedIndex(selectedIndex);
                }
            }
        }

        /// <summary>
        /// Affiche uniquement les prio/état utilisées
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkBox_onlyMoreThan0_CheckedChanged(object sender, EventArgs e)
        {
            onlyMoreThan0 = checkBox_onlyMoreThan0.Checked;

            if (checkBox_onlyMoreThan0.Checked)
            {
                SetAllComboBoxFor(0);
                SetAllComboBoxForPriority(0);

                List<Control> toAdd = new List<Control>();
                foreach (Control ctrl in panel_state.Controls)
                {
                    if (ctrl is UserControl_Statistic_etat_chiffre)
                    {
                        UserControl_Statistic_etat_chiffre ct = ctrl as UserControl_Statistic_etat_chiffre;
                        if (ct.nbDeFoisUtilisées != 0)
                        {
                            toAdd.Add(ctrl);
                        }
                    }
                    else if(ctrl is UserControl_Statistic_priorité_chiffre)
                    {
                        UserControl_Statistic_priorité_chiffre ct = ctrl as UserControl_Statistic_priorité_chiffre;
                        if (ct.nbDeFoisUtilisées != 0)
                        {
                            toAdd.Add(ctrl);
                        }
                    }
                }

                panel_state.Controls.Clear();
                foreach (var item in toAdd)
                {
                    panel_state.Controls.Add(item);
                }

                // Re-set la location
                int x = 0, y = 0;
                foreach(Control ctrl in panel_state.Controls)
                {
                    ctrl.Location = new Point(x, y);
                    x += ctrl.Width;
                }
            }
            else
            {
                panel_state.Controls.Clear();

                if (Switch_.Value)
                {
                    int x = 0, y = 0;
                    foreach (var etat in Main.Utilities.resource.etats)
                    {
                        x = addEtatInPanel(x, y, etat);
                    }
                }
                else
                {
                    int xa = 0, ya = 0;
                    foreach (var prio in Main.Utilities.resource.priorités)
                    {
                        xa = addPrioInPanel(xa, ya, prio);
                    }
                }

                panel_state.HorizontalScroll.Value = 0;
                panel_state.PerformLayout();
            }
        }

        private int addPrioInPanel(int xa, int ya, Priorité prio)
        {
            UserControl_Statistic_priorité_chiffre UC = new UserControl_Statistic_priorité_chiffre(prio, Main.selected_Projet, this);
            UC.Visible = true;
            UC.Location = new Point(xa, ya);
            panel_state.Controls.Add(UC);
            xa += UC.Width;
            return xa;
        }
    }
}