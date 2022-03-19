using System;
using System.Collections.Generic;
using System.Drawing;

namespace Gestionnaire_de_tâche__Last_
{
    [Serializable()]
    public class Message
    {
        public Message(string objet, string corps, List<string> images, DateTime date_De_Publication, string etat_texte, Color etat_couleur)
        {
            Objet = objet;
            Corps = corps;
            Images = images;
            Date_De_Publication = date_De_Publication;
            Etat_texte = etat_texte;
            Etat_couleur = etat_couleur;
        }

        public string Objet { get; set; }
        public string Corps { get; set; }

        public List<string> Images { get; }

        public string Etat_texte { get; set; }
        public Color Etat_couleur { get; set; }

        public DateTime Date_De_Publication { get; set; }
        public DateTime? Date_De_Modification { get; set; }
    }
}