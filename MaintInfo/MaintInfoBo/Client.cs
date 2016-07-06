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
        public int num_client { get; set; }
        public string nom_client { get; set; }
        public string adresse_client { get; set; }
        public int cp_client { get; set; }
        public string ville_client { get; set; }
        public int tel_client { get; set; }
        #endregion

        #region Constructeurs
        public Client() { }
        public Client(int num, string nom, string adresse, int cp, string ville, int tel)
        {
            num_client = num;
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
                    ((Client)obj).num_client.Equals(this.num_client);
            else
                return false;
        }
        public override string ToString()
        {
            return string.Format("Client : {0}, Raison sociale : {1}, Adresse : {2}, Code Postal : {3}, Ville : {4}," +
                "Téléphone : {5}", num_client, nom_client, adresse_client, cp_client, ville_client, tel_client);
        }
        #endregion
    }
}
