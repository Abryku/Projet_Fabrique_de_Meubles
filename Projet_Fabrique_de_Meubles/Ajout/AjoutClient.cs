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
    public partial class AjoutClient : Form
    {
        string sConnexion;
        public AjoutClient()
        {
            InitializeComponent();
            sConnexion = ConfigurationManager.ConnectionStrings["Projet_Fabrique_de_Meubles.Properties.Settings.FabMeublesCouches"].ConnectionString;
            tbPrenom.Text = tbNom.Text = tbMail.Text = tbGSM.Text = "";
            Activer(false);
            tbPrenom.Focus();
        }

        private void Activer(bool lPrincipal)
        {
            tbPrenom.Enabled = tbNom.Enabled = tbMail.Enabled = tbGSM.Enabled = !lPrincipal;
            Add_Client.Enabled = Annuler_Client.Enabled = !lPrincipal;
        }

        private void Add_Client_Click(object sender, EventArgs e)
        {
            new G_CLIENT(sConnexion).Ajouter(tbNom.Text, tbPrenom.Text, tbGSM.Text, tbMail.Text);
            MessageBox.Show("Le client a bien été ajouté.");
            tbPrenom.Text = tbNom.Text = tbMail.Text = tbGSM.Text = "";
            Close();
        }

        private void Annuler_Client_Click(object sender, EventArgs e)
        {
            Activer(true);
            Close();
        }
    }
}
