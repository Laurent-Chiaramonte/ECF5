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
    public class ModeleManager
    {
        private IRepository<Modele> _modeleDao;

        public ModeleManager() { }
        public ModeleManager(IRepository<Modele> repos)
        {
            this._modeleDao = repos;
        }

        public void ajouterModele(Modele mod)
        {
            try
            {
                _modeleDao.Insert(mod);  
            }
            catch (Exception)
            {
                throw new BllManagerExceptionAfficheMessage("Ajout impossible");
            }
        }

        public void modifierModele(Modele mod)
        {
            try
            {
                _modeleDao.Update(mod);  
            }
            catch (Exception)
            {
                throw new BllManagerExceptionAfficheMessage("Modification impossible");
            }
        }

        public void supprimerModele(Modele mod)
        {
            try
            {
                _modeleDao.Delete(mod); 
            }
            catch (Exception)
            {
                throw new BllManagerExceptionAfficheMessage("Suppression impossible");
            }
        }

        public IEnumerable<Modele> afficherTousLesModeles()
        {
            try
            {
                return _modeleDao.GetAll();
            }
            catch (Exception)
            {
                throw new BllManagerExceptionAfficheMessage("Affichage impossible");
            }
        }

        public Modele afficherModeleParID(int id)
        {
            try
            {
                return _modeleDao.GetSingleById(id);
            }
            catch (Exception)
            {
                throw new BllManagerExceptionAfficheMessage("Affichage impossible");
            }
        }

        public bool modeleExiste(string des)
        {
            return _modeleDao.GetAll().Any(modele => string.Compare(modele.designation_modele, des,
                StringComparison.CurrentCultureIgnoreCase) == 0);
        }
    }
}
