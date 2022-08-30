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

namespace Projet_Fabrique_de_Meubles.Modification
{
    public partial class EditStock : Form
    {
        string sConnexion;
        public EditStock()
        {
            InitializeComponent();
            sConnexion = ConfigurationManager.ConnectionStrings["Projet_Fabrique_de_Meubles.Properties.Settings.FabMeublesCouches"].ConnectionString;
            tbQuantite.Text =  tbDelaiLiv.Text = tbEtatFab.Text = tbIDMeuble.Text = "";
            tbQuantite.Focus();

            C_STOCK produit = new C_STOCK();
            int i = 1;
            produit = new G_STOCK(sConnexion).Lire_ID(i);

            for (i = 1; i < 100; i++)
            {
                produit = new G_STOCK(sConnexion).Lire_ID(i);
                if (produit.ID != 0)
                {
                    tbID.Items.Add(produit.ID);
                }
            }
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            C_STOCK produit = new G_STOCK(sConnexion).Lire_ID(int.Parse(tbID.Text));

            tbIDMeuble.Text = produit.ID_MEUBLE.ToString();
            tbQuantite.Text = produit.QUANTITE.ToString();
            tbDelaiLiv.Text = produit.DELAI_DE_LIVRAISON.ToString();
            tbEtatFab.Text = produit.ETAT_DE_FABRICATION;

        }

        private void edit_Stock_Click(object sender, EventArgs e)
        {
            new G_STOCK(sConnexion).Modifier(int.Parse(tbID.Text), int.Parse(tbIDMeuble.Text), int.Parse(tbQuantite.Text), tbEtatFab.Text, int.Parse(tbDelaiLiv.Text));
            MessageBox.Show("Le stock a bien été modifié.");
            tbQuantite.Text = tbDelaiLiv.Text = tbEtatFab.Text = tbIDMeuble.Text = "";
            Close();
        }

        private void Annuler_Stock_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
