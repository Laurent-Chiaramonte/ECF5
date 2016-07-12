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
    public class ContratManager
    {
        private IRepository<Contrat> _contratRepository;

        public ContratManager()
        {
            this._contratRepository = new Repository<Contrat>();
        }

        public void ajouterContrat(Contrat ct)
        {
            try
            {
                _contratRepository.Insert(ct);
                _contratRepository.Save();
            }
            catch (Exception)
            {

                throw new BllManagerExceptionAfficheMessage("Ajout impossible");
            }
        }

        public void modifierContrat(Contrat ct)
        {
            try
            {
                _contratRepository.Update(ct);
                _contratRepository.Save();
            }
            catch (Exception)
            {

                throw new BllManagerExceptionAfficheMessage("Modification impossible");
            }
        }

        public void supprimerContrat(Contrat ct)
        {
            try
            {
                _contratRepository.Delete(ct);
                _contratRepository.Save();
            }
            catch (Exception)
            {

                throw new BllManagerExceptionAfficheMessage("Suppression impossible");
            }
        }

        public IEnumerable<Contrat> afficherTousLesContrats()
        {
            try
            {
                return _contratRepository.GetAll();
            }
            catch (Exception)
            {

                throw new BllManagerExceptionAfficheMessage("Affichage impossible");
            }
        }

        public Contrat afficherContratParID(int id)
        {
            try
            {
                return _contratRepository.GetSingleById(id);
            }
            catch (Exception)
            {

                throw new BllManagerExceptionAfficheMessage("Affichage impossible");
            }
        }
    }
}
