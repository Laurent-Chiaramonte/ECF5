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
        private IRepository<Secteur> _secteurDao;

        public SecteurManager() { }
        public SecteurManager(IRepository<Secteur> repos)
        {
            this._secteurDao = repos;
        }

        public void ajouterSecteur(Secteur sct)
        {
            try
            {
                _secteurDao.Insert(sct); 
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
                _secteurDao.Update(sct); 
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
                _secteurDao.Delete(sct); 
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
                return _secteurDao.GetAll();
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
                return _secteurDao.GetSingleById(id);
            }
            catch (Exception)
            {
                throw new BllManagerExceptionAfficheMessage("Affichage impossible");
            }
        }

        public bool secteurExiste(string lib)
        {
            return _secteurDao.GetAll().Any(secteur => string.Compare(secteur.libelleSecteur, lib,
                StringComparison.CurrentCultureIgnoreCase) == 0);
        }

    }
}
