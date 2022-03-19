using System;
using System.Windows.Forms;

namespace Gestionnaire_de_tâche__Last_
{
    public partial class Ajouter_un_état : Form
    {
        public UserControl_Tâche UserControl_Tâche { get; }
        public Etat Etat { get; }

        public Ajouter_un_état(UserControl_Tâche userControl_Tâche = null, Etat etat = null)
        {
            InitializeComponent();
            UserControl_Tâche = userControl_Tâche;
            Etat = etat;
            Icon = Gestionnaire_de_tâche__Last_.Properties.Resources.icon_add;

            if (etat != null)
            {
                panel_color.BackColor = etat.Couleur_de_l_etat;
                Textbox_name.Text = etat.Texte_de_l_etat;
            }
        }

        private void button_add_MouseDown(object sender, MouseEventArgs e)
        {
            if (!(String.IsNullOrEmpty(Textbox_name.Text) || Textbox_name.Text.Equals("Nom de l'état")))
            {
                bool isDuplicate = false;

                foreach (var etatA in Main.Utilities.resource.etats)
                {
                    if (etatA.Texte_de_l_etat.Equals(Textbox_name.Text))
                    {
                        isDuplicate = true;
                    }
                }

                if (UserControl_Tâche != null)
                {
                    if (!isDuplicate)
                    {
                        Etat etat = new Etat(panel_color.BackColor, Textbox_name.Text);
                        if (Etat == null)
                        {
                            Main.Utilities.resource.etats.Add(etat);
                            UserControl_Tâche.setState(etat);

                            Close();
                        }
                        else
                        {
                            int index = Main.Utilities.resource.etats.IndexOf(Etat);
                            Main.Utilities.resource.etats[index] = etat;

                            UserControl_Tâche.setStateIfIsDefinied(etat, Etat);
                            Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Un état portant le nom de " + Textbox_name.Text + " existe déjà !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    Etat etat = new Etat(panel_color.BackColor, Textbox_name.Text);
                    Main.Utilities.resource.etats.Add(etat);
                    Close();
                }
            }
            else
            {
                MessageBox.Show("Vous devez renseigner un nom !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void xuiColorPicker1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                panel_color.BackColor = ColorPicker_color.SelectedColor;
            }
        }

        private void xuiColorPane_color_MouseDown(object sender, MouseEventArgs e)
        {
        }

        private void Ajouter_un_état_Load(object sender, EventArgs e)
        {
        }

        private void Textbox_name_Enter(object sender, EventArgs e)
        {
            if (Textbox_name.Text.Equals("Nom de l'état"))
            {
                Textbox_name.Text = string.Empty;
            }
        }
    }
}