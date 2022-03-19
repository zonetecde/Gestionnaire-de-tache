namespace Gestionnaire_de_tâche__Last_
{
    partial class Ajouter_un_projet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ajouter_un_projet));
            this.text_projectName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label_titre = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuSeparator_titleToInfo = new Bunifu.Framework.UI.BunifuSeparator();
            this.Groupbox_info = new XanderUI.XUICustomGroupbox();
            this.richTextBox_desc = new System.Windows.Forms.RichTextBox();
            this.Button_next = new Bunifu.Framework.UI.BunifuThinButton2();
            this.Button_prev = new Bunifu.Framework.UI.BunifuThinButton2();
            this.GroupBox_couleur = new XanderUI.XUICustomGroupbox();
            this.panel_color = new System.Windows.Forms.Panel();
            this.label_select_a_color = new System.Windows.Forms.Label();
            this.ColorPicker_couleur = new XanderUI.XUIColorPicker();
            this.Groupbox_date = new XanderUI.XUICustomGroupbox();
            this.button_release = new System.Windows.Forms.Button();
            this.button_debug = new System.Windows.Forms.Button();
            this.button_solution = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.panel_hidedate = new System.Windows.Forms.Panel();
            this.bunifuDatepicker_fin = new Bunifu.Framework.UI.BunifuDatepicker();
            this.Checkbox_date = new Bunifu.Framework.UI.BunifuCheckbox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Datepicker_creationDate = new Bunifu.Framework.UI.BunifuDatepicker();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox_deleteSln = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.Groupbox_info.SuspendLayout();
            this.GroupBox_couleur.SuspendLayout();
            this.Groupbox_date.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_deleteSln)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // text_projectName
            // 
            this.text_projectName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text_projectName.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.text_projectName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.text_projectName.HintForeColor = System.Drawing.Color.Black;
            this.text_projectName.HintText = "";
            this.text_projectName.isPassword = false;
            this.text_projectName.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.text_projectName.LineIdleColor = System.Drawing.Color.Gray;
            this.text_projectName.LineMouseHoverColor = System.Drawing.Color.LightSteelBlue;
            this.text_projectName.LineThickness = 3;
            this.text_projectName.Location = new System.Drawing.Point(7, 21);
            this.text_projectName.Margin = new System.Windows.Forms.Padding(4);
            this.text_projectName.Name = "text_projectName";
            this.text_projectName.Size = new System.Drawing.Size(738, 44);
            this.text_projectName.TabIndex = 0;
            this.text_projectName.Text = "Nom du projet";
            this.text_projectName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.text_projectName.Enter += new System.EventHandler(this.text_projectName_Enter);
            this.text_projectName.Leave += new System.EventHandler(this.text_projectName_Leave);
            // 
            // label_titre
            // 
            this.label_titre.Font = new System.Drawing.Font("Verdana", 25.25F);
            this.label_titre.Location = new System.Drawing.Point(12, 9);
            this.label_titre.Name = "label_titre";
            this.label_titre.Size = new System.Drawing.Size(759, 75);
            this.label_titre.TabIndex = 1;
            this.label_titre.Text = "Ajouter un projet";
            this.label_titre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bunifuSeparator_titleToInfo
            // 
            this.bunifuSeparator_titleToInfo.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator_titleToInfo.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator_titleToInfo.LineThickness = 1;
            this.bunifuSeparator_titleToInfo.Location = new System.Drawing.Point(72, 75);
            this.bunifuSeparator_titleToInfo.Name = "bunifuSeparator_titleToInfo";
            this.bunifuSeparator_titleToInfo.Size = new System.Drawing.Size(639, 15);
            this.bunifuSeparator_titleToInfo.TabIndex = 2;
            this.bunifuSeparator_titleToInfo.Transparency = 255;
            this.bunifuSeparator_titleToInfo.Vertical = false;
            // 
            // Groupbox_info
            // 
            this.Groupbox_info.BorderColor = System.Drawing.Color.DodgerBlue;
            this.Groupbox_info.BorderWidth = 2;
            this.Groupbox_info.Controls.Add(this.richTextBox_desc);
            this.Groupbox_info.Controls.Add(this.text_projectName);
            this.Groupbox_info.Location = new System.Drawing.Point(19, 104);
            this.Groupbox_info.Name = "Groupbox_info";
            this.Groupbox_info.ShowText = true;
            this.Groupbox_info.Size = new System.Drawing.Size(752, 306);
            this.Groupbox_info.TabIndex = 3;
            this.Groupbox_info.TabStop = false;
            this.Groupbox_info.Text = "Informations";
            this.Groupbox_info.TextColor = System.Drawing.Color.DodgerBlue;
            // 
            // richTextBox_desc
            // 
            this.richTextBox_desc.BackColor = System.Drawing.Color.WhiteSmoke;
            this.richTextBox_desc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox_desc.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox_desc.Location = new System.Drawing.Point(7, 87);
            this.richTextBox_desc.Name = "richTextBox_desc";
            this.richTextBox_desc.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.richTextBox_desc.Size = new System.Drawing.Size(738, 202);
            this.richTextBox_desc.TabIndex = 2;
            this.richTextBox_desc.Text = "Description du projet";
            this.richTextBox_desc.Enter += new System.EventHandler(this.richTextBox_desc_Enter);
            this.richTextBox_desc.Leave += new System.EventHandler(this.richTextBox_desc_Leave);
            // 
            // Button_next
            // 
            this.Button_next.ActiveBorderThickness = 1;
            this.Button_next.ActiveCornerRadius = 20;
            this.Button_next.ActiveFillColor = System.Drawing.Color.Green;
            this.Button_next.ActiveForecolor = System.Drawing.Color.White;
            this.Button_next.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.Button_next.BackColor = System.Drawing.SystemColors.Control;
            this.Button_next.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Button_next.BackgroundImage")));
            this.Button_next.ButtonText = "Suivant";
            this.Button_next.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_next.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_next.ForeColor = System.Drawing.Color.SeaGreen;
            this.Button_next.IdleBorderThickness = 1;
            this.Button_next.IdleCornerRadius = 25;
            this.Button_next.IdleFillColor = System.Drawing.Color.White;
            this.Button_next.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.Button_next.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.Button_next.Location = new System.Drawing.Point(610, 415);
            this.Button_next.Margin = new System.Windows.Forms.Padding(5);
            this.Button_next.Name = "Button_next";
            this.Button_next.Size = new System.Drawing.Size(161, 41);
            this.Button_next.TabIndex = 4;
            this.Button_next.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Button_next.MouseDown += new System.EventHandler(this.Button_next_MouseDown);
            // 
            // Button_prev
            // 
            this.Button_prev.ActiveBorderThickness = 1;
            this.Button_prev.ActiveCornerRadius = 20;
            this.Button_prev.ActiveFillColor = System.Drawing.Color.Green;
            this.Button_prev.ActiveForecolor = System.Drawing.Color.White;
            this.Button_prev.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.Button_prev.BackColor = System.Drawing.SystemColors.Control;
            this.Button_prev.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Button_prev.BackgroundImage")));
            this.Button_prev.ButtonText = "Précédent";
            this.Button_prev.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_prev.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_prev.ForeColor = System.Drawing.Color.SeaGreen;
            this.Button_prev.IdleBorderThickness = 1;
            this.Button_prev.IdleCornerRadius = 25;
            this.Button_prev.IdleFillColor = System.Drawing.Color.White;
            this.Button_prev.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.Button_prev.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.Button_prev.Location = new System.Drawing.Point(19, 415);
            this.Button_prev.Margin = new System.Windows.Forms.Padding(5);
            this.Button_prev.Name = "Button_prev";
            this.Button_prev.Size = new System.Drawing.Size(161, 41);
            this.Button_prev.TabIndex = 5;
            this.Button_prev.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Button_prev.MouseDown += new System.EventHandler(this.Button_next_MouseDown);
            // 
            // GroupBox_couleur
            // 
            this.GroupBox_couleur.BorderColor = System.Drawing.Color.DodgerBlue;
            this.GroupBox_couleur.BorderWidth = 2;
            this.GroupBox_couleur.Controls.Add(this.panel_color);
            this.GroupBox_couleur.Controls.Add(this.label_select_a_color);
            this.GroupBox_couleur.Controls.Add(this.ColorPicker_couleur);
            this.GroupBox_couleur.Location = new System.Drawing.Point(19, 104);
            this.GroupBox_couleur.Name = "GroupBox_couleur";
            this.GroupBox_couleur.ShowText = true;
            this.GroupBox_couleur.Size = new System.Drawing.Size(752, 306);
            this.GroupBox_couleur.TabIndex = 4;
            this.GroupBox_couleur.TabStop = false;
            this.GroupBox_couleur.Text = "Couleur";
            this.GroupBox_couleur.TextColor = System.Drawing.Color.DodgerBlue;
            this.GroupBox_couleur.Visible = false;
            // 
            // panel_color
            // 
            this.panel_color.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel_color.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_color.Location = new System.Drawing.Point(9, 273);
            this.panel_color.Name = "panel_color";
            this.panel_color.Size = new System.Drawing.Size(736, 27);
            this.panel_color.TabIndex = 7;
            // 
            // label_select_a_color
            // 
            this.label_select_a_color.Font = new System.Drawing.Font("Verdana", 16.25F);
            this.label_select_a_color.Location = new System.Drawing.Point(6, 16);
            this.label_select_a_color.Name = "label_select_a_color";
            this.label_select_a_color.Size = new System.Drawing.Size(739, 40);
            this.label_select_a_color.TabIndex = 6;
            this.label_select_a_color.Text = "Couleur du projet";
            this.label_select_a_color.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ColorPicker_couleur
            // 
            this.ColorPicker_couleur.Location = new System.Drawing.Point(277, 57);
            this.ColorPicker_couleur.Name = "ColorPicker_couleur";
            this.ColorPicker_couleur.PickerImage = ((System.Drawing.Image)(resources.GetObject("ColorPicker_couleur.PickerImage")));
            this.ColorPicker_couleur.SelectedColor = System.Drawing.Color.Empty;
            this.ColorPicker_couleur.ShowColorPreview = true;
            this.ColorPicker_couleur.Size = new System.Drawing.Size(200, 200);
            this.ColorPicker_couleur.TabIndex = 5;
            this.ColorPicker_couleur.Text = "xuiColorPicker1";
            this.ColorPicker_couleur.MouseMove += new System.Windows.Forms.MouseEventHandler(this.xuiColorPicker_couleur_MouseMove);
            // 
            // Groupbox_date
            // 
            this.Groupbox_date.BorderColor = System.Drawing.Color.DodgerBlue;
            this.Groupbox_date.BorderWidth = 2;
            this.Groupbox_date.Controls.Add(this.pictureBox3);
            this.Groupbox_date.Controls.Add(this.pictureBox2);
            this.Groupbox_date.Controls.Add(this.pictureBox_deleteSln);
            this.Groupbox_date.Controls.Add(this.button_release);
            this.Groupbox_date.Controls.Add(this.button_debug);
            this.Groupbox_date.Controls.Add(this.button_solution);
            this.Groupbox_date.Controls.Add(this.label5);
            this.Groupbox_date.Controls.Add(this.panel_hidedate);
            this.Groupbox_date.Controls.Add(this.bunifuDatepicker_fin);
            this.Groupbox_date.Controls.Add(this.Checkbox_date);
            this.Groupbox_date.Controls.Add(this.label4);
            this.Groupbox_date.Controls.Add(this.label3);
            this.Groupbox_date.Controls.Add(this.label2);
            this.Groupbox_date.Controls.Add(this.Datepicker_creationDate);
            this.Groupbox_date.Controls.Add(this.label1);
            this.Groupbox_date.Location = new System.Drawing.Point(19, 104);
            this.Groupbox_date.Name = "Groupbox_date";
            this.Groupbox_date.ShowText = true;
            this.Groupbox_date.Size = new System.Drawing.Size(752, 306);
            this.Groupbox_date.TabIndex = 8;
            this.Groupbox_date.TabStop = false;
            this.Groupbox_date.Text = "Autre";
            this.Groupbox_date.TextColor = System.Drawing.Color.DodgerBlue;
            this.Groupbox_date.Visible = false;
            // 
            // button_release
            // 
            this.button_release.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_release.Location = new System.Drawing.Point(525, 224);
            this.button_release.Name = "button_release";
            this.button_release.Size = new System.Drawing.Size(197, 33);
            this.button_release.TabIndex = 20;
            this.button_release.Text = "Éxecutable (RELEASE)";
            this.button_release.UseVisualStyleBackColor = true;
            this.button_release.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button_release_MouseDown);
            // 
            // button_debug
            // 
            this.button_debug.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_debug.Location = new System.Drawing.Point(275, 224);
            this.button_debug.Name = "button_debug";
            this.button_debug.Size = new System.Drawing.Size(197, 33);
            this.button_debug.TabIndex = 19;
            this.button_debug.Text = "Éxecutable (DEBUG)";
            this.button_debug.UseVisualStyleBackColor = true;
            this.button_debug.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button_debug_MouseDown);
            // 
            // button_solution
            // 
            this.button_solution.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_solution.Location = new System.Drawing.Point(11, 224);
            this.button_solution.Name = "button_solution";
            this.button_solution.Size = new System.Drawing.Size(197, 33);
            this.button_solution.TabIndex = 18;
            this.button_solution.Text = "Solution du projet";
            this.button_solution.UseVisualStyleBackColor = true;
            this.button_solution.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button_solution_MouseDown);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Verdana", 16.25F);
            this.label5.Location = new System.Drawing.Point(6, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(739, 40);
            this.label5.TabIndex = 17;
            this.label5.Text = "Répértoire du projet";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel_hidedate
            // 
            this.panel_hidedate.BackColor = System.Drawing.Color.SeaGreen;
            this.panel_hidedate.Location = new System.Drawing.Point(440, 97);
            this.panel_hidedate.Name = "panel_hidedate";
            this.panel_hidedate.Size = new System.Drawing.Size(289, 31);
            this.panel_hidedate.TabIndex = 15;
            // 
            // bunifuDatepicker_fin
            // 
            this.bunifuDatepicker_fin.BackColor = System.Drawing.Color.SeaGreen;
            this.bunifuDatepicker_fin.BorderRadius = 15;
            this.bunifuDatepicker_fin.ForeColor = System.Drawing.Color.White;
            this.bunifuDatepicker_fin.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.bunifuDatepicker_fin.FormatCustom = null;
            this.bunifuDatepicker_fin.Location = new System.Drawing.Point(432, 95);
            this.bunifuDatepicker_fin.Name = "bunifuDatepicker_fin";
            this.bunifuDatepicker_fin.Size = new System.Drawing.Size(303, 36);
            this.bunifuDatepicker_fin.TabIndex = 16;
            this.bunifuDatepicker_fin.Value = new System.DateTime(2019, 12, 28, 15, 35, 59, 706);
            // 
            // Checkbox_date
            // 
            this.Checkbox_date.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.Checkbox_date.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.Checkbox_date.Checked = false;
            this.Checkbox_date.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.Checkbox_date.ForeColor = System.Drawing.Color.White;
            this.Checkbox_date.Location = new System.Drawing.Point(551, 71);
            this.Checkbox_date.Name = "Checkbox_date";
            this.Checkbox_date.Size = new System.Drawing.Size(20, 20);
            this.Checkbox_date.TabIndex = 14;
            this.Checkbox_date.OnChange += new System.EventHandler(this.bunifuCheckbox_date_OnChange);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 10.25F);
            this.label4.Location = new System.Drawing.Point(663, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "optionnel";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(429, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 23);
            this.label3.TabIndex = 12;
            this.label3.Text = "Date de fin";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 23);
            this.label2.TabIndex = 10;
            this.label2.Text = "Date de création";
            // 
            // Datepicker_creationDate
            // 
            this.Datepicker_creationDate.BackColor = System.Drawing.Color.SeaGreen;
            this.Datepicker_creationDate.BorderRadius = 15;
            this.Datepicker_creationDate.ForeColor = System.Drawing.Color.White;
            this.Datepicker_creationDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.Datepicker_creationDate.FormatCustom = null;
            this.Datepicker_creationDate.Location = new System.Drawing.Point(11, 95);
            this.Datepicker_creationDate.Name = "Datepicker_creationDate";
            this.Datepicker_creationDate.Size = new System.Drawing.Size(303, 36);
            this.Datepicker_creationDate.TabIndex = 9;
            this.Datepicker_creationDate.Value = new System.DateTime(2019, 12, 28, 15, 35, 59, 706);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Verdana", 16.25F);
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(739, 40);
            this.label1.TabIndex = 6;
            this.label1.Text = "Date du projet";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox_deleteSln
            // 
            this.pictureBox_deleteSln.Image = global::Gestionnaire_de_tâche__Last_.Properties.Resources.delete_trash;
            this.pictureBox_deleteSln.Location = new System.Drawing.Point(209, 231);
            this.pictureBox_deleteSln.Name = "pictureBox_deleteSln";
            this.pictureBox_deleteSln.Size = new System.Drawing.Size(27, 25);
            this.pictureBox_deleteSln.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_deleteSln.TabIndex = 22;
            this.pictureBox_deleteSln.TabStop = false;
            this.pictureBox_deleteSln.Click += new System.EventHandler(this.pictureBox_deleteSln_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Gestionnaire_de_tâche__Last_.Properties.Resources.delete_trash;
            this.pictureBox2.Location = new System.Drawing.Point(474, 231);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(27, 25);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 23;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Gestionnaire_de_tâche__Last_.Properties.Resources.delete_trash;
            this.pictureBox3.Location = new System.Drawing.Point(722, 231);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(27, 25);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 24;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // Ajouter_un_projet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 461);
            this.Controls.Add(this.Groupbox_date);
            this.Controls.Add(this.GroupBox_couleur);
            this.Controls.Add(this.Button_prev);
            this.Controls.Add(this.Button_next);
            this.Controls.Add(this.Groupbox_info);
            this.Controls.Add(this.bunifuSeparator_titleToInfo);
            this.Controls.Add(this.label_titre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Ajouter_un_projet";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Ajouter un projet";
            this.Load += new System.EventHandler(this.Ajouter_un_projet_Load);
            this.Groupbox_info.ResumeLayout(false);
            this.Groupbox_info.PerformLayout();
            this.GroupBox_couleur.ResumeLayout(false);
            this.GroupBox_couleur.PerformLayout();
            this.Groupbox_date.ResumeLayout(false);
            this.Groupbox_date.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_deleteSln)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion     

        private Bunifu.Framework.UI.BunifuMaterialTextbox text_projectName;
        private Bunifu.Framework.UI.BunifuCustomLabel label_titre;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator_titleToInfo;
        private XanderUI.XUICustomGroupbox Groupbox_info;
        private System.Windows.Forms.RichTextBox richTextBox_desc;
        private Bunifu.Framework.UI.BunifuThinButton2 Button_next;
        private Bunifu.Framework.UI.BunifuThinButton2 Button_prev;
        private XanderUI.XUICustomGroupbox GroupBox_couleur;
        private System.Windows.Forms.Panel panel_color;
        private System.Windows.Forms.Label label_select_a_color;
        private XanderUI.XUIColorPicker ColorPicker_couleur;
        private XanderUI.XUICustomGroupbox Groupbox_date;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuDatepicker Datepicker_creationDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuCheckbox Checkbox_date;
        private System.Windows.Forms.Panel panel_hidedate;
        private Bunifu.Framework.UI.BunifuDatepicker bunifuDatepicker_fin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button_release;
        private System.Windows.Forms.Button button_debug;
        private System.Windows.Forms.Button button_solution;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox_deleteSln;
    }
}