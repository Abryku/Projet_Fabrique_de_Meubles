namespace Projet_Fabrique_de_Meubles.Modification
{
    partial class EditStock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditStock));
            this.FicheProduit = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbID = new System.Windows.Forms.ComboBox();
            this.Annuler_Stock = new System.Windows.Forms.Button();
            this.edit_Stock = new System.Windows.Forms.Button();
            this.tbDelaiLiv = new System.Windows.Forms.TextBox();
            this.lblFicheAjDateNaisMed = new System.Windows.Forms.Label();
            this.lblFicheAjMedGSM = new System.Windows.Forms.Label();
            this.lblFicheAjMedPrenom = new System.Windows.Forms.Label();
            this.tbEtatFab = new System.Windows.Forms.TextBox();
            this.tbQuantite = new System.Windows.Forms.TextBox();
            this.Refresh = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbIDMeuble = new System.Windows.Forms.TextBox();
            this.FicheProduit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Refresh)).BeginInit();
            this.SuspendLayout();
            // 
            // FicheProduit
            // 
            this.FicheProduit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.FicheProduit.Controls.Add(this.label2);
            this.FicheProduit.Controls.Add(this.tbIDMeuble);
            this.FicheProduit.Controls.Add(this.Refresh);
            this.FicheProduit.Controls.Add(this.label1);
            this.FicheProduit.Controls.Add(this.tbID);
            this.FicheProduit.Controls.Add(this.Annuler_Stock);
            this.FicheProduit.Controls.Add(this.edit_Stock);
            this.FicheProduit.Controls.Add(this.tbDelaiLiv);
            this.FicheProduit.Controls.Add(this.lblFicheAjDateNaisMed);
            this.FicheProduit.Controls.Add(this.lblFicheAjMedGSM);
            this.FicheProduit.Controls.Add(this.lblFicheAjMedPrenom);
            this.FicheProduit.Controls.Add(this.tbEtatFab);
            this.FicheProduit.Controls.Add(this.tbQuantite);
            this.FicheProduit.Location = new System.Drawing.Point(12, 12);
            this.FicheProduit.Name = "FicheProduit";
            this.FicheProduit.Size = new System.Drawing.Size(279, 243);
            this.FicheProduit.TabIndex = 7;
            this.FicheProduit.TabStop = false;
            this.FicheProduit.Text = "Fiche du produit";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(154, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "ID stock :";
            // 
            // tbID
            // 
            this.tbID.FormattingEnabled = true;
            this.tbID.Location = new System.Drawing.Point(213, 0);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(66, 21);
            this.tbID.TabIndex = 11;
            // 
            // Annuler_Stock
            // 
            this.Annuler_Stock.Location = new System.Drawing.Point(178, 188);
            this.Annuler_Stock.Name = "Annuler_Stock";
            this.Annuler_Stock.Size = new System.Drawing.Size(75, 23);
            this.Annuler_Stock.TabIndex = 5;
            this.Annuler_Stock.Text = "Annuler";
            this.Annuler_Stock.UseVisualStyleBackColor = true;
            this.Annuler_Stock.Click += new System.EventHandler(this.Annuler_Stock_Click);
            // 
            // edit_Stock
            // 
            this.edit_Stock.Location = new System.Drawing.Point(46, 188);
            this.edit_Stock.Name = "edit_Stock";
            this.edit_Stock.Size = new System.Drawing.Size(75, 23);
            this.edit_Stock.TabIndex = 4;
            this.edit_Stock.Text = "Editer";
            this.edit_Stock.UseVisualStyleBackColor = true;
            this.edit_Stock.Click += new System.EventHandler(this.edit_Stock_Click);
            // 
            // tbDelaiLiv
            // 
            this.tbDelaiLiv.Location = new System.Drawing.Point(133, 141);
            this.tbDelaiLiv.Name = "tbDelaiLiv";
            this.tbDelaiLiv.Size = new System.Drawing.Size(135, 20);
            this.tbDelaiLiv.TabIndex = 3;
            // 
            // lblFicheAjDateNaisMed
            // 
            this.lblFicheAjDateNaisMed.AutoSize = true;
            this.lblFicheAjDateNaisMed.Location = new System.Drawing.Point(28, 144);
            this.lblFicheAjDateNaisMed.Name = "lblFicheAjDateNaisMed";
            this.lblFicheAjDateNaisMed.Size = new System.Drawing.Size(93, 13);
            this.lblFicheAjDateNaisMed.TabIndex = 10;
            this.lblFicheAjDateNaisMed.Text = "Délai de livraison :";
            // 
            // lblFicheAjMedGSM
            // 
            this.lblFicheAjMedGSM.AutoSize = true;
            this.lblFicheAjMedGSM.Location = new System.Drawing.Point(28, 92);
            this.lblFicheAjMedGSM.Name = "lblFicheAjMedGSM";
            this.lblFicheAjMedGSM.Size = new System.Drawing.Size(99, 13);
            this.lblFicheAjMedGSM.TabIndex = 8;
            this.lblFicheAjMedGSM.Text = "Etat de fabrication :";
            // 
            // lblFicheAjMedPrenom
            // 
            this.lblFicheAjMedPrenom.AutoSize = true;
            this.lblFicheAjMedPrenom.Location = new System.Drawing.Point(175, 43);
            this.lblFicheAjMedPrenom.Name = "lblFicheAjMedPrenom";
            this.lblFicheAjMedPrenom.Size = new System.Drawing.Size(53, 13);
            this.lblFicheAjMedPrenom.TabIndex = 7;
            this.lblFicheAjMedPrenom.Text = "Quantité :";
            // 
            // tbEtatFab
            // 
            this.tbEtatFab.Location = new System.Drawing.Point(133, 89);
            this.tbEtatFab.Name = "tbEtatFab";
            this.tbEtatFab.Size = new System.Drawing.Size(135, 20);
            this.tbEtatFab.TabIndex = 2;
            // 
            // tbQuantite
            // 
            this.tbQuantite.Location = new System.Drawing.Point(234, 40);
            this.tbQuantite.Name = "tbQuantite";
            this.tbQuantite.Size = new System.Drawing.Size(34, 20);
            this.tbQuantite.TabIndex = 1;
            // 
            // Refresh
            // 
            this.Refresh.ErrorImage = ((System.Drawing.Image)(resources.GetObject("Refresh.ErrorImage")));
            this.Refresh.Image = ((System.Drawing.Image)(resources.GetObject("Refresh.Image")));
            this.Refresh.InitialImage = ((System.Drawing.Image)(resources.GetObject("Refresh.InitialImage")));
            this.Refresh.Location = new System.Drawing.Point(7, 200);
            this.Refresh.Name = "Refresh";
            this.Refresh.Size = new System.Drawing.Size(28, 27);
            this.Refresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Refresh.TabIndex = 22;
            this.Refresh.TabStop = false;
            this.Refresh.Click += new System.EventHandler(this.Refresh_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "ID Meuble :";
            // 
            // tbIDMeuble
            // 
            this.tbIDMeuble.Location = new System.Drawing.Point(96, 37);
            this.tbIDMeuble.Name = "tbIDMeuble";
            this.tbIDMeuble.Size = new System.Drawing.Size(34, 20);
            this.tbIDMeuble.TabIndex = 23;
            // 
            // EditStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 269);
            this.Controls.Add(this.FicheProduit);
            this.Name = "EditStock";
            this.Text = "EditStock";
            this.FicheProduit.ResumeLayout(false);
            this.FicheProduit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Refresh)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox FicheProduit;
        private System.Windows.Forms.PictureBox Refresh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox tbID;
        private System.Windows.Forms.Button Annuler_Stock;
        private System.Windows.Forms.Button edit_Stock;
        private System.Windows.Forms.TextBox tbDelaiLiv;
        private System.Windows.Forms.Label lblFicheAjDateNaisMed;
        private System.Windows.Forms.Label lblFicheAjMedGSM;
        private System.Windows.Forms.Label lblFicheAjMedPrenom;
        private System.Windows.Forms.TextBox tbEtatFab;
        private System.Windows.Forms.TextBox tbQuantite;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbIDMeuble;
    }
}