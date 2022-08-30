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
 public class G_CLIENT : G_Base
 {
  #region Constructeurs
  public G_CLIENT()
   : base()
  { }
  public G_CLIENT(string sChaineConnexion)
   : base(sChaineConnexion)
  { }
  #endregion
  public int Ajouter(string Nom, string Prénom, string Téléphone, string Mail)
  { return new A_CLIENT(ChaineConnexion).Ajouter(Nom, Prénom, Téléphone, Mail); }
  public int Modifier(int ID, string Nom, string Prénom, string Téléphone, string Mail)
  { return new A_CLIENT(ChaineConnexion).Modifier(ID, Nom, Prénom, Téléphone, Mail); }
  public List<C_CLIENT> Lire(string Index)
  { return new A_CLIENT(ChaineConnexion).Lire(Index); }
  public C_CLIENT Lire_ID(int ID)
  { return new A_CLIENT(ChaineConnexion).Lire_ID(ID); }
  public int Supprimer(int ID)
  { return new A_CLIENT(ChaineConnexion).Supprimer(ID); }
 }
}
