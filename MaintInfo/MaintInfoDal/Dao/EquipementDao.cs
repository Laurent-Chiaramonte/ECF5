using MaintInfoBo;
using MaintInfoBo.Exceptions.EquipementExceptions;
using MaintInfoDal.Exceptions;
using MaintInfoDal.Repository;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaintInfoDal.Dao
{
    public class EquipementDao : IRepository<Equipement>
    {
        public void Delete(Equipement obj)
        {
            using (MaintInfoContext db = new MaintInfoContext())
            {
                try
                {
                    db.Entry(obj).State = EntityState.Deleted;
                    db.Entry(obj.leContrat).State = EntityState.Unchanged;
                    db.Entry(obj.leModele).State = EntityState.Unchanged;

                    int n = db.SaveChanges();
                }
                catch (Exception ex)
                {
                    if (ex.HResult == -2146233087)
                        throw new EquipementException("Suppression impossible");
                    throw new DaoException(ex.Message);
                }
            }
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Equipement> GetAll()
        {
            using (MaintInfoContext db = new MaintInfoContext())
            {
                try
                {
                    var query = db.Equipements.ToList();
                    foreach (var p in query)
                    {
                        db.Entry(p).Reference(q => q.leContrat).Load();
                        db.Entry(p).Reference(q => q.leModele).Load();
                    }
                    return query;
                }
                catch (Exception ex)
                {
                    throw new DaoExceptionAfficheMessage(ex.Message);
                }
            }
        }

        public Equipement GetSingleById(int Id)
        {
            using (MaintInfoContext db = new MaintInfoContext())
            {
                try
                {
                    var obj = db.Equipements.Find(Id);
                    if (obj == null)
                        throw new NotExistEquipementException("Equipement inexistant");
                    db.Entry(obj).Reference(q => q.leContrat).Load();
                    db.Entry(obj).Reference(q => q.leModele).Load();
                    return obj;
                }
                catch (Exception ex)
                {
                    throw new DaoException(ex.Message);
                }
            }
        }

        public void Insert(Equipement obj)
        {
            using (MaintInfoContext db = new MaintInfoContext())
            {
                try
                {
                    db.Entry(obj).State = EntityState.Added;
                    // 
                    db.Entry(obj.leContrat).State = EntityState.Unchanged;
                    db.Entry(obj.leModele).State = EntityState.Unchanged;

                    int n = db.SaveChanges();
                }
                catch (Exception ex)
                {
                    if (ex.HResult == -2146233087)
                        throw new EquipementException(ex.Message);
                    throw new DaoException(ex.Message);
                }
            }
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public void Update(Equipement obj)
        {
            using (MaintInfoContext db = new MaintInfoContext())
            {
                try
                {
                    db.Entry(obj).State = EntityState.Modified;
                    db.Entry(obj.leContrat).State = EntityState.Unchanged;
                    db.Entry(obj.leModele).State = EntityState.Unchanged;

                    int n = db.SaveChanges();
                }
                catch (Exception ex)
                {
                    throw new DaoException(ex.Message);
                }
            }
        }
    }
}
