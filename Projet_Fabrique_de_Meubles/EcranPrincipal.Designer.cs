namespace Projet_Fabrique_de_Meubles
{
    partial class EcranPrincipal
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EcranPrincipal));
            this.DGV_Client = new System.Windows.Forms.DataGridView();
            this.cID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblEquipe = new System.Windows.Forms.Label();
            this.DGV_Commandes = new System.Windows.Forms.DataGridView();
            this.DGV_Stock = new System.Windows.Forms.DataGridView();
            this.ChiffreDAffaire = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AddClient = new System.Windows.Forms.Button();
            this.AddCommand = new System.Windows.Forms.Button();
            this.AddProduct = new System.Windows.Forms.Button();
            this.Bill = new System.Windows.Forms.Button();
            this.Turnover = new System.Windows.Forms.Button();
            this.ListCommand = new System.Windows.Forms.Button();
            this.DelayedPayment = new System.Windows.Forms.Button();
            this.StockState = new System.Windows.Forms.Button();
            this.Edit_Client = new System.Windows.Forms.Button();
            this.DelClient = new System.Windows.Forms.Button();
            this.AjoutStock = new System.Windows.Forms.Button();
            this.DelStock = new System.Windows.Forms.Button();
            this.DelCommand = new System.Windows.Forms.Button();
            this.ModStock = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Client)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Commandes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Stock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // DGV_Client
            // 
            this.DGV_Client.AllowUserToAddRows = false;
            this.DGV_Client.AllowUserToDeleteRows = false;
            this.DGV_Client.AllowUserToResizeRows = false;
            this.DGV_Client.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_Client.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DGV_Client.BackgroundColor = System.Drawing.Color.SeaShell;
            this.DGV_Client.ColumnHeadersHeight = 30;
            this.DGV_Client.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cID});
            this.DGV_Client.GridColor = System.Drawing.SystemColors.InfoText;
            this.DGV_Client.Location = new System.Drawing.Point(27, 48);
            this.DGV_Client.Margin = new System.Windows.Forms.Padding(2);
            this.DGV_Client.Name = "DGV_Client";
            this.DGV_Client.ReadOnly = true;
            this.DGV_Client.RowHeadersVisible = false;
            this.DGV_Client.RowTemplate.Height = 28;
            this.DGV_Client.Size = new System.Drawing.Size(452, 280);
            this.DGV_Client.TabIndex = 5;
            // 
            // cID
            // 
            this.cID.DataPropertyName = "ID";
            this.cID.FillWeight = 30.45685F;
            this.cID.HeaderText = "ID";
            this.cID.Name = "cID";
            this.cID.ReadOnly = true;
            this.cID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // lblEquipe
            // 
            this.lblEquipe.AutoSize = true;
            this.lblEquipe.BackColor = System.Drawing.Color.White;
            this.lblEquipe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblEquipe.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.lblEquipe.Location = new System.Drawing.Point(36, 18);
            this.lblEquipe.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEquipe.Name = "lblEquipe";
            this.lblEquipe.Size = new System.Drawing.Size(76, 24);
            this.lblEquipe.TabIndex = 6;
            this.lblEquipe.Text = "Clients";
            // 
            // DGV_Commandes
            // 
            this.DGV_Commandes.AllowUserToAddRows = false;
            this.DGV_Commandes.AllowUserToDeleteRows = false;
            this.DGV_Commandes.AllowUserToResizeRows = false;
            this.DGV_Commandes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_Commandes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DGV_Commandes.BackgroundColor = System.Drawing.Color.SeaShell;
            this.DGV_Commandes.ColumnHeadersHeight = 30;
            this.DGV_Commandes.GridColor = System.Drawing.SystemColors.InfoText;
            this.DGV_Commandes.Location = new System.Drawing.Point(497, 48);
            this.DGV_Commandes.Margin = new System.Windows.Forms.Padding(2);
            this.DGV_Commandes.Name = "DGV_Commandes";
            this.DGV_Commandes.ReadOnly = true;
            this.DGV_Commandes.RowHeadersVisible = false;
            this.DGV_Commandes.RowTemplate.Height = 28;
            this.DGV_Commandes.Size = new System.Drawing.Size(442, 280);
            this.DGV_Commandes.TabIndex = 7;
            this.DGV_Commandes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_Commandes_CellContentClick);
            // 
            // DGV_Stock
            // 
            this.DGV_Stock.AllowUserToAddRows = false;
            this.DGV_Stock.AllowUserToDeleteRows = false;
            this.DGV_Stock.AllowUserToResizeRows = false;
            this.DGV_Stock.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_Stock.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DGV_Stock.BackgroundColor = System.Drawing.Color.SeaShell;
            this.DGV_Stock.ColumnHeadersHeight = 30;
            this.DGV_Stock.GridColor = System.Drawing.SystemColors.InfoText;
            this.DGV_Stock.Location = new System.Drawing.Point(958, 48);
            this.DGV_Stock.Margin = new System.Windows.Forms.Padding(2);
            this.DGV_Stock.Name = "DGV_Stock";
            this.DGV_Stock.ReadOnly = true;
            this.DGV_Stock.RowHeadersVisible = false;
            this.DGV_Stock.RowTemplate.Height = 28;
            this.DGV_Stock.Size = new System.Drawing.Size(523, 280);
            this.DGV_Stock.TabIndex = 8;
            // 
            // ChiffreDAffaire
            // 
            this.ChiffreDAffaire.AutoSize = true;
            this.ChiffreDAffaire.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ChiffreDAffaire.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.ChiffreDAffaire.Location = new System.Drawing.Point(525, 18);
            this.ChiffreDAffaire.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ChiffreDAffaire.Name = "ChiffreDAffaire";
            this.ChiffreDAffaire.Size = new System.Drawing.Size(129, 24);
            this.ChiffreDAffaire.TabIndex = 9;
            this.ChiffreDAffaire.Text = "Commandes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(999, 18);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 24);
            this.label2.TabIndex = 10;
            this.label2.Text = "Produits";
            // 
            // AddClient
            // 
            this.AddClient.BackColor = System.Drawing.SystemColors.Control;
            this.AddClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.AddClient.Location = new System.Drawing.Point(331, 333);
            this.AddClient.Name = "AddClient";
            this.AddClient.Size = new System.Drawing.Size(148, 23);
            this.AddClient.TabIndex = 11;
            this.AddClient.Text = "Ajouter un client";
            this.AddClient.UseVisualStyleBackColor = false;
            this.AddClient.Click += new System.EventHandler(this.AddClient_Click);
            // 
            // AddCommand
            // 
            this.AddCommand.BackColor = System.Drawing.SystemColors.Control;
            this.AddCommand.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.AddCommand.Location = new System.Drawing.Point(797, 333);
            this.AddCommand.Name = "AddCommand";
            this.AddCommand.Size = new System.Drawing.Size(142, 23);
            this.AddCommand.TabIndex = 12;
            this.AddCommand.Text = "Nouvelle commande";
            this.AddCommand.UseVisualStyleBackColor = false;
            this.AddCommand.Click += new System.EventHandler(this.AddCommand_Click);
            // 
            // AddProduct
            // 
            this.AddProduct.BackColor = System.Drawing.SystemColors.Control;
            this.AddProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.AddProduct.Location = new System.Drawing.Point(1347, 333);
            this.AddProduct.Name = "AddProduct";
            this.AddProduct.Size = new System.Drawing.Size(134, 23);
            this.AddProduct.TabIndex = 13;
            this.AddProduct.Text = "Nouveau produit";
            this.AddProduct.UseVisualStyleBackColor = false;
            this.AddProduct.Click += new System.EventHandler(this.AddProduct_Click);
            // 
            // Bill
            // 
            this.Bill.BackColor = System.Drawing.SystemColors.Control;
            this.Bill.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.Bill.Location = new System.Drawing.Point(346, 423);
            this.Bill.Name = "Bill";
            this.Bill.Size = new System.Drawing.Size(260, 46);
            this.Bill.TabIndex = 15;
            this.Bill.Text = "Générer facture";
            this.Bill.UseVisualStyleBackColor = false;
            this.Bill.Click += new System.EventHandler(this.Bill_Click);
            // 
            // Turnover
            // 
            this.Turnover.BackColor = System.Drawing.SystemColors.Control;
            this.Turnover.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.Turnover.Location = new System.Drawing.Point(643, 423);
            this.Turnover.Name = "Turnover";
            this.Turnover.Size = new System.Drawing.Size(285, 46);
            this.Turnover.TabIndex = 16;
            this.Turnover.Text = "Chiffre d\'affaire hebdo";
            this.Turnover.UseVisualStyleBackColor = false;
            this.Turnover.Click += new System.EventHandler(this.Turnover_Click);
            // 
            // ListCommand
            // 
            this.ListCommand.BackColor = System.Drawing.SystemColors.Control;
            this.ListCommand.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.ListCommand.Location = new System.Drawing.Point(958, 423);
            this.ListCommand.Name = "ListCommand";
            this.ListCommand.Size = new System.Drawing.Size(264, 46);
            this.ListCommand.TabIndex = 17;
            this.ListCommand.Text = "Relevé de commandes";
            this.ListCommand.UseVisualStyleBackColor = false;
            this.ListCommand.Click += new System.EventHandler(this.ListCommand_Click);
            // 
            // DelayedPayment
            // 
            this.DelayedPayment.BackColor = System.Drawing.SystemColors.Control;
            this.DelayedPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.DelayedPayment.Location = new System.Drawing.Point(12, 423);
            this.DelayedPayment.Name = "DelayedPayment";
            this.DelayedPayment.Size = new System.Drawing.Size(328, 46);
            this.DelayedPayment.TabIndex = 18;
            this.DelayedPayment.Text = "Relevé des clients en retard de paiement";
            this.DelayedPayment.UseVisualStyleBackColor = false;
            this.DelayedPayment.Click += new System.EventHandler(this.DelayedPayment_Click);
            // 
            // StockState
            // 
            this.StockState.BackColor = System.Drawing.SystemColors.Control;
            this.StockState.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.StockState.Location = new System.Drawing.Point(1228, 423);
            this.StockState.Name = "StockState";
            this.StockState.Size = new System.Drawing.Size(252, 46);
            this.StockState.TabIndex = 19;
            this.StockState.Text = "Etat des stocks";
            this.StockState.UseVisualStyleBackColor = false;
            this.StockState.Click += new System.EventHandler(this.StockState_Click);
            // 
            // Edit_Client
            // 
            this.Edit_Client.BackColor = System.Drawing.SystemColors.Control;
            this.Edit_Client.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.Edit_Client.Location = new System.Drawing.Point(27, 333);
            this.Edit_Client.Name = "Edit_Client";
            this.Edit_Client.Size = new System.Drawing.Size(148, 23);
            this.Edit_Client.TabIndex = 20;
            this.Edit_Client.Text = "Editer un client";
            this.Edit_Client.UseVisualStyleBackColor = false;
            this.Edit_Client.Click += new System.EventHandler(this.Edit_Client_Click);
            // 
            // DelClient
            // 
            this.DelClient.Location = new System.Drawing.Point(181, 333);
            this.DelClient.Name = "DelClient";
            this.DelClient.Size = new System.Drawing.Size(144, 23);
            this.DelClient.TabIndex = 22;
            this.DelClient.Text = "Supprimer un client";
            this.DelClient.UseVisualStyleBackColor = true;
            this.DelClient.Click += new System.EventHandler(this.DelClient_Click);
            // 
            // AjoutStock
            // 
            this.AjoutStock.BackColor = System.Drawing.SystemColors.Control;
            this.AjoutStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.AjoutStock.Location = new System.Drawing.Point(1173, 333);
            this.AjoutStock.Name = "AjoutStock";
            this.AjoutStock.Size = new System.Drawing.Size(168, 23);
            this.AjoutStock.TabIndex = 23;
            this.AjoutStock.Text = "Ajout produit au stock";
            this.AjoutStock.UseVisualStyleBackColor = false;
            this.AjoutStock.Click += new System.EventHandler(this.AjoutStock_Click);
            // 
            // DelStock
            // 
            this.DelStock.Location = new System.Drawing.Point(1173, 362);
            this.DelStock.Name = "DelStock";
            this.DelStock.Size = new System.Drawing.Size(168, 23);
            this.DelStock.TabIndex = 24;
            this.DelStock.Text = "Supprimer du stock";
            this.DelStock.UseVisualStyleBackColor = true;
            this.DelStock.Click += new System.EventHandler(this.DelStock_Click);
            // 
            // DelCommand
            // 
            this.DelCommand.Location = new System.Drawing.Point(643, 334);
            this.DelCommand.Name = "DelCommand";
            this.DelCommand.Size = new System.Drawing.Size(148, 23);
            this.DelCommand.TabIndex = 25;
            this.DelCommand.Text = "Supprimer commande";
            this.DelCommand.UseVisualStyleBackColor = true;
            this.DelCommand.Click += new System.EventHandler(this.DelCommand_Click);
            // 
            // ModStock
            // 
            this.ModStock.BackColor = System.Drawing.SystemColors.Control;
            this.ModStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.ModStock.Location = new System.Drawing.Point(999, 334);
            this.ModStock.Name = "ModStock";
            this.ModStock.Size = new System.Drawing.Size(168, 23);
            this.ModStock.TabIndex = 26;
            this.ModStock.Text = "Modification du stock";
            this.ModStock.UseVisualStyleBackColor = false;
            this.ModStock.Click += new System.EventHandler(this.ModStock_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 472);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(28, 27);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // EcranPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1492, 511);
            this.Controls.Add(this.ModStock);
            this.Controls.Add(this.DelCommand);
            this.Controls.Add(this.DelStock);
            this.Controls.Add(this.AjoutStock);
            this.Controls.Add(this.DelClient);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Edit_Client);
            this.Controls.Add(this.StockState);
            this.Controls.Add(this.DelayedPayment);
            this.Controls.Add(this.ListCommand);
            this.Controls.Add(this.Turnover);
            this.Controls.Add(this.Bill);
            this.Controls.Add(this.AddProduct);
            this.Controls.Add(this.AddCommand);
            this.Controls.Add(this.AddClient);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ChiffreDAffaire);
            this.Controls.Add(this.DGV_Stock);
            this.Controls.Add(this.DGV_Commandes);
            this.Controls.Add(this.lblEquipe);
            this.Controls.Add(this.DGV_Client);
            this.Name = "EcranPrincipal";
            this.Text = "Meubléa";
            this.Load += new System.EventHandler(this.EcranPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Client)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Commandes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Stock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV_Client;
        private System.Windows.Forms.Label lblEquipe;
        private System.Windows.Forms.DataGridView DGV_Commandes;
        private System.Windows.Forms.DataGridView DGV_Stock;
        private System.Windows.Forms.Label ChiffreDAffaire;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button AddClient;
        private System.Windows.Forms.Button AddCommand;
        private System.Windows.Forms.Button AddProduct;
        private System.Windows.Forms.Button Bill;
        private System.Windows.Forms.Button Turnover;
        private System.Windows.Forms.Button ListCommand;
        private System.Windows.Forms.Button DelayedPayment;
        private System.Windows.Forms.Button StockState;
        private System.Windows.Forms.Button Edit_Client;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cID;
        private System.Windows.Forms.Button DelClient;
        private System.Windows.Forms.Button AjoutStock;
        private System.Windows.Forms.Button DelStock;
        private System.Windows.Forms.Button DelCommand;
        private System.Windows.Forms.Button ModStock;
    }
}

