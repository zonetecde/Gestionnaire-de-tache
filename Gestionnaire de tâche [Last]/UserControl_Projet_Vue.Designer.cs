namespace Gestionnaire_de_tâche__Last_
{
    partial class UserControl_Projet_Vue
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl_Projet_Vue));
            this.label_projectName = new System.Windows.Forms.Label();
            this.bunifuSeparator = new Bunifu.Framework.UI.BunifuSeparator();
            this.richTextBox_desc = new System.Windows.Forms.RichTextBox();
            this.bunifuSeparator2 = new Bunifu.Framework.UI.BunifuSeparator();
            this.labelsousProjet_Count = new System.Windows.Forms.Label();
            this.pictureBox_exporte = new System.Windows.Forms.PictureBox();
            this.pictureBox_order = new System.Windows.Forms.PictureBox();
            this.Btn_exe = new Bunifu.Framework.UI.BunifuImageButton();
            this.Btn_Ouvrir_VS = new Bunifu.Framework.UI.BunifuImageButton();
            this.pictureBox_static = new System.Windows.Forms.PictureBox();
            this.textBpx_search = new Bunifu.Framework.UI.BunifuTextbox();
            this.PictureBox_edit = new Bunifu.Framework.UI.BunifuImageButton();
            this.pictureBox_delete = new Bunifu.Framework.UI.BunifuImageButton();
            this.Button_addSousProjet = new Bunifu.Framework.UI.BunifuFlatButton();
            this.contextMenuStrip_options = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.collerLeSousProjetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_exporte)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_order)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_exe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Ouvrir_VS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_static)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_edit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_delete)).BeginInit();
            this.contextMenuStrip_options.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_projectName
            // 
            this.label_projectName.AutoSize = true;
            this.label_projectName.ContextMenuStrip = this.contextMenuStrip_options;
            this.label_projectName.Font = new System.Drawing.Font("Verdana", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_projectName.Location = new System.Drawing.Point(48, 0);
            this.label_projectName.Name = "label_projectName";
            this.label_projectName.Size = new System.Drawing.Size(263, 35);
            this.label_projectName.TabIndex = 0;
            this.label_projectName.Text = "Le nom du Projet";
            // 
            // bunifuSeparator
            // 
            this.bunifuSeparator.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator.ContextMenuStrip = this.contextMenuStrip_options;
            this.bunifuSeparator.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator.LineThickness = 2;
            this.bunifuSeparator.Location = new System.Drawing.Point(54, 22);
            this.bunifuSeparator.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuSeparator.Name = "bunifuSeparator";
            this.bunifuSeparator.Size = new System.Drawing.Size(585, 35);
            this.bunifuSeparator.TabIndex = 1;
            this.bunifuSeparator.Transparency = 255;
            this.bunifuSeparator.Vertical = false;
            // 
            // richTextBox_desc
            // 
            this.richTextBox_desc.BackColor = System.Drawing.Color.White;
            this.richTextBox_desc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox_desc.ContextMenuStrip = this.contextMenuStrip_options;
            this.richTextBox_desc.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox_desc.Location = new System.Drawing.Point(54, 46);
            this.richTextBox_desc.Name = "richTextBox_desc";
            this.richTextBox_desc.ReadOnly = true;
            this.richTextBox_desc.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.richTextBox_desc.Size = new System.Drawing.Size(912, 70);
            this.richTextBox_desc.TabIndex = 2;
            this.richTextBox_desc.Text = "Aucun description";
            // 
            // bunifuSeparator2
            // 
            this.bunifuSeparator2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator2.LineThickness = 2;
            this.bunifuSeparator2.Location = new System.Drawing.Point(35, 0);
            this.bunifuSeparator2.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuSeparator2.Name = "bunifuSeparator2";
            this.bunifuSeparator2.Size = new System.Drawing.Size(18, 158);
            this.bunifuSeparator2.TabIndex = 5;
            this.bunifuSeparator2.Transparency = 255;
            this.bunifuSeparator2.Vertical = true;
            // 
            // labelsousProjet_Count
            // 
            this.labelsousProjet_Count.AutoSize = true;
            this.labelsousProjet_Count.ContextMenuStrip = this.contextMenuStrip_options;
            this.labelsousProjet_Count.Font = new System.Drawing.Font("Verdana", 8.8F);
            this.labelsousProjet_Count.Location = new System.Drawing.Point(59, 125);
            this.labelsousProjet_Count.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelsousProjet_Count.Name = "labelsousProjet_Count";
            this.labelsousProjet_Count.Size = new System.Drawing.Size(146, 14);
            this.labelsousProjet_Count.TabIndex = 11;
            this.labelsousProjet_Count.Text = "X sous projet, X tâche";
            // 
            // pictureBox_exporte
            // 
            this.pictureBox_exporte.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_exporte.ContextMenuStrip = this.contextMenuStrip_options;
            this.pictureBox_exporte.Image = global::Gestionnaire_de_tâche__Last_.Properties.Resources.exporter;
            this.pictureBox_exporte.Location = new System.Drawing.Point(624, 1);
            this.pictureBox_exporte.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox_exporte.Name = "pictureBox_exporte";
            this.pictureBox_exporte.Size = new System.Drawing.Size(48, 41);
            this.pictureBox_exporte.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_exporte.TabIndex = 16;
            this.pictureBox_exporte.TabStop = false;
            this.pictureBox_exporte.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox_exporte_MouseDown);
            // 
            // pictureBox_order
            // 
            this.pictureBox_order.ContextMenuStrip = this.contextMenuStrip_options;
            this.pictureBox_order.Image = global::Gestionnaire_de_tâche__Last_.Properties.Resources.icons8_alphabetical_sorting_96px;
            this.pictureBox_order.Location = new System.Drawing.Point(668, 1);
            this.pictureBox_order.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox_order.Name = "pictureBox_order";
            this.pictureBox_order.Size = new System.Drawing.Size(48, 41);
            this.pictureBox_order.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_order.TabIndex = 15;
            this.pictureBox_order.TabStop = false;
            this.pictureBox_order.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox_order_MouseDown);
            // 
            // Btn_exe
            // 
            this.Btn_exe.BackColor = System.Drawing.Color.Transparent;
            this.Btn_exe.Image = global::Gestionnaire_de_tâche__Last_.Properties.Resources.play1;
            this.Btn_exe.ImageActive = null;
            this.Btn_exe.Location = new System.Drawing.Point(3, 82);
            this.Btn_exe.Name = "Btn_exe";
            this.Btn_exe.Size = new System.Drawing.Size(38, 38);
            this.Btn_exe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Btn_exe.TabIndex = 14;
            this.Btn_exe.TabStop = false;
            this.Btn_exe.Visible = false;
            this.Btn_exe.Zoom = 10;
            this.Btn_exe.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Btn_exe_MouseDown);
            // 
            // Btn_Ouvrir_VS
            // 
            this.Btn_Ouvrir_VS.BackColor = System.Drawing.Color.Transparent;
            this.Btn_Ouvrir_VS.Image = global::Gestionnaire_de_tâche__Last_.Properties.Resources.VS;
            this.Btn_Ouvrir_VS.ImageActive = null;
            this.Btn_Ouvrir_VS.Location = new System.Drawing.Point(3, 42);
            this.Btn_Ouvrir_VS.Name = "Btn_Ouvrir_VS";
            this.Btn_Ouvrir_VS.Size = new System.Drawing.Size(38, 38);
            this.Btn_Ouvrir_VS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Btn_Ouvrir_VS.TabIndex = 13;
            this.Btn_Ouvrir_VS.TabStop = false;
            this.Btn_Ouvrir_VS.Visible = false;
            this.Btn_Ouvrir_VS.Zoom = 10;
            this.Btn_Ouvrir_VS.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Btn_Ouvrir_VS_MouseDown);
            // 
            // pictureBox_static
            // 
            this.pictureBox_static.ContextMenuStrip = this.contextMenuStrip_options;
            this.pictureBox_static.Image = global::Gestionnaire_de_tâche__Last_.Properties.Resources.statostic;
            this.pictureBox_static.Location = new System.Drawing.Point(714, 1);
            this.pictureBox_static.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox_static.Name = "pictureBox_static";
            this.pictureBox_static.Size = new System.Drawing.Size(48, 41);
            this.pictureBox_static.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_static.TabIndex = 12;
            this.pictureBox_static.TabStop = false;
            this.pictureBox_static.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox_static_MouseDown);
            // 
            // textBpx_search
            // 
            this.textBpx_search.BackColor = System.Drawing.Color.White;
            this.textBpx_search.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("textBpx_search.BackgroundImage")));
            this.textBpx_search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.textBpx_search.ForeColor = System.Drawing.Color.Black;
            this.textBpx_search.Icon = ((System.Drawing.Image)(resources.GetObject("textBpx_search.Icon")));
            this.textBpx_search.Location = new System.Drawing.Point(764, 2);
            this.textBpx_search.Name = "textBpx_search";
            this.textBpx_search.Size = new System.Drawing.Size(201, 40);
            this.textBpx_search.TabIndex = 10;
            this.textBpx_search.text = "Rechercher...";
            this.textBpx_search.OnTextChange += new System.EventHandler(this.textBpx_search_OnTextChange);
            this.textBpx_search.Enter += new System.EventHandler(this.textBpx_search_Enter);
            this.textBpx_search.Leave += new System.EventHandler(this.textBpx_search_Leave);
            // 
            // PictureBox_edit
            // 
            this.PictureBox_edit.BackColor = System.Drawing.Color.Transparent;
            this.PictureBox_edit.Image = global::Gestionnaire_de_tâche__Last_.Properties.Resources.modify;
            this.PictureBox_edit.ImageActive = null;
            this.PictureBox_edit.Location = new System.Drawing.Point(3, 3);
            this.PictureBox_edit.Name = "PictureBox_edit";
            this.PictureBox_edit.Size = new System.Drawing.Size(38, 38);
            this.PictureBox_edit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBox_edit.TabIndex = 9;
            this.PictureBox_edit.TabStop = false;
            this.PictureBox_edit.Zoom = 10;
            this.PictureBox_edit.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PictureBox_edit_MouseDown);
            // 
            // pictureBox_delete
            // 
            this.pictureBox_delete.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_delete.Image = global::Gestionnaire_de_tâche__Last_.Properties.Resources.delete_trash;
            this.pictureBox_delete.ImageActive = null;
            this.pictureBox_delete.Location = new System.Drawing.Point(3, 118);
            this.pictureBox_delete.Name = "pictureBox_delete";
            this.pictureBox_delete.Size = new System.Drawing.Size(38, 38);
            this.pictureBox_delete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_delete.TabIndex = 8;
            this.pictureBox_delete.TabStop = false;
            this.pictureBox_delete.Zoom = 10;
            this.pictureBox_delete.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox_delete_MouseDown);
            // 
            // Button_addSousProjet
            // 
            this.Button_addSousProjet.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Button_addSousProjet.BackColor = System.Drawing.Color.Transparent;
            this.Button_addSousProjet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Button_addSousProjet.BorderRadius = 0;
            this.Button_addSousProjet.ButtonText = "Ajouter un sous projet";
            this.Button_addSousProjet.ContextMenuStrip = this.contextMenuStrip_options;
            this.Button_addSousProjet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_addSousProjet.DisabledColor = System.Drawing.Color.Gray;
            this.Button_addSousProjet.Iconcolor = System.Drawing.Color.Transparent;
            this.Button_addSousProjet.Iconimage = null;
            this.Button_addSousProjet.Iconimage_right = global::Gestionnaire_de_tâche__Last_.Properties.Resources.add2;
            this.Button_addSousProjet.Iconimage_right_Selected = null;
            this.Button_addSousProjet.Iconimage_Selected = null;
            this.Button_addSousProjet.IconMarginLeft = 0;
            this.Button_addSousProjet.IconMarginRight = 0;
            this.Button_addSousProjet.IconRightVisible = true;
            this.Button_addSousProjet.IconRightZoom = 0D;
            this.Button_addSousProjet.IconVisible = true;
            this.Button_addSousProjet.IconZoom = 90D;
            this.Button_addSousProjet.IsTab = false;
            this.Button_addSousProjet.Location = new System.Drawing.Point(695, 118);
            this.Button_addSousProjet.Margin = new System.Windows.Forms.Padding(4);
            this.Button_addSousProjet.Name = "Button_addSousProjet";
            this.Button_addSousProjet.Normalcolor = System.Drawing.Color.Transparent;
            this.Button_addSousProjet.OnHovercolor = System.Drawing.Color.Transparent;
            this.Button_addSousProjet.OnHoverTextColor = System.Drawing.Color.Maroon;
            this.Button_addSousProjet.selected = false;
            this.Button_addSousProjet.Size = new System.Drawing.Size(272, 40);
            this.Button_addSousProjet.TabIndex = 3;
            this.Button_addSousProjet.Text = "Ajouter un sous projet";
            this.Button_addSousProjet.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Button_addSousProjet.Textcolor = System.Drawing.Color.Black;
            this.Button_addSousProjet.TextFont = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_addSousProjet.MouseDown += new System.EventHandler(this.Button_addSousProjet_MouseDown);
            this.Button_addSousProjet.Click += new System.EventHandler(this.Button_addSousProjet_Click);
            // 
            // contextMenuStrip_options
            // 
            this.contextMenuStrip_options.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.collerLeSousProjetToolStripMenuItem});
            this.contextMenuStrip_options.Name = "contextMenuStrip_options";
            this.contextMenuStrip_options.Size = new System.Drawing.Size(181, 48);
            this.contextMenuStrip_options.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip_options_Opening);
            // 
            // collerLeSousProjetToolStripMenuItem
            // 
            this.collerLeSousProjetToolStripMenuItem.Image = global::Gestionnaire_de_tâche__Last_.Properties.Resources.paste1;
            this.collerLeSousProjetToolStripMenuItem.Name = "collerLeSousProjetToolStripMenuItem";
            this.collerLeSousProjetToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.collerLeSousProjetToolStripMenuItem.Text = "Coller le sous projet";
            this.collerLeSousProjetToolStripMenuItem.Click += new System.EventHandler(this.collerLeSousProjetToolStripMenuItem_Click);
            // 
            // UserControl_Projet_Vue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ContextMenuStrip = this.contextMenuStrip_options;
            this.Controls.Add(this.pictureBox_exporte);
            this.Controls.Add(this.pictureBox_order);
            this.Controls.Add(this.Btn_exe);
            this.Controls.Add(this.Btn_Ouvrir_VS);
            this.Controls.Add(this.pictureBox_static);
            this.Controls.Add(this.labelsousProjet_Count);
            this.Controls.Add(this.textBpx_search);
            this.Controls.Add(this.PictureBox_edit);
            this.Controls.Add(this.pictureBox_delete);
            this.Controls.Add(this.bunifuSeparator2);
            this.Controls.Add(this.Button_addSousProjet);
            this.Controls.Add(this.richTextBox_desc);
            this.Controls.Add(this.label_projectName);
            this.Controls.Add(this.bunifuSeparator);
            this.Name = "UserControl_Projet_Vue";
            this.Size = new System.Drawing.Size(973, 159);
            this.Load += new System.EventHandler(this.UserControl_Projet_Vue_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_exporte)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_order)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_exe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Ouvrir_VS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_static)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_edit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_delete)).EndInit();
            this.contextMenuStrip_options.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_projectName;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator;
        private System.Windows.Forms.RichTextBox richTextBox_desc;
        private Bunifu.Framework.UI.BunifuFlatButton Button_addSousProjet;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator2;
        private Bunifu.Framework.UI.BunifuImageButton PictureBox_edit;
        private Bunifu.Framework.UI.BunifuImageButton pictureBox_delete;
        private Bunifu.Framework.UI.BunifuTextbox textBpx_search;
        private System.Windows.Forms.Label labelsousProjet_Count;
        private System.Windows.Forms.PictureBox pictureBox_static;
        private Bunifu.Framework.UI.BunifuImageButton Btn_Ouvrir_VS;
        private Bunifu.Framework.UI.BunifuImageButton Btn_exe;
        private System.Windows.Forms.PictureBox pictureBox_order;
        private System.Windows.Forms.PictureBox pictureBox_exporte;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip_options;
        private System.Windows.Forms.ToolStripMenuItem collerLeSousProjetToolStripMenuItem;
    }
}
