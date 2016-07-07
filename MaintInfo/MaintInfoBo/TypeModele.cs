using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaintInfoBo
{
    public class TypeModele
    {
        #region Propriétés
        public int typeModeleID { get; set; }
        public string designation_type { get; set; }
        #endregion

        #region Constructeurs
        public TypeModele() { }
        #endregion

        #region Méthodes
        public override bool Equals(object obj)
        {
            if (obj is TypeModele)
                return
                    ((TypeModele)obj).typeModeleID.Equals(this.typeModeleID);
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
