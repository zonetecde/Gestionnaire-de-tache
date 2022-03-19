using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Net;
using System.Windows.Forms;

namespace Gestionnaire_de_tâche__Last_
{
    public partial class Télécharger_mise_à_jour : Form
    {
        public Télécharger_mise_à_jour()
        {
            InitializeComponent();
        }

        private void button_annuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_download_MouseDown(object sender, MouseEventArgs e)
        {
            button_annuler.Enabled = false;
            button_download.Enabled = false;

            string file = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\Zonedetec\Gestionnaire de tâche [Last]\autoUpdater.msi";

            try
            {
                DownloadFile(Main.Utilities.linkUpdate, file);
            }
            catch
            {
                MessageBox.Show("Vérifier votre connexion internet !", "Erreur !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private WebClient webClient;
        private Stopwatch sw = new Stopwatch();

        public void DownloadFile(string urlAddress, string location)
        {
            using (webClient = new WebClient())
            {
                webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(Completed);
                webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(ProgressChanged);

                // The variable that will be holding the url address (making sure it starts with http://)
                Uri URL = urlAddress.StartsWith("https://", StringComparison.OrdinalIgnoreCase) ? new Uri(urlAddress) : new Uri("https://" + urlAddress);

                // Start the stopwatch which we will be using to calculate the download speed
                sw.Start();

                try
                {
                    // Start downloading the file
                    webClient.DownloadFileAsync(URL, location);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        // The event that will fire whenever the progress of the WebClient is changed
        private void ProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            // Calculate download speed and output it to labelSpeed.
            labelSpeed.Text = string.Format("{0} kb/s", (e.BytesReceived / 1024d / sw.Elapsed.TotalSeconds).ToString("0.00"));

            // Update the progressbar percentage only when the value is not the same.
            progressBar.Value = e.ProgressPercentage;

            // Show the percentage on our label.
            labelPerc.Text = e.ProgressPercentage.ToString() + "%";

            // Update the label with how much data have been downloaded so far and the total size of the file we are currently downloading
            labelDownloaded.Text = string.Format("{0} MB's / {1} MB's",
                (e.BytesReceived / 1024d / 1024d).ToString("0.00"),
                (e.TotalBytesToReceive / 1024d / 1024d).ToString("0.00"));
        }

        // The event that will trigger when the WebClient is completed
        private void Completed(object sender, AsyncCompletedEventArgs e)
        {
            // Reset the stopwatch.
            sw.Reset();

            if (e.Cancelled == true)
            {
                MessageBox.Show("Annuler.");
            }
            else
            {
                // Quand le download se finit
                Process.Start(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\Zonedetec\Gestionnaire de tâche [Last]\autoUpdater.msi");
                Application.Exit();
            }
        }

        private void Télécharger_mise_à_jour_Load(object sender, EventArgs e)
        {
        }
    }
}