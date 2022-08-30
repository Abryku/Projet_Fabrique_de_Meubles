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
 public class A_CLIENT : ADBase
 {
  #region Constructeurs
  public A_CLIENT(string sChaineConnexion)
  	: base("Data Source =.\\SQLEXPRESS; AttachDbFilename=\"C:\\Users\\antoi\\Desktop\\Base de données\\Projet_Fabrique_de_Meubles\\FabMeubles.mdf\";Integrated Security = True; Connect Timeout = 30; User Instance = True")
  { }
  #endregion
  public int Ajouter(string Nom, string Prénom, string Téléphone, string Mail)
  {
   CreerCommande("AjouterCLIENT");
   int res = 0;
   Commande.Parameters.Add("ID", SqlDbType.Int);
   Direction("ID", ParameterDirection.Output);
   Commande.Parameters.AddWithValue("@Nom", Nom);
   Commande.Parameters.AddWithValue("@Prénom", Prénom);
   if(Téléphone == null) Commande.Parameters.AddWithValue("@Téléphone", Convert.DBNull);
   else Commande.Parameters.AddWithValue("@Téléphone", Téléphone);
   if(Mail == null) Commande.Parameters.AddWithValue("@Mail", Convert.DBNull);
   else Commande.Parameters.AddWithValue("@Mail", Mail);
   Commande.Connection.Open();
   Commande.ExecuteNonQuery();
   res = int.Parse(LireParametre("ID"));
   Commande.Connection.Close();
   return res;
  }
  public int Modifier(int ID, string Nom, string Prénom, string Téléphone, string Mail)
  {
   CreerCommande("ModifierCLIENT");
   int res = 0;
   Commande.Parameters.AddWithValue("@ID", ID);
   Commande.Parameters.AddWithValue("@Nom", Nom);
   Commande.Parameters.AddWithValue("@Prénom", Prénom);
   if(Téléphone == null) Commande.Parameters.AddWithValue("@Téléphone", Convert.DBNull);
   else Commande.Parameters.AddWithValue("@Téléphone", Téléphone);
   if(Mail == null) Commande.Parameters.AddWithValue("@Mail", Convert.DBNull);
   else Commande.Parameters.AddWithValue("@Mail", Mail);
   Commande.Connection.Open();
   Commande.ExecuteNonQuery();
   Commande.Connection.Close();
   return res;
  }
  public List<C_CLIENT> Lire(string Index)
  {
   CreerCommande("SelectionnerCLIENT");
   Commande.Parameters.AddWithValue("@Index", Index);
   Commande.Connection.Open();
   SqlDataReader dr = Commande.ExecuteReader();
   List<C_CLIENT> res = new List<C_CLIENT>();
   while (dr.Read())
   {
    C_CLIENT tmp = new C_CLIENT();
    tmp.ID = int.Parse(dr["ID"].ToString());
    tmp.Nom = dr["Nom"].ToString();
    tmp.Prénom = dr["Prénom"].ToString();
    tmp.Téléphone = dr["Téléphone"].ToString();
    tmp.Mail = dr["Mail"].ToString();
    res.Add(tmp);
			}
			dr.Close();
			Commande.Connection.Close();
			return res;
		}
  public C_CLIENT Lire_ID(int ID)
  {
   CreerCommande("SelectionnerCLIENT_ID");
   Commande.Parameters.AddWithValue("@ID", ID);
   Commande.Connection.Open();
   SqlDataReader dr = Commande.ExecuteReader();
   C_CLIENT res = new C_CLIENT();
   while (dr.Read())
   {
    res.ID = int.Parse(dr["ID"].ToString());
    res.Nom = dr["Nom"].ToString();
    res.Prénom = dr["Prénom"].ToString();
    res.Téléphone = dr["Téléphone"].ToString();
    res.Mail = dr["Mail"].ToString();
   }
			dr.Close();
			Commande.Connection.Close();
			return res;
		}
  public int Supprimer(int ID)
  {
   CreerCommande("SupprimerCLIENT");
   int res = 0;
   Commande.Parameters.AddWithValue("@ID", ID);
   Commande.Connection.Open();
   res = Commande.ExecuteNonQuery();
			Commande.Connection.Close();
			return res;
		}
 }
}
