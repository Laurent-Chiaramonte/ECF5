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
        private IRepository<Client> _clientRepository;

        public ClientManager()
        {
            this._clientRepository = new Repository<Client>();
        }

        public void ajouterClient(Client cli)
        {
            try
            {
                _clientRepository.Insert(cli);
                _clientRepository.Save();
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
                _clientRepository.Update(cli);
                _clientRepository.Save();
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
                _clientRepository.Delete(cli);
                _clientRepository.Save();
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
                return _clientRepository.GetAll();
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
                return _clientRepository.GetSingleById(id);
            }
            catch (Exception)
            {
                throw new BllManagerExceptionAfficheMessage("Affichage impossible");
            }
        }
    }
}
