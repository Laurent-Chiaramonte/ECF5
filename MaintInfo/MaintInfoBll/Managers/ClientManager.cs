using MaintInfoBll.Exceptions;
using MaintInfoBo;
using MaintInfoDal.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaintInfoBll
{
    public class ClientManager
    {
        private IRepository<Client> _clientDao;

        public ClientManager() { }

        public ClientManager(IRepository<Client> repos)
        {
            this._clientDao = repos;
        }

        public void ajouterClient(Client cli)
        {
            try
            {
                _clientDao.Insert(cli);
            }
            catch (Exception)
            {
                throw new BllManagerExceptionAfficheMessage("Ajout impossible");
            }
        }

        public void modifierClient(Client cli)
        {
            try
            {
                _clientDao.Update(cli);
            }
            catch (Exception)
            {
                throw new BllManagerExceptionAfficheMessage("Modification impossible");
            }
        }

        public void supprimerClient(Client cli)
        {
            try
            {
                _clientDao.Delete(cli);
            }
            catch (Exception)
            {
                throw new BllManagerExceptionAfficheMessage("Suppression impossible");
            }
        }

        public IEnumerable<Client> afficherTousLesClients()
        {
            try
            {
                return _clientDao.GetAll();
            }
            catch (Exception)
            {
                throw new BllManagerExceptionAfficheMessage("Affichage impossible");
            }
        }

        public Client afficherClientParID(int id)
        {
            try
            {
                return _clientDao.GetSingleById(id);
            }
            catch (Exception)
            {
                throw new BllManagerExceptionAfficheMessage("Affichage impossible");
            }
        }

        public bool clientExiste(string nom)
        {
            return _clientDao.GetAll().Any(client => string.Compare(client.nom_client, nom, StringComparison.CurrentCultureIgnoreCase) == 0);
        }
    }
}
