using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.IO;
using System.Threading;
using System.Configuration;
using Projet_Fabrique_de_meubles.Acces;
using Projet_Fabrique_de_meubles.Classes;
using Projet_Fabrique_de_meubles.Gestion;

namespace Projet_Fabrique_de_Meubles
{
    public partial class EcranPrincipal : Form
    {
        private static string sConnexion;
        private DataTable DT_CLIENT, DT_COMMANDE, DT_DETAIL_COMMANDE, DT_MEUBLE, DT_STOCK;
        private BindingSource BS_CLIENT, BS_COMMANDE, BS_DETAIL_COMMANDE, BS_MEUBLE, BS_STOCK;

        private void AddProduct_Click(object sender, EventArgs e)
        {
            Ajout.AjoutProduit AddProduct = new Ajout.AjoutProduit();
            AddProduct.ShowDialog();
        }

        private void DelayedPayment_Click(object sender, EventArgs e)
        {
            Retard_Paiement DelayedPayment = new Retard_Paiement();
            DelayedPayment.ShowDialog();
        }

        private void ListCommand_Click(object sender, EventArgs e)
        {
            Commandes_En_Cours ListCommand = new Commandes_En_Cours();
            ListCommand.ShowDialog();
        }

        private void StockState_Click(object sender, EventArgs e)
        {
            string file = "Programme.html";

            string path = Path.GetFullPath(file);

            Thread tGenererHTML = new Thread(GenererHTML);
            tGenererHTML.Start();
            Etat_Stock_HTML StockState = new Etat_Stock_HTML(path);
            StockState.ShowDialog();
        }

        private void GenererHTML()
        {
            Thread tHTML = new Thread(CreateHTML);
            tHTML.Start();
        }

        private void CreateHTML()
        {
            //Table start
            string html = "<table cellpadding='5' cellspacing='0' style='border: 1px solid #ccc;font-size: 9pt;font-family:arial'>";

            //Ajout en tête
            html += "<tr>";
            foreach (DataGridViewColumn column in DGV_Stock.Columns)
            {
                html += "<th style='background-color: #B8DBFD;border: 1px solid #ccc'>" + column.HeaderText + "</th>";
            }
            html += "</tr>";

            //Ajout ligne.
            foreach (DataGridViewRow row in DGV_Stock.Rows)
            {

                html += "<tr>";
                foreach (DataGridViewCell cell in row.Cells)
                {
                    html += "<td style='width:120px;border: 1px solid #ccc'>" + cell.Value.ToString() + "</td>";
                }
                html += "</tr>";

            }

            //Table end
            html += "</table>";

            string file = "Programme.html";

            string path = Path.GetFullPath(file); //Chemin complet

            File.WriteAllText(path, html); //Ecriture du fichier

            MessageBox.Show("Chemin du fichier : " + path, "Sauvegarde du fichier HTML"); //Affichage
        }

        private void Bill_Click(object sender, EventArgs e)
        {
            Facture Bill = new Facture();
            Bill.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            RemplirDGV();
        }

        private void DelClient_Click(object sender, EventArgs e)
        {
            Modification.SupprimerClient Delete = new Modification.SupprimerClient();
            Delete.ShowDialog();
        }

        private void AjoutStock_Click(object sender, EventArgs e)
        {
            Ajout.AjoutStock AddStock = new Ajout.AjoutStock();
            AddStock.ShowDialog();
        }

        private void DelStock_Click(object sender, EventArgs e)
        {
            Modification.SupprimerStock DelStock = new Modification.SupprimerStock();
            DelStock.ShowDialog();
        }

        private void ModStock_Click(object sender, EventArgs e)
        {
            Modification.EditStock editStock = new Modification.EditStock();
            editStock.ShowDialog();
        }

        private void DelCommand_Click(object sender, EventArgs e)
        {
            Modification.SupprimerCommande supprimerCommande = new Modification.SupprimerCommande();
            supprimerCommande.ShowDialog();
        }

        private void DGV_Commandes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Turnover_Click(object sender, EventArgs e)
        {
            Chiffre_d_affaire Turnover = new Chiffre_d_affaire();
            Turnover.ShowDialog();
        }

        private void EcranPrincipal_Load(object sender, EventArgs e)
        {
            sConnexion = ConfigurationManager.ConnectionStrings["Projet_Fabrique_de_Meubles.Properties.Settings.FabMeublesCouches"].ConnectionString;
            RemplirDGV();
        }

        private void AddCommand_Click(object sender, EventArgs e)
        {
            Ajout.AjoutCommande AddCommand = new Ajout.AjoutCommande();
            AddCommand.ShowDialog();
        }

        private void AddClient_Click(object sender, EventArgs e)
        {
            AjoutClient AddClient = new AjoutClient();
            AddClient.ShowDialog();
        }

