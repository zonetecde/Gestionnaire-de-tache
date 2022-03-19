namespace Gestionnaire_de_tâche__Last_
{
    partial class Statistiques_Graph
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Statistiques_Graph));
            this.chart_graphic = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.listBox_sousProjet = new System.Windows.Forms.ListBox();
            this.Switch_ = new Bunifu.Framework.UI.BunifuiOSSwitch();
            this.label_statut = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart_graphic)).BeginInit();
            this.SuspendLayout();
            // 
            // chart_graphic
            // 
            chartArea3.Name = "ChartArea1";
            this.chart_graphic.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart_graphic.Legends.Add(legend3);
            this.chart_graphic.Location = new System.Drawing.Point(387, 15);
            this.chart_graphic.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chart_graphic.Name = "chart_graphic";
            this.chart_graphic.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series3.Legend = "Legend1";
            series3.Name = "s1";
            this.chart_graphic.Series.Add(series3);
            this.chart_graphic.Size = new System.Drawing.Size(648, 524);
            this.chart_graphic.TabIndex = 0;
            this.chart_graphic.Text = "chart1";
            // 
            // listBox_sousProjet
            // 
            this.listBox_sousProjet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBox_sousProjet.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox_sousProjet.FormattingEnabled = true;
            this.listBox_sousProjet.ItemHeight = 25;
            this.listBox_sousProjet.Location = new System.Drawing.Point(16, 15);
            this.listBox_sousProjet.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBox_sousProjet.Name = "listBox_sousProjet";
            this.listBox_sousProjet.Size = new System.Drawing.Size(362, 477);
            this.listBox_sousProjet.TabIndex = 1;
            this.listBox_sousProjet.SelectedIndexChanged += new System.EventHandler(this.listBox_sousProjet_SelectedIndexChanged);
            // 
            // Switch_
            // 
            this.Switch_.BackColor = System.Drawing.Color.Transparent;
            this.Switch_.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Switch_.BackgroundImage")));
            this.Switch_.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Switch_.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Switch_.Location = new System.Drawing.Point(164, 512);
            this.Switch_.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Switch_.Name = "Switch_";
            this.Switch_.OffColor = System.Drawing.Color.Fuchsia;
            this.Switch_.OnColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Switch_.Size = new System.Drawing.Size(43, 25);
            this.Switch_.TabIndex = 2;
            this.Switch_.Value = true;
            this.Switch_.OnValueChange += new System.EventHandler(this.Switch__OnValueChange);
            // 
            // label_statut
            // 
            this.label_statut.AutoSize = true;
            this.label_statut.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_statut.Location = new System.Drawing.Point(229, 516);
            this.label_statut.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_statut.Name = "label_statut";
            this.label_statut.Size = new System.Drawing.Size(75, 25);
            this.label_statut.TabIndex = 3;
            this.label_statut.Text = "Statut";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(67, 516);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Priorité";
            // 
            // Statistiques
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_statut);
            this.Controls.Add(this.Switch_);
            this.Controls.Add(this.listBox_sousProjet);
            this.Controls.Add(this.chart_graphic);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Statistiques";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Statistiques (Graphique)";
            this.Load += new System.EventHandler(this.Statistiques_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart_graphic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart_graphic;
        private System.Windows.Forms.ListBox listBox_sousProjet;
        private Bunifu.Framework.UI.BunifuiOSSwitch Switch_;
        private System.Windows.Forms.Label label_statut;
        private System.Windows.Forms.Label label1;
    }
}