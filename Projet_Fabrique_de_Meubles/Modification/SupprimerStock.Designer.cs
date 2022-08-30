namespace Projet_Fabrique_de_Meubles.Modification
{
    partial class SupprimerStock
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
            this.Cancel = new System.Windows.Forms.Button();
            this.DelProduct = new System.Windows.Forms.Button();
            this.SuppSto = new System.Windows.Forms.GroupBox();
            this.tbID_Meubles = new System.Windows.Forms.ComboBox();
            this.lblFicheAjMedNom = new System.Windows.Forms.Label();
            this.SuppSto.SuspendLayout();
            this.SuspendLayout();
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(222, 108);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(155, 23);
            this.Cancel.TabIndex = 12;
            this.Cancel.Text = "Annuler";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // DelProduct
            // 
            this.DelProduct.Location = new System.Drawing.Point(21, 108);
            this.DelProduct.Name = "DelProduct";
            this.DelProduct.Size = new System.Drawing.Size(144, 23);
            this.DelProduct.TabIndex = 11;
            this.DelProduct.Text = "Supprimer";
            this.DelProduct.UseVisualStyleBackColor = true;
            this.DelProduct.Click += new System.EventHandler(this.DelProduct_Click);
            // 
            // SuppSto
            // 
            this.SuppSto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.SuppSto.Controls.Add(this.tbID_Meubles);
            this.SuppSto.Controls.Add(this.lblFicheAjMedNom);
            this.SuppSto.Location = new System.Drawing.Point(12, 12);
            this.SuppSto.Name = "SuppSto";
            this.SuppSto.Size = new System.Drawing.Size(377, 90);
            this.SuppSto.TabIndex = 10;
            this.SuppSto.TabStop = false;
            this.SuppSto.Text = "Produit à supprimer";
            // 
            // tbID_Meubles
            // 
            this.tbID_Meubles.FormattingEnabled = true;
            this.tbID_Meubles.Location = new System.Drawing.Point(83, 41);
            this.tbID_Meubles.Name = "tbID_Meubles";
            this.tbID_Meubles.Size = new System.Drawing.Size(212, 21);
            this.tbID_Meubles.TabIndex = 9;
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
            // SupprimerStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 145);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.DelProduct);
            this.Controls.Add(this.SuppSto);
            this.Name = "SupprimerStock";
            this.Text = "SupprimerStock";
            this.SuppSto.ResumeLayout(false);
            this.SuppSto.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button DelProduct;
        private System.Windows.Forms.GroupBox SuppSto;
        private System.Windows.Forms.ComboBox tbID_Meubles;
        private System.Windows.Forms.Label lblFicheAjMedNom;
    }
}