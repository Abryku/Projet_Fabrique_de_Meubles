#region Ressources extérieures
using System;
using System.Collections.Generic;
using System.Text;
using Projet_Fabrique_de_meubles.Classes;
using Projet_Fabrique_de_meubles.Acces;
#endregion

namespace Projet_Fabrique_de_meubles.Gestion
{
 /// <summary>
 /// Couche intermédiaire de gestion (Business Layer)
 /// </summary>
 public class G_COMMANDE : G_Base
 {
  #region Constructeurs
  public G_COMMANDE()
   : base()
  { }
  public G_COMMANDE(string sChaineConnexion)
   : base(sChaineConnexion)
  { }
  #endregion
  public int Ajouter(int ID_CLIENT, DateTime DATE, DateTime? DATE_DE_PAIMENT)
  { return new A_COMMANDE(ChaineConnexion).Ajouter(ID_CLIENT, DATE, DATE_DE_PAIMENT); }
  public int Modifier(int ID, int ID_CLIENT, DateTime DATE, DateTime? DATE_DE_PAIMENT)
  { return new A_COMMANDE(ChaineConnexion).Modifier(ID, ID_CLIENT, DATE, DATE_DE_PAIMENT); }
  public List<C_COMMANDE> Lire(string Index)
  { return new A_COMMANDE(ChaineConnexion).Lire(Index); }
  public C_COMMANDE Lire_ID(int ID)
  { return new A_COMMANDE(ChaineConnexion).Lire_ID(ID); }
  public int Supprimer(int ID)
  { return new A_COMMANDE(ChaineConnexion).Supprimer(ID); }
 }
}
