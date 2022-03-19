namespace Gestionnaire_de_tâche__Last_
{
    partial class Statistiques
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
            this.btn_graph_circ = new Bunifu.Framework.UI.BunifuImageButton();
            this.label_graphCircular = new System.Windows.Forms.Label();
            this.Btn_statistiqueParChiffre = new Bunifu.Framework.UI.BunifuImageButton();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.btn_graph_circ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_statistiqueParChiffre)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_graph_circ
            // 
            this.btn_graph_circ.BackColor = System.Drawing.Color.Transparent;
            this.btn_graph_circ.Image = global::Gestionnaire_de_tâche__Last_.Properties.Resources._5_icon_icons_com_68890;
            this.btn_graph_circ.ImageActive = null;
            this.btn_graph_circ.Location = new System.Drawing.Point(42, 45);
            this.btn_graph_circ.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_graph_circ.Name = "btn_graph_circ";
            this.btn_graph_circ.Size = new System.Drawing.Size(130, 138);
            this.btn_graph_circ.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_graph_circ.TabIndex = 0;
            this.btn_graph_circ.TabStop = false;
            this.btn_graph_circ.Zoom = 10;
            this.btn_graph_circ.Click += new System.EventHandler(this.label_graphCircular_Click);
            // 
            // label_graphCircular
            // 
            this.label_graphCircular.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_graphCircular.Location = new System.Drawing.Point(21, 207);
            this.label_graphCircular.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_graphCircular.Name = "label_graphCircular";
            this.label_graphCircular.Size = new System.Drawing.Size(166, 60);
            this.label_graphCircular.TabIndex = 1;
            this.label_graphCircular.Text = "Graphique circulaire des états et des prioritées";
            this.label_graphCircular.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label_graphCircular.Click += new System.EventHandler(this.label_graphCircular_Click);
            // 
            // Btn_statistiqueParChiffre
            // 
            this.Btn_statistiqueParChiffre.BackColor = System.Drawing.Color.Transparent;
            this.Btn_statistiqueParChiffre.Image = global::Gestionnaire_de_tâche__Last_.Properties.Resources.Chiffres_et_formes_20273;
            this.Btn_statistiqueParChiffre.ImageActive = null;
            this.Btn_statistiqueParChiffre.Location = new System.Drawing.Point(218, 34);
            this.Btn_statistiqueParChiffre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Btn_statistiqueParChiffre.Name = "Btn_statistiqueParChiffre";
            this.Btn_statistiqueParChiffre.Size = new System.Drawing.Size(164, 162);
            this.Btn_statistiqueParChiffre.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Btn_statistiqueParChiffre.TabIndex = 2;
            this.Btn_statistiqueParChiffre.TabStop = false;
            this.Btn_statistiqueParChiffre.Zoom = 10;
            this.Btn_statistiqueParChiffre.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Btn_statistiqueParChiffre_MouseDown);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(214, 207);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 47);
            this.label1.TabIndex = 3;
            this.label1.Text = "Statistiques par nombres";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Btn_statistiqueParChiffre_MouseDown);
            // 
            // Statistiques
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 304);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btn_statistiqueParChiffre);
            this.Controls.Add(this.label_graphCircular);
            this.Controls.Add(this.btn_graph_circ);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Statistiques";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Statistiques";
            this.Load += new System.EventHandler(this.Statistiques_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btn_graph_circ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_statistiqueParChiffre)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuImageButton btn_graph_circ;
        private System.Windows.Forms.Label label_graphCircular;
        private Bunifu.Framework.UI.BunifuImageButton Btn_statistiqueParChiffre;
        private System.Windows.Forms.Label label1;
    }
}