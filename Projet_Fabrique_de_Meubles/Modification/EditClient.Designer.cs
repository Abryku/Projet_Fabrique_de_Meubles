namespace Projet_Fabrique_de_Meubles.Modification
{
    partial class EditClient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditClient));
            this.FicheClient = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbID = new System.Windows.Forms.ComboBox();
            this.Annuler_Client = new System.Windows.Forms.Button();
            this.edit_Client = new System.Windows.Forms.Button();
            this.tbMail = new System.Windows.Forms.TextBox();
            this.lblFicheAjDateNaisMed = new System.Windows.Forms.Label();
            this.lblFicheAjMedGSM = new System.Windows.Forms.Label();
            this.lblFicheAjMedPrenom = new System.Windows.Forms.Label();
            this.lblFicheAjMedNom = new System.Windows.Forms.Label();
            this.tbGSM = new System.Windows.Forms.TextBox();
            this.tbPrenom = new System.Windows.Forms.TextBox();
            this.tbNom = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.FicheClient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // FicheClient
            // 
            this.FicheClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.FicheClient.Controls.Add(this.button1);
            this.FicheClient.Controls.Add(this.pictureBox1);
            this.FicheClient.Controls.Add(this.label1);
            this.FicheClient.Controls.Add(this.tbID);
            this.FicheClient.Controls.Add(this.Annuler_Client);
            this.FicheClient.Controls.Add(this.edit_Client);
            this.FicheClient.Controls.Add(this.tbMail);
            this.FicheClient.Controls.Add(this.lblFicheAjDateNaisMed);
            this.FicheClient.Controls.Add(this.lblFicheAjMedGSM);
            this.FicheClient.Controls.Add(this.lblFicheAjMedPrenom);
            this.FicheClient.Controls.Add(this.lblFicheAjMedNom);
            this.FicheClient.Controls.Add(this.tbGSM);
            this.FicheClient.Controls.Add(this.tbPrenom);
            this.FicheClient.Controls.Add(this.tbNom);
            this.FicheClient.Location = new System.Drawing.Point(12, 12);
            this.FicheClient.Name = "FicheClient";
            this.FicheClient.Size = new System.Drawing.Size(377, 354);
            this.FicheClient.TabIndex = 6;
            this.FicheClient.TabStop = false;
            this.FicheClient.Text = "Fiche du client";
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(6, 321);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(28, 27);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(220, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "ID :";
            // 
            // tbID
            // 
            this.tbID.FormattingEnabled = true;
            this.tbID.Location = new System.Drawing.Point(250, 0);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(121, 21);
            this.tbID.TabIndex = 11;
            // 
            // Annuler_Client
            // 
            this.Annuler_Client.Location = new System.Drawing.Point(252, 309);
            this.Annuler_Client.Name = "Annuler_Client";
            this.Annuler_Client.Size = new System.Drawing.Size(75, 23);
            this.Annuler_Client.TabIndex = 5;
            this.Annuler_Client.Text = "Annuler";
            this.Annuler_Client.UseVisualStyleBackColor = true;
            this.Annuler_Client.Click += new System.EventHandler(this.Annuler_Client_Click_1);
            // 
            // edit_Client
            // 
            this.edit_Client.Location = new System.Drawing.Point(45, 309);
            this.edit_Client.Name = "edit_Client";
            this.edit_Client.Size = new System.Drawing.Size(75, 23);
            this.edit_Client.TabIndex = 4;
            this.edit_Client.Text = "Editer";
            this.edit_Client.UseVisualStyleBackColor = true;
            this.edit_Client.Click += new System.EventHandler(this.edit_Client_Click);
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(316, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(10, 8);
            this.button1.TabIndex = 23;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // EditClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 390);
            this.Controls.Add(this.FicheClient);
            this.Name = "EditClient";
            this.Text = "EditClient";
            this.FicheClient.ResumeLayout(false);
            this.FicheClient.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox FicheClient;
        private System.Windows.Forms.Button Annuler_Client;
        private System.Windows.Forms.Button edit_Client;
        private System.Windows.Forms.TextBox tbMail;
        private System.Windows.Forms.Label lblFicheAjDateNaisMed;
        private System.Windows.Forms.Label lblFicheAjMedGSM;
        private System.Windows.Forms.Label lblFicheAjMedPrenom;
        private System.Windows.Forms.Label lblFicheAjMedNom;
        private System.Windows.Forms.TextBox tbGSM;
        private System.Windows.Forms.TextBox tbPrenom;
        private System.Windows.Forms.TextBox tbNom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox tbID;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
    }
}