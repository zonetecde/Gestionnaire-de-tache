namespace Gestionnaire_de_tâche__Last_
{
    partial class Ajouter_une_date_d_échéance
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
            this.Datepicker_date = new Bunifu.Framework.UI.BunifuDatepicker();
            this.label_tâche = new System.Windows.Forms.Label();
            this.button_done = new System.Windows.Forms.Button();
            this.button_removeDate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Datepicker_date
            // 
            this.Datepicker_date.BackColor = System.Drawing.Color.SeaGreen;
            this.Datepicker_date.BorderRadius = 0;
            this.Datepicker_date.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Datepicker_date.ForeColor = System.Drawing.Color.White;
            this.Datepicker_date.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.Datepicker_date.FormatCustom = "dd/MM/aaaa";
            this.Datepicker_date.Location = new System.Drawing.Point(105, 103);
            this.Datepicker_date.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.Datepicker_date.Name = "Datepicker_date";
            this.Datepicker_date.Size = new System.Drawing.Size(303, 36);
            this.Datepicker_date.TabIndex = 0;
            this.Datepicker_date.Value = new System.DateTime(2020, 1, 3, 0, 0, 0, 0);
            // 
            // label_tâche
            // 
            this.label_tâche.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_tâche.Location = new System.Drawing.Point(12, 9);
            this.label_tâche.Name = "label_tâche";
            this.label_tâche.Size = new System.Drawing.Size(493, 64);
            this.label_tâche.TabIndex = 1;
            this.label_tâche.Text = "Ajouter une date d\'échéance pour ";
            this.label_tâche.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_done
            // 
            this.button_done.Font = new System.Drawing.Font("Verdana", 12.25F);
            this.button_done.Location = new System.Drawing.Point(15, 172);
            this.button_done.Name = "button_done";
            this.button_done.Size = new System.Drawing.Size(242, 27);
            this.button_done.TabIndex = 2;
            this.button_done.Text = "Valider";
            this.button_done.UseVisualStyleBackColor = true;
            this.button_done.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button_done_MouseDown);
            // 
            // button_removeDate
            // 
            this.button_removeDate.Font = new System.Drawing.Font("Verdana", 11.25F);
            this.button_removeDate.Location = new System.Drawing.Point(263, 172);
            this.button_removeDate.Name = "button_removeDate";
            this.button_removeDate.Size = new System.Drawing.Size(242, 27);
            this.button_removeDate.TabIndex = 3;
            this.button_removeDate.Text = "Enlever la date d\'échéance";
            this.button_removeDate.UseVisualStyleBackColor = true;
            this.button_removeDate.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button_removeDate_MouseDown);
            // 
            // Ajouter_une_date_d_échéance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 211);
            this.Controls.Add(this.button_removeDate);
            this.Controls.Add(this.button_done);
            this.Controls.Add(this.label_tâche);
            this.Controls.Add(this.Datepicker_date);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Ajouter_une_date_d_échéance";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ajouter une date d\'échéance";
            this.Load += new System.EventHandler(this.Ajouter_une_date_d_échéance_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuDatepicker Datepicker_date;
        private System.Windows.Forms.Label label_tâche;
        private System.Windows.Forms.Button button_done;
        private System.Windows.Forms.Button button_removeDate;
    }
}