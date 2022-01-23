using EntityFramework_WPF.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework_WPF.Models.ViewModels {
    internal class MainWindowViewModel : ObservableObject {

        private object _currentView;
        public object CurrentView { get { return _currentView; } set { _currentView = value; OnPropertyChanged(); } }

        public RelayCommand CustomersViewCommand { get; set; }
        public RelayCommand NewCustomerViewCommand { get; set; }
        public RelayCommand LogErrandViewCommand { get; set; }
        public RelayCommand ErrandsViewCommand { get; set; }


        public CustomersViewModel CustomersViewModel { get; set; }
        public NewCustomerViewModel NewCustomerViewModel { get; set; }
        public LogErrandViewModel LogErrandViewModel { get; set; }
        public ErrandsViewModel ErrandsViewModel { get; set; }





        public MainWindowViewModel() {

            CustomersViewModel = new CustomersViewModel();
            NewCustomerViewModel = new NewCustomerViewModel();
            LogErrandViewModel = new LogErrandViewModel();
            ErrandsViewModel = new ErrandsViewModel();
            CurrentView = CustomersViewModel;

            CustomersViewCommand = new RelayCommand(x => CurrentView = CustomersViewModel);
            NewCustomerViewCommand = new RelayCommand(x => CurrentView = NewCustomerViewModel);
            LogErrandViewCommand = new RelayCommand(x => CurrentView = LogErrandViewModel);
            ErrandsViewCommand = new RelayCommand(x => CurrentView = ErrandsViewModel);
        }           


    }
}
