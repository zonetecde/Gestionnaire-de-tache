namespace Gestionnaire_de_tâche__Last_
{
    partial class Ajouter_une_prioritée
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ajouter_une_prioritée));
            this.button_add = new System.Windows.Forms.Button();
            this.panel_color = new System.Windows.Forms.Panel();
            this.Textbox_name = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.ColorPicker_color = new XanderUI.XUIColorPicker();
            this.SuspendLayout();
            // 
            // button_add
            // 
            this.button_add.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_add.ForeColor = System.Drawing.Color.Black;
            this.button_add.Location = new System.Drawing.Point(307, 134);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(116, 27);
            this.button_add.TabIndex = 8;
            this.button_add.Text = "Ajouter";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button_add_MouseDown);
            // 
            // panel_color
            // 
            this.panel_color.BackColor = System.Drawing.Color.White;
            this.panel_color.Location = new System.Drawing.Point(205, 81);
            this.panel_color.Name = "panel_color";
            this.panel_color.Size = new System.Drawing.Size(218, 34);
            this.panel_color.TabIndex = 7;
            // 
            // Textbox_name
            // 
            this.Textbox_name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Textbox_name.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.Textbox_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Textbox_name.HintForeColor = System.Drawing.Color.Empty;
            this.Textbox_name.HintText = "";
            this.Textbox_name.isPassword = false;
            this.Textbox_name.LineFocusedColor = System.Drawing.Color.Blue;
            this.Textbox_name.LineIdleColor = System.Drawing.Color.Gray;
            this.Textbox_name.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.Textbox_name.LineThickness = 3;
            this.Textbox_name.Location = new System.Drawing.Point(205, 23);
            this.Textbox_name.Margin = new System.Windows.Forms.Padding(4);
            this.Textbox_name.Name = "Textbox_name";
            this.Textbox_name.Size = new System.Drawing.Size(218, 44);
            this.Textbox_name.TabIndex = 6;
            this.Textbox_name.Text = "Nom de la prioritée";
            this.Textbox_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Textbox_name.Enter += new System.EventHandler(this.Textbox_name_Enter);
            // 
            // ColorPicker_color
            // 
            this.ColorPicker_color.Location = new System.Drawing.Point(12, 12);
            this.ColorPicker_color.Name = "ColorPicker_color";
            this.ColorPicker_color.PickerImage = ((System.Drawing.Image)(resources.GetObject("ColorPicker_color.PickerImage")));
            this.ColorPicker_color.SelectedColor = System.Drawing.Color.Empty;
            this.ColorPicker_color.ShowColorPreview = true;
            this.ColorPicker_color.Size = new System.Drawing.Size(157, 157);
            this.ColorPicker_color.TabIndex = 5;
            this.ColorPicker_color.Text = "xuiColorPicker1";
            this.ColorPicker_color.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ColorPicker_color_MouseMove);
            // 
            // Ajouter_une_prioritée
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 183);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.panel_color);
            this.Controls.Add(this.Textbox_name);
            this.Controls.Add(this.ColorPicker_color);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Ajouter_une_prioritée";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ajouter une prioritée";
            this.Load += new System.EventHandler(this.Ajouter_une_prioritée_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Panel panel_color;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Textbox_name;
        private XanderUI.XUIColorPicker ColorPicker_color;
    }
}