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
    public class TarifManager
    {
        private IRepository<Tarif> _tarifDao;

        public TarifManager() { }
        public TarifManager(IRepository<Tarif> repos)
        {
            this._tarifDao = repos;
        }

        public void ajouterTarif(Tarif tf)
        {
            try
            {
                _tarifDao.Insert(tf);  
            }
            catch (Exception)
            {
                throw new BllManagerExceptionAfficheMessage("Ajout impossible");
            }
        }

        public void modifierTarif(Tarif tf)
        {
            try
            {
                _tarifDao.Update(tf);  
            }
            catch (Exception)
            {

                throw new BllManagerExceptionAfficheMessage("Modification impossible");
            }
        }

        public void supprimerTarif(Tarif tf)
        {
            try
            {
                _tarifDao.Delete(tf); 
            }
            catch (Exception)
            {

                throw new BllManagerExceptionAfficheMessage("Suppression impossible");
            }
        }

        public IEnumerable<Tarif> afficherTousLesTarifs()
        {
            try
            {
                return _tarifDao.GetAll();
            }
            catch (Exception)
            {

                throw new BllManagerExceptionAfficheMessage("Affichage impossible");
            }
        }

        public Tarif afficherTarifParID(int id)
        {
            try
            {
                return _tarifDao.GetSingleById(id);
            }
            catch (Exception)
            {

                throw new BllManagerExceptionAfficheMessage("Affichage impossible");
            }
        }
    }
}
