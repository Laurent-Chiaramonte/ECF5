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
        public int idEquipement { get; set; }
        public string designation_equip { get; set; }
        public Contrat leContrat { get; set; }
        public int idContrat { get; set; }
        public Modele leModele { get; set; }
        public int idModele { get; set; }

        #endregion

        #region Constructeurs
        public Equipement() { }
        #endregion

        #region Méthodes
        public override bool Equals(object obj)
        {
            if (obj is Equipement)
                return
                    ((Equipement)obj).idEquipement.Equals(this.idEquipement);
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
