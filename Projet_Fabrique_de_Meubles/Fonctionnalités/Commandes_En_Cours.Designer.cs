namespace Projet_Fabrique_de_Meubles
{
    partial class Commandes_En_Cours
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Commandes_En_Cours));
            this.cbCommande = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DGV_facture = new System.Windows.Forms.DataGridView();
            this.Actualisation = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_facture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Actualisation)).BeginInit();
            this.SuspendLayout();
            // 
            // cbCommande
            // 
            this.cbCommande.FormattingEnabled = true;
            this.cbCommande.Location = new System.Drawing.Point(170, 14);
            this.cbCommande.Name = "cbCommande";
            this.cbCommande.Size = new System.Drawing.Size(121, 21);
            this.cbCommande.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Numero de commande :";
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
            this.DGV_facture.Location = new System.Drawing.Point(11, 45);
            this.DGV_facture.Margin = new System.Windows.Forms.Padding(2);
            this.DGV_facture.Name = "DGV_facture";
            this.DGV_facture.ReadOnly = true;
            this.DGV_facture.RowHeadersVisible = false;
            this.DGV_facture.RowTemplate.Height = 28;
            this.DGV_facture.Size = new System.Drawing.Size(778, 390);
            this.DGV_facture.TabIndex = 10;
            // 
            // Actualisation
            // 
            this.Actualisation.ErrorImage = ((System.Drawing.Image)(resources.GetObject("Actualisation.ErrorImage")));
            this.Actualisation.Image = ((System.Drawing.Image)(resources.GetObject("Actualisation.Image")));
            this.Actualisation.InitialImage = ((System.Drawing.Image)(resources.GetObject("Actualisation.InitialImage")));
            this.Actualisation.Location = new System.Drawing.Point(749, 8);
            this.Actualisation.Name = "Actualisation";
            this.Actualisation.Size = new System.Drawing.Size(28, 27);
            this.Actualisation.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Actualisation.TabIndex = 23;
            this.Actualisation.TabStop = false;
            this.Actualisation.Click += new System.EventHandler(this.Actualisation_Click);
            // 
            // Commandes_En_Cours
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Projet_Fabrique_de_Meubles.Properties.Resources.parement_bois_pas_cher_lambris_mural_pvc;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Actualisation);
            this.Controls.Add(this.DGV_facture);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbCommande);
            this.Name = "Commandes_En_Cours";
            this.Text = "Relevé de commande en cours";
            ((System.ComponentModel.ISupportInitialize)(this.DGV_facture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Actualisation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbCommande;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DGV_facture;
        private System.Windows.Forms.PictureBox Actualisation;
    }
}