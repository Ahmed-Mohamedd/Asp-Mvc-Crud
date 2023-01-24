using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public interface IGenericRepository<T>
    {
        T get(int? id);

        IEnumerable<T> get_all();

        int Delete(T T);
        int Update(T T);

        int Add(T T);
    }
}
