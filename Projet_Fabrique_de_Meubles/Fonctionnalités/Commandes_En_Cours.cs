using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Projet_Fabrique_de_meubles.Acces;
using Projet_Fabrique_de_meubles.Classes;
using Projet_Fabrique_de_meubles.Gestion;

namespace Projet_Fabrique_de_Meubles
{
    public partial class Commandes_En_Cours : Form
    {
        private static string sConnexion;
        private DataTable DT_CLIENT, DT_COMMANDE, DT_DETAIL_COMMANDE, DT_MEUBLE, DT_STOCK;
        private BindingSource BS_CLIENT, BS_COMMANDE, BS_DETAIL_COMMANDE, BS_MEUBLE, BS_STOCK;
        public Commandes_En_Cours()
        {
            InitializeComponent();

            C_COMMANDE commande = new C_COMMANDE();

            for (int j = 1; j < 100; j++)
            {
                commande = new G_COMMANDE(sConnexion).Lire_ID(j);
                if (commande.ID != 0)
                {
                    cbCommande.Items.Add(commande.ID);
                }
            }
        }

        private void Actualisation_Click(object sender, EventArgs e)
        {
            AfficherReleveCommande(int.Parse(cbCommande.Text));
        }

        private void AfficherReleveCommande(int IDComm)
        {
            DT_DETAIL_COMMANDE = new DataTable();

            int PrixTotal = 0;

            DGV_facture.Columns.Add("ID du meuble", "ID du meuble");
            DGV_facture.Columns.Add("Prix unitaire", "Prix unitaire");
            DGV_facture.Columns.Add("Prix total", "Prix total");


            List<C_DETAIL_COMMANDE> lTmp_C_ID_DETAIL_COMMANDE = new G_DETAIL_COMMANDE(sConnexion).Lire("ID");
            List<C_MEUBLE> lTmp_C_ID_MEUBLE = new G_MEUBLE(sConnexion).Lire("ID");
            List<int> ListeIDMeubleAFact = new List<int>();

            //Récupération liste des meubles de la commande
            foreach (C_DETAIL_COMMANDE Tmp in lTmp_C_ID_DETAIL_COMMANDE)
            {
                if (Tmp.ID_COMMANDE == IDComm)
                {
                    //ListeIDMeubleAFact.Add(Tmp.ID_MEUBLES);
                    foreach (C_MEUBLE meuble in lTmp_C_ID_MEUBLE)
                    {
                        if (meuble.ID == Tmp.ID_MEUBLES)
                        {
                            DGV_facture.Rows.Add(Convert.ToString(Tmp.ID_MEUBLES), meuble.PRIX_UNITAIRE);
                            PrixTotal = PrixTotal + Convert.ToInt32(meuble.PRIX_UNITAIRE);
                        }
                    }
                }
            }
            DGV_facture.Rows.Add("", "", "Total : " + PrixTotal);
            
        }
    }
}
