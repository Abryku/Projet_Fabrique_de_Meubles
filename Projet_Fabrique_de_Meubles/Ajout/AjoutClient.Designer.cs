namespace Projet_Fabrique_de_Meubles
{
    partial class AjoutClient
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
            this.gbAjMed = new System.Windows.Forms.GroupBox();
            this.Add_Client = new System.Windows.Forms.Button();
            this.tbMail = new System.Windows.Forms.TextBox();
            this.lblFicheAjDateNaisMed = new System.Windows.Forms.Label();
            this.lblFicheAjMedGSM = new System.Windows.Forms.Label();
            this.lblFicheAjMedPrenom = new System.Windows.Forms.Label();
            this.lblFicheAjMedNom = new System.Windows.Forms.Label();
            this.tbGSM = new System.Windows.Forms.TextBox();
            this.tbPrenom = new System.Windows.Forms.TextBox();
            this.tbNom = new System.Windows.Forms.TextBox();
            this.Annuler_Client = new System.Windows.Forms.Button();
            this.gbAjMed.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbAjMed
            // 
            this.gbAjMed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.gbAjMed.Controls.Add(this.Annuler_Client);
            this.gbAjMed.Controls.Add(this.Add_Client);
            this.gbAjMed.Controls.Add(this.tbMail);
            this.gbAjMed.Controls.Add(this.lblFicheAjDateNaisMed);
            this.gbAjMed.Controls.Add(this.lblFicheAjMedGSM);
            this.gbAjMed.Controls.Add(this.lblFicheAjMedPrenom);
            this.gbAjMed.Controls.Add(this.lblFicheAjMedNom);
            this.gbAjMed.Controls.Add(this.tbGSM);
            this.gbAjMed.Controls.Add(this.tbPrenom);
            this.gbAjMed.Controls.Add(this.tbNom);
            this.gbAjMed.Location = new System.Drawing.Point(12, 12);
            this.gbAjMed.Name = "gbAjMed";
            this.gbAjMed.Size = new System.Drawing.Size(377, 354);
            this.gbAjMed.TabIndex = 5;
            this.gbAjMed.TabStop = false;
            this.gbAjMed.Text = "Fiche du client";
            // 
            // Add_Client
            // 
            this.Add_Client.Location = new System.Drawing.Point(45, 309);
            this.Add_Client.Name = "Add_Client";
            this.Add_Client.Size = new System.Drawing.Size(75, 23);
            this.Add_Client.TabIndex = 4;
            this.Add_Client.Text = "Ajouter";
            this.Add_Client.UseVisualStyleBackColor = true;
            this.Add_Client.Click += new System.EventHandler(this.Add_Client_Click);
            // 
            // tbMail
            // 
            this.tbMail.Location = new System.Drawing.Point(45, 246);
            this.tbMail.Name = "tbMail";
            this.tbMail.Size = new System.Drawing.Size(282, 20);
            this.tbMail.TabIndex = 3;
            // 
            // lblFicheAjDateNaisMed
            // 
            this.lblFicheAjDateNaisMed.AutoSize = true;
            this.lblFicheAjDateNaisMed.Location = new System.Drawing.Point(42, 230);
            this.lblFicheAjDateNaisMed.Name = "lblFicheAjDateNaisMed";
            this.lblFicheAjDateNaisMed.Size = new System.Drawing.Size(32, 13);
            this.lblFicheAjDateNaisMed.TabIndex = 10;
            this.lblFicheAjDateNaisMed.Text = "Email";
            // 
            // lblFicheAjMedGSM
            // 
            this.lblFicheAjMedGSM.AutoSize = true;
            this.lblFicheAjMedGSM.Location = new System.Drawing.Point(42, 169);
            this.lblFicheAjMedGSM.Name = "lblFicheAjMedGSM";
            this.lblFicheAjMedGSM.Size = new System.Drawing.Size(64, 13);
            this.lblFicheAjMedGSM.TabIndex = 8;
            this.lblFicheAjMedGSM.Text = "Téléphone :";
            // 
            // lblFicheAjMedPrenom
            // 
            this.lblFicheAjMedPrenom.AutoSize = true;
            this.lblFicheAjMedPrenom.Location = new System.Drawing.Point(42, 109);
            this.lblFicheAjMedPrenom.Name = "lblFicheAjMedPrenom";
            this.lblFicheAjMedPrenom.Size = new System.Drawing.Size(49, 13);
            this.lblFicheAjMedPrenom.TabIndex = 7;
            this.lblFicheAjMedPrenom.Text = "Prénom :";
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
            // tbGSM
            // 
            this.tbGSM.Location = new System.Drawing.Point(45, 185);
            this.tbGSM.Name = "tbGSM";
            this.tbGSM.Size = new System.Drawing.Size(282, 20);
            this.tbGSM.TabIndex = 2;
            // 
            // tbPrenom
            // 
            this.tbPrenom.Location = new System.Drawing.Point(45, 125);
            this.tbPrenom.Name = "tbPrenom";
            this.tbPrenom.Size = new System.Drawing.Size(282, 20);
            this.tbPrenom.TabIndex = 1;
            // 
            // tbNom
            // 
            this.tbNom.Location = new System.Drawing.Point(45, 69);
            this.tbNom.Name = "tbNom";
            this.tbNom.Size = new System.Drawing.Size(282, 20);
            this.tbNom.TabIndex = 0;
            // 
            // Annuler_Client
            // 
            this.Annuler_Client.Location = new System.Drawing.Point(252, 309);
            this.Annuler_Client.Name = "Annuler_Client";
            this.Annuler_Client.Size = new System.Drawing.Size(75, 23);
            this.Annuler_Client.TabIndex = 5;
            this.Annuler_Client.Text = "Annuler";
            this.Annuler_Client.UseVisualStyleBackColor = true;
            this.Annuler_Client.Click += new System.EventHandler(this.Annuler_Client_Click);
            // 
            // AjoutClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 381);
            this.Controls.Add(this.gbAjMed);
            this.Name = "AjoutClient";
            this.Text = "AjoutClient";
            this.gbAjMed.ResumeLayout(false);
            this.gbAjMed.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbAjMed;
        private System.Windows.Forms.TextBox tbMail;
        private System.Windows.Forms.Label lblFicheAjDateNaisMed;
        private System.Windows.Forms.Label lblFicheAjMedGSM;
        private System.Windows.Forms.Label lblFicheAjMedPrenom;
        private System.Windows.Forms.Label lblFicheAjMedNom;
        private System.Windows.Forms.TextBox tbGSM;
        private System.Windows.Forms.TextBox tbPrenom;
        private System.Windows.Forms.TextBox tbNom;
        private System.Windows.Forms.Button Add_Client;
        private System.Windows.Forms.Button Annuler_Client;
    }
}