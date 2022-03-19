using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestionnaire_de_tâche__Last_
{
    public partial class FirstLaunch : Form
    {
        public FirstLaunch()
        {
            InitializeComponent();

            this.Icon = Gestionnaire_de_tâche__Last_.Properties.Resources.Main_Icon;
        }

        private void FirstLaunch_Load(object sender, EventArgs e)
        {

        }

        private void Btn_no_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Importation du logiciel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_yes_Click(object sender, EventArgs e)
        {
            try
            {
                WebClient client = new WebClient();
                string reply = client.DownloadString("https://pastebin.com/raw/eKygDAak");

                string json = EncryptionHelper.Decrypt(reply);
                Projet projet_importé = JsonConvert.DeserializeObject<Projet>(json);

                Trie_du_projet_importé trie_window = new Trie_du_projet_importé(new List<Projet> { projet_importé });
                trie_window.ShowDialog();

                this.Close();
            }
            catch
            {
                MessageBox.Show("Excusez nous, il semblerait y avoir une erreur avec le téléchargement du projet. Vérifier votre connexion internet et réessayer !",
                    "Une erreur est survenue", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
