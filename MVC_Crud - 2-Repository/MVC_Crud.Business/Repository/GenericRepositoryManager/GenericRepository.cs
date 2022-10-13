using MVC_Crud.Business.Repository.GenericRepositoryInterface;
using MVC_Crud.Models.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Crud.Business.Repository.GenericRepositoryManager
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        //CrudDbContext Context;
        //DbSet<T> dbSet;
        //public GenericRepository()
        //{
        //    Context = new CrudDbContext();
        //    this.dbSet = Context.Set<T>();
        //}
        public void Add(T entity)
        {
            using (CrudDbContext db = new CrudDbContext())
            {
                db.Set<T>().Add(entity);
                db.SaveChanges();
            }
        }

        
        public void Delete(int id)
        {
            using (CrudDbContext db = new CrudDbContext())
            {
                var t = db.Set<T>().Find(id);
                db.Set<T>().Remove(t);
                db.SaveChanges();
            }
        }

        public List<T> Get_List()
        {
            using (CrudDbContext db = new CrudDbContext())
            {
                return db.Set<T>().ToList();
            }
        }

        public T List_By_Id(int id)
        {
            using (CrudDbContext db = new CrudDbContext())
            {
                return db.Set<T>().Find(id);
            }
        }

        //public void Save(T t)
        //{
        //    throw new NotImplementedException();
        //}

        public void Update(T entity)
        {
            using (CrudDbContext db = new CrudDbContext())
            {
                db.Set<T>().Attach(entity);
                db.Entry(entity).State = EntityState.Modified;
                db.SaveChanges();
            }
        }
    }
}
