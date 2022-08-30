namespace Projet_Fabrique_de_Meubles
{
    partial class Retard_Paiement
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
            this.DGV_Impaye = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Impaye)).BeginInit();
            this.SuspendLayout();
            // 
            // DGV_Impaye
            // 
            this.DGV_Impaye.AllowUserToAddRows = false;
            this.DGV_Impaye.AllowUserToDeleteRows = false;
            this.DGV_Impaye.AllowUserToResizeRows = false;
            this.DGV_Impaye.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_Impaye.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DGV_Impaye.BackgroundColor = System.Drawing.Color.SeaShell;
            this.DGV_Impaye.ColumnHeadersHeight = 30;
            this.DGV_Impaye.GridColor = System.Drawing.SystemColors.InfoText;
            this.DGV_Impaye.Location = new System.Drawing.Point(11, 11);
            this.DGV_Impaye.Margin = new System.Windows.Forms.Padding(2);
            this.DGV_Impaye.Name = "DGV_Impaye";
            this.DGV_Impaye.ReadOnly = true;
            this.DGV_Impaye.RowHeadersVisible = false;
            this.DGV_Impaye.RowTemplate.Height = 28;
            this.DGV_Impaye.Size = new System.Drawing.Size(778, 428);
            this.DGV_Impaye.TabIndex = 11;
            // 
            // Retard_Paiement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Projet_Fabrique_de_Meubles.Properties.Resources.parement_bois_pas_cher_lambris_mural_pvc;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DGV_Impaye);
            this.Name = "Retard_Paiement";
            this.Text = "Retard de paiement";
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Impaye)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView DGV_Impaye;
    }
}