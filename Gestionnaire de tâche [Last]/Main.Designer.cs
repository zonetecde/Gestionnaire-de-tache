namespace Gestionnaire_de_tâche__Last_
{
    partial class Main
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.bunifuElipse_form = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel_topBar = new System.Windows.Forms.Panel();
            this.pictureBox_settings = new System.Windows.Forms.PictureBox();
            this.btn_minimize = new System.Windows.Forms.PictureBox();
            this.btn_exit = new System.Windows.Forms.PictureBox();
            this.bunifuSeparator_projetsToOther = new Bunifu.Framework.UI.BunifuSeparator();
            this.panel_projets = new System.Windows.Forms.Panel();
            this.panel_hideScrollBar = new System.Windows.Forms.Panel();
            this.pictureBox_add = new Bunifu.Framework.UI.BunifuImageButton();
            this.pictureBox_delete = new Bunifu.Framework.UI.BunifuImageButton();
            this.PictureBox_edit = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel_informations = new System.Windows.Forms.Panel();
            this.label_warning2 = new System.Windows.Forms.Label();
            this.label_warning3 = new System.Windows.Forms.Label();
            this.label_warning = new System.Windows.Forms.Label();
            this.panel_hideScrollBar2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Btn_duplicate = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton_import = new Bunifu.Framework.UI.BunifuImageButton();
            this.openFileWindow = new System.Windows.Forms.OpenFileDialog();
            this.panel_topBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_settings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_add)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_delete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_edit)).BeginInit();
            this.panel_informations.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_duplicate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton_import)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse_form
            // 
            this.bunifuElipse_form.ElipseRadius = 50;
            this.bunifuElipse_form.TargetControl = this;
            // 
            // panel_topBar
            // 
            this.panel_topBar.BackColor = System.Drawing.Color.Silver;
            this.panel_topBar.Controls.Add(this.pictureBox_settings);
            this.panel_topBar.Controls.Add(this.btn_minimize);
            this.panel_topBar.Controls.Add(this.btn_exit);
            this.panel_topBar.Location = new System.Drawing.Point(-21, -2);
            this.panel_topBar.Name = "panel_topBar";
            this.panel_topBar.Size = new System.Drawing.Size(1305, 41);
            this.panel_topBar.TabIndex = 0;
            this.panel_topBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_topBar_MouseDown);
            // 
            // pictureBox_settings
            // 
            this.pictureBox_settings.Image = global::Gestionnaire_de_tâche__Last_.Properties.Resources.setting;
            this.pictureBox_settings.Location = new System.Drawing.Point(1155, 1);
            this.pictureBox_settings.Name = "pictureBox_settings";
            this.pictureBox_settings.Size = new System.Drawing.Size(38, 38);
            this.pictureBox_settings.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_settings.TabIndex = 3;
            this.pictureBox_settings.TabStop = false;
            this.pictureBox_settings.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox_settings_MouseDown);
            // 
            // btn_minimize
            // 
            this.btn_minimize.Image = global::Gestionnaire_de_tâche__Last_.Properties.Resources.minimize;
            this.btn_minimize.Location = new System.Drawing.Point(1199, 2);
            this.btn_minimize.Name = "btn_minimize";
            this.btn_minimize.Size = new System.Drawing.Size(38, 38);
            this.btn_minimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_minimize.TabIndex = 2;
            this.btn_minimize.TabStop = false;
            this.btn_minimize.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_minimize_MouseDown);
            // 
            // btn_exit
            // 
            this.btn_exit.Image = global::Gestionnaire_de_tâche__Last_.Properties.Resources.exit;
            this.btn_exit.Location = new System.Drawing.Point(1243, 2);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(38, 38);
            this.btn_exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_exit.TabIndex = 1;
            this.btn_exit.TabStop = false;
            this.btn_exit.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_exit_MouseDown);
            // 
            // bunifuSeparator_projetsToOther
            // 
            this.bunifuSeparator_projetsToOther.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator_projetsToOther.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator_projetsToOther.LineThickness = 1;
            this.bunifuSeparator_projetsToOther.Location = new System.Drawing.Point(227, 79);
            this.bunifuSeparator_projetsToOther.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuSeparator_projetsToOther.Name = "bunifuSeparator_projetsToOther";
            this.bunifuSeparator_projetsToOther.Size = new System.Drawing.Size(30, 675);
            this.bunifuSeparator_projetsToOther.TabIndex = 1;
            this.bunifuSeparator_projetsToOther.Transparency = 255;
            this.bunifuSeparator_projetsToOther.Vertical = true;
            // 
            // panel_projets
            // 
            this.panel_projets.AutoScroll = true;
            this.panel_projets.Location = new System.Drawing.Point(5, 92);
            this.panel_projets.Name = "panel_projets";
            this.panel_projets.Size = new System.Drawing.Size(238, 662);
            this.panel_projets.TabIndex = 2;
            // 
            // panel_hideScrollBar
            // 
            this.panel_hideScrollBar.Location = new System.Drawing.Point(227, 48);
            this.panel_hideScrollBar.Name = "panel_hideScrollBar";
            this.panel_hideScrollBar.Size = new System.Drawing.Size(16, 707);
            this.panel_hideScrollBar.TabIndex = 3;
            // 
            // pictureBox_add
            // 
            this.pictureBox_add.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_add.Image = global::Gestionnaire_de_tâche__Last_.Properties.Resources.add2;
            this.pictureBox_add.ImageActive = null;
            this.pictureBox_add.Location = new System.Drawing.Point(5, 48);
            this.pictureBox_add.Name = "pictureBox_add";
            this.pictureBox_add.Size = new System.Drawing.Size(38, 38);
            this.pictureBox_add.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_add.TabIndex = 5;
            this.pictureBox_add.TabStop = false;
            this.pictureBox_add.Zoom = 10;
            this.pictureBox_add.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox_add_MouseDown_1);
            // 
            // pictureBox_delete
            // 
            this.pictureBox_delete.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_delete.Image = global::Gestionnaire_de_tâche__Last_.Properties.Resources.delete_trash;
            this.pictureBox_delete.ImageActive = null;
            this.pictureBox_delete.Location = new System.Drawing.Point(49, 48);
            this.pictureBox_delete.Name = "pictureBox_delete";
            this.pictureBox_delete.Size = new System.Drawing.Size(38, 38);
            this.pictureBox_delete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_delete.TabIndex = 6;
            this.pictureBox_delete.TabStop = false;
            this.pictureBox_delete.Zoom = 10;
            this.pictureBox_delete.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox_delete_MouseDown_1);
            // 
            // PictureBox_edit
            // 
            this.PictureBox_edit.BackColor = System.Drawing.Color.Transparent;
            this.PictureBox_edit.Image = global::Gestionnaire_de_tâche__Last_.Properties.Resources.modify;
            this.PictureBox_edit.ImageActive = null;
            this.PictureBox_edit.Location = new System.Drawing.Point(93, 48);
            this.PictureBox_edit.Name = "PictureBox_edit";
            this.PictureBox_edit.Size = new System.Drawing.Size(38, 38);
            this.PictureBox_edit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBox_edit.TabIndex = 7;
            this.PictureBox_edit.TabStop = false;
            this.PictureBox_edit.Zoom = 10;
            this.PictureBox_edit.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PictureBox_edit_MouseDown);
            // 
            // panel_informations
            // 
            this.panel_informations.AutoScroll = true;
            this.panel_informations.Controls.Add(this.label_warning2);
            this.panel_informations.Controls.Add(this.label_warning3);
            this.panel_informations.Controls.Add(this.label_warning);
            this.panel_informations.Location = new System.Drawing.Point(267, 92);
            this.panel_informations.Name = "panel_informations";
            this.panel_informations.Size = new System.Drawing.Size(993, 660);
            this.panel_informations.TabIndex = 8;
            this.panel_informations.Scroll += new System.Windows.Forms.ScrollEventHandler(this.panel_informations_Scroll);
            // 
            // label_warning2
            // 
            this.label_warning2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_warning2.Font = new System.Drawing.Font("Verdana", 20.25F);
            this.label_warning2.ForeColor = System.Drawing.Color.Blue;
            this.label_warning2.Location = new System.Drawing.Point(416, 355);
            this.label_warning2.Name = "label_warning2";
            this.label_warning2.Size = new System.Drawing.Size(49, 31);
            this.label_warning2.TabIndex = 1;
            this.label_warning2.Text = "ici";
            this.label_warning2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_warning2.Visible = false;
            this.label_warning2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label_warning_MouseDown);
            this.label_warning2.MouseEnter += new System.EventHandler(this.label_warning_MouseEnter);
            this.label_warning2.MouseLeave += new System.EventHandler(this.label_warning_MouseLeave);
            // 
            // label_warning3
            // 
            this.label_warning3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_warning3.Font = new System.Drawing.Font("Verdana", 20.25F);
            this.label_warning3.Location = new System.Drawing.Point(309, 352);
            this.label_warning3.Name = "label_warning3";
            this.label_warning3.Size = new System.Drawing.Size(378, 36);
            this.label_warning3.TabIndex = 2;
            this.label_warning3.Text = "Cliquez     pour en ajouter";
            this.label_warning3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_warning3.Visible = false;
            this.label_warning3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label_warning_MouseDown);
            this.label_warning3.MouseEnter += new System.EventHandler(this.label_warning_MouseEnter);
            this.label_warning3.MouseLeave += new System.EventHandler(this.label_warning_MouseLeave);
            // 
            // label_warning
            // 
            this.label_warning.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_warning.Font = new System.Drawing.Font("Verdana", 20.25F);
            this.label_warning.Location = new System.Drawing.Point(130, 315);
            this.label_warning.Name = "label_warning";
            this.label_warning.Size = new System.Drawing.Size(742, 37);
            this.label_warning.TabIndex = 0;
            this.label_warning.Text = "Aucun sous projet pour + nom du projet  \r\n";
            this.label_warning.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_warning.Visible = false;
            this.label_warning.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label_warning_MouseDown);
            this.label_warning.MouseEnter += new System.EventHandler(this.label_warning_MouseEnter);
            this.label_warning.MouseLeave += new System.EventHandler(this.label_warning_MouseLeave);
            // 
            // panel_hideScrollBar2
            // 
            this.panel_hideScrollBar2.Location = new System.Drawing.Point(0, 736);
            this.panel_hideScrollBar2.Name = "panel_hideScrollBar2";
            this.panel_hideScrollBar2.Size = new System.Drawing.Size(251, 19);
            this.panel_hideScrollBar2.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(1246, 91);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(16, 707);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(263, 736);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1005, 19);
            this.panel2.TabIndex = 4;
            // 
            // Btn_duplicate
            // 
            this.Btn_duplicate.BackColor = System.Drawing.Color.Transparent;
            this.Btn_duplicate.Image = global::Gestionnaire_de_tâche__Last_.Properties.Resources.icons8_duplicate_100px;
            this.Btn_duplicate.ImageActive = null;
            this.Btn_duplicate.Location = new System.Drawing.Point(137, 48);
            this.Btn_duplicate.Name = "Btn_duplicate";
            this.Btn_duplicate.Size = new System.Drawing.Size(38, 38);
            this.Btn_duplicate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Btn_duplicate.TabIndex = 9;
            this.Btn_duplicate.TabStop = false;
            this.Btn_duplicate.Zoom = 10;
            this.Btn_duplicate.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Btn_duplicate_MouseDown);
            // 
            // bunifuImageButton_import
            // 
            this.bunifuImageButton_import.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton_import.Image = global::Gestionnaire_de_tâche__Last_.Properties.Resources.import;
            this.bunifuImageButton_import.ImageActive = null;
            this.bunifuImageButton_import.Location = new System.Drawing.Point(182, 48);
            this.bunifuImageButton_import.Name = "bunifuImageButton_import";
            this.bunifuImageButton_import.Size = new System.Drawing.Size(38, 38);
            this.bunifuImageButton_import.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton_import.TabIndex = 10;
            this.bunifuImageButton_import.TabStop = false;
            this.bunifuImageButton_import.Zoom = 10;
            this.bunifuImageButton_import.MouseDown += new System.Windows.Forms.MouseEventHandler(this.bunifuImageButton_import_MouseDown);
            // 
            // openFileWindow
            // 
            this.openFileWindow.FileName = "openFileDialog1";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1280, 764);
            this.Controls.Add(this.bunifuImageButton_import);
            this.Controls.Add(this.Btn_duplicate);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel_hideScrollBar2);
            this.Controls.Add(this.panel_informations);
            this.Controls.Add(this.PictureBox_edit);
            this.Controls.Add(this.pictureBox_delete);
            this.Controls.Add(this.pictureBox_add);
            this.Controls.Add(this.bunifuSeparator_projetsToOther);
            this.Controls.Add(this.panel_hideScrollBar);
            this.Controls.Add(this.panel_topBar);
            this.Controls.Add(this.panel_projets);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestionnaire de tâche";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_FormClosed);
            this.Load += new System.EventHandler(this.Main_Load);
            this.Shown += new System.EventHandler(this.Main_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Main_KeyDown);
            this.panel_topBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_settings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_add)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_delete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_edit)).EndInit();
            this.panel_informations.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Btn_duplicate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton_import)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse_form;
        private System.Windows.Forms.Panel panel_topBar;
        private System.Windows.Forms.PictureBox btn_exit;
        private System.Windows.Forms.PictureBox btn_minimize;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator_projetsToOther;
        private System.Windows.Forms.Panel panel_hideScrollBar;
        private System.Windows.Forms.Panel panel_projets;
        private Bunifu.Framework.UI.BunifuImageButton pictureBox_add;
        private Bunifu.Framework.UI.BunifuImageButton pictureBox_delete;
        private Bunifu.Framework.UI.BunifuImageButton PictureBox_edit;
        private System.Windows.Forms.Panel panel_informations;
        private System.Windows.Forms.Label label_warning;
        private System.Windows.Forms.Label label_warning2;
        private System.Windows.Forms.Label label_warning3;
        private System.Windows.Forms.Panel panel_hideScrollBar2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuImageButton Btn_duplicate;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton_import;
        private System.Windows.Forms.OpenFileDialog openFileWindow;
        private System.Windows.Forms.PictureBox pictureBox_settings;
    }
}

