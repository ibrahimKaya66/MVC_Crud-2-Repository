using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Crud.Business.Repository.GenericRepositoryInterface
{
    public interface IGenericRepository<T> where T:class //T Entitiesteki sınıfları ifade eder
    {
        List<T> Get_List();
        T List_By_Id(int id);
        void Add(T entity);
        void Update(T entity);
       // void Save(T t);
        void Delete(int id);
    }
}
