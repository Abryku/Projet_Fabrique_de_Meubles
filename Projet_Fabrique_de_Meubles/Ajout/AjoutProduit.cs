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
    public partial class AjoutProduit : Form
    {
        string sConnexion;
        public AjoutProduit()
        {
            InitializeComponent();
            sConnexion = ConfigurationManager.ConnectionStrings["Projet_Fabrique_de_Meubles.Properties.Settings.FabMeublesCouches"].ConnectionString;
            tbNom.Text = tbPU.Text = tbTmpsFab.Text = "";
            tbNom.Focus();
        }

        private void AjoutProd_Click(object sender, EventArgs e)
        {
            new G_MEUBLE(sConnexion).Ajouter(tbNom.Text, int.Parse(tbPU.Text), tbTmpsFab.Text);
            MessageBox.Show("Le produit a bien été ajouté.");
            tbNom.Text = tbPU.Text = tbTmpsFab.Text = "";
            Close();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
