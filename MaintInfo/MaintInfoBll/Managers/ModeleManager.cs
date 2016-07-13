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
        private IRepository<Modele> _modeleRepository;

        public ModeleManager()
        {
            this._modeleRepository = new Repository<Modele>();
        }

        public void ajouterModele(Modele mod)
        {
            try
            {
                _modeleRepository.Insert(mod);
                _modeleRepository.Save(); 
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
                _modeleRepository.Update(mod);
                _modeleRepository.Save(); 
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
                _modeleRepository.Delete(mod);
                _modeleRepository.Save(); 
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
                return _modeleRepository.GetAll();
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
                return _modeleRepository.GetSingleById(id);
            }
            catch (Exception)
            {
                throw new BllManagerExceptionAfficheMessage("Affichage impossible");
            }
        }

        public bool modeleExiste(string des)
        {
            return _modeleRepository.GetAll().Any(modele => string.Compare(modele.designation_modele, des,
                StringComparison.CurrentCultureIgnoreCase) == 0);
        }
    }
}
