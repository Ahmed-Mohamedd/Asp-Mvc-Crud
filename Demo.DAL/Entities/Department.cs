using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.DAL.Entities
{
    public class Department
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Code is required")]
        public string Code { get; set; }

        [Required(ErrorMessage = "Code is required")]
        [MaxLength(50,ErrorMessage ="Max Length for name is 50 char")]
        public string Name { get; set; }
        public DateTime DateOfCreation { get; set; }
        public virtual ICollection<Employee> Employees { get; set; } = new HashSet<Employee>();

    }
}
