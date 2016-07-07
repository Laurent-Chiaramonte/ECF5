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

        public bool ajouterEquipement(Equipement eqt)
        {
            try
            {
                _equipementRepository.Insert(eqt);
                _equipementRepository.Save();
                return true;
            }
            catch (Exception)
            {
                throw new BllExceptionAfficheMessage("Ajout impossible");
            }
        }

        public bool modifierEquipement(Equipement eqt)
        {
            try
            {
                _equipementRepository.Update(eqt);
                _equipementRepository.Save();
                return true;
            }
            catch (Exception)
            {
                throw new BllExceptionAfficheMessage("Modification impossible");
            }
        }

        public bool supprimerEquipement(Equipement eqt)
        {
            try
            {
                _equipementRepository.Delete(eqt);
                _equipementRepository.Save();
                return true;
            }
            catch (Exception)
            {
                throw new BllExceptionAfficheMessage("Suppression impossible");
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
                throw new BllExceptionAfficheMessage("Affichage impossible");
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
                throw new BllExceptionAfficheMessage("Affichage impossible");
            }
        }
    }
}
