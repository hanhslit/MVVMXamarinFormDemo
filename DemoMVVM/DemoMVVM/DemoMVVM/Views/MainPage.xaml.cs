using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoMVVM.ViewModels;
using Xamarin.Forms;

namespace DemoMVVM.Views
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
       //     MainViewModel mainViewModel = new MainViewModel();
           BindingContext = new MainViewModel();
            //      listViews.ItemsSource = mainViewModel.EmployeesList;
        }
    }
}
