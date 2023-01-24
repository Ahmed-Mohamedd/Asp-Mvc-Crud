using BLL.Interfaces;
using Demo.DAL.Context;
using Demo.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Repositories
{
    public class GenericRepository<T>:IGenericRepository<T> where T : class
    {
        private readonly MvcDbContext _context;

        public GenericRepository(MvcDbContext context)
        {
            this._context=context;
        }


        public T get(int? id)
          =>  _context.Set<T>().Find(id);

        public IEnumerable<T> get_all()
        {
            //if(typeof(T) == typeof(Employee))
            //{
            //    return  (IEnumerable<T>)  _context.Set<Employee>().Include(E => E.Department).ToListAsync();
            //}
            return  _context.Set<T>().ToList();
        }
        

        public int Delete(T Item)
        {
            _context.Set<T>().Remove(Item);
            return _context.SaveChanges();
        }

        public int Update(T Item)
        {
            _context.Set<T>().Update(Item);
            return _context.SaveChanges();
        }

        public int Add(T Item)
        {
            _context.Set<T>().Add(Item);
            return  _context.SaveChanges();
        }
    }
}
