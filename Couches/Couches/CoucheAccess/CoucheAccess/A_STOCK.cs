#region Ressources extérieures
using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using Projet_Fabrique_de_meubles.Classes;
#endregion

namespace Projet_Fabrique_de_meubles.Acces
{
 /// <summary>
 /// Couche d'accès aux données (Data Access Layer)
 /// </summary>
 public class A_STOCK : ADBase
 {
  #region Constructeurs
  public A_STOCK(string sChaineConnexion)
  	: base("Data Source =.\\SQLEXPRESS; AttachDbFilename=\"C:\\Users\\antoi\\Desktop\\Base de données\\Projet_Fabrique_de_Meubles\\FabMeubles.mdf\";Integrated Security = True; Connect Timeout = 30; User Instance = True")
  { }
  #endregion
  public int Ajouter(int ID_MEUBLE, int? QUANTITE, string ETAT_DE_FABRICATION, int? DELAI_DE_LIVRAISON)
  {
   CreerCommande("AjouterSTOCK");
   int res = 0;
   Commande.Parameters.Add("ID", SqlDbType.Int);
   Direction("ID", ParameterDirection.Output);
   Commande.Parameters.AddWithValue("@ID_MEUBLE", ID_MEUBLE);
   if(QUANTITE == null) Commande.Parameters.AddWithValue("@QUANTITE", Convert.DBNull);
   else Commande.Parameters.AddWithValue("@QUANTITE", QUANTITE);
   Commande.Parameters.AddWithValue("@ETAT_DE_FABRICATION", ETAT_DE_FABRICATION);
   if(DELAI_DE_LIVRAISON == null) Commande.Parameters.AddWithValue("@DELAI_DE_LIVRAISON", Convert.DBNull);
   else Commande.Parameters.AddWithValue("@DELAI_DE_LIVRAISON", DELAI_DE_LIVRAISON);
   Commande.Connection.Open();
   Commande.ExecuteNonQuery();
   res = int.Parse(LireParametre("ID"));
   Commande.Connection.Close();
   return res;
  }
  public int Modifier(int ID, int ID_MEUBLE, int? QUANTITE, string ETAT_DE_FABRICATION, int? DELAI_DE_LIVRAISON)
  {
   CreerCommande("ModifierSTOCK");
   int res = 0;
   Commande.Parameters.AddWithValue("@ID", ID);
   Commande.Parameters.AddWithValue("@ID_MEUBLE", ID_MEUBLE);
   if(QUANTITE == null) Commande.Parameters.AddWithValue("@QUANTITE", Convert.DBNull);
   else Commande.Parameters.AddWithValue("@QUANTITE", QUANTITE);
   Commande.Parameters.AddWithValue("@ETAT_DE_FABRICATION", ETAT_DE_FABRICATION);
   if(DELAI_DE_LIVRAISON == null) Commande.Parameters.AddWithValue("@DELAI_DE_LIVRAISON", Convert.DBNull);
   else Commande.Parameters.AddWithValue("@DELAI_DE_LIVRAISON", DELAI_DE_LIVRAISON);
   Commande.Connection.Open();
   Commande.ExecuteNonQuery();
   Commande.Connection.Close();
   return res;
  }
  public List<C_STOCK> Lire(string Index)
  {
   CreerCommande("SelectionnerSTOCK");
   Commande.Parameters.AddWithValue("@Index", Index);
   Commande.Connection.Open();
   SqlDataReader dr = Commande.ExecuteReader();
   List<C_STOCK> res = new List<C_STOCK>();
   while (dr.Read())
   {
    C_STOCK tmp = new C_STOCK();
    tmp.ID = int.Parse(dr["ID"].ToString());
    tmp.ID_MEUBLE = int.Parse(dr["ID_MEUBLE"].ToString());
   if(dr["QUANTITE"] != DBNull.Value) tmp.QUANTITE = int.Parse(dr["QUANTITE"].ToString());
    tmp.ETAT_DE_FABRICATION = dr["ETAT_DE_FABRICATION"].ToString();
   if(dr["DELAI_DE_LIVRAISON"] != DBNull.Value) tmp.DELAI_DE_LIVRAISON = int.Parse(dr["DELAI_DE_LIVRAISON"].ToString());
    res.Add(tmp);
			}
			dr.Close();
			Commande.Connection.Close();
			return res;
		}
  public C_STOCK Lire_ID(int ID)
  {
   CreerCommande("SelectionnerSTOCK_ID");
   Commande.Parameters.AddWithValue("@ID", ID);
   Commande.Connection.Open();
   SqlDataReader dr = Commande.ExecuteReader();
   C_STOCK res = new C_STOCK();
   while (dr.Read())
   {
    res.ID = int.Parse(dr["ID"].ToString());
    res.ID_MEUBLE = int.Parse(dr["ID_MEUBLE"].ToString());
   if(dr["QUANTITE"] != DBNull.Value) res.QUANTITE = int.Parse(dr["QUANTITE"].ToString());
    res.ETAT_DE_FABRICATION = dr["ETAT_DE_FABRICATION"].ToString();
   if(dr["DELAI_DE_LIVRAISON"] != DBNull.Value) res.DELAI_DE_LIVRAISON = int.Parse(dr["DELAI_DE_LIVRAISON"].ToString());
   }
			dr.Close();
			Commande.Connection.Close();
			return res;
		}
  public int Supprimer(int ID)
  {
   CreerCommande("SupprimerSTOCK");
   int res = 0;
   Commande.Parameters.AddWithValue("@ID", ID);
   Commande.Connection.Open();
   res = Commande.ExecuteNonQuery();
			Commande.Connection.Close();
			return res;
		}
 }
}
