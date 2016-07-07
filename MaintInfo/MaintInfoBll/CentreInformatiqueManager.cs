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

        public bool ajouterCentreInformatique(CentreInformatique cti)
        {
            try
            {
                _centreInformatiqueRepository.Insert(cti);
                _centreInformatiqueRepository.Save();
                return true;
            }
            catch (Exception)
            {
                throw new BllExceptionAfficheMessage("Ajout impossible");
            }
        }

        public bool modifierCentreInformatique(CentreInformatique cti)
        {
            try
            {
                _centreInformatiqueRepository.Update(cti);
                _centreInformatiqueRepository.Save();
                return true;
            }
            catch (Exception)
            {
                throw new BllExceptionAfficheMessage("Modification impossible");
            }
        }

        public bool supprimerCentreInformatique(CentreInformatique cti)
        {
            try
            {
                _centreInformatiqueRepository.Delete(cti);
                _centreInformatiqueRepository.Save();
                return true;
            }
            catch (Exception)
            {
                throw new BllExceptionAfficheMessage("Suppression impossible");
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
                throw new BllExceptionAfficheMessage("Affichage impossible");
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
                throw new BllExceptionAfficheMessage("Affichage impossible");
            }
        }
    }
}
