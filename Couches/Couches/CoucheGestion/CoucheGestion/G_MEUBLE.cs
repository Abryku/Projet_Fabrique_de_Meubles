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
 public class G_MEUBLE : G_Base
 {
  #region Constructeurs
  public G_MEUBLE()
   : base()
  { }
  public G_MEUBLE(string sChaineConnexion)
   : base(sChaineConnexion)
  { }
  #endregion
  public int Ajouter(string NOM, double? PRIX_UNITAIRE, string TEMPS_DE_FABRICATION)
  { return new A_MEUBLE(ChaineConnexion).Ajouter(NOM, PRIX_UNITAIRE, TEMPS_DE_FABRICATION); }
  public int Modifier(int ID, string NOM, double? PRIX_UNITAIRE, string TEMPS_DE_FABRICATION)
  { return new A_MEUBLE(ChaineConnexion).Modifier(ID, NOM, PRIX_UNITAIRE, TEMPS_DE_FABRICATION); }
  public List<C_MEUBLE> Lire(string Index)
  { return new A_MEUBLE(ChaineConnexion).Lire(Index); }
  public C_MEUBLE Lire_ID(int ID)
  { return new A_MEUBLE(ChaineConnexion).Lire_ID(ID); }
  public int Supprimer(int ID)
  { return new A_MEUBLE(ChaineConnexion).Supprimer(ID); }
 }
}
