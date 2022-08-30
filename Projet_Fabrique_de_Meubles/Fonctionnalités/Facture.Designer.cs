namespace Projet_Fabrique_de_Meubles
{
    partial class Facture
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Facture));
            this.DGV_facture = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.cbCommande = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.SortieFacture = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_facture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // DGV_facture
            // 
            this.DGV_facture.AllowUserToAddRows = false;
            this.DGV_facture.AllowUserToDeleteRows = false;
            this.DGV_facture.AllowUserToResizeRows = false;
            this.DGV_facture.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_facture.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DGV_facture.BackgroundColor = System.Drawing.Color.SeaShell;
            this.DGV_facture.ColumnHeadersHeight = 30;
            this.DGV_facture.GridColor = System.Drawing.SystemColors.InfoText;
            this.DGV_facture.Location = new System.Drawing.Point(11, 40);
            this.DGV_facture.Margin = new System.Windows.Forms.Padding(2);
            this.DGV_facture.Name = "DGV_facture";
            this.DGV_facture.ReadOnly = true;
            this.DGV_facture.RowHeadersVisible = false;
            this.DGV_facture.RowTemplate.Height = 28;
            this.DGV_facture.Size = new System.Drawing.Size(778, 399);
            this.DGV_facture.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Numero de commande :";
            // 
            // cbCommande
            // 
            this.cbCommande.FormattingEnabled = true;
            this.cbCommande.Location = new System.Drawing.Point(176, 12);
            this.cbCommande.Name = "cbCommande";
            this.cbCommande.Size = new System.Drawing.Size(142, 21);
            this.cbCommande.TabIndex = 11;
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(761, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(28, 27);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // SortieFacture
            // 
            this.SortieFacture.Location = new System.Drawing.Point(324, 12);
            this.SortieFacture.Name = "SortieFacture";
            this.SortieFacture.Size = new System.Drawing.Size(91, 23);
            this.SortieFacture.TabIndex = 23;
            this.SortieFacture.Text = "Sortir la facture";
            this.SortieFacture.UseVisualStyleBackColor = true;
            this.SortieFacture.Click += new System.EventHandler(this.SortieFacture_Click);
            // 
            // Facture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Projet_Fabrique_de_Meubles.Properties.Resources.parement_bois_pas_cher_lambris_mural_pvc;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SortieFacture);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cbCommande);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DGV_facture);
            this.Name = "Facture";
            this.Text = "Facture";
            ((System.ComponentModel.ISupportInitialize)(this.DGV_facture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV_facture;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbCommande;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button SortieFacture;
    }
}