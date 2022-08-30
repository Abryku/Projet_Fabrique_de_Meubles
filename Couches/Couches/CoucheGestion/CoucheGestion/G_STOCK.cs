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
 public class G_STOCK : G_Base
 {
  #region Constructeurs
  public G_STOCK()
   : base()
  { }
  public G_STOCK(string sChaineConnexion)
   : base(sChaineConnexion)
  { }
  #endregion
  public int Ajouter(int ID_MEUBLE, int? QUANTITE, string ETAT_DE_FABRICATION, int? DELAI_DE_LIVRAISON)
  { return new A_STOCK(ChaineConnexion).Ajouter(ID_MEUBLE, QUANTITE, ETAT_DE_FABRICATION, DELAI_DE_LIVRAISON); }
  public int Modifier(int ID, int ID_MEUBLE, int? QUANTITE, string ETAT_DE_FABRICATION, int? DELAI_DE_LIVRAISON)
  { return new A_STOCK(ChaineConnexion).Modifier(ID, ID_MEUBLE, QUANTITE, ETAT_DE_FABRICATION, DELAI_DE_LIVRAISON); }
  public List<C_STOCK> Lire(string Index)
  { return new A_STOCK(ChaineConnexion).Lire(Index); }
  public C_STOCK Lire_ID(int ID)
  { return new A_STOCK(ChaineConnexion).Lire_ID(ID); }
  public int Supprimer(int ID)
  { return new A_STOCK(ChaineConnexion).Supprimer(ID); }
 }
}
