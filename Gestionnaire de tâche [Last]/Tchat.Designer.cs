namespace Gestionnaire_de_tâche__Last_
{
    partial class Tchat
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label_titre = new System.Windows.Forms.Label();
            this.panel_nouveauMessage = new System.Windows.Forms.Panel();
            this.Button_add = new Bunifu.Framework.UI.BunifuImageButton();
            this.comboBox_images = new System.Windows.Forms.ComboBox();
            this.pictureBox_delete = new System.Windows.Forms.PictureBox();
            this.button_addImg = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox_color = new System.Windows.Forms.PictureBox();
            this.pictureBox_underline = new System.Windows.Forms.PictureBox();
            this.pictureBox_italic = new System.Windows.Forms.PictureBox();
            this.pictureBox_bold = new System.Windows.Forms.PictureBox();
            this.panel_messageBorderStyle = new System.Windows.Forms.Panel();
            this.richTextBox_message = new System.Windows.Forms.RichTextBox();
            this.textBox_objet = new System.Windows.Forms.TextBox();
            this.btn_hide = new System.Windows.Forms.PictureBox();
            this.label_newMessage = new System.Windows.Forms.Label();
            this.openFileWindow = new System.Windows.Forms.OpenFileDialog();
            this.panel_message = new System.Windows.Forms.Panel();
            this.panel_nouveauMessage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Button_add)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_delete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_color)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_underline)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_italic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_bold)).BeginInit();
            this.panel_messageBorderStyle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_hide)).BeginInit();
            this.SuspendLayout();
            // 
            // label_titre
            // 
            this.label_titre.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_titre.Location = new System.Drawing.Point(12, 9);
            this.label_titre.Name = "label_titre";
            this.label_titre.Size = new System.Drawing.Size(489, 70);
            this.label_titre.TabIndex = 0;
            this.label_titre.Text = "Informations sur la tâche ";
            this.label_titre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel_nouveauMessage
            // 
            this.panel_nouveauMessage.BackColor = System.Drawing.Color.Linen;
            this.panel_nouveauMessage.Controls.Add(this.Button_add);
            this.panel_nouveauMessage.Controls.Add(this.comboBox_images);
            this.panel_nouveauMessage.Controls.Add(this.pictureBox_delete);
            this.panel_nouveauMessage.Controls.Add(this.button_addImg);
            this.panel_nouveauMessage.Controls.Add(this.label1);
            this.panel_nouveauMessage.Controls.Add(this.pictureBox_color);
            this.panel_nouveauMessage.Controls.Add(this.pictureBox_underline);
            this.panel_nouveauMessage.Controls.Add(this.pictureBox_italic);
            this.panel_nouveauMessage.Controls.Add(this.pictureBox_bold);
            this.panel_nouveauMessage.Controls.Add(this.panel_messageBorderStyle);
            this.panel_nouveauMessage.Controls.Add(this.textBox_objet);
            this.panel_nouveauMessage.Controls.Add(this.btn_hide);
            this.panel_nouveauMessage.Controls.Add(this.label_newMessage);
            this.panel_nouveauMessage.Location = new System.Drawing.Point(1, 247);
            this.panel_nouveauMessage.Name = "panel_nouveauMessage";
            this.panel_nouveauMessage.Size = new System.Drawing.Size(513, 359);
            this.panel_nouveauMessage.TabIndex = 1;
            // 
            // Button_add
            // 
            this.Button_add.BackColor = System.Drawing.Color.Transparent;
            this.Button_add.Image = global::Gestionnaire_de_tâche__Last_.Properties.Resources.add2;
            this.Button_add.ImageActive = null;
            this.Button_add.Location = new System.Drawing.Point(457, 279);
            this.Button_add.Name = "Button_add";
            this.Button_add.Size = new System.Drawing.Size(44, 40);
            this.Button_add.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Button_add.TabIndex = 13;
            this.Button_add.TabStop = false;
            this.Button_add.Zoom = 10;
            this.Button_add.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Button_add_MouseDown);
            // 
            // comboBox_images
            // 
            this.comboBox_images.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_images.FormattingEnabled = true;
            this.comboBox_images.Location = new System.Drawing.Point(17, 318);
            this.comboBox_images.Name = "comboBox_images";
            this.comboBox_images.Size = new System.Drawing.Size(163, 21);
            this.comboBox_images.TabIndex = 12;
            // 
            // pictureBox_delete
            // 
            this.pictureBox_delete.Image = global::Gestionnaire_de_tâche__Last_.Properties.Resources.delete_trash;
            this.pictureBox_delete.Location = new System.Drawing.Point(182, 316);
            this.pictureBox_delete.Name = "pictureBox_delete";
            this.pictureBox_delete.Size = new System.Drawing.Size(25, 24);
            this.pictureBox_delete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_delete.TabIndex = 11;
            this.pictureBox_delete.TabStop = false;
            this.pictureBox_delete.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox_delete_MouseDown);
            // 
            // button_addImg
            // 
            this.button_addImg.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_addImg.Location = new System.Drawing.Point(17, 282);
            this.button_addImg.Name = "button_addImg";
            this.button_addImg.Size = new System.Drawing.Size(163, 27);
            this.button_addImg.TabIndex = 9;
            this.button_addImg.Text = "Ajouter des images";
            this.button_addImg.UseVisualStyleBackColor = true;
            this.button_addImg.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button_addImg_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Linen;
            this.label1.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.label1.Location = new System.Drawing.Point(14, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Objet :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox_color
            // 
            this.pictureBox_color.BackColor = System.Drawing.Color.Linen;
            this.pictureBox_color.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox_color.Image = global::Gestionnaire_de_tâche__Last_.Properties.Resources.color;
            this.pictureBox_color.Location = new System.Drawing.Point(137, 73);
            this.pictureBox_color.Name = "pictureBox_color";
            this.pictureBox_color.Size = new System.Drawing.Size(28, 28);
            this.pictureBox_color.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_color.TabIndex = 7;
            this.pictureBox_color.TabStop = false;
            this.pictureBox_color.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox_color_MouseDown);
            // 
            // pictureBox_underline
            // 
            this.pictureBox_underline.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_underline.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox_underline.Image = global::Gestionnaire_de_tâche__Last_.Properties.Resources.underline_2;
            this.pictureBox_underline.Location = new System.Drawing.Point(97, 73);
            this.pictureBox_underline.Name = "pictureBox_underline";
            this.pictureBox_underline.Size = new System.Drawing.Size(28, 28);
            this.pictureBox_underline.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_underline.TabIndex = 6;
            this.pictureBox_underline.TabStop = false;
            this.pictureBox_underline.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox_underline_MouseDown);
            // 
            // pictureBox_italic
            // 
            this.pictureBox_italic.BackColor = System.Drawing.Color.Linen;
            this.pictureBox_italic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox_italic.Image = global::Gestionnaire_de_tâche__Last_.Properties.Resources.italic;
            this.pictureBox_italic.Location = new System.Drawing.Point(57, 73);
            this.pictureBox_italic.Name = "pictureBox_italic";
            this.pictureBox_italic.Size = new System.Drawing.Size(28, 28);
            this.pictureBox_italic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_italic.TabIndex = 5;
            this.pictureBox_italic.TabStop = false;
            this.pictureBox_italic.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox_italic_MouseDown);
            // 
            // pictureBox_bold
            // 
            this.pictureBox_bold.BackColor = System.Drawing.Color.Linen;
            this.pictureBox_bold.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox_bold.Image = global::Gestionnaire_de_tâche__Last_.Properties.Resources.bold;
            this.pictureBox_bold.Location = new System.Drawing.Point(17, 73);
            this.pictureBox_bold.Name = "pictureBox_bold";
            this.pictureBox_bold.Size = new System.Drawing.Size(28, 28);
            this.pictureBox_bold.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_bold.TabIndex = 4;
            this.pictureBox_bold.TabStop = false;
            this.pictureBox_bold.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox_bold_MouseDown);
            // 
            // panel_messageBorderStyle
            // 
            this.panel_messageBorderStyle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_messageBorderStyle.Controls.Add(this.richTextBox_message);
            this.panel_messageBorderStyle.Location = new System.Drawing.Point(16, 109);
            this.panel_messageBorderStyle.Name = "panel_messageBorderStyle";
            this.panel_messageBorderStyle.Size = new System.Drawing.Size(485, 164);
            this.panel_messageBorderStyle.TabIndex = 2;
            // 
            // richTextBox_message
            // 
            this.richTextBox_message.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox_message.Font = new System.Drawing.Font("Verdana", 10.25F);
            this.richTextBox_message.Location = new System.Drawing.Point(0, -1);
            this.richTextBox_message.Name = "richTextBox_message";
            this.richTextBox_message.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBox_message.Size = new System.Drawing.Size(484, 164);
            this.richTextBox_message.TabIndex = 1;
            this.richTextBox_message.Text = "";
            this.richTextBox_message.MouseMove += new System.Windows.Forms.MouseEventHandler(this.richTextBox_message_MouseMove);
            // 
            // textBox_objet
            // 
            this.textBox_objet.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_objet.Location = new System.Drawing.Point(16, 41);
            this.textBox_objet.Name = "textBox_objet";
            this.textBox_objet.Size = new System.Drawing.Size(485, 27);
            this.textBox_objet.TabIndex = 0;
            // 
            // btn_hide
            // 
            this.btn_hide.Image = global::Gestionnaire_de_tâche__Last_.Properties.Resources.exit;
            this.btn_hide.Location = new System.Drawing.Point(488, 3);
            this.btn_hide.Name = "btn_hide";
            this.btn_hide.Size = new System.Drawing.Size(22, 22);
            this.btn_hide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_hide.TabIndex = 2;
            this.btn_hide.TabStop = false;
            this.btn_hide.Visible = false;
            this.btn_hide.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_hide_MouseDown);
            // 
            // label_newMessage
            // 
            this.label_newMessage.BackColor = System.Drawing.Color.Linen;
            this.label_newMessage.Font = new System.Drawing.Font("Verdana", 10.25F);
            this.label_newMessage.Location = new System.Drawing.Point(12, 3);
            this.label_newMessage.Name = "label_newMessage";
            this.label_newMessage.Size = new System.Drawing.Size(489, 18);
            this.label_newMessage.TabIndex = 2;
            this.label_newMessage.Text = "Nouveau message";
            this.label_newMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_newMessage.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label_newMessage_MouseDown);
            // 
            // openFileWindow
            // 
            this.openFileWindow.FileName = "openFileDialog1";
            // 
            // panel_message
            // 
            this.panel_message.AutoScroll = true;
            this.panel_message.Location = new System.Drawing.Point(9, 82);
            this.panel_message.Name = "panel_message";
            this.panel_message.Size = new System.Drawing.Size(517, 504);
            this.panel_message.TabIndex = 2;
            // 
            // Tchat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 624);
            this.Controls.Add(this.panel_nouveauMessage);
            this.Controls.Add(this.label_titre);
            this.Controls.Add(this.panel_message);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Tchat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tchat";
            this.Load += new System.EventHandler(this.Tchat_Load);
            this.panel_nouveauMessage.ResumeLayout(false);
            this.panel_nouveauMessage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Button_add)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_delete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_color)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_underline)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_italic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_bold)).EndInit();
            this.panel_messageBorderStyle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_hide)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label_titre;
        private System.Windows.Forms.Panel panel_nouveauMessage;
        private System.Windows.Forms.RichTextBox richTextBox_message;
        private System.Windows.Forms.Label label_newMessage;
        private System.Windows.Forms.PictureBox btn_hide;
        private System.Windows.Forms.TextBox textBox_objet;
        private System.Windows.Forms.Panel panel_messageBorderStyle;
        private System.Windows.Forms.PictureBox pictureBox_bold;
        private System.Windows.Forms.PictureBox pictureBox_color;
        private System.Windows.Forms.PictureBox pictureBox_underline;
        private System.Windows.Forms.PictureBox pictureBox_italic;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_addImg;
        private System.Windows.Forms.OpenFileDialog openFileWindow;
        private System.Windows.Forms.PictureBox pictureBox_delete;
        private System.Windows.Forms.ComboBox comboBox_images;
        private Bunifu.Framework.UI.BunifuImageButton Button_add;
        private System.Windows.Forms.Panel panel_message;
    }
}