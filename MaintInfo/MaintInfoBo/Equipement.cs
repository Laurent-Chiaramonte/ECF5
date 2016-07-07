using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaintInfoBo
{
    public class Equipement
    {
        #region Propriétés
        public int equipementID { get; set; }
        public string num_serie { get; set; }
        public int planification { get; set; }
        public Contrat leContrat { get; set; }
        public int contratID { get; set; }
        public Modele leModele { get; set; }
        public int modeleID { get; set; }

        #endregion

        #region Constructeurs
        public Equipement() { }
        #endregion

        #region Méthodes
        public override bool Equals(object obj)
        {
            if (obj is Equipement)
                return
                    ((Equipement)obj).equipementID.Equals(this.equipementID);
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
