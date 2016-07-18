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
        private IRepository<Contrat> _contratDao;

        public ContratManager() { }
        public ContratManager(IRepository<Contrat> repos)
        {
            this._contratDao = repos;
        }

        public void ajouterContrat(Contrat ct)
        {
            try
            {
                _contratDao.Insert(ct); 
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
                _contratDao.Update(ct); 
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
                _contratDao.Delete(ct); 
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
                return _contratDao.GetAll();
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
                return _contratDao.GetSingleById(id);
            }
            catch (Exception)
            {

                throw new BllManagerExceptionAfficheMessage("Affichage impossible");
            }
        }

        public bool contratExiste(int idCenInfo)
        {
            return _contratDao.GetAll().Any(contrat =>
                string.Compare(contrat.centreInformatiqueID.ToString(), idCenInfo.ToString(),
                StringComparison.CurrentCultureIgnoreCase) == 0);
        }
    }
}
