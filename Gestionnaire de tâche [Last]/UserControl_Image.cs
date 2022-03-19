using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Gestionnaire_de_tâche__Last_
{
    public partial class UserControl_Image : UserControl
    {
        public string ImgPath { get; }
        public int I { get; }
        public Message Message { get; }

        public UserControl_Image(string imgPath, int i, Message message)
        {
            InitializeComponent();

            try
            {
                pictureBox_img.Image = LoadBitmap(imgPath);
                ImgPath = imgPath;
                I = i;
                Message = message;

                image_View = new Image_view(Message, I);
            }
            catch
            {

            }
        }

        private Image_view image_View;

        private void pictureBox_img_DoubleClick_1(object sender, EventArgs e)
        {
            image_View.Show();
        }

        internal void SetImageNoNull()
        {
            pictureBox_img.Image = null;
        }

        public Bitmap LoadBitmap(string path)
        {
            if (File.Exists(path))
            {
                // open file in read only mode
                using (FileStream stream = new FileStream(path, FileMode.Open, FileAccess.Read))
                {
                    // get a binary reader for the file stream
                    using (BinaryReader reader = new BinaryReader(stream))
                    {
                        // copy the content of the file into a memory stream
                        var memoryStream = new MemoryStream(reader.ReadBytes((int)stream.Length));
                        // make a new Bitmap object the owner of the MemoryStream
                        stream.Close();

                        return new Bitmap(memoryStream);
                    }
                }
            }
            else
            {
                MessageBox.Show("Erreur lors du chargement des images.", "Erreur !", MessageBoxButtons.OK);
                return null;
            }
        }

        internal void CloseViewWindow()
        {
            image_View.Close();
        }
    }
}