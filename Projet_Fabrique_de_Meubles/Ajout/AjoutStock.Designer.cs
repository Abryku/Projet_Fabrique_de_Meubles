namespace Projet_Fabrique_de_Meubles.Ajout
{
    partial class AjoutStock
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
            this.FicheProd = new System.Windows.Forms.GroupBox();
            this.lblFicheAjMedGSM = new System.Windows.Forms.Label();
            this.lblFicheAjMedPrenom = new System.Windows.Forms.Label();
            this.lblFicheAjMedNom = new System.Windows.Forms.Label();
            this.tbEtat = new System.Windows.Forms.TextBox();
            this.tbQuantite = new System.Windows.Forms.TextBox();
            this.tbNom = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbDelai = new System.Windows.Forms.TextBox();
            this.AddProduct = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.FicheProd.SuspendLayout();
            this.SuspendLayout();
            // 
            // FicheProd
            // 
            this.FicheProd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.FicheProd.Controls.Add(this.label1);
            this.FicheProd.Controls.Add(this.tbDelai);
            this.FicheProd.Controls.Add(this.tbNom);
            this.FicheProd.Controls.Add(this.lblFicheAjMedGSM);
            this.FicheProd.Controls.Add(this.lblFicheAjMedPrenom);
            this.FicheProd.Controls.Add(this.lblFicheAjMedNom);
            this.FicheProd.Controls.Add(this.tbEtat);
            this.FicheProd.Controls.Add(this.tbQuantite);
            this.FicheProd.Location = new System.Drawing.Point(12, 12);
            this.FicheProd.Name = "FicheProd";
            this.FicheProd.Size = new System.Drawing.Size(377, 229);
            this.FicheProd.TabIndex = 7;
            this.FicheProd.TabStop = false;
            this.FicheProd.Text = "Fiche du produit";
            this.FicheProd.Enter += new System.EventHandler(this.gbAjMed_Enter);
            // 
            // lblFicheAjMedGSM
            // 
            this.lblFicheAjMedGSM.AutoSize = true;
            this.lblFicheAjMedGSM.Location = new System.Drawing.Point(42, 132);
            this.lblFicheAjMedGSM.Name = "lblFicheAjMedGSM";
            this.lblFicheAjMedGSM.Size = new System.Drawing.Size(99, 13);
            this.lblFicheAjMedGSM.TabIndex = 8;
            this.lblFicheAjMedGSM.Text = "Etat de fabrication :";
            // 
            // lblFicheAjMedPrenom
            // 
            this.lblFicheAjMedPrenom.AutoSize = true;
            this.lblFicheAjMedPrenom.Location = new System.Drawing.Point(42, 88);
            this.lblFicheAjMedPrenom.Name = "lblFicheAjMedPrenom";
            this.lblFicheAjMedPrenom.Size = new System.Drawing.Size(53, 13);
            this.lblFicheAjMedPrenom.TabIndex = 7;
            this.lblFicheAjMedPrenom.Text = "Quantité :";
            // 
            // lblFicheAjMedNom
            // 
            this.lblFicheAjMedNom.AutoSize = true;
            this.lblFicheAjMedNom.Location = new System.Drawing.Point(42, 44);
            this.lblFicheAjMedNom.Name = "lblFicheAjMedNom";
            this.lblFicheAjMedNom.Size = new System.Drawing.Size(35, 13);
            this.lblFicheAjMedNom.TabIndex = 6;
            this.lblFicheAjMedNom.Text = "Nom :";
            // 
            // tbEtat
            // 
            this.tbEtat.Location = new System.Drawing.Point(147, 129);
            this.tbEtat.Name = "tbEtat";
            this.tbEtat.Size = new System.Drawing.Size(48, 20);
            this.tbEtat.TabIndex = 3;
            // 
            // tbQuantite
            // 
            this.tbQuantite.Location = new System.Drawing.Point(101, 85);
            this.tbQuantite.Name = "tbQuantite";
            this.tbQuantite.Size = new System.Drawing.Size(40, 20);
            this.tbQuantite.TabIndex = 2;
            // 
            // tbNom
            // 
            this.tbNom.FormattingEnabled = true;
            this.tbNom.Location = new System.Drawing.Point(83, 41);
            this.tbNom.Name = "tbNom";
            this.tbNom.Size = new System.Drawing.Size(212, 21);
            this.tbNom.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Délai de livraison (h) :";
            // 
            // tbDelai
            // 
            this.tbDelai.Location = new System.Drawing.Point(156, 177);
            this.tbDelai.Name = "tbDelai";
            this.tbDelai.Size = new System.Drawing.Size(39, 20);
            this.tbDelai.TabIndex = 10;
            // 
            // AddProduct
            // 
            this.AddProduct.Location = new System.Drawing.Point(23, 247);
            this.AddProduct.Name = "AddProduct";
            this.AddProduct.Size = new System.Drawing.Size(144, 23);
            this.AddProduct.TabIndex = 8;
            this.AddProduct.Text = "Ajouter";
            this.AddProduct.UseVisualStyleBackColor = true;
            this.AddProduct.Click += new System.EventHandler(this.AddProduct_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(224, 247);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(155, 23);
            this.Cancel.TabIndex = 9;
            this.Cancel.Text = "Annuler";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // AjoutStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 290);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.AddProduct);
            this.Controls.Add(this.FicheProd);
            this.Name = "AjoutStock";
            this.Text = "AjoutStock";
            this.FicheProd.ResumeLayout(false);
            this.FicheProd.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox FicheProd;
        private System.Windows.Forms.Label lblFicheAjMedGSM;
        private System.Windows.Forms.Label lblFicheAjMedPrenom;
        private System.Windows.Forms.Label lblFicheAjMedNom;
        private System.Windows.Forms.TextBox tbEtat;
        private System.Windows.Forms.TextBox tbQuantite;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbDelai;
        private System.Windows.Forms.ComboBox tbNom;
        private System.Windows.Forms.Button AddProduct;
        private System.Windows.Forms.Button Cancel;
    }
}