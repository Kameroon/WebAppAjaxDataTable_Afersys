using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppAjaxDataTable.Models
{
    public class Employee
    {
        public int EmployeeID { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }
        public string Office { get; set; }
        public Nullable<int> Age { get; set; }
    }
}