using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestionnaire_de_tâche__Last_
{
    public partial class Paramètres : Form
    {
        bool alreadyDoBackup = false;

        public Paramètres()
        {
            InitializeComponent();

            dataGridView_backup.ScrollBars = ScrollBars.Vertical;

            this.Icon = Properties.Resources.icons_settings;

            textBox_dataPath.Text = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\Zonedetec\Gestionnaire de tâche [Last]";

            this.ActiveControl = label1;

            addBackupInBoard();

            numericUpDown_backupTime.Value = Main.Utilities.resource.BackupInterval;

            checkBox_verifyMaj.Checked = Properties.Settings.Default.checkMaj;

            string actualVersion = Application.ProductVersion;
            actualVersion = actualVersion.Remove(2, 1);
            actualVersion = actualVersion.Remove(2, 1);

            label_actualV.Text = actualVersion;
        }

        /// <summary>
        /// Ajoute les backups dans le tableau
        /// </summary>
        private void addBackupInBoard()
        {
            dataGridView_backup.Rows.Clear();

            System.IO.DirectoryInfo di = new DirectoryInfo(Utilities.backupPath);
            foreach (FileInfo file in di.GetFiles())
            {
                string[] sizes = { "B", "KB", "MB", "GB", "TB" };
                double len = file.Length;
                int order = 0;
                while (len >= 1024 && order < sizes.Length - 1)
                {
                    order++;
                    len = len / 1024;
                }


                string result = String.Format("{0:0.##} {1}", len, sizes[order]);

                dataGridView_backup.Rows.Insert(0, file.CreationTime.ToString("dd/MM/yyyy HH:mm:ss"), file.FullName, result, "Charger");
            }
        }

        private void Paramètres_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Ouvre l'explorateur de fichier vers le path des resources
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_showPathInExplorer_MouseDown(object sender, EventArgs e)
        {
            Process.Start(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\Zonedetec\Gestionnaire de tâche [Last]");
        } 

        /// <summary>
        /// Supprime toutes les donées de l'application et la redémarre
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_deleteDonnees_MouseDown(object sender, EventArgs e)
        {
            DialogResult dialogResult = 
            MessageBox.Show("Voulez-vous vraiment supprimer toutes les données de l'application ? \nLes backups seront conservées. \nCette action est irréversible.", "Avertissement !", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(dialogResult == DialogResult.Yes)
            {
                Log.Mess("Suppression de toutes les données");

                File.WriteAllText(Utilities.resourcesPath, string.Empty);

                System.IO.DirectoryInfo di = new DirectoryInfo(Utilities.imagesPath);
                foreach (FileInfo file in di.GetFiles())
                {
                    file.Delete();
                }
                foreach (DirectoryInfo dir in di.GetDirectories())
                {
                    dir.Delete(true);
                }

                Process.Start(Application.ExecutablePath);
                Utilities.saveWhenExit = false; ;
                Application.Exit();
            }
        }

        private void dataGridView_backup_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Log.Mess("Chargement d'unee backup");

            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                if (!alreadyDoBackup)
                {
                    DialogResult dialogResult =
                    MessageBox.Show("Voulez-vous faire une backup des données actuelles avant d'en charger une autre ?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (dialogResult == DialogResult.Yes)
                    {
                        Btn_saveData_MouseDown(this, null);
                    }
                }

                int selectedrowindex = dataGridView_backup.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView_backup.Rows[selectedrowindex];
                string a = Convert.ToString(selectedRow.Cells["Répértoire"].Value); 

                File.WriteAllText(Utilities.resourcesPath, EncryptionHelper.Decrypt(File.ReadAllText(a)));

                Properties.Settings.Default.ShowProjectVu = true;
                Properties.Settings.Default.Save();

                Process.Start(Application.ExecutablePath);
                Utilities.saveWhenExit = false;
                Application.Exit();
            }
        }

        /// <summary>
        /// Crée une backup de maintenant
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void Btn_saveData_MouseDown(object sender, EventArgs e)
        {
            Log.Mess("Ajoute une backup");

            Main.Utilities.SaveResources();

            string filePath = Utilities.backupPath + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss:mm").Replace('/', '.').Replace(':','.') + ".backDat";

            File.Create(filePath).Close();
            File.WriteAllText(filePath, EncryptionHelper.Encrypt(File.ReadAllText(Utilities.resourcesPath)));

            addBackupInBoard();

            alreadyDoBackup = true;
        }

        /// <summary>
        /// Supprime la backup séléctionné
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_delete_MouseDown(object sender, EventArgs e)
        {
            Log.Mess("Suppression d'une backup");

            try
            {
                File.Delete(dataGridView_backup.CurrentRow.Cells[1].Value.ToString());

                Int32 selectedRowCount = dataGridView_backup.Rows.GetRowCount(DataGridViewElementStates.Selected);
                if (selectedRowCount > 0)
                {
                    for (int i = 0; i < selectedRowCount; i++)
                    {
                        dataGridView_backup.Rows.RemoveAt(dataGridView_backup.SelectedRows[0].Index);
                    }
                }
            }
            catch(Exception ex)
            {
                Log.Mess("Erreur lors de la suppression d'une backup " + ex);
            }
        }

        private void dataGridView_backup_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                Log.Mess("Suppression d'une backup par raccourcis clavier");

                try
                {
                    File.Delete(dataGridView_backup.CurrentRow.Cells[1].Value.ToString());

                    Int32 selectedRowCount = dataGridView_backup.Rows.GetRowCount(DataGridViewElementStates.Selected);
                    if (selectedRowCount > 0)
                    {
                        for (int i = 0; i < selectedRowCount; i++)
                        {
                            dataGridView_backup.Rows.RemoveAt(dataGridView_backup.SelectedRows[0].Index);
                        }
                    }
                }
                catch(Exception ex)
                {
                    Log.Mess("Erreur lors de la suppression d'une backup " + ex);
                }
            }
            else if(e.KeyCode == Keys.Add)
            {
                Btn_saveData_MouseDown(this, null);
            }
        }

        /// <summary>
        /// Set l'intervelle des sauvegardes 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void numericUpDown_backupTime_ValueChanged(object sender, EventArgs e)
        {
            Main.Utilities.resource.BackupInterval = Convert.ToInt32(numericUpDown_backupTime.Value);
        }

        private void Paramètres_Shown(object sender, EventArgs e)
        {
            if (!Properties.Settings.Default.checkMaj)
            {
                this.PerformLayout();

                // MISE A JOUR
                if (Main.Utilities.MajDispo())
                {
                    Télécharger_mise_à_jour télécharger_Mise_À_Jour = new Télécharger_mise_à_jour();
                    télécharger_Mise_À_Jour.ShowDialog();
                }
            }
        }

        /// <summary>
        /// Paramètre permettant de checker les mises à jour ou non à chaque lancement
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkBox_verifyMaj_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.checkMaj = checkBox_verifyMaj.Checked;
            Properties.Settings.Default.Save();
        }
    }
}
