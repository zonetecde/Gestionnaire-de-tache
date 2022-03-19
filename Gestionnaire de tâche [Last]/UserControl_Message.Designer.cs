namespace Gestionnaire_de_tâche__Last_
{
    partial class UserControl_Message
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
            this.components = new System.ComponentModel.Container();
            this.label_objet = new System.Windows.Forms.Label();
            this.contextMenuStrip_option = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.modifierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supprimerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label_chevron = new System.Windows.Forms.Label();
            this.label_createThe = new System.Windows.Forms.Label();
            this.label_modifiyThe = new System.Windows.Forms.Label();
            this.panel_statutColor = new System.Windows.Forms.Panel();
            this.label_statutTexte = new System.Windows.Forms.Label();
            this.groupBox_img = new System.Windows.Forms.Panel();
            this.richTextBox_message = new System.Windows.Forms.RichTextBox();
            this.contextMenuStrip_option.SuspendLayout();
            this.panel_statutColor.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_objet
            // 
            this.label_objet.AutoSize = true;
            this.label_objet.ContextMenuStrip = this.contextMenuStrip_option;
            this.label_objet.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_objet.Location = new System.Drawing.Point(31, 5);
            this.label_objet.Name = "label_objet";
            this.label_objet.Size = new System.Drawing.Size(254, 18);
            this.label_objet.TabIndex = 0;
            this.label_objet.Text = "Ceci est un objet de message";
            // 
            // contextMenuStrip_option
            // 
            this.contextMenuStrip_option.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modifierToolStripMenuItem,
            this.supprimerToolStripMenuItem});
            this.contextMenuStrip_option.Name = "contextMenuStrip_option";
            this.contextMenuStrip_option.Size = new System.Drawing.Size(130, 48);
            // 
            // modifierToolStripMenuItem
            // 
            this.modifierToolStripMenuItem.Image = global::Gestionnaire_de_tâche__Last_.Properties.Resources.modify;
            this.modifierToolStripMenuItem.Name = "modifierToolStripMenuItem";
            this.modifierToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.modifierToolStripMenuItem.Text = "Modifier";
            this.modifierToolStripMenuItem.Click += new System.EventHandler(this.modifierToolStripMenuItem_Click);
            // 
            // supprimerToolStripMenuItem
            // 
            this.supprimerToolStripMenuItem.Image = global::Gestionnaire_de_tâche__Last_.Properties.Resources.delete_trash;
            this.supprimerToolStripMenuItem.Name = "supprimerToolStripMenuItem";
            this.supprimerToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.supprimerToolStripMenuItem.Text = "Supprimer";
            this.supprimerToolStripMenuItem.Click += new System.EventHandler(this.supprimerToolStripMenuItem_Click);
            // 
            // label_chevron
            // 
            this.label_chevron.AutoSize = true;
            this.label_chevron.ContextMenuStrip = this.contextMenuStrip_option;
            this.label_chevron.Font = new System.Drawing.Font("Verdana", 15F);
            this.label_chevron.Location = new System.Drawing.Point(8, 0);
            this.label_chevron.Name = "label_chevron";
            this.label_chevron.Size = new System.Drawing.Size(25, 25);
            this.label_chevron.TabIndex = 1;
            this.label_chevron.Text = "»";
            // 
            // label_createThe
            // 
            this.label_createThe.AutoSize = true;
            this.label_createThe.Font = new System.Drawing.Font("Yu Gothic", 7.75F);
            this.label_createThe.Location = new System.Drawing.Point(3, 225);
            this.label_createThe.Name = "label_createThe";
            this.label_createThe.Size = new System.Drawing.Size(49, 14);
            this.label_createThe.TabIndex = 6;
            this.label_createThe.Text = "Crée le :";
            // 
            // label_modifiyThe
            // 
            this.label_modifiyThe.AutoSize = true;
            this.label_modifiyThe.ContextMenuStrip = this.contextMenuStrip_option;
            this.label_modifiyThe.Font = new System.Drawing.Font("Yu Gothic", 7.75F);
            this.label_modifiyThe.Location = new System.Drawing.Point(3, 237);
            this.label_modifiyThe.Name = "label_modifiyThe";
            this.label_modifiyThe.Size = new System.Drawing.Size(67, 14);
            this.label_modifiyThe.TabIndex = 7;
            this.label_modifiyThe.Text = "Modifier le :";
            this.label_modifiyThe.Visible = false;
            // 
            // panel_statutColor
            // 
            this.panel_statutColor.Controls.Add(this.label_statutTexte);
            this.panel_statutColor.Location = new System.Drawing.Point(377, 3);
            this.panel_statutColor.Name = "panel_statutColor";
            this.panel_statutColor.Size = new System.Drawing.Size(110, 32);
            this.panel_statutColor.TabIndex = 9;
            this.panel_statutColor.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_statutColor_Paint);
            // 
            // label_statutTexte
            // 
            this.label_statutTexte.ContextMenuStrip = this.contextMenuStrip_option;
            this.label_statutTexte.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_statutTexte.Location = new System.Drawing.Point(0, 0);
            this.label_statutTexte.Name = "label_statutTexte";
            this.label_statutTexte.Size = new System.Drawing.Size(110, 32);
            this.label_statutTexte.TabIndex = 0;
            this.label_statutTexte.Text = "label_satutText";
            this.label_statutTexte.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox_img
            // 
            this.groupBox_img.AutoScroll = true;
            this.groupBox_img.ContextMenuStrip = this.contextMenuStrip_option;
            this.groupBox_img.Location = new System.Drawing.Point(0, 154);
            this.groupBox_img.Name = "groupBox_img";
            this.groupBox_img.Size = new System.Drawing.Size(493, 63);
            this.groupBox_img.TabIndex = 0;
            // 
            // richTextBox_message
            // 
            this.richTextBox_message.BackColor = System.Drawing.Color.White;
            this.richTextBox_message.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox_message.ContextMenuStrip = this.contextMenuStrip_option;
            this.richTextBox_message.Cursor = System.Windows.Forms.Cursors.Default;
            this.richTextBox_message.Enabled = false;
            this.richTextBox_message.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.richTextBox_message.Location = new System.Drawing.Point(3, 38);
            this.richTextBox_message.Name = "richTextBox_message";
            this.richTextBox_message.ReadOnly = true;
            this.richTextBox_message.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.richTextBox_message.Size = new System.Drawing.Size(490, 110);
            this.richTextBox_message.TabIndex = 3;
            this.richTextBox_message.TabStop = false;
            this.richTextBox_message.Text = "";
            this.richTextBox_message.ContentsResized += new System.Windows.Forms.ContentsResizedEventHandler(this.richTextBox_message_ContentsResized);
            this.richTextBox_message.MouseEnter += new System.EventHandler(this.richTextBox_message_MouseEnter);
            // 
            // UserControl_Message
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ContextMenuStrip = this.contextMenuStrip_option;
            this.Controls.Add(this.panel_statutColor);
            this.Controls.Add(this.richTextBox_message);
            this.Controls.Add(this.groupBox_img);
            this.Controls.Add(this.label_createThe);
            this.Controls.Add(this.label_chevron);
            this.Controls.Add(this.label_objet);
            this.Controls.Add(this.label_modifiyThe);
            this.Name = "UserControl_Message";
            this.Size = new System.Drawing.Size(492, 254);
            this.Load += new System.EventHandler(this.UserControl_Message_Load);
            this.contextMenuStrip_option.ResumeLayout(false);
            this.panel_statutColor.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_objet;
        private System.Windows.Forms.Label label_chevron;
        private System.Windows.Forms.Label label_createThe;
        private System.Windows.Forms.Label label_modifiyThe;
        private System.Windows.Forms.Panel panel_statutColor;
        private System.Windows.Forms.Label label_statutTexte;
        private System.Windows.Forms.Panel groupBox_img;
        private System.Windows.Forms.RichTextBox richTextBox_message;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip_option;
        private System.Windows.Forms.ToolStripMenuItem modifierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supprimerToolStripMenuItem;
    }
}
