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

        public void ajouterSecteur(Secteur sct)
        {
            try
            {
                _secteurRepository.Insert(sct);
                _secteurRepository.Save(); 
            }
            catch (Exception)
            {
                throw new BllManagerExceptionAfficheMessage("Ajout impossible");
            }
        }

        public void modifierSecteur(Secteur sct)
        {
            try
            {
                _secteurRepository.Update(sct);
                _secteurRepository.Save(); 
            }
            catch (Exception)
            {
                throw new BllManagerExceptionAfficheMessage("Modification impossible");
            }
        }

        public void supprimerSecteur(Secteur sct)
        {
            try
            {
                _secteurRepository.Delete(sct);
                _secteurRepository.Save(); 
            }
            catch (Exception)
            {
                throw new BllManagerExceptionAfficheMessage("Suppression impossible");
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
                throw new BllManagerExceptionAfficheMessage("Affichage impossible");
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
                throw new BllManagerExceptionAfficheMessage("Affichage impossible");
            }
        }

        public bool secteurExiste(string lib)
        {
            return _secteurRepository.GetAll().Any(secteur => string.Compare(secteur.libelleSecteur, lib,
                StringComparison.CurrentCultureIgnoreCase) == 0);
        }

    }
}
