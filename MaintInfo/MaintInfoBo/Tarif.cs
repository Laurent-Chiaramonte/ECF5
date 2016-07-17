using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaintInfoBo
{
    public class Tarif
    {
        #region Propriétés
        public int tarifID { get; set; }

        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime date_tarif { get; set; }
        public double montant_tarif { get; set; }
        #endregion

        #region Constructeurs
        public Tarif() { }
        public Tarif(int num, DateTime date, double mt)
        {
            tarifID = num;
            date_tarif = date;
            montant_tarif = mt;
        }
        #endregion

        #region Méthodes
        public override bool Equals(object obj)
        {
            if (obj is Tarif)
                return
                    ((Tarif)obj).tarifID.Equals(this.tarifID);
            else
                return false;
        }

        public override string ToString()
        {
            return String.Format("Date du tarif : {0}, Montant : {1} ", date_tarif.ToShortDateString(), montant_tarif);
        }
        #endregion
    }
}
