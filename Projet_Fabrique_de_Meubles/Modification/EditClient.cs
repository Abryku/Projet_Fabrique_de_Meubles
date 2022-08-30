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
    public partial class EditClient : Form
    {
        string sConnexion;
        public EditClient()
        {
            InitializeComponent();
            sConnexion = ConfigurationManager.ConnectionStrings["Projet_Fabrique_de_Meubles.Properties.Settings.FabMeublesCouches"].ConnectionString;
            tbPrenom.Text = tbNom.Text = tbMail.Text = tbGSM.Text = "";
            Activer(false);
            tbPrenom.Focus();

            C_CLIENT client = new C_CLIENT();
            int i = 1;
            client = new G_CLIENT(sConnexion).Lire_ID(i);

            for(i = 1; i<100;i++)
            {
                client = new G_CLIENT(sConnexion).Lire_ID(i);
                if (client.ID != 0)
                {
                    tbID.Items.Add( client.ID);
                }
            }
        }

        private void Activer(bool lPrincipal)
        {
            tbPrenom.Enabled = tbNom.Enabled = tbMail.Enabled = tbGSM.Enabled = !lPrincipal;
            edit_Client.Enabled = Annuler_Client.Enabled = !lPrincipal;
        }

        private void edit_Client_Click(object sender, EventArgs e)
        {
            new G_CLIENT(sConnexion).Modifier(int.Parse(tbID.Text), tbNom.Text, tbPrenom.Text, tbGSM.Text, tbMail.Text);
            MessageBox.Show("Le client a bien été modifié.");
            tbPrenom.Text = tbNom.Text = tbMail.Text = tbGSM.Text = "";
            Close();
        }

        private void Annuler_Client_Click(object sender, EventArgs e)
        {
            Activer(true);
            Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            C_CLIENT client = new G_CLIENT(sConnexion).Lire_ID(int.Parse(tbID.Text));
            
            tbPrenom.Text = client.Prénom;
            tbNom.Text = client.Nom;
            tbMail.Text = client.Mail;
            tbGSM.Text = client.Téléphone;
        }

        private void Annuler_Client_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}
