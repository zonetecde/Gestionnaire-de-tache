using System;
using System.Collections.Generic;
using System.Drawing;

namespace Gestionnaire_de_tâche__Last_
{
    [Serializable()]
    public class Sous_Projet
    {
        public Sous_Projet(string nom_du_sous_projet, string description_du_sous_projet, int id_du_sous_projet, Projet projet_attacher, DateTime? date_de_fin, Color couleur_du_sous_projet)
        {
            Nom_du_sous_projet = nom_du_sous_projet;
            Description_du_sous_projet = description_du_sous_projet;
            Id_du_sous_projet = id_du_sous_projet;
            Date_de_fin = date_de_fin;
            Couleur_du_sous_projet = couleur_du_sous_projet;

            Tâches = new List<Tâche>();
        }

        public Sous_Projet()
        {
        }

        public string Nom_du_sous_projet { get; set; }
        public string Description_du_sous_projet { get; set; }

        public Color Couleur_du_sous_projet { get; set; }

        public int Id_du_sous_projet { get; set; }

        public DateTime? Date_de_fin { get; set; }

        public List<Tâche> Tâches { get; set; }
    }
}