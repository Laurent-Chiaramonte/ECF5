using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaintInfoBo
{
    public class Secteur
    {
        #region Propriétés
        public int idSecteur { get; set; }
        public string libelleSecteur { get; set; }
        #endregion

        #region Constructeurs
        public Secteur() { }
        #endregion

        #region Méthodes
        public override bool Equals(object obj)
        {
            if (obj is Secteur)
                return
                    ((Secteur)obj).idSecteur.Equals(this.idSecteur);
            else
                return false;
        }
        #endregion
    }
}
