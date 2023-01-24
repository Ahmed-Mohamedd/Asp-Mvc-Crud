using Demo.BLL.Interfaces;
using Demo.DAL.Context;
using Demo.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.BLL.Repositories
{
    public class DepartmentRepository : IDepartmentRepository
    {
        private readonly MvcDbContext _context;

        public DepartmentRepository(MvcDbContext context)
        {
            this._context=context;
        }
        public int Add(Department department)
        {
            _context.Departments.Add(department);
           return _context.SaveChanges();
        }

        public int Delete(Department department)
        {
            _context.Departments.Remove(department);
            return _context.SaveChanges();
        }

        public Department Get(int id)
            =>  _context.Departments.Where(d=> d.Id==id).FirstOrDefault();
   

        public IEnumerable<Department> GetAll()
           => _context.Departments.ToList();
     

        public int Update(Department department)
        {
            _context.Departments.Update(department);
            return _context.SaveChanges();
        }
    }
}
