namespace Gestionnaire_de_tâche__Last_
{
    partial class UserControl_Tâche
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
            this.contextMenuStrip_optionTache = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panel_color = new System.Windows.Forms.Panel();
            this.bunifuSeparator6 = new Bunifu.Framework.UI.BunifuSeparator();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.bunifuSeparator2 = new Bunifu.Framework.UI.BunifuSeparator();
            this.bunifuSeparator3 = new Bunifu.Framework.UI.BunifuSeparator();
            this.bunifuSeparator4 = new Bunifu.Framework.UI.BunifuSeparator();
            this.bunifuSeparator5 = new Bunifu.Framework.UI.BunifuSeparator();
            this.bunifuSeparator7 = new Bunifu.Framework.UI.BunifuSeparator();
            this.panel_state = new System.Windows.Forms.Panel();
            this.contextMenuStrip_optionsEtat = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panel_priorité = new System.Windows.Forms.Panel();
            this.contextMenuStrip_optionsPriorité = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label_date = new System.Windows.Forms.Label();
            this.contextMenuStrip_date = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.comboBox_motsClés = new System.Windows.Forms.ComboBox();
            this.contextMenuStrip_motsClés = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panel_motClé = new System.Windows.Forms.Panel();
            this.richtextBox_nom = new System.Windows.Forms.RichTextBox();
            this.label_counter = new System.Windows.Forms.Label();
            this.textBox_modify = new System.Windows.Forms.TextBox();
            this.progressBar_progression = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_progressbar = new System.Windows.Forms.Panel();
            this.bunifuSeparator8 = new Bunifu.Framework.UI.BunifuSeparator();
            this.bunifuSeparator9 = new Bunifu.Framework.UI.BunifuSeparator();
            this.richTextBox_texte = new System.Windows.Forms.RichTextBox();
            this.ajouterUnMotCléToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supprimeCeMotCléToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterUneDateDéchéanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supprimerLaDateDéchéanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.appliquerPourTousDansLeSousProjetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PictureBox_tchat = new XanderUI.XUICustomPictureBox();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.dupliquerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip_optionTache.SuspendLayout();
            this.panel_color.SuspendLayout();
            this.contextMenuStrip_optionsEtat.SuspendLayout();
            this.contextMenuStrip_optionsPriorité.SuspendLayout();
            this.contextMenuStrip_date.SuspendLayout();
            this.contextMenuStrip_motsClés.SuspendLayout();
            this.panel_motClé.SuspendLayout();
            this.panel_progressbar.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip_optionTache
            // 
            this.contextMenuStrip_optionTache.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.dupliquerToolStripMenuItem,
            this.copierToolStripMenuItem});
            this.contextMenuStrip_optionTache.Name = "contextMenuStrip_motsClés";
            this.contextMenuStrip_optionTache.Size = new System.Drawing.Size(191, 92);
            // 
            // panel_color
            // 
            this.panel_color.BackColor = System.Drawing.Color.LightGray;
            this.panel_color.Controls.Add(this.bunifuSeparator6);
            this.panel_color.Location = new System.Drawing.Point(10, 0);
            this.panel_color.Name = "panel_color";
            this.panel_color.Size = new System.Drawing.Size(17, 109);
            this.panel_color.TabIndex = 6;
            this.panel_color.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_color_MouseDown);
            this.panel_color.MouseMove += new System.Windows.Forms.MouseEventHandler(this.richtextBox_nom_MouseMove);
            this.panel_color.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel_motClé_MouseUp);
            // 
            // bunifuSeparator6
            // 
            this.bunifuSeparator6.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator6.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator6.LineThickness = 1;
            this.bunifuSeparator6.Location = new System.Drawing.Point(-5, 0);
            this.bunifuSeparator6.Name = "bunifuSeparator6";
            this.bunifuSeparator6.Size = new System.Drawing.Size(10, 106);
            this.bunifuSeparator6.TabIndex = 15;
            this.bunifuSeparator6.Transparency = 255;
            this.bunifuSeparator6.Vertical = true;
            this.bunifuSeparator6.MouseMove += new System.Windows.Forms.MouseEventHandler(this.richtextBox_nom_MouseMove);
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(354, 0);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(10, 109);
            this.bunifuSeparator1.TabIndex = 7;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = true;
            // 
            // bunifuSeparator2
            // 
            this.bunifuSeparator2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator2.LineThickness = 1;
            this.bunifuSeparator2.Location = new System.Drawing.Point(483, 0);
            this.bunifuSeparator2.Name = "bunifuSeparator2";
            this.bunifuSeparator2.Size = new System.Drawing.Size(10, 43);
            this.bunifuSeparator2.TabIndex = 8;
            this.bunifuSeparator2.Transparency = 255;
            this.bunifuSeparator2.Vertical = true;
            // 
            // bunifuSeparator3
            // 
            this.bunifuSeparator3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator3.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator3.LineThickness = 1;
            this.bunifuSeparator3.Location = new System.Drawing.Point(613, -1);
            this.bunifuSeparator3.Name = "bunifuSeparator3";
            this.bunifuSeparator3.Size = new System.Drawing.Size(18, 44);
            this.bunifuSeparator3.TabIndex = 11;
            this.bunifuSeparator3.Transparency = 255;
            this.bunifuSeparator3.Vertical = true;
            // 
            // bunifuSeparator4
            // 
            this.bunifuSeparator4.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator4.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator4.LineThickness = 1;
            this.bunifuSeparator4.Location = new System.Drawing.Point(747, 0);
            this.bunifuSeparator4.Name = "bunifuSeparator4";
            this.bunifuSeparator4.Size = new System.Drawing.Size(18, 43);
            this.bunifuSeparator4.TabIndex = 12;
            this.bunifuSeparator4.Transparency = 255;
            this.bunifuSeparator4.Vertical = true;
            // 
            // bunifuSeparator5
            // 
            this.bunifuSeparator5.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator5.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator5.LineThickness = 1;
            this.bunifuSeparator5.Location = new System.Drawing.Point(882, 0);
            this.bunifuSeparator5.Name = "bunifuSeparator5";
            this.bunifuSeparator5.Size = new System.Drawing.Size(18, 43);
            this.bunifuSeparator5.TabIndex = 13;
            this.bunifuSeparator5.Transparency = 255;
            this.bunifuSeparator5.Vertical = true;
            // 
            // bunifuSeparator7
            // 
            this.bunifuSeparator7.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator7.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator7.LineThickness = 1;
            this.bunifuSeparator7.Location = new System.Drawing.Point(938, 0);
            this.bunifuSeparator7.Name = "bunifuSeparator7";
            this.bunifuSeparator7.Size = new System.Drawing.Size(10, 172);
            this.bunifuSeparator7.TabIndex = 16;
            this.bunifuSeparator7.Transparency = 255;
            this.bunifuSeparator7.Vertical = true;
            // 
            // panel_state
            // 
            this.panel_state.BackColor = System.Drawing.Color.Transparent;
            this.panel_state.ContextMenuStrip = this.contextMenuStrip_optionsEtat;
            this.panel_state.Location = new System.Drawing.Point(490, 3);
            this.panel_state.Name = "panel_state";
            this.panel_state.Size = new System.Drawing.Size(131, 37);
            this.panel_state.TabIndex = 17;
            // 
            // contextMenuStrip_optionsEtat
            // 
            this.contextMenuStrip_optionsEtat.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.appliquerPourTousDansLeSousProjetToolStripMenuItem});
            this.contextMenuStrip_optionsEtat.Name = "contextMenuStrip_optionEtat";
            this.contextMenuStrip_optionsEtat.Size = new System.Drawing.Size(293, 26);
            // 
            // panel_priorité
            // 
            this.panel_priorité.ContextMenuStrip = this.contextMenuStrip_optionsPriorité;
            this.panel_priorité.Location = new System.Drawing.Point(624, 3);
            this.panel_priorité.Name = "panel_priorité";
            this.panel_priorité.Size = new System.Drawing.Size(131, 37);
            this.panel_priorité.TabIndex = 18;
            // 
            // contextMenuStrip_optionsPriorité
            // 
            this.contextMenuStrip_optionsPriorité.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem3});
            this.contextMenuStrip_optionsPriorité.Name = "contextMenuStrip_optionEtat";
            this.contextMenuStrip_optionsPriorité.Size = new System.Drawing.Size(293, 26);
            // 
            // label_date
            // 
            this.label_date.ContextMenuStrip = this.contextMenuStrip_date;
            this.label_date.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_date.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label_date.Location = new System.Drawing.Point(758, 0);
            this.label_date.Name = "label_date";
            this.label_date.Size = new System.Drawing.Size(132, 43);
            this.label_date.TabIndex = 19;
            this.label_date.Text = "06 Septembre";
            this.label_date.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_date.DoubleClick += new System.EventHandler(this.label_date_DoubleClick);
            this.label_date.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label_date_MouseDown);
            this.label_date.MouseHover += new System.EventHandler(this.label_date_MouseHover);
            // 
            // contextMenuStrip_date
            // 
            this.contextMenuStrip_date.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterUneDateDéchéanceToolStripMenuItem,
            this.supprimerLaDateDéchéanceToolStripMenuItem});
            this.contextMenuStrip_date.Name = "contextMenuStrip_date";
            this.contextMenuStrip_date.Size = new System.Drawing.Size(265, 48);
            // 
            // comboBox_motsClés
            // 
            this.comboBox_motsClés.ContextMenuStrip = this.contextMenuStrip_motsClés;
            this.comboBox_motsClés.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_motsClés.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBox_motsClés.ForeColor = System.Drawing.Color.Black;
            this.comboBox_motsClés.FormattingEnabled = true;
            this.comboBox_motsClés.Location = new System.Drawing.Point(2, 12);
            this.comboBox_motsClés.Name = "comboBox_motsClés";
            this.comboBox_motsClés.Size = new System.Drawing.Size(121, 21);
            this.comboBox_motsClés.TabIndex = 20;
            this.comboBox_motsClés.DropDownClosed += new System.EventHandler(this.comboBox_motsClés_DropDownClosed);
            this.comboBox_motsClés.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comboBox_motsClés_KeyDown);
            // 
            // contextMenuStrip_motsClés
            // 
            this.contextMenuStrip_motsClés.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterUnMotCléToolStripMenuItem,
            this.supprimeCeMotCléToolStripMenuItem});
            this.contextMenuStrip_motsClés.Name = "contextMenuStrip_motsClés";
            this.contextMenuStrip_motsClés.Size = new System.Drawing.Size(184, 48);
            // 
            // panel_motClé
            // 
            this.panel_motClé.BackColor = System.Drawing.Color.Transparent;
            this.panel_motClé.ContextMenuStrip = this.contextMenuStrip_motsClés;
            this.panel_motClé.Controls.Add(this.comboBox_motsClés);
            this.panel_motClé.Location = new System.Drawing.Point(362, 0);
            this.panel_motClé.Name = "panel_motClé";
            this.panel_motClé.Size = new System.Drawing.Size(124, 43);
            this.panel_motClé.TabIndex = 18;
            this.panel_motClé.MouseMove += new System.Windows.Forms.MouseEventHandler(this.richtextBox_nom_MouseMove);
            this.panel_motClé.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel_motClé_MouseUp);
            // 
            // richtextBox_nom
            // 
            this.richtextBox_nom.BackColor = System.Drawing.SystemColors.Control;
            this.richtextBox_nom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richtextBox_nom.ContextMenuStrip = this.contextMenuStrip_optionTache;
            this.richtextBox_nom.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.richtextBox_nom.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richtextBox_nom.Location = new System.Drawing.Point(29, 12);
            this.richtextBox_nom.Name = "richtextBox_nom";
            this.richtextBox_nom.ReadOnly = true;
            this.richtextBox_nom.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richtextBox_nom.Size = new System.Drawing.Size(327, 44);
            this.richtextBox_nom.TabIndex = 0;
            this.richtextBox_nom.TabStop = false;
            this.richtextBox_nom.Text = "CECI EST UN";
            this.richtextBox_nom.DoubleClick += new System.EventHandler(this.richtextBox_nom_DoubleClick);
            this.richtextBox_nom.MouseEnter += new System.EventHandler(this.richtextBox_nom_MouseEnter);
            this.richtextBox_nom.MouseLeave += new System.EventHandler(this.richtextBox_nom_MouseLeave);
            this.richtextBox_nom.MouseMove += new System.Windows.Forms.MouseEventHandler(this.richtextBox_nom_MouseMove);
            this.richtextBox_nom.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel_motClé_MouseUp);
            // 
            // label_counter
            // 
            this.label_counter.AutoSize = true;
            this.label_counter.BackColor = System.Drawing.Color.Transparent;
            this.label_counter.Font = new System.Drawing.Font("Comic Sans MS", 10.75F, System.Drawing.FontStyle.Bold);
            this.label_counter.Location = new System.Drawing.Point(919, 19);
            this.label_counter.Name = "label_counter";
            this.label_counter.Size = new System.Drawing.Size(28, 21);
            this.label_counter.TabIndex = 20;
            this.label_counter.Text = "99";
            this.label_counter.Visible = false;
            this.label_counter.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label_counter_MouseDown);
            // 
            // textBox_modify
            // 
            this.textBox_modify.Font = new System.Drawing.Font("Verdana", 10.25F);
            this.textBox_modify.Location = new System.Drawing.Point(29, 10);
            this.textBox_modify.MaxLength = 65;
            this.textBox_modify.Name = "textBox_modify";
            this.textBox_modify.Size = new System.Drawing.Size(327, 24);
            this.textBox_modify.TabIndex = 21;
            this.textBox_modify.Visible = false;
            this.textBox_modify.Enter += new System.EventHandler(this.textBox_modify_Enter);
            this.textBox_modify.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_modify_KeyDown);
            this.textBox_modify.Leave += new System.EventHandler(this.textBox_modify_Leave);
            // 
            // progressBar_progression
            // 
            this.progressBar_progression.Location = new System.Drawing.Point(3, 18);
            this.progressBar_progression.Name = "progressBar_progression";
            this.progressBar_progression.Size = new System.Drawing.Size(322, 15);
            this.progressBar_progression.TabIndex = 22;
            this.progressBar_progression.Click += new System.EventHandler(this.panel_progressbar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Progression";
            this.label1.Click += new System.EventHandler(this.panel_progressbar_Click);
            // 
            // panel_progressbar
            // 
            this.panel_progressbar.Controls.Add(this.progressBar_progression);
            this.panel_progressbar.Controls.Add(this.label1);
            this.panel_progressbar.Location = new System.Drawing.Point(28, 46);
            this.panel_progressbar.Name = "panel_progressbar";
            this.panel_progressbar.Size = new System.Drawing.Size(328, 36);
            this.panel_progressbar.TabIndex = 25;
            this.panel_progressbar.Click += new System.EventHandler(this.panel_progressbar_Click);
            // 
            // bunifuSeparator8
            // 
            this.bunifuSeparator8.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator8.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator8.LineThickness = 1;
            this.bunifuSeparator8.Location = new System.Drawing.Point(11, 38);
            this.bunifuSeparator8.Name = "bunifuSeparator8";
            this.bunifuSeparator8.Size = new System.Drawing.Size(933, 10);
            this.bunifuSeparator8.TabIndex = 23;
            this.bunifuSeparator8.Transparency = 255;
            this.bunifuSeparator8.Vertical = false;
            // 
            // bunifuSeparator9
            // 
            this.bunifuSeparator9.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator9.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator9.LineThickness = 1;
            this.bunifuSeparator9.Location = new System.Drawing.Point(10, 82);
            this.bunifuSeparator9.Name = "bunifuSeparator9";
            this.bunifuSeparator9.Size = new System.Drawing.Size(933, 2);
            this.bunifuSeparator9.TabIndex = 26;
            this.bunifuSeparator9.Transparency = 255;
            this.bunifuSeparator9.Vertical = false;
            // 
            // richTextBox_texte
            // 
            this.richTextBox_texte.BackColor = System.Drawing.Color.WhiteSmoke;
            this.richTextBox_texte.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox_texte.Location = new System.Drawing.Point(367, 47);
            this.richTextBox_texte.Name = "richTextBox_texte";
            this.richTextBox_texte.Size = new System.Drawing.Size(577, 33);
            this.richTextBox_texte.TabIndex = 27;
            this.richTextBox_texte.Text = "...";
            this.richTextBox_texte.TextChanged += new System.EventHandler(this.richTextBox_texte_TextChanged);
            this.richTextBox_texte.Enter += new System.EventHandler(this.richTextBox_texte_Enter);
            // 
            // ajouterUnMotCléToolStripMenuItem
            // 
            this.ajouterUnMotCléToolStripMenuItem.Image = global::Gestionnaire_de_tâche__Last_.Properties.Resources.add2;
            this.ajouterUnMotCléToolStripMenuItem.Name = "ajouterUnMotCléToolStripMenuItem";
            this.ajouterUnMotCléToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.ajouterUnMotCléToolStripMenuItem.Text = "Ajouter un mot clé";
            this.ajouterUnMotCléToolStripMenuItem.Click += new System.EventHandler(this.ajouterUnMotCléToolStripMenuItem_Click);
            // 
            // supprimeCeMotCléToolStripMenuItem
            // 
            this.supprimeCeMotCléToolStripMenuItem.Image = global::Gestionnaire_de_tâche__Last_.Properties.Resources.delete_trash;
            this.supprimeCeMotCléToolStripMenuItem.Name = "supprimeCeMotCléToolStripMenuItem";
            this.supprimeCeMotCléToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.supprimeCeMotCléToolStripMenuItem.Text = "Supprime ce mot clé";
            this.supprimeCeMotCléToolStripMenuItem.Click += new System.EventHandler(this.supprimeCeMotCléToolStripMenuItem_Click);
            // 
            // ajouterUneDateDéchéanceToolStripMenuItem
            // 
            this.ajouterUneDateDéchéanceToolStripMenuItem.Image = global::Gestionnaire_de_tâche__Last_.Properties.Resources.add2;
            this.ajouterUneDateDéchéanceToolStripMenuItem.Name = "ajouterUneDateDéchéanceToolStripMenuItem";
            this.ajouterUneDateDéchéanceToolStripMenuItem.Size = new System.Drawing.Size(264, 22);
            this.ajouterUneDateDéchéanceToolStripMenuItem.Text = "Ajouter/modifier la date d\'échéance";
            this.ajouterUneDateDéchéanceToolStripMenuItem.Click += new System.EventHandler(this.ajouterUneDateDéchéanceToolStripMenuItem_Click);
            // 
            // supprimerLaDateDéchéanceToolStripMenuItem
            // 
            this.supprimerLaDateDéchéanceToolStripMenuItem.Image = global::Gestionnaire_de_tâche__Last_.Properties.Resources.delete_trash;
            this.supprimerLaDateDéchéanceToolStripMenuItem.Name = "supprimerLaDateDéchéanceToolStripMenuItem";
            this.supprimerLaDateDéchéanceToolStripMenuItem.Size = new System.Drawing.Size(264, 22);
            this.supprimerLaDateDéchéanceToolStripMenuItem.Text = "Supprimer la date d\'échéance";
            this.supprimerLaDateDéchéanceToolStripMenuItem.Click += new System.EventHandler(this.supprimerLaDateDéchéanceToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Image = global::Gestionnaire_de_tâche__Last_.Properties.Resources.duplicate;
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(292, 22);
            this.toolStripMenuItem3.Text = "Appliquer pour tous (dans ce sous projet)";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_appliquerPourTous_Click);
            // 
            // appliquerPourTousDansLeSousProjetToolStripMenuItem
            // 
            this.appliquerPourTousDansLeSousProjetToolStripMenuItem.Image = global::Gestionnaire_de_tâche__Last_.Properties.Resources.duplicate;
            this.appliquerPourTousDansLeSousProjetToolStripMenuItem.Name = "appliquerPourTousDansLeSousProjetToolStripMenuItem";
            this.appliquerPourTousDansLeSousProjetToolStripMenuItem.Size = new System.Drawing.Size(292, 22);
            this.appliquerPourTousDansLeSousProjetToolStripMenuItem.Text = "Appliquer pour tous (dans ce sous projet)";
            this.appliquerPourTousDansLeSousProjetToolStripMenuItem.Click += new System.EventHandler(this.appliquerPourTousDansLeSousProjetToolStripMenuItem_Click);
            // 
            // PictureBox_tchat
            // 
            this.PictureBox_tchat.Color1 = System.Drawing.Color.Tomato;
            this.PictureBox_tchat.Color2 = System.Drawing.Color.Tomato;
            this.PictureBox_tchat.FilterAlpha = 0;
            this.PictureBox_tchat.FilterEnabled = true;
            this.PictureBox_tchat.Image = global::Gestionnaire_de_tâche__Last_.Properties.Resources.note;
            this.PictureBox_tchat.IsElipse = true;
            this.PictureBox_tchat.IsParallax = false;
            this.PictureBox_tchat.Location = new System.Drawing.Point(898, 4);
            this.PictureBox_tchat.Name = "PictureBox_tchat";
            this.PictureBox_tchat.Size = new System.Drawing.Size(39, 34);
            this.PictureBox_tchat.TabIndex = 14;
            this.PictureBox_tchat.Text = "PictureBox_people";
            this.PictureBox_tchat.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PictureBox_tchat_MouseDown);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Image = global::Gestionnaire_de_tâche__Last_.Properties.Resources.modify;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(190, 22);
            this.toolStripMenuItem1.Text = "Modifier la tâche";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Image = global::Gestionnaire_de_tâche__Last_.Properties.Resources.delete_trash;
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(190, 22);
            this.toolStripMenuItem2.Text = "Supprimer cette tâche";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // dupliquerToolStripMenuItem
            // 
            this.dupliquerToolStripMenuItem.Image = global::Gestionnaire_de_tâche__Last_.Properties.Resources.duplicate;
            this.dupliquerToolStripMenuItem.Name = "dupliquerToolStripMenuItem";
            this.dupliquerToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.dupliquerToolStripMenuItem.Text = "Dupliquer";
            this.dupliquerToolStripMenuItem.Click += new System.EventHandler(this.dupliquerToolStripMenuItem_Click);
            // 
            // copierToolStripMenuItem
            // 
            this.copierToolStripMenuItem.Image = global::Gestionnaire_de_tâche__Last_.Properties.Resources.copy;
            this.copierToolStripMenuItem.Name = "copierToolStripMenuItem";
            this.copierToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.copierToolStripMenuItem.Text = "Copier";
            this.copierToolStripMenuItem.Click += new System.EventHandler(this.copierToolStripMenuItem_Click);
            // 
            // UserControl_Tâche
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBox_modify);
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.label_counter);
            this.Controls.Add(this.bunifuSeparator7);
            this.Controls.Add(this.richTextBox_texte);
            this.Controls.Add(this.panel_progressbar);
            this.Controls.Add(this.panel_motClé);
            this.Controls.Add(this.label_date);
            this.Controls.Add(this.panel_priorité);
            this.Controls.Add(this.panel_state);
            this.Controls.Add(this.PictureBox_tchat);
            this.Controls.Add(this.bunifuSeparator5);
            this.Controls.Add(this.bunifuSeparator4);
            this.Controls.Add(this.bunifuSeparator3);
            this.Controls.Add(this.bunifuSeparator2);
            this.Controls.Add(this.panel_color);
            this.Controls.Add(this.bunifuSeparator8);
            this.Controls.Add(this.richtextBox_nom);
            this.Controls.Add(this.bunifuSeparator9);
            this.Name = "UserControl_Tâche";
            this.Size = new System.Drawing.Size(993, 84);
            this.Load += new System.EventHandler(this.UserControl_Tâche_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.richtextBox_nom_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel_motClé_MouseUp);
            this.contextMenuStrip_optionTache.ResumeLayout(false);
            this.panel_color.ResumeLayout(false);
            this.contextMenuStrip_optionsEtat.ResumeLayout(false);
            this.contextMenuStrip_optionsPriorité.ResumeLayout(false);
            this.contextMenuStrip_date.ResumeLayout(false);
            this.contextMenuStrip_motsClés.ResumeLayout(false);
            this.panel_motClé.ResumeLayout(false);
            this.panel_progressbar.ResumeLayout(false);
            this.panel_progressbar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel_color;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator2;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator3;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator4;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator5;
        private XanderUI.XUICustomPictureBox PictureBox_tchat;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator6;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator7;
        private System.Windows.Forms.Panel panel_state;
        private System.Windows.Forms.Panel panel_priorité;
        private System.Windows.Forms.Label label_date;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip_date;
        private System.Windows.Forms.ToolStripMenuItem ajouterUneDateDéchéanceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supprimerLaDateDéchéanceToolStripMenuItem;
        private System.Windows.Forms.ComboBox comboBox_motsClés;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip_motsClés;
        private System.Windows.Forms.ToolStripMenuItem ajouterUnMotCléToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supprimeCeMotCléToolStripMenuItem;
        private System.Windows.Forms.Panel panel_motClé;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip_optionTache;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.RichTextBox richtextBox_nom;
        private System.Windows.Forms.ToolStripMenuItem dupliquerToolStripMenuItem;
        private System.Windows.Forms.Label label_counter;
        private System.Windows.Forms.TextBox textBox_modify;
        private System.Windows.Forms.ProgressBar progressBar_progression;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel_progressbar;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator8;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator9;
        private System.Windows.Forms.RichTextBox richTextBox_texte;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip_optionsEtat;
        private System.Windows.Forms.ToolStripMenuItem appliquerPourTousDansLeSousProjetToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip_optionsPriorité;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem copierToolStripMenuItem;
    }
}
