namespace Gestionnaire_de_tâche__Last_
{
    partial class Ordre
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
            this.tabControl_projet = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.pictureBox_up = new System.Windows.Forms.PictureBox();
            this.listBox_sousProjet = new System.Windows.Forms.ListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.pictureBox_down = new System.Windows.Forms.PictureBox();
            this.label_monter = new System.Windows.Forms.Label();
            this.label_descendre = new System.Windows.Forms.Label();
            this.pictureBox_trash = new System.Windows.Forms.PictureBox();
            this.pictureBox_delete = new System.Windows.Forms.PictureBox();
            this.pictureBox_descendreTache = new System.Windows.Forms.PictureBox();
            this.pictureBox_monterTache = new System.Windows.Forms.PictureBox();
            this.listBox_tache = new System.Windows.Forms.ListBox();
            this.comboBox_sousProjet = new System.Windows.Forms.ComboBox();
            this.label_descendreTache = new System.Windows.Forms.Label();
            this.label_monterTache = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabControl_projet.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_up)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_down)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_trash)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_delete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_descendreTache)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_monterTache)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl_projet
            // 
            this.tabControl_projet.Controls.Add(this.tabPage1);
            this.tabControl_projet.Controls.Add(this.tabPage2);
            this.tabControl_projet.Location = new System.Drawing.Point(12, 12);
            this.tabControl_projet.Name = "tabControl_projet";
            this.tabControl_projet.SelectedIndex = 0;
            this.tabControl_projet.Size = new System.Drawing.Size(638, 363);
            this.tabControl_projet.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage1.Controls.Add(this.pictureBox_trash);
            this.tabPage1.Controls.Add(this.label_descendre);
            this.tabPage1.Controls.Add(this.label_monter);
            this.tabPage1.Controls.Add(this.pictureBox_down);
            this.tabPage1.Controls.Add(this.pictureBox_up);
            this.tabPage1.Controls.Add(this.listBox_sousProjet);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(630, 337);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Sous projet";
            // 
            // pictureBox_up
            // 
            this.pictureBox_up.Image = global::Gestionnaire_de_tâche__Last_.Properties.Resources.up;
            this.pictureBox_up.Location = new System.Drawing.Point(382, 41);
            this.pictureBox_up.Name = "pictureBox_up";
            this.pictureBox_up.Size = new System.Drawing.Size(100, 50);
            this.pictureBox_up.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox_up.TabIndex = 1;
            this.pictureBox_up.TabStop = false;
            this.pictureBox_up.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label_monter_MouseDown);
            // 
            // listBox_sousProjet
            // 
            this.listBox_sousProjet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBox_sousProjet.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox_sousProjet.FormattingEnabled = true;
            this.listBox_sousProjet.ItemHeight = 16;
            this.listBox_sousProjet.Location = new System.Drawing.Point(3, 41);
            this.listBox_sousProjet.Name = "listBox_sousProjet";
            this.listBox_sousProjet.Size = new System.Drawing.Size(373, 290);
            this.listBox_sousProjet.TabIndex = 0;
            this.listBox_sousProjet.SelectedIndexChanged += new System.EventHandler(this.listBox_sousProjet_SelectedIndexChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label_descendreTache);
            this.tabPage2.Controls.Add(this.label_monterTache);
            this.tabPage2.Controls.Add(this.comboBox_sousProjet);
            this.tabPage2.Controls.Add(this.pictureBox_delete);
            this.tabPage2.Controls.Add(this.pictureBox_descendreTache);
            this.tabPage2.Controls.Add(this.pictureBox_monterTache);
            this.tabPage2.Controls.Add(this.listBox_tache);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(630, 337);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Tâche";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // pictureBox_down
            // 
            this.pictureBox_down.Image = global::Gestionnaire_de_tâche__Last_.Properties.Resources.down;
            this.pictureBox_down.Location = new System.Drawing.Point(382, 281);
            this.pictureBox_down.Name = "pictureBox_down";
            this.pictureBox_down.Size = new System.Drawing.Size(100, 50);
            this.pictureBox_down.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox_down.TabIndex = 2;
            this.pictureBox_down.TabStop = false;
            this.pictureBox_down.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox_down_MouseDown);
            // 
            // label_monter
            // 
            this.label_monter.Location = new System.Drawing.Point(382, 90);
            this.label_monter.Name = "label_monter";
            this.label_monter.Size = new System.Drawing.Size(100, 15);
            this.label_monter.TabIndex = 3;
            this.label_monter.Text = "Monter";
            this.label_monter.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label_monter.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label_monter_MouseDown);
            // 
            // label_descendre
            // 
            this.label_descendre.Location = new System.Drawing.Point(382, 267);
            this.label_descendre.Name = "label_descendre";
            this.label_descendre.Size = new System.Drawing.Size(100, 15);
            this.label_descendre.TabIndex = 4;
            this.label_descendre.Text = "Descendre";
            this.label_descendre.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label_descendre.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox_down_MouseDown);
            // 
            // pictureBox_trash
            // 
            this.pictureBox_trash.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pictureBox_trash.Image = global::Gestionnaire_de_tâche__Last_.Properties.Resources.delete_trash;
            this.pictureBox_trash.Location = new System.Drawing.Point(385, 156);
            this.pictureBox_trash.Name = "pictureBox_trash";
            this.pictureBox_trash.Size = new System.Drawing.Size(100, 56);
            this.pictureBox_trash.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_trash.TabIndex = 5;
            this.pictureBox_trash.TabStop = false;
            this.pictureBox_trash.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox_trash_MouseDown);
            // 
            // pictureBox_delete
            // 
            this.pictureBox_delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pictureBox_delete.Image = global::Gestionnaire_de_tâche__Last_.Properties.Resources.delete_trash;
            this.pictureBox_delete.Location = new System.Drawing.Point(385, 156);
            this.pictureBox_delete.Name = "pictureBox_delete";
            this.pictureBox_delete.Size = new System.Drawing.Size(100, 56);
            this.pictureBox_delete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_delete.TabIndex = 9;
            this.pictureBox_delete.TabStop = false;
            this.pictureBox_delete.Visible = false;
            this.pictureBox_delete.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox_delete_MouseDown);
            // 
            // pictureBox_descendreTache
            // 
            this.pictureBox_descendreTache.Image = global::Gestionnaire_de_tâche__Last_.Properties.Resources.down;
            this.pictureBox_descendreTache.Location = new System.Drawing.Point(382, 281);
            this.pictureBox_descendreTache.Name = "pictureBox_descendreTache";
            this.pictureBox_descendreTache.Size = new System.Drawing.Size(100, 50);
            this.pictureBox_descendreTache.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox_descendreTache.TabIndex = 8;
            this.pictureBox_descendreTache.TabStop = false;
            this.pictureBox_descendreTache.Visible = false;
            this.pictureBox_descendreTache.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox_descendreTache_MouseDown);
            // 
            // pictureBox_monterTache
            // 
            this.pictureBox_monterTache.Image = global::Gestionnaire_de_tâche__Last_.Properties.Resources.up;
            this.pictureBox_monterTache.Location = new System.Drawing.Point(382, 41);
            this.pictureBox_monterTache.Name = "pictureBox_monterTache";
            this.pictureBox_monterTache.Size = new System.Drawing.Size(100, 50);
            this.pictureBox_monterTache.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox_monterTache.TabIndex = 7;
            this.pictureBox_monterTache.TabStop = false;
            this.pictureBox_monterTache.Visible = false;
            this.pictureBox_monterTache.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox_monterTache_MouseDown);
            // 
            // listBox_tache
            // 
            this.listBox_tache.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBox_tache.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox_tache.FormattingEnabled = true;
            this.listBox_tache.ItemHeight = 16;
            this.listBox_tache.Location = new System.Drawing.Point(3, 41);
            this.listBox_tache.Name = "listBox_tache";
            this.listBox_tache.Size = new System.Drawing.Size(373, 290);
            this.listBox_tache.TabIndex = 6;
            this.listBox_tache.SelectedIndexChanged += new System.EventHandler(this.listBox_tache_SelectedIndexChanged);
            // 
            // comboBox_sousProjet
            // 
            this.comboBox_sousProjet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_sousProjet.FormattingEnabled = true;
            this.comboBox_sousProjet.Location = new System.Drawing.Point(116, 14);
            this.comboBox_sousProjet.Name = "comboBox_sousProjet";
            this.comboBox_sousProjet.Size = new System.Drawing.Size(243, 21);
            this.comboBox_sousProjet.TabIndex = 10;
            this.comboBox_sousProjet.SelectedIndexChanged += new System.EventHandler(this.comboBox_sousProjet_SelectedIndexChanged);
            // 
            // label_descendreTache
            // 
            this.label_descendreTache.Location = new System.Drawing.Point(382, 267);
            this.label_descendreTache.Name = "label_descendreTache";
            this.label_descendreTache.Size = new System.Drawing.Size(100, 15);
            this.label_descendreTache.TabIndex = 12;
            this.label_descendreTache.Text = "Descendre";
            this.label_descendreTache.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label_descendreTache.Visible = false;
            this.label_descendreTache.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox_descendreTache_MouseDown);
            // 
            // label_monterTache
            // 
            this.label_monterTache.Location = new System.Drawing.Point(382, 90);
            this.label_monterTache.Name = "label_monterTache";
            this.label_monterTache.Size = new System.Drawing.Size(100, 15);
            this.label_monterTache.TabIndex = 11;
            this.label_monterTache.Text = "Monter";
            this.label_monterTache.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label_monterTache.Visible = false;
            this.label_monterTache.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox_monterTache_MouseDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 18);
            this.label3.TabIndex = 13;
            this.label3.Text = "Sous projet :";
            // 
            // Ordre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 387);
            this.Controls.Add(this.tabControl_projet);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Ordre";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ordre";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Ordre_FormClosed);
            this.Load += new System.EventHandler(this.Ordre_Load);
            this.tabControl_projet.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_up)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_down)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_trash)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_delete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_descendreTache)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_monterTache)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl_projet;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.PictureBox pictureBox_up;
        private System.Windows.Forms.ListBox listBox_sousProjet;
        private System.Windows.Forms.Label label_descendre;
        private System.Windows.Forms.Label label_monter;
        private System.Windows.Forms.PictureBox pictureBox_down;
        private System.Windows.Forms.PictureBox pictureBox_trash;
        private System.Windows.Forms.ComboBox comboBox_sousProjet;
        private System.Windows.Forms.PictureBox pictureBox_delete;
        private System.Windows.Forms.PictureBox pictureBox_descendreTache;
        private System.Windows.Forms.PictureBox pictureBox_monterTache;
        private System.Windows.Forms.ListBox listBox_tache;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_descendreTache;
        private System.Windows.Forms.Label label_monterTache;
    }
}