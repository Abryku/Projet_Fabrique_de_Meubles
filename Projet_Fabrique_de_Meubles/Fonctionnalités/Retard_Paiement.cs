using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using Projet_Fabrique_de_meubles.Acces;
using Projet_Fabrique_de_meubles.Classes;
using Projet_Fabrique_de_meubles.Gestion;

namespace Projet_Fabrique_de_Meubles
{
    public partial class Retard_Paiement : Form
    {
        string sConnexion;
        public Retard_Paiement()
        {
            InitializeComponent();
            sConnexion = ConfigurationManager.ConnectionStrings["Projet_Fabrique_de_Meubles.Properties.Settings.FabMeublesCouches"].ConnectionString;


            DGV_Impaye.Columns.Add("ID de la facture", "ID de la facture");
            DGV_Impaye.Columns.Add("Nom", "Nom");
            DGV_Impaye.Columns.Add("Prenom", "Prenom");
            DGV_Impaye.Columns.Add("ID", "ID");
            DGV_Impaye.Columns.Add("Mail", "Mail");

            List<C_COMMANDE> lTmp_C_ID_COMMANDE = new G_COMMANDE(sConnexion).Lire("ID");
            List<C_CLIENT> lTmp_C_ID_CLIENT = new G_CLIENT(sConnexion).Lire("ID");
            foreach (C_COMMANDE Tmp in lTmp_C_ID_COMMANDE)
            {
                if(Tmp.DATE_DE_PAIMENT == null)
                {
                    foreach(C_CLIENT client in lTmp_C_ID_CLIENT)
                    {
                        if(client.ID == Tmp.ID_CLIENT)
                        {
                            DGV_Impaye.Rows.Add(Tmp.ID, client.Nom, client.Prénom, client.ID, client.Mail);
                            //Affiche
                        }
                    }
                }
            }
        }


    }
}
