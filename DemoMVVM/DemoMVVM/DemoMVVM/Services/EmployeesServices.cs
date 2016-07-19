using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoMVVM.Models;
using System.Collections.ObjectModel;

namespace DemoMVVM.Services
{
    public class EmployeesServices
    {
        public ObservableCollection<Employee> GetEmployees()
        {
            ObservableCollection<Employee> employeesList = new ObservableCollection<Employee>() {
                new Employee {Name="abc",Department="xyz" },
                new Employee {Name="abc",Department="xyz" },
                new Employee {Name="abc",Department="xyz"}
            };
            return employeesList;
        }
    }
}
