using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.IO;
using System.Threading;
using System.Configuration;
using iText.IO.Image;
using iText.Kernel.Colors;
using iText.Kernel.Pdf;
using iText.Kernel.Pdf.Canvas.Draw;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using Color = System.Drawing.Color;
using Projet_Fabrique_de_meubles.Acces;
using Projet_Fabrique_de_meubles.Classes;
using Projet_Fabrique_de_meubles.Gestion;

namespace Projet_Fabrique_de_Meubles
{
    public partial class Facture : Form
    {
        private static string sConnexion;
        private DataTable DT_CLIENT, DT_COMMANDE, DT_DETAIL_COMMANDE, DT_MEUBLE, DT_STOCK;
        private BindingSource BS_CLIENT, BS_COMMANDE, BS_DETAIL_COMMANDE, BS_MEUBLE, BS_STOCK;

        private void SortieFacture_Click(object sender, EventArgs e)
        {
            EtablirFacture(int.Parse(cbCommande.Text));
        }

        int Total = 0;

        public Facture()
        {
            InitializeComponent();
            C_COMMANDE commande = new C_COMMANDE();

            for (int j = 1; j < 100; j++)
            {
                commande = new G_COMMANDE(sConnexion).Lire_ID(j);
                if (commande.ID != 0)
                {
                    cbCommande.Items.Add(commande.ID);
                }
            }
        }


