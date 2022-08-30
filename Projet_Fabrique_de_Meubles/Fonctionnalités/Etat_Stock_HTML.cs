using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;


namespace Projet_Fabrique_de_Meubles
{
    public partial class Etat_Stock_HTML : Form
    {
        public Etat_Stock_HTML(string path)
        {
            InitializeComponent();
            var uri = new Uri(path); //Produit une url à l'aide du fichier
            this.Text = Path.GetFileName(path); //Affiche le nom du fichier sur la fenêtre
            wbEtatStock.Navigate(uri); //Lecteur de page web  
        }

    }
}
