using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Gestionnaire_de_tâche__Last_
{
    public partial class Trie_du_projet_importé : Form
    {
        public List<Projet> Projets_importes { get; }
        public bool BlockCancelButton { get; }

        public Trie_du_projet_importé(List<Projet> projets_importes, bool blockCancelButton = false)
        {
            InitializeComponent();

            if(projets_importes != null)
            {
                for (int z = 0; z < projets_importes.Count; z++)
                {
                    listView_projet_checkbox.Nodes.Add(projets_importes[z].Nom_du_projet);
                    treeView_data.Nodes.Add(projets_importes[z].Id_du_projet.ToString());

                    for (int i = 0; i < projets_importes[z].sous_Projets.Count; i++)
                    {
                        listView_projet_checkbox.Nodes[z].Nodes.Add(projets_importes[z].sous_Projets[i].Nom_du_sous_projet);
                        treeView_data.Nodes[z].Nodes.Add(projets_importes[z].sous_Projets[i].Id_du_sous_projet.ToString());

                        foreach (Tâche item in projets_importes[z].sous_Projets[i].Tâches)
                        {
                            listView_projet_checkbox.Nodes[z].Nodes[i].Nodes.Add(item.Nom_de_la_tâche);
                            treeView_data.Nodes[z].Nodes[i].Nodes.Add(item.Id_de_la_tâche.ToString());
                        }
                    }
                }
            }

            if(blockCancelButton)
            {
                button_cancel.Enabled = false;
            }

            listView_projet_checkbox.ExpandAll();
            Projets_importes = projets_importes;
            BlockCancelButton = blockCancelButton;
        }

        private void Trie_du_projet_importé_Load(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// Importe le projet
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_import_Click(object sender, EventArgs e)
        {
            if (!BlockCancelButton)
            {
                Random rdn = new Random();

                foreach (Projet projet in Projets_importes)
                {
                    int Id = rdn.Next(0, 2147483647);
                    projet.Id_du_projet = Id;

                    Main.Utilities.resource.projets.Insert(0, projet);
                }

                Gestion_des_UserControls.LoadList(Main.selected_Projet);
            }

            this.Close();
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}