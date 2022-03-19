using System;
using System.Collections.Generic;
using System.Drawing;

namespace Gestionnaire_de_tâche__Last_
{
    [Serializable()]
    public class Tâche
    {
        public Tâche(string nom_de_la_tâche, string description_de_la_tâche, Color couleur_de_la_tâche, int id_de_la_tâche, List<string> parentInformation)
        {
            Nom_de_la_tâche = nom_de_la_tâche;
            Détail_de_la_tâche = description_de_la_tâche;
            Couleur_de_la_tâche = couleur_de_la_tâche;
            Id_de_la_tâche = id_de_la_tâche;

            Mots_Clés = new List<string>();
            Messages = new List<Message>();

            Date_d_echeance = null;
            Priorité_de_la_tâche = 0;
            State_de_la_tâche = 0;
            Progression = 0;
            Texte = string.Empty;
            ParentInformation = parentInformation;
        }

        public Tâche()
        {
        }

        public string Nom_de_la_tâche { get; set; }
        public string Détail_de_la_tâche { get; set; }

        public Color Couleur_de_la_tâche { get; set; }

        public List<string> ParentInformation { get; set; }
        public int Id_de_la_tâche { get; set; }

        // Paramètre de la tâche personnalisable
        public DateTime? Date_d_echeance { get; set; }

        public List<string> Mots_Clés { get; set; }
        public int State_de_la_tâche { get; set; }
        public int Priorité_de_la_tâche { get; set; }
        public List<Message> Messages { get; set; }
        public int Progression { get; set; }
        public string Texte { get; set; }
    }
}