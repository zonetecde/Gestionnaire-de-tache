namespace Gestionnaire_de_tâche__Last_
{
    partial class Trie_du_projet_importé
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
            this.listView_projet_checkbox = new System.Windows.Forms.TreeView();
            this.button_import = new System.Windows.Forms.Button();
            this.button_cancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.treeView_data = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // listView_projet_checkbox
            // 
            this.listView_projet_checkbox.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView_projet_checkbox.Location = new System.Drawing.Point(12, 12);
            this.listView_projet_checkbox.Name = "listView_projet_checkbox";
            this.listView_projet_checkbox.Size = new System.Drawing.Size(374, 388);
            this.listView_projet_checkbox.TabIndex = 1;
            // 
            // button_import
            // 
            this.button_import.Font = new System.Drawing.Font("Verdana", 12.75F);
            this.button_import.Location = new System.Drawing.Point(12, 406);
            this.button_import.Name = "button_import";
            this.button_import.Size = new System.Drawing.Size(164, 32);
            this.button_import.TabIndex = 2;
            this.button_import.Text = "Importer";
            this.button_import.UseVisualStyleBackColor = true;
            this.button_import.Click += new System.EventHandler(this.button_import_Click);
            // 
            // button_cancel
            // 
            this.button_cancel.Font = new System.Drawing.Font("Verdana", 12.75F);
            this.button_cancel.Location = new System.Drawing.Point(223, 406);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(164, 32);
            this.button_cancel.TabIndex = 3;
            this.button_cancel.Text = "Annuler";
            this.button_cancel.UseVisualStyleBackColor = true;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 10F);
            this.label1.Location = new System.Drawing.Point(1, 441);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(397, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Les images liées aux projets ne seront pas importées !";
            // 
            // treeView_data
            // 
            this.treeView_data.CheckBoxes = true;
            this.treeView_data.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeView_data.Location = new System.Drawing.Point(399, 12);
            this.treeView_data.Name = "treeView_data";
            this.treeView_data.Size = new System.Drawing.Size(374, 388);
            this.treeView_data.TabIndex = 5;
            // 
            // Trie_du_projet_importé
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 462);
            this.Controls.Add(this.treeView_data);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.button_import);
            this.Controls.Add(this.listView_projet_checkbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Trie_du_projet_importé";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vue des projets importées";
            this.Load += new System.EventHandler(this.Trie_du_projet_importé_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView listView_projet_checkbox;
        private System.Windows.Forms.Button button_import;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TreeView treeView_data;
    }
}