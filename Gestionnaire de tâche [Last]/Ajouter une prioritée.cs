using System;
using System.Windows.Forms;

namespace Gestionnaire_de_tâche__Last_
{
    public partial class Ajouter_une_prioritée : Form
    {
        private Priorité Etat;
        public UserControl_Tâche UserControl_Tâche { get; }

        public Ajouter_une_prioritée(UserControl_Tâche userControl_Tâche = null, Priorité priorité = null)
        {
            InitializeComponent();
            UserControl_Tâche = userControl_Tâche;
            Etat = priorité;

            Icon = Gestionnaire_de_tâche__Last_.Properties.Resources.icon_add;

            if (Etat != null)
            {
                panel_color.BackColor = Etat.Couleur_de_l_etat;
                Textbox_name.Text = Etat.Texte_de_l_etat;
            }
        }

        private void Ajouter_une_prioritée_Load(object sender, EventArgs e)
        {
        }

        private void button_add_MouseDown(object sender, MouseEventArgs e)
        {
            if (!(String.IsNullOrEmpty(Textbox_name.Text) || Textbox_name.Text.Equals("Nom de la prioritée")))
            {
                bool isDuplicate = false;

                foreach (var priorité1 in Main.Utilities.resource.priorités)
                {
                    if (priorité1.Texte_de_l_etat.Equals(Textbox_name.Text))
                    {
                        isDuplicate = true;
                    }
                }

                if (UserControl_Tâche != null)
                {
                    if (!isDuplicate)
                    {
                        Priorité priorité = new Priorité(panel_color.BackColor, Textbox_name.Text);

                        if (Etat == null)
                        {
                            Main.Utilities.resource.priorités.Add(priorité);
                            UserControl_Tâche.setPriorité(priorité);

                            Close();
                        }
                        else
                        {
                            int index = Main.Utilities.resource.priorités.IndexOf(Etat);
                            Main.Utilities.resource.priorités[index] = priorité;

                            UserControl_Tâche.setStateIfIsDefinied_Priorité(priorité, Etat);
                            Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Une prioritée portant le nom de " + Textbox_name.Text + " existe déjà !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    Priorité priorité = new Priorité(panel_color.BackColor, Textbox_name.Text);

                    Main.Utilities.resource.priorités.Add(priorité);
                    Close();
                }
            }
            else
            {
                MessageBox.Show("Vous devez renseigner un nom !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ColorPicker_color_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                panel_color.BackColor = ColorPicker_color.SelectedColor;
            }
        }

        private void Textbox_name_Enter(object sender, EventArgs e)
        {
            if (Textbox_name.Text.Equals("Nom de la prioritée"))
            {
                Textbox_name.Text = string.Empty;
            }
        }
    }
}