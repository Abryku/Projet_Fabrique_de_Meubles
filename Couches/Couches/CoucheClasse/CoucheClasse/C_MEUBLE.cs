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
 public class C_MEUBLE
 {
  #region Données membres
  private int _ID;
  private string _NOM;
  private double? _PRIX_UNITAIRE;
  private string _TEMPS_DE_FABRICATION;
  #endregion
  #region Constructeurs
  public C_MEUBLE()
  { }
  public C_MEUBLE(string NOM_, double? PRIX_UNITAIRE_, string TEMPS_DE_FABRICATION_)
  {
   NOM = NOM_;
   PRIX_UNITAIRE = PRIX_UNITAIRE_;
   TEMPS_DE_FABRICATION = TEMPS_DE_FABRICATION_;
  }
  public C_MEUBLE(int ID_, string NOM_, double? PRIX_UNITAIRE_, string TEMPS_DE_FABRICATION_)
   : this(NOM_, PRIX_UNITAIRE_, TEMPS_DE_FABRICATION_)
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
  public string NOM
  {
   get { return _NOM; }
   set { _NOM = value; }
  }
  public double? PRIX_UNITAIRE
  {
   get { return _PRIX_UNITAIRE; }
   set { _PRIX_UNITAIRE = value; }
  }
  public string TEMPS_DE_FABRICATION
  {
   get { return _TEMPS_DE_FABRICATION; }
   set { _TEMPS_DE_FABRICATION = value; }
  }
  #endregion
 }
}
