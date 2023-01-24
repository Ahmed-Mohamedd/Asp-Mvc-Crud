using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.DAL.Entities
{
    public class Employee
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Name is required !")]
        [MaxLength(50, ErrorMessage = "Maximum length of name is 50 chars")]
        [MinLength(5, ErrorMessage = "Minumum length of name is 5 chars")]
        public string Name { get; set; }
        [Range(18, 60, ErrorMessage = "Age should be in range 18 and 60")]
        public int? Age { get; set; }

        [RegularExpression(@"^[0-9]{1,10}-[a-zA-Z]{1,40}-[a-zA-Z]{1,40}-[a-zA-Z]{1,40}$",
           ErrorMessage = "Address must be like '123-Street-Region-City' ")]
        public string Address { get; set; }
        [DataType(DataType.Currency)]
        [Range(4000,10000)]
        public decimal Salary { get; set; }

        public bool IsActive { get; set; }
        [EmailAddress]
        //[DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }

        public DateTime HireDate { get; set; }

        public DateTime CreationDate { get; set; } = DateTime.Now;

        [Display(Name ="Department")]
        public int? DepartmentId { get; set; }
        public virtual Department Department { get; set; } // navigational property

        //public string ImageName { get; set; }
    }
}
