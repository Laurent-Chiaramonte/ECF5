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
        private IRepository<Equipement> _equipementRepository;

        public EquipementManager()
        {
            this._equipementRepository = new Repository<Equipement>();
        }

        public void ajouterEquipement(Equipement eqt)
        {
            try
            {
                _equipementRepository.Insert(eqt);
                _equipementRepository.Save();
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
                _equipementRepository.Update(eqt);
                _equipementRepository.Save();
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
                _equipementRepository.Delete(eqt);
                _equipementRepository.Save();
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
                return _equipementRepository.GetAll();
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
                return _equipementRepository.GetSingleById(id);
            }
            catch (Exception)
            {
                throw new BllManagerExceptionAfficheMessage("Affichage impossible");
            }
        }

        public bool equipementExiste(string nserie)
        {
            return _equipementRepository.GetAll().Any(equip => 
                string.Compare(equip.num_serie, nserie, StringComparison.CurrentCultureIgnoreCase) == 0);
        }
    }
}
