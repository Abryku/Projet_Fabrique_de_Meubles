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
 public class C_CLIENT
 {
  #region Données membres
  private int _ID;
  private string _Nom;
  private string _Prénom;
  private string _Téléphone;
  private string _Mail;
  #endregion
  #region Constructeurs
  public C_CLIENT()
  { }
  public C_CLIENT(string Nom_, string Prénom_, string Téléphone_, string Mail_)
  {
   Nom = Nom_;
   Prénom = Prénom_;
   Téléphone = Téléphone_;
   Mail = Mail_;
  }
  public C_CLIENT(int ID_, string Nom_, string Prénom_, string Téléphone_, string Mail_)
   : this(Nom_, Prénom_, Téléphone_, Mail_)
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
  public string Nom
  {
   get { return _Nom; }
   set { _Nom = value; }
  }
  public string Prénom
  {
   get { return _Prénom; }
   set { _Prénom = value; }
  }
  public string Téléphone
  {
   get { return _Téléphone; }
   set { _Téléphone = value; }
  }
  public string Mail
  {
   get { return _Mail; }
   set { _Mail = value; }
  }
  #endregion
 }
}
