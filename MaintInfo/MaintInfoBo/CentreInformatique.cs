using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaintInfoBo
{
    public class CentreInformatique
    {
        #region Propriétés
        public int centreID { get; set; }
        public string adresse_centre { get; set; }
        public string cp_centre { get; set; }
        public string ville_centre { get; set; }
        public string tel_centre { get; set; }
        public Client leClient { get; set; }
        public int idClient { get; set; }
        public Secteur leSecteur { get; set; }
        public int idSecteur { get; set; }
        #endregion

        #region Constructeurs
        public CentreInformatique() { }
        public CentreInformatique(int num, string adresse, string cp, string ville, string tel, Client cli)
        {
            centreID = num;
            adresse_centre = adresse;
            cp_centre = cp;
            ville_centre = ville;
            tel_centre = tel;
            leClient = cli;
        }
        #endregion

        #region Méthodes
        public override bool Equals(object obj)
        {
            if (obj is CentreInformatique)
                return
                    ((CentreInformatique)obj).centreID.Equals(this.centreID);
            else
                return false;
        }
        public override string ToString()
        {
            return string.Format("Centre : {0}, Client : {1}, Adresse : {2}, Code Postal : {3}, Ville : {4},"+
                "Téléphone : {5}", centreID, leClient.nom_client, adresse_centre, cp_centre, ville_centre, tel_centre);
        }
        #endregion
    }
}
