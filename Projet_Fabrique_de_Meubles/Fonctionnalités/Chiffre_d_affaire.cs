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
    public partial class Chiffre_d_affaire : Form
    {
        private static string sConnexion;
        private DataTable DT_CLIENT, DT_COMMANDE, DT_DETAIL_COMMANDE, DT_MEUBLE, DT_STOCK;


        private BindingSource BS_CLIENT, BS_COMMANDE, BS_DETAIL_COMMANDE, BS_MEUBLE, BS_STOCK;
        public Chiffre_d_affaire()
        {
            InitializeComponent();
        }
        private void DateSélectionnée_Click(object sender, EventArgs e)
        {
            tbDate.Text = mcDate.SelectionStart.ToShortDateString();

            EtablirChiffreAffaireHebdo();

        }

        private void EtablirChiffreAffaireHebdo()
        {
            List<C_COMMANDE> lTmp_C_COMMANDE = new G_COMMANDE(sConnexion).Lire("ID");

            DateTime dt1 = DateTime.Today;
            DateTime dt2 = mcDate.SelectionStart;
            DateTime dt3 = dt2.AddDays(7);

            int ChiffreDAffaireHebdo = 0;

            foreach (C_COMMANDE Tmp in lTmp_C_COMMANDE)
            {
                if(Tmp.DATE_DE_PAIMENT != null)
                {
                    dt1 = (DateTime)Tmp.DATE_DE_PAIMENT;

                    if((DateTime.Compare(dt1, dt2) > 0) && (DateTime.Compare(dt1, dt3) <0))
                    {
                        //Ecrire : ("Calcul de la facture" + Tmp.ID + "...")
                        listBox1.Items.Add("Calcul de la facture" + Tmp.ID.ToString() + "...");
                        ChiffreDAffaireHebdo = ChiffreDAffaireHebdo + CalculFacture(Tmp.ID);
                    }

                }
                
            }
            //Ecrire : ("Le chiffre d'affaire hebdomadaire est de " + ChiffreDAffaireHebdo)
            listBox1.Items.Add("Le chiffre d'affaire hebdomadaire est de " + ChiffreDAffaireHebdo.ToString() + ".");
        }
        int CalculFacture(int IDComm)
        {
            int Total = 0;
            List<C_DETAIL_COMMANDE> lTmp_C_ID_DETAIL_COMMANDE = new G_DETAIL_COMMANDE(sConnexion).Lire("ID");
            List<C_MEUBLE> lTmp_C_ID_MEUBLE = new G_MEUBLE(sConnexion).Lire("ID");

            foreach(C_DETAIL_COMMANDE TmpDetail in lTmp_C_ID_DETAIL_COMMANDE)
            {
                if(TmpDetail.ID_COMMANDE == IDComm)
                {
                    foreach(C_MEUBLE TmpMeuble in lTmp_C_ID_MEUBLE)
                    {
                        if(TmpDetail.ID_MEUBLES == TmpMeuble.ID)
                        {
                            Total = Total + (int)TmpMeuble.PRIX_UNITAIRE;
                        }
                    }
                }
            }

            return Total;
        }
    }
}
