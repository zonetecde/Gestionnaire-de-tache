namespace Gestionnaire_de_tâche__Last_
{
    partial class Statistique_nombre
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Statistique_nombre));
            this.panel_state = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label_statut = new System.Windows.Forms.Label();
            this.Switch_ = new Bunifu.Framework.UI.BunifuiOSSwitch();
            this.checkBox_onlyMoreThan0 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // panel_state
            // 
            this.panel_state.AutoScroll = true;
            this.panel_state.Location = new System.Drawing.Point(10, 55);
            this.panel_state.Margin = new System.Windows.Forms.Padding(2);
            this.panel_state.Name = "panel_state";
            this.panel_state.Size = new System.Drawing.Size(581, 300);
            this.panel_state.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(207, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "Priorité";
            // 
            // label_statut
            // 
            this.label_statut.AutoSize = true;
            this.label_statut.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_statut.Location = new System.Drawing.Point(329, 18);
            this.label_statut.Name = "label_statut";
            this.label_statut.Size = new System.Drawing.Size(59, 18);
            this.label_statut.TabIndex = 6;
            this.label_statut.Text = "Statut";
            // 
            // Switch_
            // 
            this.Switch_.BackColor = System.Drawing.Color.Transparent;
            this.Switch_.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Switch_.BackgroundImage")));
            this.Switch_.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Switch_.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Switch_.Location = new System.Drawing.Point(280, 15);
            this.Switch_.Margin = new System.Windows.Forms.Padding(4);
            this.Switch_.Name = "Switch_";
            this.Switch_.OffColor = System.Drawing.Color.Fuchsia;
            this.Switch_.OnColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Switch_.Size = new System.Drawing.Size(43, 25);
            this.Switch_.TabIndex = 5;
            this.Switch_.Value = true;
            this.Switch_.OnValueChange += new System.EventHandler(this.Switch__OnValueChange);
            // 
            // checkBox_onlyMoreThan0
            // 
            this.checkBox_onlyMoreThan0.AutoSize = true;
            this.checkBox_onlyMoreThan0.Font = new System.Drawing.Font("Verdana", 10F);
            this.checkBox_onlyMoreThan0.Location = new System.Drawing.Point(10, 357);
            this.checkBox_onlyMoreThan0.Name = "checkBox_onlyMoreThan0";
            this.checkBox_onlyMoreThan0.Size = new System.Drawing.Size(210, 21);
            this.checkBox_onlyMoreThan0.TabIndex = 8;
            this.checkBox_onlyMoreThan0.Text = "Uniquement ceux utilisées";
            this.checkBox_onlyMoreThan0.UseVisualStyleBackColor = true;
            this.checkBox_onlyMoreThan0.CheckedChanged += new System.EventHandler(this.checkBox_onlyMoreThan0_CheckedChanged);
            // 
            // Statistique_nombre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 380);
            this.Controls.Add(this.checkBox_onlyMoreThan0);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_statut);
            this.Controls.Add(this.Switch_);
            this.Controls.Add(this.panel_state);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Statistique_nombre";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Statistiques (nombre)";
            this.Load += new System.EventHandler(this.Statistique_nombre_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_state;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_statut;
        private Bunifu.Framework.UI.BunifuiOSSwitch Switch_;
        private System.Windows.Forms.CheckBox checkBox_onlyMoreThan0;
    }
}