namespace Projet_Fabrique_de_Meubles.Ajout
{
    partial class AjoutProduit
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
            this.tbTmpsFab = new System.Windows.Forms.TextBox();
            this.tbPU = new System.Windows.Forms.TextBox();
            this.tbNom = new System.Windows.Forms.TextBox();
            this.Cancel = new System.Windows.Forms.Button();
            this.AjoutProd = new System.Windows.Forms.Button();
            this.FicheProd.SuspendLayout();
            this.SuspendLayout();
            // 
            // FicheProd
            // 
            this.FicheProd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.FicheProd.Controls.Add(this.lblFicheAjMedGSM);
            this.FicheProd.Controls.Add(this.lblFicheAjMedPrenom);
            this.FicheProd.Controls.Add(this.lblFicheAjMedNom);
            this.FicheProd.Controls.Add(this.tbTmpsFab);
            this.FicheProd.Controls.Add(this.tbPU);
            this.FicheProd.Controls.Add(this.tbNom);
            this.FicheProd.Location = new System.Drawing.Point(12, 13);
            this.FicheProd.Name = "FicheProd";
            this.FicheProd.Size = new System.Drawing.Size(377, 153);
            this.FicheProd.TabIndex = 6;
            this.FicheProd.TabStop = false;
            this.FicheProd.Text = "Fiche du produit";
            // 
            // lblFicheAjMedGSM
            // 
            this.lblFicheAjMedGSM.AutoSize = true;
            this.lblFicheAjMedGSM.Location = new System.Drawing.Point(168, 109);
            this.lblFicheAjMedGSM.Name = "lblFicheAjMedGSM";
            this.lblFicheAjMedGSM.Size = new System.Drawing.Size(127, 13);
            this.lblFicheAjMedGSM.TabIndex = 8;
            this.lblFicheAjMedGSM.Text = "Temps de fabrication (h) :";
            // 
            // lblFicheAjMedPrenom
            // 
            this.lblFicheAjMedPrenom.AutoSize = true;
            this.lblFicheAjMedPrenom.Location = new System.Drawing.Point(42, 109);
            this.lblFicheAjMedPrenom.Name = "lblFicheAjMedPrenom";
            this.lblFicheAjMedPrenom.Size = new System.Drawing.Size(67, 13);
            this.lblFicheAjMedPrenom.TabIndex = 7;
            this.lblFicheAjMedPrenom.Text = "Prix unitaire :";
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
            // tbTmpsFab
            // 
            this.tbTmpsFab.Location = new System.Drawing.Point(301, 106);
            this.tbTmpsFab.Name = "tbTmpsFab";
            this.tbTmpsFab.Size = new System.Drawing.Size(39, 20);
            this.tbTmpsFab.TabIndex = 3;
            // 
            // tbPU
            // 
            this.tbPU.Location = new System.Drawing.Point(115, 106);
            this.tbPU.Name = "tbPU";
            this.tbPU.Size = new System.Drawing.Size(29, 20);
            this.tbPU.TabIndex = 2;
            // 
            // tbNom
            // 
            this.tbNom.Location = new System.Drawing.Point(45, 69);
            this.tbNom.Name = "tbNom";
            this.tbNom.Size = new System.Drawing.Size(295, 20);
            this.tbNom.TabIndex = 1;
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(259, 172);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 15;
            this.Cancel.Text = "Annuler";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // AjoutProd
            // 
            this.AjoutProd.Location = new System.Drawing.Point(52, 172);
            this.AjoutProd.Name = "AjoutProd";
            this.AjoutProd.Size = new System.Drawing.Size(75, 23);
            this.AjoutProd.TabIndex = 14;
            this.AjoutProd.Text = "Ajouter";
            this.AjoutProd.UseVisualStyleBackColor = true;
            this.AjoutProd.Click += new System.EventHandler(this.AjoutProd_Click);
            // 
            // AjoutProduit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 207);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.AjoutProd);
            this.Controls.Add(this.FicheProd);
            this.Name = "AjoutProduit";
            this.Text = "AjoutPrduit";
            this.FicheProd.ResumeLayout(false);
            this.FicheProd.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox FicheProd;
        private System.Windows.Forms.Label lblFicheAjMedGSM;
        private System.Windows.Forms.Label lblFicheAjMedPrenom;
        private System.Windows.Forms.Label lblFicheAjMedNom;
        private System.Windows.Forms.TextBox tbTmpsFab;
        private System.Windows.Forms.TextBox tbPU;
        private System.Windows.Forms.TextBox tbNom;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button AjoutProd;
    }
}