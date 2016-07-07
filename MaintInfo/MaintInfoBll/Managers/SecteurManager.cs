using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MaintInfoBll.Exceptions;
using MaintInfoBo;
using MaintInfoDal.Repository;

namespace MaintInfoBll
{
    public class SecteurManager
    {
        private IRepository<Secteur> _secteurRepository;

        public SecteurManager()
        {
            this._secteurRepository = new Repository<Secteur>();
        }

        public bool ajouterSecteur(Secteur sct)
        {
            try
            {
                _secteurRepository.Insert(sct);
                _secteurRepository.Save();
                return true;
            }
            catch (Exception)
            {
                throw new BllExceptionAfficheMessage("Ajout impossible");
            }
        }

        public bool modifierSecteur(Secteur sct)
        {
            try
            {
                _secteurRepository.Update(sct);
                _secteurRepository.Save();
                return true;
            }
            catch (Exception)
            {
                throw new BllExceptionAfficheMessage("Modification impossible");
            }
        }

        public bool supprimerSecteur(Secteur sct)
        {
            try
            {
                _secteurRepository.Delete(sct);
                _secteurRepository.Save();
                return true;
            }
            catch (Exception)
            {
                throw new BllExceptionAfficheMessage("Suppression impossible");
            }
        }

        public IEnumerable<Secteur> afficherTousLesSecteurs()
        {
            try
            {
                return _secteurRepository.GetAll();
            }
            catch (Exception)
            {
                throw new BllExceptionAfficheMessage("Affichage impossible");
            }
        }

        public Secteur afficherSecteurParID(int id)
        {
            try
            {
                return _secteurRepository.GetSingleById(id);
            }
            catch (Exception)
            {
                throw new BllExceptionAfficheMessage("Affichage impossible");
            }
        }

    }
}
