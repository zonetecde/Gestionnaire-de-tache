namespace Gestionnaire_de_tâche__Last_
{
    partial class Ajouter_une_priorité
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ajouter_une_priorité));
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
            this.button_add.Location = new System.Drawing.Point(346, 144);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(116, 27);
            this.button_add.TabIndex = 8;
            this.button_add.Text = "Ajouter";
            this.button_add.UseVisualStyleBackColor = true;
            // 
            // panel_color
            // 
            this.panel_color.BackColor = System.Drawing.Color.White;
            this.panel_color.Location = new System.Drawing.Point(244, 91);
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
            this.Textbox_name.Location = new System.Drawing.Point(244, 33);
            this.Textbox_name.Margin = new System.Windows.Forms.Padding(4);
            this.Textbox_name.Name = "Textbox_name";
            this.Textbox_name.Size = new System.Drawing.Size(218, 44);
            this.Textbox_name.TabIndex = 6;
            this.Textbox_name.Text = "Nom de l\'état";
            this.Textbox_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // ColorPicker_color
            // 
            this.ColorPicker_color.Location = new System.Drawing.Point(51, 22);
            this.ColorPicker_color.Name = "ColorPicker_color";
            this.ColorPicker_color.PickerImage = ((System.Drawing.Image)(resources.GetObject("ColorPicker_color.PickerImage")));
            this.ColorPicker_color.SelectedColor = System.Drawing.Color.Empty;
            this.ColorPicker_color.ShowColorPreview = true;
            this.ColorPicker_color.Size = new System.Drawing.Size(157, 157);
            this.ColorPicker_color.TabIndex = 5;
            this.ColorPicker_color.Text = "xuiColorPicker1";
            // 
            // Ajouter_une_priorité
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.panel_color);
            this.Controls.Add(this.Textbox_name);
            this.Controls.Add(this.ColorPicker_color);
            this.Name = "Ajouter_une_priorité";
            this.Text = "Ajouter_une_priorité";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Panel panel_color;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Textbox_name;
        private XanderUI.XUIColorPicker ColorPicker_color;
    }
}