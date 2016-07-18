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
    public class CentreInformatiqueManager
    {
        private IRepository<CentreInformatique> _centreInformatiqueDao;

        public CentreInformatiqueManager() { }
        public CentreInformatiqueManager(IRepository<CentreInformatique> repos)
        {
            _centreInformatiqueDao = repos;
        }

        public void ajouterCentreInformatique(CentreInformatique cti)
        {
            try
            {
                _centreInformatiqueDao.Insert(cti); 
            }
            catch (Exception)
            {
                throw new BllManagerExceptionAfficheMessage("Ajout impossible");
            }
        }

        public void modifierCentreInformatique(CentreInformatique cti)
        {
            try
            {
                _centreInformatiqueDao.Update(cti); 
            }
            catch (Exception)
            {
                throw new BllManagerExceptionAfficheMessage("Modification impossible");
            }
        }

        public void supprimerCentreInformatique(CentreInformatique cti)
        {
            try
            {
                _centreInformatiqueDao.Delete(cti); 
            }
            catch (Exception)
            {
                throw new BllManagerExceptionAfficheMessage("Suppression impossible");
            }
        }

        public IEnumerable<CentreInformatique> afficherTousLesCentresInformatique()
        {
            try
            {
                return _centreInformatiqueDao.GetAll();
            }
            catch (Exception)
            {
                throw new BllManagerExceptionAfficheMessage("Affichage impossible");
            }
        }

        public CentreInformatique afficherCentreInformatiqueParID(int id)
        {
            try
            {
                return _centreInformatiqueDao.GetSingleById(id);
            }
            catch (Exception)
            {
                throw new BllManagerExceptionAfficheMessage("Affichage impossible");
            }
        }

        public bool centreInformatiqueExiste(string adresse)
        {
            return _centreInformatiqueDao.GetAll().Any(client => string.Compare(client.adresse_centre, adresse, StringComparison.CurrentCultureIgnoreCase) == 0);
        }
    }
}
