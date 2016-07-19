using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoMVVM.Models;
using DemoMVVM.Services;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Collections.ObjectModel;

namespace DemoMVVM.ViewModels
{
    public class MainViewModel: INotifyPropertyChanged
    {
        private ObservableCollection<Employee> _employeesList;
        public ObservableCollection<Employee> EmployeesList {
            get { return _employeesList; }
            set {
                _employeesList = value;
                OnPropertyChanged("EmployeesList");
            }
        }
        public MainViewModel()
        {
            EmployeesServices employeeServices = new EmployeesServices();
            EmployeesList = employeeServices.GetEmployees();
            
           
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName=null)
        {
            PropertyChanged?.Invoke(this,new PropertyChangedEventArgs(propertyName));
        }
    }
}
