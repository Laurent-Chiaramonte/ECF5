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
        public int idTarif { get; set; }
        public DateTime date_tarif { get; set; }
        public double montant_tarif { get; set; }
        #endregion

        #region Constructeurs
        public Tarif() { }
        public Tarif(int num, DateTime date, double mt)
        {
            idTarif = num;
            date_tarif = date;
            montant_tarif = mt;
        }
        #endregion

        #region Méthodes
        public override bool Equals(object obj)
        {
            if (obj is Tarif)
                return
                    ((Tarif)obj).idTarif.Equals(this.idTarif);
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
