using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaintInfoBo
{
    public class Client
    {
        #region Propriétés
        public int idClient { get; set; }
        public string nom_client { get; set; }
        public string adresse_client { get; set; }
        public string cp_client { get; set; }
        public string ville_client { get; set; }
        public string tel_client { get; set; }
        #endregion

        #region Constructeurs
        public Client() { }
        public Client(int num, string nom, string adresse, string cp, string ville, string tel)
        {
            idClient = num;
            nom_client = nom;
            adresse_client = adresse;
            cp_client = cp;
            ville_client = ville;
            tel_client = tel;
        }
        #endregion

        #region Méthodes
        public override bool Equals(object obj)
        {
            if (obj is Client)
                return
                    ((Client)obj).idClient.Equals(this.idClient);
            else
                return false;
        }
        public override string ToString()
        {
            return string.Format("Client : {0}, Raison sociale : {1}, Adresse : {2}, Code Postal : {3}, Ville : {4}," +
                "Téléphone : {5}", idClient, nom_client, adresse_client, cp_client, ville_client, tel_client);
        }
        #endregion
    }
}
