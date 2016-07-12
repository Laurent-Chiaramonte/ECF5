using MaintInfoBll.Gestionnaires.GestionnaireExceptions;
using MaintInfoBo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaintInfoBll.Gestionnaires
{
    public class ClientGestionnaire
    {
        private ClientManager clMngr;

        public ClientGestionnaire()
        {
            clMngr = new ClientManager();
        }

        public void ajouterClient(Client cl)
        {
            try
            {
                clMngr.ajouterClient(cl);
            }
            catch (Exception)
            {

                throw new BllGestionnaireExceptionAfficheMessage("Ajout impossible"); ;
            }
        }

        public void modifierClient(Client cl)
        {
            try
            {
                clMngr.modifierClient(cl);
            }
            catch (Exception)
            {

                throw new BllGestionnaireExceptionAfficheMessage("Modification impossible"); ;
            }
        }

        public void supprimerClient(Client cl)
        {
            try
            {
                clMngr.supprimerClient(cl);
            }
            catch (Exception)
            {

                throw new BllGestionnaireExceptionAfficheMessage("Suppression impossible"); ;
            }
        }

        public IEnumerable<Client> afficherTousLesClients()
        {
            try
            {
                return clMngr.afficherTousLesClients();
            }
            catch (Exception)
            {

                throw new BllGestionnaireExceptionAfficheMessage("Affichage impossible"); ;
            }
        }

        public Client afficherClientParID(int id)
        {
            try
            {
                return clMngr.afficherClientParID(id);
            }
            catch (Exception)
            {

                throw new BllGestionnaireExceptionAfficheMessage("Affichage impossible"); ;
            }
        }

        public bool clientExiste(string nom)
        {
            return clMngr.clientExiste(nom);
        }
    }
}
