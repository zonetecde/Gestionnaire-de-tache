namespace Gestionnaire_de_tâche__Last_
{
    partial class Ajouter_une_tâche
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ajouter_une_tâche));
            this.label_titre = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.text_projectName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Groupbox_info = new XanderUI.XUICustomGroupbox();
            this.label_charCount = new System.Windows.Forms.Label();
            this.richTextBox_desc = new System.Windows.Forms.RichTextBox();
            this.Button_next = new Bunifu.Framework.UI.BunifuThinButton2();
            this.Button_prev = new Bunifu.Framework.UI.BunifuThinButton2();
            this.GroupBox_couleur = new XanderUI.XUICustomGroupbox();
            this.panel_color = new System.Windows.Forms.Panel();
            this.label_select_a_color = new System.Windows.Forms.Label();
            this.ColorPicker_couleur = new XanderUI.XUIColorPicker();
            this.bunifuSeparator_titleToInfo = new Bunifu.Framework.UI.BunifuSeparator();
            this.Groupbox_info.SuspendLayout();
            this.GroupBox_couleur.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_titre
            // 
            this.label_titre.Font = new System.Drawing.Font("Verdana", 25.25F);
            this.label_titre.Location = new System.Drawing.Point(1, 0);
            this.label_titre.Name = "label_titre";
            this.label_titre.Size = new System.Drawing.Size(759, 75);
            this.label_titre.TabIndex = 15;
            this.label_titre.Text = "Ajouter une tâche";
            this.label_titre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.text_projectName.Text = "Nom de la tâche";
            this.text_projectName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.text_projectName.OnValueChanged += new System.EventHandler(this.text_projectName_OnValueChanged);
            this.text_projectName.Enter += new System.EventHandler(this.text_projectName_Enter);
            this.text_projectName.Leave += new System.EventHandler(this.text_projectName_Leave);
            // 
            // Groupbox_info
            // 
            this.Groupbox_info.BorderColor = System.Drawing.Color.DodgerBlue;
            this.Groupbox_info.BorderWidth = 2;
            this.Groupbox_info.Controls.Add(this.label_charCount);
            this.Groupbox_info.Controls.Add(this.richTextBox_desc);
            this.Groupbox_info.Controls.Add(this.text_projectName);
            this.Groupbox_info.Location = new System.Drawing.Point(8, 94);
            this.Groupbox_info.Name = "Groupbox_info";
            this.Groupbox_info.ShowText = true;
            this.Groupbox_info.Size = new System.Drawing.Size(752, 306);
            this.Groupbox_info.TabIndex = 17;
            this.Groupbox_info.TabStop = false;
            this.Groupbox_info.Text = "Informations";
            this.Groupbox_info.TextColor = System.Drawing.Color.DodgerBlue;
            // 
            // label_charCount
            // 
            this.label_charCount.AutoSize = true;
            this.label_charCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label_charCount.Location = new System.Drawing.Point(606, 68);
            this.label_charCount.Name = "label_charCount";
            this.label_charCount.Size = new System.Drawing.Size(127, 17);
            this.label_charCount.TabIndex = 4;
            this.label_charCount.Text = "Caractère(s) : 0/50";
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
            this.richTextBox_desc.Text = "Détail sur la tâche";
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
            this.Button_next.Location = new System.Drawing.Point(599, 406);
            this.Button_next.Margin = new System.Windows.Forms.Padding(5);
            this.Button_next.Name = "Button_next";
            this.Button_next.Size = new System.Drawing.Size(161, 41);
            this.Button_next.TabIndex = 19;
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
            this.Button_prev.Location = new System.Drawing.Point(8, 406);
            this.Button_prev.Margin = new System.Windows.Forms.Padding(5);
            this.Button_prev.Name = "Button_prev";
            this.Button_prev.Size = new System.Drawing.Size(161, 41);
            this.Button_prev.TabIndex = 21;
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
            this.GroupBox_couleur.Location = new System.Drawing.Point(8, 94);
            this.GroupBox_couleur.Name = "GroupBox_couleur";
            this.GroupBox_couleur.ShowText = true;
            this.GroupBox_couleur.Size = new System.Drawing.Size(752, 306);
            this.GroupBox_couleur.TabIndex = 18;
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
            // bunifuSeparator_titleToInfo
            // 
            this.bunifuSeparator_titleToInfo.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator_titleToInfo.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator_titleToInfo.LineThickness = 1;
            this.bunifuSeparator_titleToInfo.Location = new System.Drawing.Point(61, 66);
            this.bunifuSeparator_titleToInfo.Name = "bunifuSeparator_titleToInfo";
            this.bunifuSeparator_titleToInfo.Size = new System.Drawing.Size(639, 15);
            this.bunifuSeparator_titleToInfo.TabIndex = 16;
            this.bunifuSeparator_titleToInfo.Transparency = 255;
            this.bunifuSeparator_titleToInfo.Vertical = false;
            // 
            // Ajouter_une_tâche
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 450);
            this.Controls.Add(this.Groupbox_info);
            this.Controls.Add(this.Button_next);
            this.Controls.Add(this.Button_prev);
            this.Controls.Add(this.GroupBox_couleur);
            this.Controls.Add(this.bunifuSeparator_titleToInfo);
            this.Controls.Add(this.label_titre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Ajouter_une_tâche";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ajouter_une_tâche";
            this.Load += new System.EventHandler(this.Ajouter_une_tâche_Load);
            this.Groupbox_info.ResumeLayout(false);
            this.Groupbox_info.PerformLayout();
            this.GroupBox_couleur.ResumeLayout(false);
            this.GroupBox_couleur.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomLabel label_titre;
        private Bunifu.Framework.UI.BunifuMaterialTextbox text_projectName;
        private XanderUI.XUICustomGroupbox Groupbox_info;
        private System.Windows.Forms.RichTextBox richTextBox_desc;
        private Bunifu.Framework.UI.BunifuThinButton2 Button_next;
        private Bunifu.Framework.UI.BunifuThinButton2 Button_prev;
        private XanderUI.XUICustomGroupbox GroupBox_couleur;
        private System.Windows.Forms.Panel panel_color;
        private System.Windows.Forms.Label label_select_a_color;
        private XanderUI.XUIColorPicker ColorPicker_couleur;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator_titleToInfo;
        private System.Windows.Forms.Label label_charCount;
    }
}