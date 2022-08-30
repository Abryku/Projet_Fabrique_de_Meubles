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
    public partial class SupprimerStock : Form
    {
        string sConnexion;
        public SupprimerStock()
        {
            InitializeComponent();
            sConnexion = ConfigurationManager.ConnectionStrings["Projet_Fabrique_de_Meubles.Properties.Settings.FabMeublesCouches"].ConnectionString;
            tbID_Meubles.Text = "";
            tbID_Meubles.Focus();

            C_STOCK article = new C_STOCK();
            int i = 1;
            article = new G_STOCK(sConnexion).Lire_ID(i);

            for (i = 1; i < 100; i++)
            {
                article = new G_STOCK(sConnexion).Lire_ID(i);
                if (article.ID != 0)
                {
                    tbID_Meubles.Items.Add(article.ID_MEUBLE);
                }
            }
        }

        private void DelProduct_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Supprimer définitvement ?", "Confirmer", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                C_STOCK article = new C_STOCK();
                int i = 0;
                while (int.Parse(tbID_Meubles.Text) != article.ID_MEUBLE)
                {
                    i++;
                    article = new G_STOCK(sConnexion).Lire_ID(i);
                }
                new G_STOCK(sConnexion).Supprimer(article.ID);
            }
            Close();   
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
