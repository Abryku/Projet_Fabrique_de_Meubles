namespace Projet_Fabrique_de_Meubles
{
    partial class Etat_Stock_HTML
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
            this.wbEtatStock = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // wbEtatStock
            // 
            this.wbEtatStock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wbEtatStock.Location = new System.Drawing.Point(0, 0);
            this.wbEtatStock.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbEtatStock.Name = "wbEtatStock";
            this.wbEtatStock.Size = new System.Drawing.Size(800, 450);
            this.wbEtatStock.TabIndex = 0;
            // 
            // Etat_Stock_HTML
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.wbEtatStock);
            this.Name = "Etat_Stock_HTML";
            this.Text = "Etat_Stock";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser wbEtatStock;
    }
}