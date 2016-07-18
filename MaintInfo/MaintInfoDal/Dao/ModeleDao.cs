using MaintInfoBo;
using MaintInfoBo.Exceptions.ModeleExceptions;
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
    public class ModeleDao : IRepository<Modele>
    {
        public void Delete(Modele obj)
        {
            using (MaintInfoContext db = new MaintInfoContext())
            {
                try
                {
                    db.Entry(obj).State = EntityState.Deleted;
                    db.Entry(obj.leTarif).State = EntityState.Unchanged;
                    db.Entry(obj.leType).State = EntityState.Unchanged;

                    int n = db.SaveChanges();
                }
                catch (Exception ex)
                {
                    if (ex.HResult == -2146233087)
                        throw new ModeleException("Suppression impossible");
                    throw new DaoException(ex.Message);
                }
            }
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Modele> GetAll()
        {
            using (MaintInfoContext db = new MaintInfoContext())
            {
                try
                {
                    var query = db.Modeles.ToList();
                    foreach (var p in query)
                    {
                        db.Entry(p).Reference(q => q.leTarif).Load();
                        db.Entry(p).Reference(q => q.leType).Load();
                    }
                    return query;
                }
                catch (Exception ex)
                {
                    throw new DaoExceptionAfficheMessage(ex.Message);
                }
            }
        }

        public Modele GetSingleById(int Id)
        {
            using (MaintInfoContext db = new MaintInfoContext())
            {
                try
                {
                    var obj = db.Modeles.Find(Id);
                    if (obj == null)
                        throw new NotExistModeleException("Modèle inexistant");
                    db.Entry(obj).Reference(q => q.leType).Load();
                    db.Entry(obj).Reference(q => q.leTarif).Load();
                    return obj;
                }
                catch (Exception ex)
                {
                    throw new DaoException(ex.Message);
                }
            }
        }

        public void Insert(Modele obj)
        {
            using (MaintInfoContext db = new MaintInfoContext())
            {
                try
                {
                    db.Entry(obj).State = EntityState.Added;
                    // 
                    db.Entry(obj.leTarif).State = EntityState.Unchanged;
                    db.Entry(obj.leType).State = EntityState.Unchanged;

                    int n = db.SaveChanges();
                }
                catch (Exception ex)
                {
                    if (ex.HResult == -2146233087)
                        throw new ModeleException(ex.Message);
                    throw new DaoException(ex.Message);
                }
            }
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public void Update(Modele obj)
        {
            using (MaintInfoContext db = new MaintInfoContext())
            {
                try
                {
                    db.Entry(obj).State = EntityState.Modified;
                    db.Entry(obj.leType).State = EntityState.Unchanged;
                    db.Entry(obj.leTarif).State = EntityState.Unchanged;

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
