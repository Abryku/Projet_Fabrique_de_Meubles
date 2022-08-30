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
 public class G_DETAIL_COMMANDE : G_Base
 {
  #region Constructeurs
  public G_DETAIL_COMMANDE()
   : base()
  { }
  public G_DETAIL_COMMANDE(string sChaineConnexion)
   : base(sChaineConnexion)
  { }
  #endregion
  public int Ajouter(int ID_COMMANDE, int ID_MEUBLES)
  { return new A_DETAIL_COMMANDE(ChaineConnexion).Ajouter(ID_COMMANDE, ID_MEUBLES); }
  public int Modifier(int ID, int ID_COMMANDE, int ID_MEUBLES)
  { return new A_DETAIL_COMMANDE(ChaineConnexion).Modifier(ID, ID_COMMANDE, ID_MEUBLES); }
  public List<C_DETAIL_COMMANDE> Lire(string Index)
  { return new A_DETAIL_COMMANDE(ChaineConnexion).Lire(Index); }
  public C_DETAIL_COMMANDE Lire_ID(int ID)
  { return new A_DETAIL_COMMANDE(ChaineConnexion).Lire_ID(ID); }
  public int Supprimer(int ID)
  { return new A_DETAIL_COMMANDE(ChaineConnexion).Supprimer(ID); }
 }
}
