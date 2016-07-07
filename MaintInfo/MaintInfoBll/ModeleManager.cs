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

        public bool ajouterModele(Modele mod)
        {
            try
            {
                _modeleRepository.Insert(mod);
                _modeleRepository.Save();
                return true;
            }
            catch (Exception)
            {
                throw new BllExceptionAfficheMessage("Ajout impossible");
            }
        }

        public bool modifierModele(Modele mod)
        {
            try
            {
                _modeleRepository.Update(mod);
                _modeleRepository.Save();
                return true;
            }
            catch (Exception)
            {
                throw new BllExceptionAfficheMessage("Modification impossible");
            }
        }

        public bool supprimerModele(Modele mod)
        {
            try
            {
                _modeleRepository.Delete(mod);
                _modeleRepository.Save();
                return true;
            }
            catch (Exception)
            {
                throw new BllExceptionAfficheMessage("Suppression impossible");
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
                throw new BllExceptionAfficheMessage("Affichage impossible");
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
                throw new BllExceptionAfficheMessage("Affichage impossible");
            }
        }
    }
}
