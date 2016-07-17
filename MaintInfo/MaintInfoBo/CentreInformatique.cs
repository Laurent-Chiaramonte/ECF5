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
        public int centreInformatiqueID { get; set; }
        public string adresse_centre { get; set; }
        public string cp_centre { get; set; }
        public string ville_centre { get; set; }
        public string tel_centre { get; set; }
        public Client leClient { get; set; }
        public int clientID { get; set; }
        public Secteur leSecteur { get; set; }
        public int secteurID { get; set; }
        #endregion

        #region Constructeurs
        public CentreInformatique() { }
        public CentreInformatique(int num, string adresse, string cp, string ville, string tel, int cli, int sec)
        {
            centreInformatiqueID = num;
            adresse_centre = adresse;
            cp_centre = cp;
            ville_centre = ville;
            tel_centre = tel;
            clientID = cli;
            secteurID = sec;
        }
        #endregion

        #region Méthodes
        public override bool Equals(object obj)
        {
            if (obj is CentreInformatique)
                return
                    ((CentreInformatique)obj).centreInformatiqueID.Equals(this.centreInformatiqueID);
            else
                return false;
        }
        public override string ToString()
        {
            return string.Format("Centre : {0}, Client : {1}, Adresse : {2}, Code Postal : {3}, Ville : {4},"+
                "Téléphone : {5}", centreInformatiqueID, leClient.nom_client, adresse_centre, cp_centre,
                ville_centre, tel_centre);
        }
        #endregion
    }
}
