namespace Projet_Fabrique_de_Meubles.Ajout
{
    partial class AjoutCommande
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.FicheCom = new System.Windows.Forms.GroupBox();
            this.ValidInfo = new System.Windows.Forms.Button();
            this.tbID = new System.Windows.Forms.ComboBox();
            this.tbPaiementContent = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAjoutDate = new System.Windows.Forms.Button();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.tbDateCom = new System.Windows.Forms.TextBox();
            this.lblFicheAjDateNaisMed = new System.Windows.Forms.Label();
            this.lblFicheAjMedID = new System.Windows.Forms.Label();
            this.ListeProd = new System.Windows.Forms.GroupBox();
            this.AjoutListe = new System.Windows.Forms.Button();
            this.tbArticle = new System.Windows.Forms.ComboBox();
            this.dgvListeArticle = new System.Windows.Forms.DataGridView();
            this.Valid = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.tbCommand = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FicheCom.SuspendLayout();
            this.ListeProd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListeArticle)).BeginInit();
            this.SuspendLayout();
            // 
            // FicheCom
            // 
            this.FicheCom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.FicheCom.Controls.Add(this.tbCommand);
            this.FicheCom.Controls.Add(this.label2);
            this.FicheCom.Controls.Add(this.ValidInfo);
            this.FicheCom.Controls.Add(this.tbID);
            this.FicheCom.Controls.Add(this.tbPaiementContent);
            this.FicheCom.Controls.Add(this.label1);
            this.FicheCom.Controls.Add(this.btnAjoutDate);
            this.FicheCom.Controls.Add(this.monthCalendar1);
            this.FicheCom.Controls.Add(this.tbDateCom);
            this.FicheCom.Controls.Add(this.lblFicheAjDateNaisMed);
            this.FicheCom.Controls.Add(this.lblFicheAjMedID);
            this.FicheCom.Location = new System.Drawing.Point(12, 12);
            this.FicheCom.Name = "FicheCom";
            this.FicheCom.Size = new System.Drawing.Size(377, 419);
            this.FicheCom.TabIndex = 5;
            this.FicheCom.TabStop = false;
            this.FicheCom.Text = "Fiche de la commande";
            // 
            // ValidInfo
            // 
            this.ValidInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ValidInfo.Location = new System.Drawing.Point(200, 360);
            this.ValidInfo.Name = "ValidInfo";
            this.ValidInfo.Size = new System.Drawing.Size(159, 42);
            this.ValidInfo.TabIndex = 16;
            this.ValidInfo.Text = "Valider les informations";
            this.ValidInfo.UseVisualStyleBackColor = true;
            this.ValidInfo.Click += new System.EventHandler(this.ValidInfo_Click);
            // 
            // tbID
            // 
            this.tbID.FormattingEnabled = true;
            this.tbID.Location = new System.Drawing.Point(45, 57);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(100, 21);
            this.tbID.TabIndex = 15;
            // 
            // tbPaiementContent
            // 
            this.tbPaiementContent.FormattingEnabled = true;
            this.tbPaiementContent.Location = new System.Drawing.Point(45, 367);
            this.tbPaiementContent.Name = "tbPaiementContent";
            this.tbPaiementContent.Size = new System.Drawing.Size(121, 21);
            this.tbPaiementContent.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 351);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Paiement content :";
            // 
            // btnAjoutDate
            // 
            this.btnAjoutDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjoutDate.Location = new System.Drawing.Point(284, 229);
            this.btnAjoutDate.Name = "btnAjoutDate";
            this.btnAjoutDate.Size = new System.Drawing.Size(75, 47);
            this.btnAjoutDate.TabIndex = 6;
            this.btnAjoutDate.Text = "Ajouter date";
            this.btnAjoutDate.UseVisualStyleBackColor = true;
            this.btnAjoutDate.Click += new System.EventHandler(this.btnAjoutDate_Click);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(45, 162);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 12;
            // 
            // tbDateCom
            // 
            this.tbDateCom.Location = new System.Drawing.Point(45, 115);
            this.tbDateCom.Name = "tbDateCom";
            this.tbDateCom.Size = new System.Drawing.Size(100, 20);
            this.tbDateCom.TabIndex = 11;
            // 
            // lblFicheAjDateNaisMed
            // 
            this.lblFicheAjDateNaisMed.AutoSize = true;
            this.lblFicheAjDateNaisMed.Location = new System.Drawing.Point(42, 99);
            this.lblFicheAjDateNaisMed.Name = "lblFicheAjDateNaisMed";
            this.lblFicheAjDateNaisMed.Size = new System.Drawing.Size(117, 13);
            this.lblFicheAjDateNaisMed.TabIndex = 10;
            this.lblFicheAjDateNaisMed.Text = "Date de la commande :";
            // 
            // lblFicheAjMedID
            // 
            this.lblFicheAjMedID.AutoSize = true;
            this.lblFicheAjMedID.Location = new System.Drawing.Point(42, 41);
            this.lblFicheAjMedID.Name = "lblFicheAjMedID";
            this.lblFicheAjMedID.Size = new System.Drawing.Size(53, 13);
            this.lblFicheAjMedID.TabIndex = 5;
            this.lblFicheAjMedID.Text = "ID Client :";
            // 
            // ListeProd
            // 
            this.ListeProd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ListeProd.Controls.Add(this.AjoutListe);
            this.ListeProd.Controls.Add(this.tbArticle);
            this.ListeProd.Controls.Add(this.dgvListeArticle);
            this.ListeProd.Location = new System.Drawing.Point(395, 12);
            this.ListeProd.Name = "ListeProd";
            this.ListeProd.Size = new System.Drawing.Size(393, 419);
            this.ListeProd.TabIndex = 6;
            this.ListeProd.TabStop = false;
            this.ListeProd.Text = "Liste des articles";
            // 
            // AjoutListe
            // 
            this.AjoutListe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AjoutListe.Location = new System.Drawing.Point(130, 374);
            this.AjoutListe.Name = "AjoutListe";
            this.AjoutListe.Size = new System.Drawing.Size(159, 28);
            this.AjoutListe.TabIndex = 7;
            this.AjoutListe.Text = "Ajouter à la liste";
            this.AjoutListe.UseVisualStyleBackColor = true;
            this.AjoutListe.Click += new System.EventHandler(this.AjoutListe_Click);
            // 
            // tbArticle
            // 
            this.tbArticle.FormattingEnabled = true;
            this.tbArticle.Location = new System.Drawing.Point(6, 347);
            this.tbArticle.Name = "tbArticle";
            this.tbArticle.Size = new System.Drawing.Size(381, 21);
            this.tbArticle.TabIndex = 1;
            // 
            // dgvListeArticle
            // 
            this.dgvListeArticle.AllowUserToAddRows = false;
            this.dgvListeArticle.AllowUserToDeleteRows = false;
            this.dgvListeArticle.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListeArticle.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListeArticle.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvListeArticle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListeArticle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dgvListeArticle.Location = new System.Drawing.Point(6, 19);
            this.dgvListeArticle.Name = "dgvListeArticle";
            this.dgvListeArticle.ReadOnly = true;
            this.dgvListeArticle.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            this.dgvListeArticle.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvListeArticle.Size = new System.Drawing.Size(381, 322);
            this.dgvListeArticle.TabIndex = 0;
            // 
            // Valid
            // 
            this.Valid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Valid.Location = new System.Drawing.Point(133, 437);
            this.Valid.Name = "Valid";
            this.Valid.Size = new System.Drawing.Size(138, 32);
            this.Valid.TabIndex = 15;
            this.Valid.Text = "Valider";
            this.Valid.UseVisualStyleBackColor = true;
            this.Valid.Click += new System.EventHandler(this.Valid_Click);
            // 
            // Cancel
            // 
            this.Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancel.Location = new System.Drawing.Point(534, 437);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(138, 32);
            this.Cancel.TabIndex = 16;
            this.Cancel.Text = "Annuler";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // tbCommand
            // 
            this.tbCommand.Location = new System.Drawing.Point(227, 57);
            this.tbCommand.Name = "tbCommand";
            this.tbCommand.Size = new System.Drawing.Size(100, 20);
            this.tbCommand.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(224, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "ID Commande :";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Nom";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // AjoutCommande
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 482);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Valid);
            this.Controls.Add(this.ListeProd);
            this.Controls.Add(this.FicheCom);
            this.Name = "AjoutCommande";
            this.Text = "AjoutCommande";
            this.FicheCom.ResumeLayout(false);
            this.FicheCom.PerformLayout();
            this.ListeProd.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListeArticle)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox FicheCom;
        private System.Windows.Forms.Button btnAjoutDate;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.TextBox tbDateCom;
        private System.Windows.Forms.Label lblFicheAjDateNaisMed;
        private System.Windows.Forms.Label lblFicheAjMedID;
        private System.Windows.Forms.ComboBox tbPaiementContent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox ListeProd;
        private System.Windows.Forms.DataGridView dgvListeArticle;
        private System.Windows.Forms.Button AjoutListe;
        private System.Windows.Forms.ComboBox tbArticle;
        private System.Windows.Forms.Button Valid;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.ComboBox tbID;
        private System.Windows.Forms.Button ValidInfo;
        private System.Windows.Forms.TextBox tbCommand;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    }
}