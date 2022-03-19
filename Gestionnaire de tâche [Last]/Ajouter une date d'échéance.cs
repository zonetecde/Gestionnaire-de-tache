using System;
using System.Windows.Forms;

namespace Gestionnaire_de_tâche__Last_
{
    public partial class Ajouter_une_date_d_échéance : Form
    {
        /// <summary>
        /// Load la tâche à laquel on va appliquer la date d'échéance
        /// </summary>
        /// <param name="tache"></param>
        public Ajouter_une_date_d_échéance(Tâche tache, UserControl_Tâche userControl_Tâche)
        {
            InitializeComponent();

            this.Icon = Gestionnaire_de_tâche__Last_.Properties.Resources.icon_add;
            Tache = tache;
            UserControl_Tâche = userControl_Tâche;
            label_tâche.Text = "Ajouter une date d'échéance pour " + tache.Nom_de_la_tâche;

            if (Tache.Date_d_echeance != null)
            {
                Datepicker_date.Value = Tache.Date_d_echeance.Value;
            }
            else
            {
                Datepicker_date.Value = DateTime.Now;
            }
        }

        public Tâche Tache { get; }
        public UserControl_Tâche UserControl_Tâche { get; }

        private void Ajouter_une_date_d_échéance_Load(object sender, EventArgs e)
        {
        }

        private void button_done_MouseDown(object sender, MouseEventArgs e)
        {
            DateTime? date = Datepicker_date.Value;

            Tache.Date_d_echeance = date;

            UserControl_Tâche.UpdateTâche(Tache);

            this.Close();
        }

        private void button_removeDate_MouseDown(object sender, MouseEventArgs e)
        {
            DateTime? date = null;

            Tache.Date_d_echeance = date;

            UserControl_Tâche.UpdateTâche(Tache);

            this.Close();
        }
    }
}