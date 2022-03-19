namespace Gestionnaire_de_tâche__Last_
{
    partial class UserControl_Statistic_priorité_chiffre
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

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel_etat = new System.Windows.Forms.Panel();
            this.labelstate = new System.Windows.Forms.Label();
            this.label_chiffre2 = new System.Windows.Forms.RichTextBox();
            this.label_chiifre1 = new System.Windows.Forms.RichTextBox();
            this.comboBox_sousProj = new System.Windows.Forms.ComboBox();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.panel_etat.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_etat
            // 
            this.panel_etat.Controls.Add(this.labelstate);
            this.panel_etat.Location = new System.Drawing.Point(9, 5);
            this.panel_etat.Margin = new System.Windows.Forms.Padding(2);
            this.panel_etat.Name = "panel_etat";
            this.panel_etat.Size = new System.Drawing.Size(117, 54);
            this.panel_etat.TabIndex = 7;
            // 
            // labelstate
            // 
            this.labelstate.BackColor = System.Drawing.Color.Transparent;
            this.labelstate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelstate.Location = new System.Drawing.Point(0, 0);
            this.labelstate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelstate.Name = "labelstate";
            this.labelstate.Size = new System.Drawing.Size(117, 54);
            this.labelstate.TabIndex = 0;
            this.labelstate.Text = "label1";
            this.labelstate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_chiffre2
            // 
            this.label_chiffre2.BackColor = System.Drawing.SystemColors.Control;
            this.label_chiffre2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.label_chiffre2.Cursor = System.Windows.Forms.Cursors.Default;
            this.label_chiffre2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_chiffre2.Location = new System.Drawing.Point(8, 140);
            this.label_chiffre2.Name = "label_chiffre2";
            this.label_chiffre2.ReadOnly = true;
            this.label_chiffre2.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.label_chiffre2.Size = new System.Drawing.Size(117, 62);
            this.label_chiffre2.TabIndex = 11;
            this.label_chiffre2.Text = "";
            this.label_chiffre2.Enter += new System.EventHandler(this.label_chiifre1_Enter);
            // 
            // label_chiifre1
            // 
            this.label_chiifre1.BackColor = System.Drawing.SystemColors.Control;
            this.label_chiifre1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.label_chiifre1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label_chiifre1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_chiifre1.Location = new System.Drawing.Point(8, 62);
            this.label_chiifre1.Name = "label_chiifre1";
            this.label_chiifre1.ReadOnly = true;
            this.label_chiifre1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.label_chiifre1.Size = new System.Drawing.Size(117, 71);
            this.label_chiifre1.TabIndex = 10;
            this.label_chiifre1.Text = "";
            this.label_chiifre1.Enter += new System.EventHandler(this.label_chiifre1_Enter);
            // 
            // comboBox_sousProj
            // 
            this.comboBox_sousProj.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_sousProj.FormattingEnabled = true;
            this.comboBox_sousProj.Items.AddRange(new object[] {
            "Tous"});
            this.comboBox_sousProj.Location = new System.Drawing.Point(7, 216);
            this.comboBox_sousProj.Name = "comboBox_sousProj";
            this.comboBox_sousProj.Size = new System.Drawing.Size(121, 21);
            this.comboBox_sousProj.TabIndex = 8;
            this.comboBox_sousProj.SelectedIndexChanged += new System.EventHandler(this.comboBox_sousProj_SelectedIndexChanged);
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(11, 119);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(111, 35);
            this.bunifuSeparator1.TabIndex = 9;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // UserControl_Statistic_priorité_chiffre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel_etat);
            this.Controls.Add(this.label_chiffre2);
            this.Controls.Add(this.label_chiifre1);
            this.Controls.Add(this.comboBox_sousProj);
            this.Controls.Add(this.bunifuSeparator1);
            this.Name = "UserControl_Statistic_priorité_chiffre";
            this.Size = new System.Drawing.Size(135, 242);
            this.Load += new System.EventHandler(this.UserControl_Statistic_priorité_chiffre_Load);
            this.panel_etat.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_etat;
        private System.Windows.Forms.Label labelstate;
        private System.Windows.Forms.RichTextBox label_chiffre2;
        private System.Windows.Forms.RichTextBox label_chiifre1;
        private System.Windows.Forms.ComboBox comboBox_sousProj;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
    }
}
