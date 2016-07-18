using MaintInfoBo;
using MaintInfoBo.Exceptions.CentreInformatiqueExceptions;
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
    public class CentreInformatiqueDao : IRepository<CentreInformatique>
    {
        public void Delete(CentreInformatique obj)
        {
            using (MaintInfoContext db = new MaintInfoContext())
            {
                try
                {
                    db.Entry(obj).State = EntityState.Deleted;
                    db.Entry(obj.leClient).State = EntityState.Unchanged;
                    db.Entry(obj.leSecteur).State = EntityState.Unchanged;

                    int n = db.SaveChanges();
                }
                catch (Exception ex)
                {
                    if (ex.HResult == -2146233087)
                        throw new CentreInformatiqueException("Suppression impossible");
                    throw new DaoException(ex.Message);
                }
            }
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<CentreInformatique> GetAll()
        {
            using (MaintInfoContext db = new MaintInfoContext())
            {
                try
                {
                    var query = db.CentresInformatique.ToList();
                    foreach (var p in query)
                    {
                        db.Entry(p).Reference(q => q.leClient).Load();
                        db.Entry(p).Reference(q => q.leSecteur).Load();
                    }
                    return query;
                }
                catch (Exception ex)
                {
                    throw new DaoExceptionAfficheMessage(ex.Message);
                }
            }
        }

        public CentreInformatique GetSingleById(int Id)
        {
            using (MaintInfoContext db = new MaintInfoContext())
            {
                try
                {
                    var obj = db.CentresInformatique.Find(Id);
                    if (obj == null)
                        throw new NotExistCentreInformatiqueException("Centre Informatique inexistant");
                    db.Entry(obj).Reference(q => q.leClient).Load();
                    db.Entry(obj).Reference(q => q.leSecteur).Load();
                    return obj;
                }
                catch (Exception ex)
                {
                    throw new DaoException(ex.Message);
                }
            }
        }

        public void Insert(CentreInformatique obj)
        {
            using (MaintInfoContext db = new MaintInfoContext())
            {
                try
                {
                    db.Entry(obj).State = EntityState.Added;
                    // 
                    db.Entry(obj.leClient).State = EntityState.Unchanged;
                    db.Entry(obj.leSecteur).State = EntityState.Unchanged;

                    int n = db.SaveChanges();
                }
                catch (Exception ex)
                {
                    if (ex.HResult == -2146233087)
                        throw new CentreInformatiqueException(ex.Message);
                    throw new DaoException(ex.Message);
                }
            }
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public void Update(CentreInformatique obj)
        {
            using (MaintInfoContext db = new MaintInfoContext())
            {
                try
                {
                    db.Entry(obj).State = EntityState.Modified;
                    db.Entry(obj.leClient).State = EntityState.Unchanged;
                    db.Entry(obj.leSecteur).State = EntityState.Unchanged;

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
