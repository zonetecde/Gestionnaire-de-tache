namespace Gestionnaire_de_tâche__Last_
{
    partial class Ajouter_un_sous_projet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ajouter_un_sous_projet));
            this.panel_color = new System.Windows.Forms.Panel();
            this.label_select_a_color = new System.Windows.Forms.Label();
            this.ColorPicker_couleur = new XanderUI.XUIColorPicker();
            this.GroupBox_couleur = new XanderUI.XUICustomGroupbox();
            this.Groupbox_priorité = new XanderUI.XUICustomGroupbox();
            this.panel_hidedate = new System.Windows.Forms.Panel();
            this.bunifuDatepicker_fin = new Bunifu.Framework.UI.BunifuDatepicker();
            this.Checkbox_date = new Bunifu.Framework.UI.BunifuCheckbox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Button_prev = new Bunifu.Framework.UI.BunifuThinButton2();
            this.Button_next = new Bunifu.Framework.UI.BunifuThinButton2();
            this.richTextBox_desc = new System.Windows.Forms.RichTextBox();
            this.Groupbox_info = new XanderUI.XUICustomGroupbox();
            this.text_projectName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuSeparator_titleToInfo = new Bunifu.Framework.UI.BunifuSeparator();
            this.label_titre = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.GroupBox_couleur.SuspendLayout();
            this.Groupbox_priorité.SuspendLayout();
            this.Groupbox_info.SuspendLayout();
            this.SuspendLayout();
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
            this.label_select_a_color.Location = new System.Drawing.Point(6, 14);
            this.label_select_a_color.Name = "label_select_a_color";
            this.label_select_a_color.Size = new System.Drawing.Size(739, 40);
            this.label_select_a_color.TabIndex = 6;
            this.label_select_a_color.Text = "Couleur du sous projet";
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
            this.ColorPicker_couleur.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ColorPicker_couleur_MouseMove);
            // 
            // GroupBox_couleur
            // 
            this.GroupBox_couleur.BorderColor = System.Drawing.Color.DodgerBlue;
            this.GroupBox_couleur.BorderWidth = 2;
            this.GroupBox_couleur.Controls.Add(this.panel_color);
            this.GroupBox_couleur.Controls.Add(this.label_select_a_color);
            this.GroupBox_couleur.Controls.Add(this.ColorPicker_couleur);
            this.GroupBox_couleur.Location = new System.Drawing.Point(7, 93);
            this.GroupBox_couleur.Name = "GroupBox_couleur";
            this.GroupBox_couleur.ShowText = true;
            this.GroupBox_couleur.Size = new System.Drawing.Size(752, 306);
            this.GroupBox_couleur.TabIndex = 12;
            this.GroupBox_couleur.TabStop = false;
            this.GroupBox_couleur.Text = "Couleur";
            this.GroupBox_couleur.TextColor = System.Drawing.Color.DodgerBlue;
            this.GroupBox_couleur.Visible = false;
            // 
            // Groupbox_priorité
            // 
            this.Groupbox_priorité.BorderColor = System.Drawing.Color.DodgerBlue;
            this.Groupbox_priorité.BorderWidth = 2;
            this.Groupbox_priorité.Controls.Add(this.panel_hidedate);
            this.Groupbox_priorité.Controls.Add(this.bunifuDatepicker_fin);
            this.Groupbox_priorité.Controls.Add(this.Checkbox_date);
            this.Groupbox_priorité.Controls.Add(this.label4);
            this.Groupbox_priorité.Controls.Add(this.label3);
            this.Groupbox_priorité.Controls.Add(this.label1);
            this.Groupbox_priorité.Location = new System.Drawing.Point(7, 95);
            this.Groupbox_priorité.Name = "Groupbox_priorité";
            this.Groupbox_priorité.ShowText = true;
            this.Groupbox_priorité.Size = new System.Drawing.Size(752, 306);
            this.Groupbox_priorité.TabIndex = 13;
            this.Groupbox_priorité.TabStop = false;
            this.Groupbox_priorité.Text = "Date de fin";
            this.Groupbox_priorité.TextColor = System.Drawing.Color.DodgerBlue;
            this.Groupbox_priorité.Visible = false;
            // 
            // panel_hidedate
            // 
            this.panel_hidedate.BackColor = System.Drawing.Color.SeaGreen;
            this.panel_hidedate.Location = new System.Drawing.Point(220, 137);
            this.panel_hidedate.Name = "panel_hidedate";
            this.panel_hidedate.Size = new System.Drawing.Size(289, 31);
            this.panel_hidedate.TabIndex = 20;
            // 
            // bunifuDatepicker_fin
            // 
            this.bunifuDatepicker_fin.BackColor = System.Drawing.Color.SeaGreen;
            this.bunifuDatepicker_fin.BorderRadius = 15;
            this.bunifuDatepicker_fin.ForeColor = System.Drawing.Color.White;
            this.bunifuDatepicker_fin.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.bunifuDatepicker_fin.FormatCustom = null;
            this.bunifuDatepicker_fin.Location = new System.Drawing.Point(212, 135);
            this.bunifuDatepicker_fin.Name = "bunifuDatepicker_fin";
            this.bunifuDatepicker_fin.Size = new System.Drawing.Size(303, 36);
            this.bunifuDatepicker_fin.TabIndex = 21;
            this.bunifuDatepicker_fin.Value = new System.DateTime(2019, 12, 28, 15, 35, 59, 706);
            // 
            // Checkbox_date
            // 
            this.Checkbox_date.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.Checkbox_date.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.Checkbox_date.Checked = false;
            this.Checkbox_date.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.Checkbox_date.ForeColor = System.Drawing.Color.White;
            this.Checkbox_date.Location = new System.Drawing.Point(331, 111);
            this.Checkbox_date.Name = "Checkbox_date";
            this.Checkbox_date.Size = new System.Drawing.Size(20, 20);
            this.Checkbox_date.TabIndex = 19;
            this.Checkbox_date.OnChange += new System.EventHandler(this.Checkbox_date_OnChange);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 10.25F);
            this.label4.Location = new System.Drawing.Point(443, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 17);
            this.label4.TabIndex = 18;
            this.label4.Text = "optionnel";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(209, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 23);
            this.label3.TabIndex = 17;
            this.label3.Text = "Date de fin";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Verdana", 16.25F);
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(739, 40);
            this.label1.TabIndex = 6;
            this.label1.Text = "Date";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.Button_prev.Location = new System.Drawing.Point(7, 405);
            this.Button_prev.Margin = new System.Windows.Forms.Padding(5);
            this.Button_prev.Name = "Button_prev";
            this.Button_prev.Size = new System.Drawing.Size(161, 41);
            this.Button_prev.TabIndex = 14;
            this.Button_prev.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Button_prev.MouseDown += new System.EventHandler(this.Button_prev_MouseDown);
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
            this.Button_next.Location = new System.Drawing.Point(598, 405);
            this.Button_next.Margin = new System.Windows.Forms.Padding(5);
            this.Button_next.Name = "Button_next";
            this.Button_next.Size = new System.Drawing.Size(161, 41);
            this.Button_next.TabIndex = 13;
            this.Button_next.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Button_next.MouseDown += new System.EventHandler(this.Button_prev_MouseDown);
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
            this.richTextBox_desc.Text = "Description du sous projet";
            this.richTextBox_desc.Enter += new System.EventHandler(this.richTextBox_desc_Enter);
            this.richTextBox_desc.Leave += new System.EventHandler(this.richTextBox_desc_Leave);
            // 
            // Groupbox_info
            // 
            this.Groupbox_info.BorderColor = System.Drawing.Color.DodgerBlue;
            this.Groupbox_info.BorderWidth = 2;
            this.Groupbox_info.Controls.Add(this.richTextBox_desc);
            this.Groupbox_info.Controls.Add(this.text_projectName);
            this.Groupbox_info.Location = new System.Drawing.Point(7, 94);
            this.Groupbox_info.Name = "Groupbox_info";
            this.Groupbox_info.ShowText = true;
            this.Groupbox_info.Size = new System.Drawing.Size(752, 306);
            this.Groupbox_info.TabIndex = 11;
            this.Groupbox_info.TabStop = false;
            this.Groupbox_info.Text = "Informations";
            this.Groupbox_info.TextColor = System.Drawing.Color.DodgerBlue;
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
            this.text_projectName.Text = "Nom du sous projet";
            this.text_projectName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.text_projectName.Enter += new System.EventHandler(this.text_projectName_Enter);
            this.text_projectName.Leave += new System.EventHandler(this.text_projectName_Leave);
            // 
            // bunifuSeparator_titleToInfo
            // 
            this.bunifuSeparator_titleToInfo.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator_titleToInfo.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator_titleToInfo.LineThickness = 1;
            this.bunifuSeparator_titleToInfo.Location = new System.Drawing.Point(60, 65);
            this.bunifuSeparator_titleToInfo.Name = "bunifuSeparator_titleToInfo";
            this.bunifuSeparator_titleToInfo.Size = new System.Drawing.Size(639, 15);
            this.bunifuSeparator_titleToInfo.TabIndex = 10;
            this.bunifuSeparator_titleToInfo.Transparency = 255;
            this.bunifuSeparator_titleToInfo.Vertical = false;
            // 
            // label_titre
            // 
            this.label_titre.Font = new System.Drawing.Font("Verdana", 25.25F);
            this.label_titre.Location = new System.Drawing.Point(0, -1);
            this.label_titre.Name = "label_titre";
            this.label_titre.Size = new System.Drawing.Size(759, 75);
            this.label_titre.TabIndex = 9;
            this.label_titre.Text = "Ajouter un sous projet";
            this.label_titre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Ajouter_un_sous_projet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 450);
            this.Controls.Add(this.Groupbox_priorité);
            this.Controls.Add(this.GroupBox_couleur);
            this.Controls.Add(this.Button_prev);
            this.Controls.Add(this.Button_next);
            this.Controls.Add(this.Groupbox_info);
            this.Controls.Add(this.bunifuSeparator_titleToInfo);
            this.Controls.Add(this.label_titre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Ajouter_un_sous_projet";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ajouter_un_sous_projet";
            this.Load += new System.EventHandler(this.Ajouter_un_sous_projet_Load);
            this.GroupBox_couleur.ResumeLayout(false);
            this.GroupBox_couleur.PerformLayout();
            this.Groupbox_priorité.ResumeLayout(false);
            this.Groupbox_priorité.PerformLayout();
            this.Groupbox_info.ResumeLayout(false);
            this.Groupbox_info.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel_color;
        private System.Windows.Forms.Label label_select_a_color;
        private XanderUI.XUIColorPicker ColorPicker_couleur;
        private XanderUI.XUICustomGroupbox GroupBox_couleur;
        private Bunifu.Framework.UI.BunifuThinButton2 Button_prev;
        private Bunifu.Framework.UI.BunifuThinButton2 Button_next;
        private System.Windows.Forms.RichTextBox richTextBox_desc;
        private XanderUI.XUICustomGroupbox Groupbox_info;
        private Bunifu.Framework.UI.BunifuMaterialTextbox text_projectName;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator_titleToInfo;
        private Bunifu.Framework.UI.BunifuCustomLabel label_titre;
        private XanderUI.XUICustomGroupbox Groupbox_priorité;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel_hidedate;
        private Bunifu.Framework.UI.BunifuDatepicker bunifuDatepicker_fin;
        private Bunifu.Framework.UI.BunifuCheckbox Checkbox_date;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}