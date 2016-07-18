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
    public class EquipementManager
    {
        private IRepository<Equipement> _equipementDao;

        public EquipementManager() { }

        public EquipementManager(IRepository<Equipement> repos)
        {
            this._equipementDao = repos;
        }

        public void ajouterEquipement(Equipement eqt)
        {
            try
            {
                _equipementDao.Insert(eqt);
            }
            catch (Exception)
            {
                throw new BllManagerExceptionAfficheMessage("Ajout impossible");
            }
        }

        public void modifierEquipement(Equipement eqt)
        {
            try
            {
                _equipementDao.Update(eqt); 
            }
            catch (Exception)
            {
                throw new BllManagerExceptionAfficheMessage("Modification impossible");
            }
        }

        public void supprimerEquipement(Equipement eqt)
        {
            try
            {
                _equipementDao.Delete(eqt); 
            }
            catch (Exception)
            {
                throw new BllManagerExceptionAfficheMessage("Suppression impossible");
            }
        }

        public IEnumerable<Equipement> afficherTousLesEquipements()
        {
            try
            {
                return _equipementDao.GetAll();
            }
            catch (Exception)
            {
                throw new BllManagerExceptionAfficheMessage("Affichage impossible");
            }
        }

        public Equipement afficherEquipementParID(int id)
        {
            try
            {
                return _equipementDao.GetSingleById(id);
            }
            catch (Exception)
            {
                throw new BllManagerExceptionAfficheMessage("Affichage impossible");
            }
        }

        public bool equipementExiste(string nserie)
        {
            return _equipementDao.GetAll().Any(equip => 
                string.Compare(equip.num_serie, nserie, StringComparison.CurrentCultureIgnoreCase) == 0);
        }
    }
}
