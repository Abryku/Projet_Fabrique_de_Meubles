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
    public partial class SupprimerCommande : Form
    {
        string sConnexion;
        public SupprimerCommande()
        {
            sConnexion = ConfigurationManager.ConnectionStrings["Projet_Fabrique_de_Meubles.Properties.Settings.FabMeublesCouches"].ConnectionString;
            InitializeComponent();

            C_COMMANDE commande = new C_COMMANDE();
            int i = 1;
            commande = new G_COMMANDE(sConnexion).Lire_ID(i);
            if (commande.ID != 0)
            {
                tbID.Items.Add(commande.ID);
            }
            while (commande.ID != 0)
            {
                commande = new G_COMMANDE(sConnexion).Lire_ID(i + 1);
                if (commande.ID != 0)
                {
                    i++;
                    tbID.Items.Add(commande.ID);
                }
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Supprimer définitvement ?", "Confirmer", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                new G_COMMANDE(sConnexion).Supprimer(int.Parse(tbID.Text));
            }
            Close();
        }
    }
}
