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
 public class C_COMMANDE
 {
  #region Données membres
  private int _ID;
  private int _ID_CLIENT;
  private DateTime _DATE;
  private DateTime? _DATE_DE_PAIMENT;
  #endregion
  #region Constructeurs
  public C_COMMANDE()
  { }
  public C_COMMANDE(int ID_CLIENT_, DateTime DATE_, DateTime? DATE_DE_PAIMENT_)
  {
   ID_CLIENT = ID_CLIENT_;
   DATE = DATE_;
   DATE_DE_PAIMENT = DATE_DE_PAIMENT_;
  }
  public C_COMMANDE(int ID_, int ID_CLIENT_, DateTime DATE_, DateTime? DATE_DE_PAIMENT_)
   : this(ID_CLIENT_, DATE_, DATE_DE_PAIMENT_)
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
  public int ID_CLIENT
  {
   get { return _ID_CLIENT; }
   set { _ID_CLIENT = value; }
  }
  public DateTime DATE
  {
   get { return _DATE; }
   set { _DATE = value; }
  }
  public DateTime? DATE_DE_PAIMENT
  {
   get { return _DATE_DE_PAIMENT; }
   set { _DATE_DE_PAIMENT = value; }
  }
  #endregion
 }
}
