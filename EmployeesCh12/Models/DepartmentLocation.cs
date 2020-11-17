using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeesCh12.Models
{
    public class DepartmentLocation
    {
        // Composit Primary key and foreign key for Department
        public int DepartmentID { get; set;  }
        // Composit Primary key and foreign key for Location
        public int LocationID { get; set; }

        // Navigation properties
        public Department Department { get; set; }
        public Location Location { get; set; }
    }
}
