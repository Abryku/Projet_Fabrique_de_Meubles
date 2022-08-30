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
    public partial class AjoutCommande : Form
    {
        string sConnexion;
        private DataTable DT_CLIENT, DT_COMMANDE, DT_DETAIL_COMMANDE, DT_MEUBLE, DT_STOCK;
        private BindingSource BS_CLIENT, BS_COMMANDE, BS_DETAIL_COMMANDE, BS_MEUBLE, BS_STOCK;

        private void Valid_Click(object sender, EventArgs e)
        {
            Close();
        }

        public AjoutCommande()
        {
            InitializeComponent();
            sConnexion = ConfigurationManager.ConnectionStrings["Projet_Fabrique_de_Meubles.Properties.Settings.FabMeublesCouches"].ConnectionString;

            C_CLIENT client = new C_CLIENT();
            int i = 1;
            client = new G_CLIENT(sConnexion).Lire_ID(i);

            for (i = 1; i < 100; i++)
            {
                client = new G_CLIENT(sConnexion).Lire_ID(i);
                if (client.ID != 0)
                {
                    tbID.Items.Add(client.ID);
                }
            }

            C_MEUBLE article = new C_MEUBLE();
            int j = 1;
            article = new G_MEUBLE(sConnexion).Lire_ID(j);

            for (j = 1; j < 100; j++)
            {
                article = new G_MEUBLE(sConnexion).Lire_ID(j);
                if (article.ID != 0)
                {
                    tbArticle.Items.Add(article.NOM);
                }
            }

            tbPaiementContent.Items.Add("Oui");
            tbPaiementContent.Items.Add("Non");

            // Permet de sélectionner une date et non une plage de date dans le calendrier \\
            monthCalendar1.MaxSelectionCount = 1;

            AjoutListe.Enabled = false;
        } 
        private void ValidInfo_Click(object sender, EventArgs e)
        {
            int ID_COMMANDE;

            if (tbPaiementContent.Text == "Oui")
            {
                ID_COMMANDE = new G_COMMANDE(sConnexion).Ajouter(int.Parse(tbID.Text), DateTime.Parse(tbDateCom.Text), DateTime.Now);
            }
            else
            {
                ID_COMMANDE = new G_COMMANDE(sConnexion).Ajouter(int.Parse(tbID.Text), DateTime.Parse(tbDateCom.Text), null);
            }

            AjoutListe.Enabled = true;
            tbCommand.Text = ID_COMMANDE.ToString();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AjoutListe_Click(object sender, EventArgs e)
        {
            int i = 0;
            C_MEUBLE article = new C_MEUBLE();
            article = new G_MEUBLE(sConnexion).Lire_ID(i);

            while (tbArticle.Text != article.NOM)
            {
                i++;
                article = new G_MEUBLE(sConnexion).Lire_ID(i);
            }
            new G_DETAIL_COMMANDE(sConnexion).Ajouter(int.Parse(tbCommand.Text), i);

            dgvListeArticle.Rows.Add(tbArticle.Text);

            MessageBox.Show("Le produit a bien été ajouté à la liste.");
        } 
        private void btnAjoutDate_Click(object sender, EventArgs e)
        {
            tbDateCom.Text = monthCalendar1.SelectionStart.ToShortDateString();
        }
    }
}
