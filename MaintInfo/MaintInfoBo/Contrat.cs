using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaintInfoBo
{
    public class Contrat
    {
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

        #region Méthodes
        public override bool Equals(object obj)
        {
            if (obj is Contrat)
                return
                    ((Contrat)obj).num_contrat.Equals(this.num_contrat);
            else
                return false;
        }

        public override string ToString()
        {
            string tost = null;
            string st = null;
            switch (statut)
            {
                case 1:
                    st = "En cours";
                    tost = String.Format("Contrat : {0}, Client : {1}, Centre : {2}, Date de création : {3}, " +
                        "Date d'écheance : {4}, Statut : {5}", num_contrat, leCentre.leClient.nom_client,
                        leCentre.num_centre, date_creation, date_echeance, st);
                    break;
                case 2:
                    st = "Renouvellé";
                    tost = String.Format("Contrat : {0}, Client : {1}, Centre : {2}, Date de création : {3}, " +
                        "Date d'écheance : {4}, Statut : {5}", num_contrat, leCentre.leClient.nom_client,
                        leCentre.num_centre, date_creation, date_echeance, st);
                    break;
                case 3:
                    st = "Résilié";
                    tost = String.Format("Contrat : {0}, Client : {1}, Centre : {2}, Date de résiliation : {3}, "+ 
                        "Statut : {4}", num_contrat, leCentre.leClient.nom_client, leCentre.num_centre,
                        date_resiliation, st);
                    break;
            }
            return tost;
        }
        #endregion
    }
}
