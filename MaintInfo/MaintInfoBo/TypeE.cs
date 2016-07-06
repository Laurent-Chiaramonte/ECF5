using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaintInfoBo
{
    public class TypeE
    {
        #region Propriétés
        public int idTypeE { get; set; }
        public string designation_type { get; set; }
        #endregion

        #region Constructeurs
        public TypeE() { }
        #endregion

        #region Méthodes
        public override bool Equals(object obj)
        {
            if (obj is TypeE)
                return
                    ((TypeE)obj).idTypeE.Equals(this.idTypeE);
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
