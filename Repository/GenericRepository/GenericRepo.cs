using DataAccessObject;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.GenericRepository
{
    public class GenericRepo<T> : IGenericRepo<T> where T : class
    {
        protected readonly CapstoneRigistrationContext _context;
        protected readonly DbSet<T> _dbSet;

        public GenericRepo(CapstoneRigistrationContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }


        public bool Add(T entity)
        {
            _dbSet.Add(entity);
            int success = _context.SaveChanges();
            return success == 1;
        }

        public IEnumerable<T> GetAll()
        {
            return _dbSet.AsNoTracking().ToList();
        }

        public T? GetById(int? id)
        {

            return _dbSet.Find(id);
        }

        public bool Remove(T entity)
        {
            _dbSet.Remove(entity);
            int success = _context.SaveChanges();
            return success == 1;
        }

        public bool Update(T entity)
        {
            _dbSet.Update(entity);
            int success = _context.SaveChanges();
            return success == 1;


        }


    }
}
