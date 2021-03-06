using EntityFramework_WPF.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace EntityFramework_WPF.Views {
    /// <summary>
    /// Interaction logic for CustomersView.xaml
    /// </summary>
    public partial class CustomersView : UserControl {

        private readonly ICustomerService customerService = new CustomerService();
        public CustomersView() {

            InitializeComponent();

            lvCustomers.Items.Clear();
            foreach (var customer in customerService.GetAll()) {
                lvCustomers.Items.Add(customer);
            }

        }
    }
}
