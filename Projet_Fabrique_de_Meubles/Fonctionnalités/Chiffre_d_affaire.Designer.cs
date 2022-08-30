namespace Projet_Fabrique_de_Meubles
{
    partial class Chiffre_d_affaire
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
            this.label1 = new System.Windows.Forms.Label();
            this.mcDate = new System.Windows.Forms.MonthCalendar();
            this.DateSélectionnée = new System.Windows.Forms.Button();
            this.tbDate = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label1.Location = new System.Drawing.Point(284, 225);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Date :";
            // 
            // mcDate
            // 
            this.mcDate.Location = new System.Drawing.Point(287, 11);
            this.mcDate.Name = "mcDate";
            this.mcDate.TabIndex = 23;
            // 
            // DateSélectionnée
            // 
            this.DateSélectionnée.Location = new System.Drawing.Point(329, 185);
            this.DateSélectionnée.Name = "DateSélectionnée";
            this.DateSélectionnée.Size = new System.Drawing.Size(141, 23);
            this.DateSélectionnée.TabIndex = 24;
            this.DateSélectionnée.Text = "Valider la date";
            this.DateSélectionnée.UseVisualStyleBackColor = true;
            this.DateSélectionnée.Click += new System.EventHandler(this.DateSélectionnée_Click);
            // 
            // tbDate
            // 
            this.tbDate.Location = new System.Drawing.Point(347, 224);
            this.tbDate.Name = "tbDate";
            this.tbDate.Size = new System.Drawing.Size(100, 20);
            this.tbDate.TabIndex = 25;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 11);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(263, 420);
            this.listBox1.TabIndex = 26;
            // 
            // Chiffre_d_affaire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Projet_Fabrique_de_Meubles.Properties.Resources.parement_bois_pas_cher_lambris_mural_pvc;
            this.ClientSize = new System.Drawing.Size(535, 450);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.tbDate);
            this.Controls.Add(this.DateSélectionnée);
            this.Controls.Add(this.mcDate);
            this.Controls.Add(this.label1);
            this.Name = "Chiffre_d_affaire";
            this.Text = "Chiffre d\'affaire hebdomadaire";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MonthCalendar mcDate;
        private System.Windows.Forms.Button DateSélectionnée;
        private System.Windows.Forms.TextBox tbDate;
        private System.Windows.Forms.ListBox listBox1;
    }
}