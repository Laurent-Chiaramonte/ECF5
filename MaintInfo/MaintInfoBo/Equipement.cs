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
        public int num_serie { get; set; }
        public string designation_equip { get; set; }
        public Contrat leContrat { get; set; }
        public Modele leModele { get; set; }

        #endregion

        #region Constructeurs
        #endregion

        #region Méthodes
        #endregion
    }
}
