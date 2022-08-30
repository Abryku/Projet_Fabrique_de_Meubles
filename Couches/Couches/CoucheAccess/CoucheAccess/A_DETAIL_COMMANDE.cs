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
 public class A_DETAIL_COMMANDE : ADBase
 {
  #region Constructeurs
  public A_DETAIL_COMMANDE(string sChaineConnexion)
  	: base("Data Source =.\\SQLEXPRESS; AttachDbFilename=\"C:\\Users\\antoi\\Desktop\\Base de données\\Projet_Fabrique_de_Meubles\\FabMeubles.mdf\";Integrated Security = True; Connect Timeout = 30; User Instance = True")
  { }
  #endregion
  public int Ajouter(int ID_COMMANDE, int ID_MEUBLES)
  {
   CreerCommande("AjouterDETAIL_COMMANDE");
   int res = 0;
   Commande.Parameters.Add("ID", SqlDbType.Int);
   Direction("ID", ParameterDirection.Output);
   Commande.Parameters.AddWithValue("@ID_COMMANDE", ID_COMMANDE);
   Commande.Parameters.AddWithValue("@ID_MEUBLES", ID_MEUBLES);
   Commande.Connection.Open();
   Commande.ExecuteNonQuery();
   res = int.Parse(LireParametre("ID"));
   Commande.Connection.Close();
   return res;
  }
  public int Modifier(int ID, int ID_COMMANDE, int ID_MEUBLES)
  {
   CreerCommande("ModifierDETAIL_COMMANDE");
   int res = 0;
   Commande.Parameters.AddWithValue("@ID", ID);
   Commande.Parameters.AddWithValue("@ID_COMMANDE", ID_COMMANDE);
   Commande.Parameters.AddWithValue("@ID_MEUBLES", ID_MEUBLES);
   Commande.Connection.Open();
   Commande.ExecuteNonQuery();
   Commande.Connection.Close();
   return res;
  }
  public List<C_DETAIL_COMMANDE> Lire(string Index)
  {
   CreerCommande("SelectionnerDETAIL_COMMANDE");
   Commande.Parameters.AddWithValue("@Index", Index);
   Commande.Connection.Open();
   SqlDataReader dr = Commande.ExecuteReader();
   List<C_DETAIL_COMMANDE> res = new List<C_DETAIL_COMMANDE>();
   while (dr.Read())
   {
    C_DETAIL_COMMANDE tmp = new C_DETAIL_COMMANDE();
    tmp.ID = int.Parse(dr["ID"].ToString());
    tmp.ID_COMMANDE = int.Parse(dr["ID_COMMANDE"].ToString());
    tmp.ID_MEUBLES = int.Parse(dr["ID_MEUBLES"].ToString());
    res.Add(tmp);
			}
			dr.Close();
			Commande.Connection.Close();
			return res;
		}
  public C_DETAIL_COMMANDE Lire_ID(int ID)
  {
   CreerCommande("SelectionnerDETAIL_COMMANDE_ID");
   Commande.Parameters.AddWithValue("@ID", ID);
   Commande.Connection.Open();
   SqlDataReader dr = Commande.ExecuteReader();
   C_DETAIL_COMMANDE res = new C_DETAIL_COMMANDE();
   while (dr.Read())
   {
    res.ID = int.Parse(dr["ID"].ToString());
    res.ID_COMMANDE = int.Parse(dr["ID_COMMANDE"].ToString());
    res.ID_MEUBLES = int.Parse(dr["ID_MEUBLES"].ToString());
   }
			dr.Close();
			Commande.Connection.Close();
			return res;
		}
  public int Supprimer(int ID)
  {
   CreerCommande("SupprimerDETAIL_COMMANDE");
   int res = 0;
   Commande.Parameters.AddWithValue("@ID", ID);
   Commande.Connection.Open();
   res = Commande.ExecuteNonQuery();
			Commande.Connection.Close();
			return res;
		}
 }
}
