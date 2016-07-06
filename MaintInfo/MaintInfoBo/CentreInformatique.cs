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
        public int num_centre { get; set; }
        public string adresse_centre { get; set; }
        public int cp_centre { get; set; }
        public string ville_centre { get; set; }
        public int tel_centre { get; set; }
        public Client leClient { get; set; }
        #endregion

        #region Constructeurs
        public CentreInformatique() { }
        public CentreInformatique(int num, string adresse, int cp, string ville, int tel, Client cli)
        {
            num_centre = num;
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
                    ((CentreInformatique)obj).num_centre.Equals(this.num_centre);
            else
                return false;
        }
        public override string ToString()
        {
            return string.Format("Centre : {0}, Client : {1}, Adresse : {2}, Code Postal : {3}, Ville : {4},"+
                "Téléphone : {5}", num_centre, leClient.nom_client, adresse_centre, cp_centre, ville_centre, tel_centre);
        }
        #endregion
    }
}
