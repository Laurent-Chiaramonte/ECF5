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
        private IRepository<CentreInformatique> _centreInformatiqueRepository;

        public CentreInformatiqueManager()
        {
            this._centreInformatiqueRepository = new Repository<CentreInformatique>();
        }

        public void ajouterCentreInformatique(CentreInformatique cti)
        {
            try
            {
                _centreInformatiqueRepository.Insert(cti);
                _centreInformatiqueRepository.Save();
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
                _centreInformatiqueRepository.Update(cti);
                _centreInformatiqueRepository.Save();
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
                _centreInformatiqueRepository.Delete(cti);
                _centreInformatiqueRepository.Save();
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
                return _centreInformatiqueRepository.GetAll();
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
                return _centreInformatiqueRepository.GetSingleById(id);
            }
            catch (Exception)
            {
                throw new BllManagerExceptionAfficheMessage("Affichage impossible");
            }
        }
    }
}
