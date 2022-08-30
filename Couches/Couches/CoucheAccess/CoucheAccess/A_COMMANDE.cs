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
 public class A_COMMANDE : ADBase
 {
  #region Constructeurs
  public A_COMMANDE(string sChaineConnexion)
  	: base("Data Source =.\\SQLEXPRESS; AttachDbFilename=\"C:\\Users\\antoi\\Desktop\\Base de données\\Projet_Fabrique_de_Meubles\\FabMeubles.mdf\";Integrated Security = True; Connect Timeout = 30; User Instance = True")
  { }
  #endregion
  public int Ajouter(int ID_CLIENT, DateTime DATE, DateTime? DATE_DE_PAIMENT)
  {
   CreerCommande("AjouterCOMMANDE");
   int res = 0;
   Commande.Parameters.Add("ID", SqlDbType.Int);
   Direction("ID", ParameterDirection.Output);
   Commande.Parameters.AddWithValue("@ID_CLIENT", ID_CLIENT);
   Commande.Parameters.AddWithValue("@DATE", DATE);
   if(DATE_DE_PAIMENT == null) Commande.Parameters.AddWithValue("@DATE_DE_PAIMENT", Convert.DBNull);
   else Commande.Parameters.AddWithValue("@DATE_DE_PAIMENT", DATE_DE_PAIMENT);
   Commande.Connection.Open();
   Commande.ExecuteNonQuery();
   res = int.Parse(LireParametre("ID"));
   Commande.Connection.Close();
   return res;
  }
  public int Modifier(int ID, int ID_CLIENT, DateTime DATE, DateTime? DATE_DE_PAIMENT)
  {
   CreerCommande("ModifierCOMMANDE");
   int res = 0;
   Commande.Parameters.AddWithValue("@ID", ID);
   Commande.Parameters.AddWithValue("@ID_CLIENT", ID_CLIENT);
   Commande.Parameters.AddWithValue("@DATE", DATE);
   if(DATE_DE_PAIMENT == null) Commande.Parameters.AddWithValue("@DATE_DE_PAIMENT", Convert.DBNull);
   else Commande.Parameters.AddWithValue("@DATE_DE_PAIMENT", DATE_DE_PAIMENT);
   Commande.Connection.Open();
   Commande.ExecuteNonQuery();
   Commande.Connection.Close();
   return res;
  }
  public List<C_COMMANDE> Lire(string Index)
  {
   CreerCommande("SelectionnerCOMMANDE");
   Commande.Parameters.AddWithValue("@Index", Index);
   Commande.Connection.Open();
   SqlDataReader dr = Commande.ExecuteReader();
   List<C_COMMANDE> res = new List<C_COMMANDE>();
   while (dr.Read())
   {
    C_COMMANDE tmp = new C_COMMANDE();
    tmp.ID = int.Parse(dr["ID"].ToString());
    tmp.ID_CLIENT = int.Parse(dr["ID_CLIENT"].ToString());
    tmp.DATE = DateTime.Parse(dr["DATE"].ToString());
   if(dr["DATE_DE_PAIMENT"] != DBNull.Value) tmp.DATE_DE_PAIMENT = DateTime.Parse(dr["DATE_DE_PAIMENT"].ToString());
    res.Add(tmp);
			}
			dr.Close();
			Commande.Connection.Close();
			return res;
		}
  public C_COMMANDE Lire_ID(int ID)
  {
   CreerCommande("SelectionnerCOMMANDE_ID");
   Commande.Parameters.AddWithValue("@ID", ID);
   Commande.Connection.Open();
   SqlDataReader dr = Commande.ExecuteReader();
   C_COMMANDE res = new C_COMMANDE();
   while (dr.Read())
   {
    res.ID = int.Parse(dr["ID"].ToString());
    res.ID_CLIENT = int.Parse(dr["ID_CLIENT"].ToString());
    res.DATE = DateTime.Parse(dr["DATE"].ToString());
   if(dr["DATE_DE_PAIMENT"] != DBNull.Value) res.DATE_DE_PAIMENT = DateTime.Parse(dr["DATE_DE_PAIMENT"].ToString());
   }
			dr.Close();
			Commande.Connection.Close();
			return res;
		}
  public int Supprimer(int ID)
  {
   CreerCommande("SupprimerCOMMANDE");
   int res = 0;
   Commande.Parameters.AddWithValue("@ID", ID);
   Commande.Connection.Open();
   res = Commande.ExecuteNonQuery();
			Commande.Connection.Close();
			return res;
		}
 }
}
