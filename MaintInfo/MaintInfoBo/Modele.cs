using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaintInfoBo
{
    public class Modele
    {
        #region Propriétés
        public int modeleID { get; set; }
        public string designation_modele { get; set; }
        public Tarif leTarif { get; set; }
        public int tarifID { get; set; }
        public TypeModele leType { get; set; }
        public int typeModeleID { get; set; }
        #endregion

        #region Constructeurs
        public Modele() { }
        #endregion

        #region Méthodes
        public override bool Equals(object obj)
        {
            if (obj is Modele)
                return
                    ((Modele)obj).modeleID.Equals(this.modeleID);
            else
                return false;
        }
        public override string ToString()
        {
            return base.ToString();
        }
        #endregion
    }
}
