using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Gestionnaire_de_tâche__Last_
{
    public partial class Image_view : Form
    {
        private int actualIndex = 0;
        private int maxPage = 0;

        public Image_view(Message message, int index)
        {
            InitializeComponent();
            Message = message;
            actualIndex = index;
            pictureBox_img.Image = LoadBitmap(message.Images[index]);

            maxPage = message.Images.Count;
        }

        public Message Message { get; }

        private void pictureBox2_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                if (actualIndex < maxPage)
                {
                    actualIndex++;
                    pictureBox_img.Image = Image.FromFile(Message.Images[actualIndex]);
                }
            }
            catch
            {
                actualIndex--;
            }
        }

        public Bitmap LoadBitmap(string path)
        {
            if (File.Exists(path))
            {
                // open file in read only mode
                using (FileStream stream = new FileStream(path, FileMode.Open, FileAccess.Read))
                // get a binary reader for the file stream
                using (BinaryReader reader = new BinaryReader(stream))
                {
                    // copy the content of the file into a memory stream
                    var memoryStream = new MemoryStream(reader.ReadBytes((int)stream.Length));
                    // make a new Bitmap object the owner of the MemoryStream
                    return new Bitmap(memoryStream);
                }
            }
            else
            {
                MessageBox.Show("Erreur lors du chargement des images.", "Erreur !", MessageBoxButtons.OK);
                return null;
            }
        }

        private void pictureBox_left_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                if (maxPage >= actualIndex)
                {
                    actualIndex--;
                    pictureBox_img.Image = Image.FromFile(Message.Images[actualIndex]);
                }
            }
            catch
            {
                actualIndex++;
            }
        }

        private void Image_view_Load(object sender, System.EventArgs e)
        {
        }
    }
}