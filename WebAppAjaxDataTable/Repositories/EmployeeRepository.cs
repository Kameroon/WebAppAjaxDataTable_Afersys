using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebAppAjaxDataTable.Models;

namespace WebAppAjaxDataTable.Repositories
{
    public class EmployeeRepository 
    {        
        public IList<Employee> PopulateEmployeeList()
        {
            var employees = new List<Employee>
            {
                new Employee { Name = "Jamy", Position = "Salary", Office = "London", Age = 31 },
                new Employee { Name = "Carol", Position = "Chief officer", Office = "London", Age = 26 },
                new Employee { Name = "Mary", Position = "Manager", Office = "Paris", Age = 22 },
                new Employee { Name = "Jimy", Position = "Salary", Office = "London", Age = 31 },
                new Employee { Name = "Patrik", Position = "Salary", Office = "London", Age = 41 },
                new Employee { Name = "Obama", Position = "Salary", Office = "London", Age = 30 },
                new Employee { Name = "Karl", Position = "Salary", Office = "London", Age = 25 }
            };

            return employees;
        }
    }
}