        private int AFacturer(int IDComm)
        {
            DT_DETAIL_COMMANDE = new DataTable();

            int PrixTotal = 0;

            DGV_facture.Columns.Add("ID du meuble", "ID du meuble");
            DGV_facture.Columns.Add("Prix unitaire", "Prix unitaire");
            DGV_facture.Columns.Add("Prix total", "Prix total");


            List<C_DETAIL_COMMANDE> lTmp_C_ID_DETAIL_COMMANDE = new G_DETAIL_COMMANDE(sConnexion).Lire("ID");
            List<C_MEUBLE> lTmp_C_ID_MEUBLE = new G_MEUBLE(sConnexion).Lire("ID");
            List<int> ListeIDMeubleAFact = new List<int>();

            //Récupération liste des meubles de la commande
            foreach(C_DETAIL_COMMANDE Tmp in lTmp_C_ID_DETAIL_COMMANDE)
            {
                if(Tmp.ID_COMMANDE == IDComm)
                {
                    //ListeIDMeubleAFact.Add(Tmp.ID_MEUBLES);
                    foreach(C_MEUBLE meuble in lTmp_C_ID_MEUBLE)
                    {
                        if(meuble.ID == Tmp.ID_MEUBLES)
                        {
                            DGV_facture.Rows.Add(Convert.ToString(Tmp.ID_MEUBLES), meuble.PRIX_UNITAIRE);
                            PrixTotal = PrixTotal + Convert.ToInt32(meuble.PRIX_UNITAIRE);
                        }
                    }
                }
            }
            DGV_facture.Rows.Add("", "", "Total : " + PrixTotal);
            return PrixTotal;

        }
        private void EtablirFacture(int IDComm)
        {
            string Coordonnées_client = "", Date_de_commande = "";
            int Prix_Total = 0;
            List<int> ID_du_Meuble = new List<int>();
            List<int> Prix_Unitaire = new List<int>();

            List<C_DETAIL_COMMANDE> lTmp_C_ID_DETAIL_COMMANDE = new G_DETAIL_COMMANDE(sConnexion).Lire("ID");
            List<C_MEUBLE> lTmp_C_ID_MEUBLE = new G_MEUBLE(sConnexion).Lire("ID");
            List<C_COMMANDE> lTmp_C_ID_COMMANDE = new G_COMMANDE(sConnexion).Lire("ID");
            List<C_CLIENT> lTmp_C_ID_CLIENT = new G_CLIENT(sConnexion).Lire("ID");



            //Récupération liste des meubles de la commande
            foreach (C_DETAIL_COMMANDE Tmp in lTmp_C_ID_DETAIL_COMMANDE)
            {
                if (Tmp.ID_COMMANDE == IDComm)
                {
                    ID_du_Meuble.Add(Tmp.ID_MEUBLES);

                    foreach (C_MEUBLE meuble in lTmp_C_ID_MEUBLE)
                    {
                        if (meuble.ID == Tmp.ID_MEUBLES)
                        {
                            Prix_Unitaire.Add(Convert.ToInt32(meuble.PRIX_UNITAIRE));
                            Prix_Total = Prix_Total + Convert.ToInt32(meuble.PRIX_UNITAIRE);
                        }
                    }
                    foreach (C_COMMANDE commande in lTmp_C_ID_COMMANDE)
                    {
                        if(commande.ID == IDComm)
                        {
                            Date_de_commande = Convert.ToString(commande.DATE);
                            foreach (C_CLIENT client in lTmp_C_ID_CLIENT)
                            {
                               if (client.ID == commande.ID_CLIENT)
                                {
                                    Coordonnées_client = Convert.ToString(client.Nom) + " " + Convert.ToString(client.Prénom) + "\n" + Convert.ToString(client.Téléphone) + "\n" + Convert.ToString(client.Mail);
                                }
                            }
                        }
                        
                    }
                }
            }

            // création du fichier de facturation dans le dossier indiqué

            PdfWriter writer = new PdfWriter(@"C:\Users\antoi\Desktop\Base de données\Projet_Fabrique_de_Meubles\facture.pdf");
            PdfDocument pdf = new PdfDocument(writer);
            Document document = new Document(pdf);
            //Coordonnées du client
            Paragraph Données_client = new Paragraph(Coordonnées_client)
                .SetMarginLeft(350)
                .SetMarginBottom(10)
                .SetTextAlignment(TextAlignment.LEFT)
                .SetFontSize(12);
            // Titre du document
            Paragraph titre = new Paragraph("FACTURE :")
                .SetMarginBottom(10)
                .SetTextAlignment(TextAlignment.CENTER)
                .SetFontSize(20);
            Paragraph espace = new Paragraph("\n\n\n");
            //Tableau séjour
            Table tableau = new Table(2, false).UseAllAvailableWidth();
            //Ligne de titre du tableau
            Cell cell11 = new Cell(1, 1)
                .SetBackgroundColor(ColorConstants.LIGHT_GRAY)
                .SetTextAlignment(TextAlignment.CENTER)
                .Add(new Paragraph("Date de commande"));
            Cell cell12 = new Cell(1, 1)
                .SetBackgroundColor(ColorConstants.LIGHT_GRAY)
                .SetTextAlignment(TextAlignment.CENTER)
                .Add(new Paragraph("Date de sortie de facture"));
            //Contenu du taleau;
            Cell cell21 = new Cell(1, 1)
                .SetTextAlignment(TextAlignment.CENTER)
                .Add(new Paragraph(Date_de_commande));
            Cell cell22 = new Cell(1, 1)
                .SetTextAlignment(TextAlignment.CENTER)
                .Add(new Paragraph(Convert.ToString(DateTime.Today)));
            //Ajout des cellules au tableau
            tableau.AddCell(cell11);
            tableau.AddCell(cell12);
            tableau.AddCell(cell21);
            tableau.AddCell(cell22);
            //Tableau
            Table tableau1 = new Table(2, false).UseAllAvailableWidth();
            //Ligne de titre du tableau
            Cell cellbis11 = new Cell(1, 1)
                .SetBackgroundColor(ColorConstants.LIGHT_GRAY)
                .SetTextAlignment(TextAlignment.CENTER)
                .Add(new Paragraph("ID du meuble"));
            Cell cellbis12 = new Cell(1, 1)
                .SetBackgroundColor(ColorConstants.LIGHT_GRAY)
                .SetTextAlignment(TextAlignment.CENTER)
                .Add(new Paragraph("Prix unitaire"));
            tableau1.AddCell(cellbis11);
            tableau1.AddCell(cellbis12);
            //Contenu du taleau
            for (int j = 0; j < ID_du_Meuble.Count; j++)
            {
                Cell cellbis1 = new Cell(1, 1)
                    .SetTextAlignment(TextAlignment.CENTER)
                    .Add(new Paragraph(ID_du_Meuble[j].ToString()));
                Cell cellbis2 = new Cell(1, 1)
                    .SetTextAlignment(TextAlignment.CENTER)
                    .Add(new Paragraph(Prix_Unitaire[j].ToString()));
                tableau1.AddCell(cellbis1);
                tableau1.AddCell(cellbis2);
            }
            // Ligne prix total
            Cell cellbisDer1 = new Cell(1, 1)
                .SetBackgroundColor(ColorConstants.LIGHT_GRAY)
                .SetTextAlignment(TextAlignment.CENTER)
                .Add(new Paragraph("Prix total :"));
            Cell cellbisDer2 = new Cell(1, 1)
                .SetTextAlignment(TextAlignment.CENTER)
                .Add(new Paragraph(Prix_Total.ToString()));
            tableau1.AddCell(cellbisDer1);
            tableau1.AddCell(cellbisDer2);

            //Ligne séparatrice
            LineSeparator ls = new LineSeparator(new SolidLine());

            document.Add(Données_client);
            document.Add(titre);
            document.Add(tableau);
            document.Add(espace);
            document.Add(tableau1);
            document.Add(espace);
            document.Add(espace);
            document.Add(ls);
            document.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if(cbCommande != null)
                Total = AFacturer(int.Parse(cbCommande.Text));
        }
    }
}
