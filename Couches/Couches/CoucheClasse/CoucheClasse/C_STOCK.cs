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
 public class C_STOCK
 {
  #region Données membres
  private int _ID;
  private int _ID_MEUBLE;
  private int? _QUANTITE;
  private string _ETAT_DE_FABRICATION;
  private int? _DELAI_DE_LIVRAISON;
  #endregion
  #region Constructeurs
  public C_STOCK()
  { }
  public C_STOCK(int ID_MEUBLE_, int? QUANTITE_, string ETAT_DE_FABRICATION_, int? DELAI_DE_LIVRAISON_)
  {
   ID_MEUBLE = ID_MEUBLE_;
   QUANTITE = QUANTITE_;
   ETAT_DE_FABRICATION = ETAT_DE_FABRICATION_;
   DELAI_DE_LIVRAISON = DELAI_DE_LIVRAISON_;
  }
  public C_STOCK(int ID_, int ID_MEUBLE_, int? QUANTITE_, string ETAT_DE_FABRICATION_, int? DELAI_DE_LIVRAISON_)
   : this(ID_MEUBLE_, QUANTITE_, ETAT_DE_FABRICATION_, DELAI_DE_LIVRAISON_)
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
  public int ID_MEUBLE
  {
   get { return _ID_MEUBLE; }
   set { _ID_MEUBLE = value; }
  }
  public int? QUANTITE
  {
   get { return _QUANTITE; }
   set { _QUANTITE = value; }
  }
  public string ETAT_DE_FABRICATION
  {
   get { return _ETAT_DE_FABRICATION; }
   set { _ETAT_DE_FABRICATION = value; }
  }
  public int? DELAI_DE_LIVRAISON
  {
   get { return _DELAI_DE_LIVRAISON; }
   set { _DELAI_DE_LIVRAISON = value; }
  }
  #endregion
 }
}
