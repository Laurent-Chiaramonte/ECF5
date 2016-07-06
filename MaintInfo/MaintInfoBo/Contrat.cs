using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaintInfoBo
{
    public class Contrat
    {
        #region Constructeurs
        public Contrat() { }
        public Contrat(int numct, double mtct, short stat, string comm, DateTime crea, DateTime ech, DateTime res, 
            CentreInformatique ci)
        {
            num_contrat = numct;
            montant_contrat = mtct;
            statut = stat;
            date_creation = crea;
            date_echeance = ech;
            date_resiliation = res;
            leCentre = ci;
        }


        #endregion

        #region Propriétés
        public int num_contrat { get; set; }
        public double montant_contrat { get; set; }
        public short statut { get; set; }
        public string commentaire { get; set; }
        public DateTime date_creation { get; set; }
        public DateTime date_echeance { get; set; }
        public DateTime date_resiliation { get; set; }
        public CentreInformatique leCentre { get; set; }
        #endregion

        #region Méthodes
        #endregion
    }
}
