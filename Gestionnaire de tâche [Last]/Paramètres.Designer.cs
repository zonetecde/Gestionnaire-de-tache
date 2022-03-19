namespace Gestionnaire_de_tâche__Last_
{
    partial class Paramètres
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Paramètres));
            this.textBox_dataPath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_showPathInExplorer = new Bunifu.Framework.UI.BunifuThinButton2();
            this.Btn_deleteDonnees = new Bunifu.Framework.UI.BunifuThinButton2();
            this.Btn_saveData = new Bunifu.Framework.UI.BunifuThinButton2();
            this.dataGridView_backup = new System.Windows.Forms.DataGridView();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Répértoire = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Taille = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Charger = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Btn_delete = new Bunifu.Framework.UI.BunifuThinButton2();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown_backupTime = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.checkBox_verifyMaj = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label_actualV = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_backup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_backupTime)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_dataPath
            // 
            this.textBox_dataPath.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_dataPath.Location = new System.Drawing.Point(12, 49);
            this.textBox_dataPath.Name = "textBox_dataPath";
            this.textBox_dataPath.ReadOnly = true;
            this.textBox_dataPath.Size = new System.Drawing.Size(656, 26);
            this.textBox_dataPath.TabIndex = 0;
            this.textBox_dataPath.Text = "Chemin d\'accès vers data";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(423, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Chemin d\'accès vers les données de l\'application :";
            // 
            // Btn_showPathInExplorer
            // 
            this.Btn_showPathInExplorer.ActiveBorderThickness = 1;
            this.Btn_showPathInExplorer.ActiveCornerRadius = 20;
            this.Btn_showPathInExplorer.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.Btn_showPathInExplorer.ActiveForecolor = System.Drawing.Color.White;
            this.Btn_showPathInExplorer.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.Btn_showPathInExplorer.BackColor = System.Drawing.SystemColors.Control;
            this.Btn_showPathInExplorer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_showPathInExplorer.BackgroundImage")));
            this.Btn_showPathInExplorer.ButtonText = "Ouvrir dans l\'explorateur de fichier";
            this.Btn_showPathInExplorer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_showPathInExplorer.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_showPathInExplorer.ForeColor = System.Drawing.Color.SeaGreen;
            this.Btn_showPathInExplorer.IdleBorderThickness = 1;
            this.Btn_showPathInExplorer.IdleCornerRadius = 20;
            this.Btn_showPathInExplorer.IdleFillColor = System.Drawing.Color.White;
            this.Btn_showPathInExplorer.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.Btn_showPathInExplorer.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.Btn_showPathInExplorer.Location = new System.Drawing.Point(387, 79);
            this.Btn_showPathInExplorer.Margin = new System.Windows.Forms.Padding(5);
            this.Btn_showPathInExplorer.Name = "Btn_showPathInExplorer";
            this.Btn_showPathInExplorer.Size = new System.Drawing.Size(281, 41);
            this.Btn_showPathInExplorer.TabIndex = 9;
            this.Btn_showPathInExplorer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Btn_showPathInExplorer.MouseDown += new System.EventHandler(this.Btn_showPathInExplorer_MouseDown);
            // 
            // Btn_deleteDonnees
            // 
            this.Btn_deleteDonnees.ActiveBorderThickness = 1;
            this.Btn_deleteDonnees.ActiveCornerRadius = 20;
            this.Btn_deleteDonnees.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Btn_deleteDonnees.ActiveForecolor = System.Drawing.Color.Black;
            this.Btn_deleteDonnees.ActiveLineColor = System.Drawing.Color.Black;
            this.Btn_deleteDonnees.BackColor = System.Drawing.SystemColors.Control;
            this.Btn_deleteDonnees.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_deleteDonnees.BackgroundImage")));
            this.Btn_deleteDonnees.ButtonText = "Supprimer toutes les données";
            this.Btn_deleteDonnees.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_deleteDonnees.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_deleteDonnees.ForeColor = System.Drawing.Color.SeaGreen;
            this.Btn_deleteDonnees.IdleBorderThickness = 1;
            this.Btn_deleteDonnees.IdleCornerRadius = 20;
            this.Btn_deleteDonnees.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Btn_deleteDonnees.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Btn_deleteDonnees.IdleLineColor = System.Drawing.Color.Red;
            this.Btn_deleteDonnees.Location = new System.Drawing.Point(14, 83);
            this.Btn_deleteDonnees.Margin = new System.Windows.Forms.Padding(5);
            this.Btn_deleteDonnees.Name = "Btn_deleteDonnees";
            this.Btn_deleteDonnees.Size = new System.Drawing.Size(242, 41);
            this.Btn_deleteDonnees.TabIndex = 10;
            this.Btn_deleteDonnees.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Btn_deleteDonnees.MouseDown += new System.EventHandler(this.Btn_deleteDonnees_MouseDown);
            // 
            // Btn_saveData
            // 
            this.Btn_saveData.ActiveBorderThickness = 1;
            this.Btn_saveData.ActiveCornerRadius = 20;
            this.Btn_saveData.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.Btn_saveData.ActiveForecolor = System.Drawing.Color.White;
            this.Btn_saveData.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.Btn_saveData.BackColor = System.Drawing.SystemColors.Control;
            this.Btn_saveData.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_saveData.BackgroundImage")));
            this.Btn_saveData.ButtonText = "Ajouter une backup";
            this.Btn_saveData.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_saveData.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_saveData.ForeColor = System.Drawing.Color.SeaGreen;
            this.Btn_saveData.IdleBorderThickness = 1;
            this.Btn_saveData.IdleCornerRadius = 20;
            this.Btn_saveData.IdleFillColor = System.Drawing.Color.White;
            this.Btn_saveData.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.Btn_saveData.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.Btn_saveData.Location = new System.Drawing.Point(14, 303);
            this.Btn_saveData.Margin = new System.Windows.Forms.Padding(5);
            this.Btn_saveData.Name = "Btn_saveData";
            this.Btn_saveData.Size = new System.Drawing.Size(207, 43);
            this.Btn_saveData.TabIndex = 11;
            this.Btn_saveData.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Btn_saveData.MouseDown += new System.EventHandler(this.Btn_saveData_MouseDown);
            // 
            // dataGridView_backup
            // 
            this.dataGridView_backup.AllowUserToAddRows = false;
            this.dataGridView_backup.AllowUserToDeleteRows = false;
            this.dataGridView_backup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_backup.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Date,
            this.Répértoire,
            this.Taille,
            this.Charger});
            this.dataGridView_backup.Location = new System.Drawing.Point(16, 152);
            this.dataGridView_backup.Name = "dataGridView_backup";
            this.dataGridView_backup.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_backup.Size = new System.Drawing.Size(673, 150);
            this.dataGridView_backup.TabIndex = 12;
            this.dataGridView_backup.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_backup_CellContentClick);
            this.dataGridView_backup.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView_backup_KeyDown);
            // 
            // Date
            // 
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            this.Date.ToolTipText = "Date de la backup";
            this.Date.Width = 125;
            // 
            // Répértoire
            // 
            this.Répértoire.HeaderText = "Répértoire";
            this.Répértoire.Name = "Répértoire";
            this.Répértoire.ReadOnly = true;
            this.Répértoire.ToolTipText = "Répértoire de la backup";
            this.Répértoire.Width = 300;
            // 
            // Taille
            // 
            this.Taille.HeaderText = "Taille";
            this.Taille.Name = "Taille";
            this.Taille.ReadOnly = true;
            // 
            // Charger
            // 
            this.Charger.HeaderText = "Charger";
            this.Charger.Name = "Charger";
            this.Charger.ReadOnly = true;
            this.Charger.Text = "Importer";
            this.Charger.Width = 83;
            // 
            // Btn_delete
            // 
            this.Btn_delete.ActiveBorderThickness = 1;
            this.Btn_delete.ActiveCornerRadius = 20;
            this.Btn_delete.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.Btn_delete.ActiveForecolor = System.Drawing.Color.White;
            this.Btn_delete.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.Btn_delete.BackColor = System.Drawing.SystemColors.Control;
            this.Btn_delete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_delete.BackgroundImage")));
            this.Btn_delete.ButtonText = "Supprimer la backup sélectionée";
            this.Btn_delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_delete.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_delete.ForeColor = System.Drawing.Color.SeaGreen;
            this.Btn_delete.IdleBorderThickness = 1;
            this.Btn_delete.IdleCornerRadius = 20;
            this.Btn_delete.IdleFillColor = System.Drawing.Color.White;
            this.Btn_delete.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.Btn_delete.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.Btn_delete.Location = new System.Drawing.Point(387, 302);
            this.Btn_delete.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Btn_delete.Name = "Btn_delete";
            this.Btn_delete.Size = new System.Drawing.Size(283, 45);
            this.Btn_delete.TabIndex = 13;
            this.Btn_delete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Btn_delete.MouseDown += new System.EventHandler(this.Btn_delete_MouseDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 360);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(343, 18);
            this.label2.TabIndex = 14;
            this.label2.Text = "Créer une backup automatiquement tout les ";
            // 
            // numericUpDown_backupTime
            // 
            this.numericUpDown_backupTime.Font = new System.Drawing.Font("Verdana", 11.25F);
            this.numericUpDown_backupTime.Location = new System.Drawing.Point(352, 356);
            this.numericUpDown_backupTime.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_backupTime.Name = "numericUpDown_backupTime";
            this.numericUpDown_backupTime.Size = new System.Drawing.Size(41, 26);
            this.numericUpDown_backupTime.TabIndex = 15;
            this.numericUpDown_backupTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDown_backupTime.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown_backupTime.ValueChanged += new System.EventHandler(this.numericUpDown_backupTime_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(396, 360);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 18);
            this.label3.TabIndex = 16;
            this.label3.Text = "lancement(s).";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 10.25F, System.Drawing.FontStyle.Underline);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(13, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(414, 17);
            this.label4.TabIndex = 17;
            this.label4.Text = "Les images ne sont pas sauvegardées dans les backups !";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 391);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(655, 38);
            this.label5.TabIndex = 18;
            this.label5.Text = "Vérifier les nouvelles mise à jour à chaque lancement ? Le logiciel prendra plus " +
    "de temps à s\'ouvrir";
            // 
            // checkBox_verifyMaj
            // 
            this.checkBox_verifyMaj.AutoSize = true;
            this.checkBox_verifyMaj.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_verifyMaj.Location = new System.Drawing.Point(145, 409);
            this.checkBox_verifyMaj.Name = "checkBox_verifyMaj";
            this.checkBox_verifyMaj.Size = new System.Drawing.Size(48, 20);
            this.checkBox_verifyMaj.TabIndex = 19;
            this.checkBox_verifyMaj.Text = "Oui";
            this.checkBox_verifyMaj.UseVisualStyleBackColor = true;
            this.checkBox_verifyMaj.CheckedChanged += new System.EventHandler(this.checkBox_verifyMaj_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 9.25F);
            this.label6.Location = new System.Drawing.Point(504, 470);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 16);
            this.label6.TabIndex = 20;
            this.label6.Text = "Version actuelle :";
            // 
            // label_actualV
            // 
            this.label_actualV.AutoSize = true;
            this.label_actualV.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_actualV.Location = new System.Drawing.Point(627, 470);
            this.label_actualV.Name = "label_actualV";
            this.label_actualV.Size = new System.Drawing.Size(42, 14);
            this.label_actualV.TabIndex = 21;
            this.label_actualV.Text = "1.0.0";
            // 
            // Paramètres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 490);
            this.Controls.Add(this.label_actualV);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.checkBox_verifyMaj);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numericUpDown_backupTime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Btn_delete);
            this.Controls.Add(this.dataGridView_backup);
            this.Controls.Add(this.Btn_saveData);
            this.Controls.Add(this.Btn_deleteDonnees);
            this.Controls.Add(this.Btn_showPathInExplorer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_dataPath);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Paramètres";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Paramètres";
            this.Load += new System.EventHandler(this.Paramètres_Load);
            this.Shown += new System.EventHandler(this.Paramètres_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_backup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_backupTime)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_dataPath;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuThinButton2 Btn_showPathInExplorer;
        private Bunifu.Framework.UI.BunifuThinButton2 Btn_deleteDonnees;
        private Bunifu.Framework.UI.BunifuThinButton2 Btn_saveData;
        private System.Windows.Forms.DataGridView dataGridView_backup;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Répértoire;
        private System.Windows.Forms.DataGridViewTextBoxColumn Taille;
        private System.Windows.Forms.DataGridViewButtonColumn Charger;
        private Bunifu.Framework.UI.BunifuThinButton2 Btn_delete;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown_backupTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox checkBox_verifyMaj;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label_actualV;
    }
}