using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NTGS.Models
{
    public class Employee
    {
        public int EmployeeID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }

        public int DepartmentId { get; set; }      
        public Department Department { get; set; }
    }
}