        public EcranPrincipal()
        {
            InitializeComponent();
            RemplirDGV();
        }

        void RemplirDGV()
        {
            DT_CLIENT = new DataTable();
            DT_COMMANDE = new DataTable();
            DT_MEUBLE = new DataTable();
            DT_STOCK = new DataTable();
            
            DT_CLIENT.Columns.Add(new DataColumn("ID", System.Type.GetType("System.Int32")));
            DT_CLIENT.Columns.Add("Nom");
            DT_CLIENT.Columns.Add("Téléphone");
            DT_CLIENT.Columns.Add("Mail");
            
            List<C_CLIENT> lTmp_C_ID = new G_CLIENT(sConnexion).Lire("ID");
            List<C_CLIENT> lTmp_C_NOM = new G_CLIENT(sConnexion).Lire("Nom");
            List<C_CLIENT> lTmp_C_TEL = new G_CLIENT(sConnexion).Lire("Téléphone");
            List<C_CLIENT> lTmp_C_MAIL = new G_CLIENT(sConnexion).Lire("Mail");

            foreach (C_CLIENT Tmp in lTmp_C_NOM)
                DT_CLIENT.Rows.Add(Tmp.ID, Tmp.Nom, Tmp.Téléphone, Tmp.Mail);

            BS_CLIENT = new BindingSource();
            BS_CLIENT.DataSource = DT_CLIENT;

            DT_COMMANDE.Columns.Add(new DataColumn("ID", System.Type.GetType("System.Int32")));
            DT_COMMANDE.Columns.Add(new DataColumn("ID Cient", System.Type.GetType("System.Int32")));
            DT_COMMANDE.Columns.Add("Date de commande");
            DT_COMMANDE.Columns.Add("Date de Paiement");

            List<C_COMMANDE> lTmp_CO_ID = new G_COMMANDE(sConnexion).Lire("ID");
            List<C_COMMANDE> lTmp_CO_IDClient = new G_COMMANDE(sConnexion).Lire("ID Client");
            List<C_COMMANDE> lTmp_CO_DCom = new G_COMMANDE(sConnexion).Lire("Date de commande");
            List<C_COMMANDE> lTmp_CO_DPaie = new G_COMMANDE(sConnexion).Lire("Date de Paiement");

            foreach (C_COMMANDE Tmp in lTmp_CO_ID)
                DT_COMMANDE.Rows.Add(Tmp.ID, Tmp.ID_CLIENT, Tmp.DATE, Tmp.DATE_DE_PAIMENT);

            BS_COMMANDE = new BindingSource();
            BS_COMMANDE.DataSource = DT_COMMANDE;

            DT_STOCK.Columns.Add(new DataColumn("ID", System.Type.GetType("System.Int32")));
            DT_STOCK.Columns.Add(new DataColumn("ID Meuble", System.Type.GetType("System.Int32")));
            DT_STOCK.Columns.Add("Quantité");
            DT_STOCK.Columns.Add("Etat de fabrication");
            DT_STOCK.Columns.Add("Délai de livraison");

            List<C_STOCK> lTmp_S_ID = new G_STOCK(sConnexion).Lire("ID");
            List<C_STOCK> lTmp_S_ID_M = new G_STOCK(sConnexion).Lire("Nom");
            List<C_STOCK> lTmp_S_QUANTITE = new G_STOCK(sConnexion).Lire("Quantité");
            List<C_STOCK> lTmp_S_ETAT_FAB = new G_STOCK(sConnexion).Lire("Etat de fabrication");
            List<C_STOCK> lTmp_S_DELAI_LIV = new G_STOCK(sConnexion).Lire("Delai de livraison");

            foreach (C_STOCK Tmp in lTmp_S_ID)
                DT_STOCK.Rows.Add(Tmp.ID, Tmp.ID_MEUBLE, Tmp.QUANTITE, Tmp.ETAT_DE_FABRICATION, Tmp.DELAI_DE_LIVRAISON);

            BS_STOCK = new BindingSource();
            BS_STOCK.DataSource = DT_STOCK;

            //DGV
            DGV_Client.DataSource = BS_CLIENT;
            DGV_Commandes.DataSource = BS_COMMANDE;
            DGV_Stock.DataSource = BS_STOCK;
        }

        private void Activer(bool lPrincipal)
        {
            DGV_Client.Enabled = DGV_Commandes.Enabled = DGV_Stock.Enabled = lPrincipal;
            AddClient.Enabled = Edit_Client.Enabled = DelayedPayment.Enabled = Bill.Enabled = AddCommand.Enabled = ListCommand.Enabled = Turnover.Enabled = AddProduct.Enabled = StockState.Enabled = lPrincipal;
            
        }

        private void Edit_Client_Click(object sender, EventArgs e)
        {
            Modification.EditClient Edit_Client = new Modification.EditClient();
            Edit_Client.ShowDialog();
        }
    }
}
