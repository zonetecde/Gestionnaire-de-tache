namespace Gestionnaire_de_tâche__Last_
{
    partial class Ajouter_un_état
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ajouter_un_état));
            this.ColorPicker_color = new XanderUI.XUIColorPicker();
            this.Textbox_name = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.panel_color = new System.Windows.Forms.Panel();
            this.button_add = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ColorPicker_color
            // 
            this.ColorPicker_color.Location = new System.Drawing.Point(20, 7);
            this.ColorPicker_color.Name = "ColorPicker_color";
            this.ColorPicker_color.PickerImage = ((System.Drawing.Image)(resources.GetObject("ColorPicker_color.PickerImage")));
            this.ColorPicker_color.SelectedColor = System.Drawing.Color.Empty;
            this.ColorPicker_color.ShowColorPreview = true;
            this.ColorPicker_color.Size = new System.Drawing.Size(157, 157);
            this.ColorPicker_color.TabIndex = 1;
            this.ColorPicker_color.Text = "xuiColorPicker1";
            this.ColorPicker_color.MouseMove += new System.Windows.Forms.MouseEventHandler(this.xuiColorPicker1_MouseMove);
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
            this.Textbox_name.Location = new System.Drawing.Point(213, 18);
            this.Textbox_name.Margin = new System.Windows.Forms.Padding(4);
            this.Textbox_name.Name = "Textbox_name";
            this.Textbox_name.Size = new System.Drawing.Size(218, 44);
            this.Textbox_name.TabIndex = 2;
            this.Textbox_name.Text = "Nom de l\'état";
            this.Textbox_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Textbox_name.Enter += new System.EventHandler(this.Textbox_name_Enter);
            // 
            // panel_color
            // 
            this.panel_color.BackColor = System.Drawing.Color.White;
            this.panel_color.Location = new System.Drawing.Point(213, 76);
            this.panel_color.Name = "panel_color";
            this.panel_color.Size = new System.Drawing.Size(218, 34);
            this.panel_color.TabIndex = 3;
            // 
            // button_add
            // 
            this.button_add.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_add.ForeColor = System.Drawing.Color.Black;
            this.button_add.Location = new System.Drawing.Point(315, 129);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(116, 27);
            this.button_add.TabIndex = 4;
            this.button_add.Text = "Ajouter";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button_add_MouseDown);
            // 
            // Ajouter_un_état
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 168);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.panel_color);
            this.Controls.Add(this.Textbox_name);
            this.Controls.Add(this.ColorPicker_color);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Ajouter_un_état";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Ajouter un état";
            this.Load += new System.EventHandler(this.Ajouter_un_état_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private XanderUI.XUIColorPicker ColorPicker_color;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Textbox_name;
        private System.Windows.Forms.Panel panel_color;
        private System.Windows.Forms.Button button_add;
    }
}