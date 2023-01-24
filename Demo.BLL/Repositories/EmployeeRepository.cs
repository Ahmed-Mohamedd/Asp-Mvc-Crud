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
    public class EmployeeRepository :  GenericRepository<Employee> ,IEmployeeRepository
    {
        public MvcDbContext _context { get; }
        public EmployeeRepository(MvcDbContext context):base(context)
        {
            _context=context;
        }

       

        //public async Task<IEnumerable<Employee>> SearchEmp(string value)
        //{
        //  return await Context.Employees.Where(e=>e.Name.Contains(value)).ToListAsync();
        //}
    }
}
