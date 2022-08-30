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
    public partial class SupprimerClient : Form
    {
        string sConnexion;
        public SupprimerClient()
        {
            InitializeComponent();
            sConnexion = ConfigurationManager.ConnectionStrings["Projet_Fabrique_de_Meubles.Properties.Settings.FabMeublesCouches"].ConnectionString;

            C_CLIENT client = new C_CLIENT();
            int i = 1;
            client = new G_CLIENT(sConnexion).Lire_ID(i);
            if (client.ID != 0)
            {
                tbID.Items.Add(client.ID);
            }
            while (client.ID != 0)
            {
                client = new G_CLIENT(sConnexion).Lire_ID(i + 1);
                if (client.ID != 0)
                {
                    i++;
                    tbID.Items.Add(client.ID);
                }
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Supprimer définitvement ?", "Confirmer", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                new G_CLIENT(sConnexion).Supprimer(int.Parse(tbID.Text));
            }
            Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tbID_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
