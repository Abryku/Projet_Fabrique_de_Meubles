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
 public class A_MEUBLE : ADBase
 {
  #region Constructeurs
  public A_MEUBLE(string sChaineConnexion)
  	: base("Data Source =.\\SQLEXPRESS; AttachDbFilename=\"C:\\Users\\antoi\\Desktop\\Base de données\\Projet_Fabrique_de_Meubles\\FabMeubles.mdf\";Integrated Security = True; Connect Timeout = 30; User Instance = True")
  { }
  #endregion
  public int Ajouter(string NOM, double? PRIX_UNITAIRE, string TEMPS_DE_FABRICATION)
  {
   CreerCommande("AjouterMEUBLE");
   int res = 0;
   Commande.Parameters.Add("ID", SqlDbType.Int);
   Direction("ID", ParameterDirection.Output);
   Commande.Parameters.AddWithValue("@NOM", NOM);
   if(PRIX_UNITAIRE == null) Commande.Parameters.AddWithValue("@PRIX_UNITAIRE", Convert.DBNull);
   else Commande.Parameters.AddWithValue("@PRIX_UNITAIRE", PRIX_UNITAIRE);
   if(TEMPS_DE_FABRICATION == null) Commande.Parameters.AddWithValue("@TEMPS_DE_FABRICATION", Convert.DBNull);
   else Commande.Parameters.AddWithValue("@TEMPS_DE_FABRICATION", TEMPS_DE_FABRICATION);
   Commande.Connection.Open();
   Commande.ExecuteNonQuery();
   res = int.Parse(LireParametre("ID"));
   Commande.Connection.Close();
   return res;
  }
  public int Modifier(int ID, string NOM, double? PRIX_UNITAIRE, string TEMPS_DE_FABRICATION)
  {
   CreerCommande("ModifierMEUBLE");
   int res = 0;
   Commande.Parameters.AddWithValue("@ID", ID);
   Commande.Parameters.AddWithValue("@NOM", NOM);
   if(PRIX_UNITAIRE == null) Commande.Parameters.AddWithValue("@PRIX_UNITAIRE", Convert.DBNull);
   else Commande.Parameters.AddWithValue("@PRIX_UNITAIRE", PRIX_UNITAIRE);
   if(TEMPS_DE_FABRICATION == null) Commande.Parameters.AddWithValue("@TEMPS_DE_FABRICATION", Convert.DBNull);
   else Commande.Parameters.AddWithValue("@TEMPS_DE_FABRICATION", TEMPS_DE_FABRICATION);
   Commande.Connection.Open();
   Commande.ExecuteNonQuery();
   Commande.Connection.Close();
   return res;
  }
  public List<C_MEUBLE> Lire(string Index)
  {
   CreerCommande("SelectionnerMEUBLE");
   Commande.Parameters.AddWithValue("@Index", Index);
   Commande.Connection.Open();
   SqlDataReader dr = Commande.ExecuteReader();
   List<C_MEUBLE> res = new List<C_MEUBLE>();
   while (dr.Read())
   {
    C_MEUBLE tmp = new C_MEUBLE();
    tmp.ID = int.Parse(dr["ID"].ToString());
    tmp.NOM = dr["NOM"].ToString();
   if(dr["PRIX_UNITAIRE"] != DBNull.Value) tmp.PRIX_UNITAIRE = double.Parse(dr["PRIX_UNITAIRE"].ToString());
    tmp.TEMPS_DE_FABRICATION = dr["TEMPS_DE_FABRICATION"].ToString();
    res.Add(tmp);
			}
			dr.Close();
			Commande.Connection.Close();
			return res;
		}
  public C_MEUBLE Lire_ID(int ID)
  {
   CreerCommande("SelectionnerMEUBLE_ID");
   Commande.Parameters.AddWithValue("@ID", ID);
   Commande.Connection.Open();
   SqlDataReader dr = Commande.ExecuteReader();
   C_MEUBLE res = new C_MEUBLE();
   while (dr.Read())
   {
    res.ID = int.Parse(dr["ID"].ToString());
    res.NOM = dr["NOM"].ToString();
   if(dr["PRIX_UNITAIRE"] != DBNull.Value) res.PRIX_UNITAIRE = double.Parse(dr["PRIX_UNITAIRE"].ToString());
    res.TEMPS_DE_FABRICATION = dr["TEMPS_DE_FABRICATION"].ToString();
   }
			dr.Close();
			Commande.Connection.Close();
			return res;
		}
  public int Supprimer(int ID)
  {
   CreerCommande("SupprimerMEUBLE");
   int res = 0;
   Commande.Parameters.AddWithValue("@ID", ID);
   Commande.Connection.Open();
   res = Commande.ExecuteNonQuery();
			Commande.Connection.Close();
			return res;
		}
 }
}
