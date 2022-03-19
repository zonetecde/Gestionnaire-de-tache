namespace Gestionnaire_de_tâche__Last_
{
    partial class UserControl_Projet
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
            this.label_title = new System.Windows.Forms.Label();
            this.contextMenuStrip_options = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.modifierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supprimerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel_color = new System.Windows.Forms.Panel();
            this.contextMenuStrip_options.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_title
            // 
            this.label_title.ContextMenuStrip = this.contextMenuStrip_options;
            this.label_title.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_title.Location = new System.Drawing.Point(15, 0);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(214, 88);
            this.label_title.TabIndex = 0;
            this.label_title.Text = "Nom du projet";
            this.label_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_title.MouseDown += new System.Windows.Forms.MouseEventHandler(this.UserControl_Projet_MouseDown);
            this.label_title.MouseEnter += new System.EventHandler(this.label_title_MouseEnter);
            this.label_title.MouseLeave += new System.EventHandler(this.label_title_MouseLeave);
            this.label_title.MouseUp += new System.Windows.Forms.MouseEventHandler(this.UserControl_Projet_MouseUp);
            // 
            // contextMenuStrip_options
            // 
            this.contextMenuStrip_options.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modifierToolStripMenuItem,
            this.supprimerToolStripMenuItem});
            this.contextMenuStrip_options.Name = "contextMenuStrip_options";
            this.contextMenuStrip_options.Size = new System.Drawing.Size(130, 48);
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
            // panel_color
            // 
            this.panel_color.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel_color.ContextMenuStrip = this.contextMenuStrip_options;
            this.panel_color.Location = new System.Drawing.Point(0, -7);
            this.panel_color.Name = "panel_color";
            this.panel_color.Size = new System.Drawing.Size(16, 100);
            this.panel_color.TabIndex = 1;
            this.panel_color.MouseDown += new System.Windows.Forms.MouseEventHandler(this.UserControl_Projet_MouseDown);
            this.panel_color.MouseEnter += new System.EventHandler(this.label_title_MouseEnter);
            this.panel_color.MouseLeave += new System.EventHandler(this.label_title_MouseLeave);
            this.panel_color.MouseUp += new System.Windows.Forms.MouseEventHandler(this.UserControl_Projet_MouseUp);
            // 
            // UserControl_Projet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ContextMenuStrip = this.contextMenuStrip_options;
            this.Controls.Add(this.panel_color);
            this.Controls.Add(this.label_title);
            this.Name = "UserControl_Projet";
            this.Size = new System.Drawing.Size(232, 88);
            this.Load += new System.EventHandler(this.UserControl_Projet_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.UserControl_Projet_MouseDown);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.UserControl_Projet_MouseUp);
            this.contextMenuStrip_options.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        #endregion

        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.Panel panel_color;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip_options;
        private System.Windows.Forms.ToolStripMenuItem modifierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supprimerToolStripMenuItem;
    }
}
