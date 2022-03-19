namespace Gestionnaire_de_tâche__Last_
{
    partial class Modifier_la_progression
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
            this.trackBar_progression = new System.Windows.Forms.TrackBar();
            this.label_title = new System.Windows.Forms.Label();
            this.label_pourcent = new System.Windows.Forms.Label();
            this.button_done = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_progression)).BeginInit();
            this.SuspendLayout();
            // 
            // trackBar_progression
            // 
            this.trackBar_progression.Location = new System.Drawing.Point(12, 125);
            this.trackBar_progression.Maximum = 100;
            this.trackBar_progression.Name = "trackBar_progression";
            this.trackBar_progression.Size = new System.Drawing.Size(495, 45);
            this.trackBar_progression.TabIndex = 0;
            this.trackBar_progression.Scroll += new System.EventHandler(this.trackBar_progression_Scroll);
            this.trackBar_progression.KeyDown += new System.Windows.Forms.KeyEventHandler(this.trackBar_progression_KeyDown);
            // 
            // label_title
            // 
            this.label_title.Font = new System.Drawing.Font("Verdana", 14F);
            this.label_title.Location = new System.Drawing.Point(12, 9);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(495, 90);
            this.label_title.TabIndex = 1;
            this.label_title.Text = "Modifier la progression de ";
            this.label_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_pourcent
            // 
            this.label_pourcent.AutoSize = true;
            this.label_pourcent.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_pourcent.Location = new System.Drawing.Point(462, 173);
            this.label_pourcent.Name = "label_pourcent";
            this.label_pourcent.Size = new System.Drawing.Size(45, 18);
            this.label_pourcent.TabIndex = 2;
            this.label_pourcent.Text = "00%";
            // 
            // button_done
            // 
            this.button_done.Font = new System.Drawing.Font("Verdana", 10.25F);
            this.button_done.Location = new System.Drawing.Point(12, 173);
            this.button_done.Name = "button_done";
            this.button_done.Size = new System.Drawing.Size(90, 29);
            this.button_done.TabIndex = 3;
            this.button_done.Text = "Valider";
            this.button_done.UseVisualStyleBackColor = true;
            this.button_done.Click += new System.EventHandler(this.button_done_Click);
            // 
            // Modifier_la_progression
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 214);
            this.Controls.Add(this.button_done);
            this.Controls.Add(this.label_pourcent);
            this.Controls.Add(this.label_title);
            this.Controls.Add(this.trackBar_progression);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Modifier_la_progression";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modifier la progression";
            this.Load += new System.EventHandler(this.Modifier_la_progression_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_progression)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar trackBar_progression;
        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.Label label_pourcent;
        private System.Windows.Forms.Button button_done;
    }
}