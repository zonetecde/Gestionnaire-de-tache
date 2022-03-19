namespace Gestionnaire_de_tâche__Last_
{
    partial class Ajouter_un_mot_clé
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
            this.label_title = new System.Windows.Forms.Label();
            this.Textbox_nom = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.button_add = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_title
            // 
            this.label_title.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_title.Location = new System.Drawing.Point(1, 1);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(525, 66);
            this.label_title.TabIndex = 0;
            this.label_title.Text = "Ajouter un mot clé pour";
            this.label_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Textbox_nom
            // 
            this.Textbox_nom.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Textbox_nom.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.Textbox_nom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Textbox_nom.HintForeColor = System.Drawing.Color.Empty;
            this.Textbox_nom.HintText = "";
            this.Textbox_nom.isPassword = false;
            this.Textbox_nom.LineFocusedColor = System.Drawing.Color.Blue;
            this.Textbox_nom.LineIdleColor = System.Drawing.Color.Gray;
            this.Textbox_nom.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.Textbox_nom.LineThickness = 3;
            this.Textbox_nom.Location = new System.Drawing.Point(13, 66);
            this.Textbox_nom.Margin = new System.Windows.Forms.Padding(4);
            this.Textbox_nom.Name = "Textbox_nom";
            this.Textbox_nom.Size = new System.Drawing.Size(313, 44);
            this.Textbox_nom.TabIndex = 1;
            this.Textbox_nom.Text = "Mot clé...";
            this.Textbox_nom.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Textbox_nom.Enter += new System.EventHandler(this.Textbox_nom_Enter);
            this.Textbox_nom.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Textbox_nom_KeyDown);
            // 
            // button_add
            // 
            this.button_add.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_add.Location = new System.Drawing.Point(405, 127);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(109, 31);
            this.button_add.TabIndex = 2;
            this.button_add.Text = "Ajouter";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // Ajouter_un_mot_clé
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 170);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.Textbox_nom);
            this.Controls.Add(this.label_title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Ajouter_un_mot_clé";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ajouter un mot clé";
            this.Load += new System.EventHandler(this.Ajouter_un_mot_clé_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label_title;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Textbox_nom;
        private System.Windows.Forms.Button button_add;
    }
}