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

namespace Projet_Fabrique_de_Meubles.Ajout
{
    public partial class AjoutStock : Form
    {
        string sConnexion;
        public AjoutStock()
        {
            InitializeComponent();
            sConnexion = ConfigurationManager.ConnectionStrings["Projet_Fabrique_de_Meubles.Properties.Settings.FabMeublesCouches"].ConnectionString;
            tbNom.Text = tbQuantite.Text = tbEtat.Text = tbDelai.Text = "";
            tbNom.Focus();

            C_MEUBLE article = new C_MEUBLE();
            int i = 1;
            article = new G_MEUBLE(sConnexion).Lire_ID(i);

            for (i = 1; i < 100; i++)
            {
                article = new G_MEUBLE(sConnexion).Lire_ID(i);
                if (article.ID != 0)
                {
                    tbNom.Items.Add(article.NOM);
                }
            }
        }

        private void AddProduct_Click(object sender, EventArgs e)
        {
            C_MEUBLE article = new C_MEUBLE();
            int i = 1;

            while(tbNom.Text != article.NOM)
            {
                article = new G_MEUBLE(sConnexion).Lire_ID(i);
                i++;
            }

            new G_STOCK(sConnexion).Ajouter(article.ID, int.Parse(tbQuantite.Text), tbEtat.Text, int.Parse(tbDelai.Text));
            MessageBox.Show("Le produit a bien été ajouté.");
            tbNom.Text = tbQuantite.Text = tbEtat.Text = tbDelai.Text = "";
            Close();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void gbAjMed_Enter(object sender, EventArgs e)
        {

        }
    }
}
