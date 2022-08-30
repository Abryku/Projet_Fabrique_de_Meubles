#region Ressources extérieures
using System;
using System.Collections.Generic;
using System.Text;
#endregion

namespace Projet_Fabrique_de_meubles.Classes
{
 /// <summary>
 /// Classe de définition des données
 /// </summary>
 public class C_DETAIL_COMMANDE
 {
  #region Données membres
  private int _ID;
  private int _ID_COMMANDE;
  private int _ID_MEUBLES;
  #endregion
  #region Constructeurs
  public C_DETAIL_COMMANDE()
  { }
  public C_DETAIL_COMMANDE(int ID_COMMANDE_, int ID_MEUBLES_)
  {
   ID_COMMANDE = ID_COMMANDE_;
   ID_MEUBLES = ID_MEUBLES_;
  }
  public C_DETAIL_COMMANDE(int ID_, int ID_COMMANDE_, int ID_MEUBLES_)
   : this(ID_COMMANDE_, ID_MEUBLES_)
  {
   ID = ID_;
  }
  #endregion
  #region Accesseurs
  public int ID
  {
   get { return _ID; }
   set { _ID = value; }
  }
  public int ID_COMMANDE
  {
   get { return _ID_COMMANDE; }
   set { _ID_COMMANDE = value; }
  }
  public int ID_MEUBLES
  {
   get { return _ID_MEUBLES; }
   set { _ID_MEUBLES = value; }
  }
  #endregion
 }
}
