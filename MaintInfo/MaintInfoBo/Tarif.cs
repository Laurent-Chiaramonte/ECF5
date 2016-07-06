using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaintInfoBo
{
    public class Tarif
    {
        #region Propriétés
        public int num_tarif { get; set; }
        public DateTime date_tarif { get; set; }
        public double montant_tarif { get; set; }
        #endregion

        #region Constructeurs
        public Tarif() { }
        public Tarif(int num, DateTime date, double mt)
        {
            num_tarif = num;
            date_tarif = date;
            montant_tarif = mt;
        }
        #endregion

        #region Méthodes
        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override string ToString()
        {
            return base.ToString();
        }
        #endregion
    }
}
