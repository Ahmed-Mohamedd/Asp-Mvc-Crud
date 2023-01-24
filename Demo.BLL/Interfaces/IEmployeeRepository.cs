
using Demo.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public interface IEmployeeRepository : IGenericRepository<Employee>
    {
        //Employee get(int? id);

        //IEnumerable<Employee> get_all();

        //int Delete(Employee Employee);
        //int Update(Employee Employee);

        //int Add(Employee Employee);

        //Task<IEnumerable<Employee>> SearchEmp(string value);

    }
}
