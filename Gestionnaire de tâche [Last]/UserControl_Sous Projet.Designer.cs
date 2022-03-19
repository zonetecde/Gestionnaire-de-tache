using System;

namespace Gestionnaire_de_tâche__Last_
{
    partial class UserControl_Sous_Projet
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
            this.contextMenuStrip_option = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label_nbTache = new System.Windows.Forms.Label();
            this.richtextBox_nom = new System.Windows.Forms.RichTextBox();
            this.textBox_modifyName = new System.Windows.Forms.TextBox();
            this.Button_add = new Bunifu.Framework.UI.BunifuImageButton();
            this.supprimerCetteSousTâcheToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.éditerCetteSousTâcheToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dupliquerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.collerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox_view = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip_option.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Button_add)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_view)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip_option
            // 
            this.contextMenuStrip_option.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.supprimerCetteSousTâcheToolStripMenuItem,
            this.éditerCetteSousTâcheToolStripMenuItem,
            this.dupliquerToolStripMenuItem,
            this.collerToolStripMenuItem,
            this.copierToolStripMenuItem});
            this.contextMenuStrip_option.Name = "contextMenuStrip_option";
            this.contextMenuStrip_option.Size = new System.Drawing.Size(206, 136);
            this.contextMenuStrip_option.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip_option_Opening);
            // 
            // label_nbTache
            // 
            this.label_nbTache.ContextMenuStrip = this.contextMenuStrip_option;
            this.label_nbTache.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_nbTache.Location = new System.Drawing.Point(785, 0);
            this.label_nbTache.Name = "label_nbTache";
            this.label_nbTache.Size = new System.Drawing.Size(148, 38);
            this.label_nbTache.TabIndex = 2;
            this.label_nbTache.Text = "Aucune tâche";
            this.label_nbTache.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label_nbTache.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label_nbTache_MouseDown);
            this.label_nbTache.MouseHover += new System.EventHandler(this.richtextBox_nom_MouseHover);
            // 
            // richtextBox_nom
            // 
            this.richtextBox_nom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richtextBox_nom.ContextMenuStrip = this.contextMenuStrip_option;
            this.richtextBox_nom.Cursor = System.Windows.Forms.Cursors.Default;
            this.richtextBox_nom.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richtextBox_nom.Location = new System.Drawing.Point(48, 6);
            this.richtextBox_nom.Name = "richtextBox_nom";
            this.richtextBox_nom.ReadOnly = true;
            this.richtextBox_nom.Size = new System.Drawing.Size(936, 28);
            this.richtextBox_nom.TabIndex = 5;
            this.richtextBox_nom.Text = "Nom du sou projet";
            this.richtextBox_nom.DoubleClick += new System.EventHandler(this.richtextBox_nom_DoubleClick);
            this.richtextBox_nom.MouseDown += new System.Windows.Forms.MouseEventHandler(this.richtextBox_nom_MouseDown);
            this.richtextBox_nom.MouseEnter += new System.EventHandler(this.richtextBox_nom_MouseEnter);
            this.richtextBox_nom.MouseLeave += new System.EventHandler(this.richtextBox_nom_MouseLeave);
            this.richtextBox_nom.MouseHover += new System.EventHandler(this.richtextBox_nom_MouseHover);
            // 
            // textBox_modifyName
            // 
            this.textBox_modifyName.Font = new System.Drawing.Font("Verdana", 14.25F);
            this.textBox_modifyName.Location = new System.Drawing.Point(48, 4);
            this.textBox_modifyName.Name = "textBox_modifyName";
            this.textBox_modifyName.Size = new System.Drawing.Size(741, 31);
            this.textBox_modifyName.TabIndex = 6;
            this.textBox_modifyName.Visible = false;
            this.textBox_modifyName.Enter += new System.EventHandler(this.textBox_modifyName_Enter);
            this.textBox_modifyName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_modifyName_KeyDown);
            this.textBox_modifyName.Leave += new System.EventHandler(this.textBox_modifyName_Leave);
            // 
            // Button_add
            // 
            this.Button_add.BackColor = System.Drawing.Color.Transparent;
            this.Button_add.ContextMenuStrip = this.contextMenuStrip_option;
            this.Button_add.Image = global::Gestionnaire_de_tâche__Last_.Properties.Resources.add2;
            this.Button_add.ImageActive = null;
            this.Button_add.Location = new System.Drawing.Point(934, 0);
            this.Button_add.Name = "Button_add";
            this.Button_add.Size = new System.Drawing.Size(46, 38);
            this.Button_add.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Button_add.TabIndex = 4;
            this.Button_add.TabStop = false;
            this.Button_add.Zoom = 10;
            this.Button_add.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label_nbTache_MouseDown);
            // 
            // supprimerCetteSousTâcheToolStripMenuItem
            // 
            this.supprimerCetteSousTâcheToolStripMenuItem.Image = global::Gestionnaire_de_tâche__Last_.Properties.Resources.delete_trash;
            this.supprimerCetteSousTâcheToolStripMenuItem.Name = "supprimerCetteSousTâcheToolStripMenuItem";
            this.supprimerCetteSousTâcheToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.supprimerCetteSousTâcheToolStripMenuItem.Text = "Supprimer ce sous projet";
            this.supprimerCetteSousTâcheToolStripMenuItem.Click += new System.EventHandler(this.supprimerCetteSousTâcheToolStripMenuItem_Click);
            // 
            // éditerCetteSousTâcheToolStripMenuItem
            // 
            this.éditerCetteSousTâcheToolStripMenuItem.Image = global::Gestionnaire_de_tâche__Last_.Properties.Resources.modify;
            this.éditerCetteSousTâcheToolStripMenuItem.Name = "éditerCetteSousTâcheToolStripMenuItem";
            this.éditerCetteSousTâcheToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.éditerCetteSousTâcheToolStripMenuItem.Text = "Éditer ce sous projet";
            this.éditerCetteSousTâcheToolStripMenuItem.Click += new System.EventHandler(this.éditerCetteSousTâcheToolStripMenuItem_Click);
            // 
            // dupliquerToolStripMenuItem
            // 
            this.dupliquerToolStripMenuItem.Image = global::Gestionnaire_de_tâche__Last_.Properties.Resources.duplicate;
            this.dupliquerToolStripMenuItem.Name = "dupliquerToolStripMenuItem";
            this.dupliquerToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.dupliquerToolStripMenuItem.Text = "Dupliquer";
            this.dupliquerToolStripMenuItem.Click += new System.EventHandler(this.dupliquerToolStripMenuItem_Click);
            // 
            // collerToolStripMenuItem
            // 
            this.collerToolStripMenuItem.Image = global::Gestionnaire_de_tâche__Last_.Properties.Resources.paste1;
            this.collerToolStripMenuItem.Name = "collerToolStripMenuItem";
            this.collerToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.collerToolStripMenuItem.Text = "Coller la tâche";
            this.collerToolStripMenuItem.Click += new System.EventHandler(this.collerToolStripMenuItem_Click);
            // 
            // copierToolStripMenuItem
            // 
            this.copierToolStripMenuItem.Image = global::Gestionnaire_de_tâche__Last_.Properties.Resources.copy1;
            this.copierToolStripMenuItem.Name = "copierToolStripMenuItem";
            this.copierToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.copierToolStripMenuItem.Text = "Copier";
            this.copierToolStripMenuItem.Click += new System.EventHandler(this.copierToolStripMenuItem_Click);
            // 
            // pictureBox_view
            // 
            this.pictureBox_view.ContextMenuStrip = this.contextMenuStrip_option;
            this.pictureBox_view.Image = global::Gestionnaire_de_tâche__Last_.Properties.Resources.view_down;
            this.pictureBox_view.Location = new System.Drawing.Point(-4, 0);
            this.pictureBox_view.Name = "pictureBox_view";
            this.pictureBox_view.Size = new System.Drawing.Size(46, 38);
            this.pictureBox_view.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_view.TabIndex = 0;
            this.pictureBox_view.TabStop = false;
            this.pictureBox_view.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox_view_MouseDown);
            this.pictureBox_view.MouseHover += new System.EventHandler(this.richtextBox_nom_MouseHover);
            // 
            // UserControl_Sous_Projet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBox_modifyName);
            this.Controls.Add(this.Button_add);
            this.Controls.Add(this.label_nbTache);
            this.Controls.Add(this.pictureBox_view);
            this.Controls.Add(this.richtextBox_nom);
            this.Name = "UserControl_Sous_Projet";
            this.Size = new System.Drawing.Size(984, 38);
            this.Load += new System.EventHandler(this.UserControl_Sous_Projet_Load);
            this.contextMenuStrip_option.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Button_add)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_view)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.PictureBox pictureBox_view;
        private System.Windows.Forms.Label label_nbTache;
        private Bunifu.Framework.UI.BunifuImageButton Button_add;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip_option;
        private System.Windows.Forms.ToolStripMenuItem supprimerCetteSousTâcheToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem éditerCetteSousTâcheToolStripMenuItem;
        private System.Windows.Forms.RichTextBox richtextBox_nom;
        private System.Windows.Forms.ToolStripMenuItem dupliquerToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox_modifyName;
        private System.Windows.Forms.ToolStripMenuItem collerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copierToolStripMenuItem;
    }
}
