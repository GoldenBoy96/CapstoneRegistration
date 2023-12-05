using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.GenericRepository
{
    public interface IGenericRepo<T> where T : class
    {
        T? GetById(int? id);
        IEnumerable<T> GetAll();
        bool Add(T entity);
        bool Update(T entity);
        bool Remove(T entity);
    }
}
