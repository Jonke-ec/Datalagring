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
    /// Interaction logic for NewCustomerView.xaml
    /// </summary>
    public partial class NewCustomerView : UserControl {

        private readonly ICustomerService customerService = new CustomerService();

        public NewCustomerView() {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e) {

            if (!string.IsNullOrEmpty(tbFirstName.Text) && !string.IsNullOrEmpty(tbLastName.Text) && !string.IsNullOrEmpty(tbEmail.Text) && !string.IsNullOrEmpty(tbPhoneNumber.Text) && !string.IsNullOrEmpty(tbAddress.Text) && !string.IsNullOrEmpty(tbPostalcode.Text) && !string.IsNullOrEmpty(tbCity.Text) && !string.IsNullOrEmpty(tbCountry.Text)) {
                if (customerService.Create(tbFirstName.Text, tbLastName.Text, tbEmail.Text, int.Parse(tbPhoneNumber.Text), tbAddress.Text, int.Parse(tbPostalcode.Text), tbCity.Text, tbCountry.Text))
                    ClearFields();
                else
                    lbError.Content = "En användare med denna E-postadress finns redan.";
            }
            
        }

        private void ClearFields() {
            tbFirstName.Text = "";
            tbLastName.Text = "";
            tbEmail.Text = "";
            tbPhoneNumber.Text = "";
            tbAddress.Text = "";
            tbPostalcode.Text = "";
            tbCity.Text = "";
            tbCountry.Text = "";
            lbError.Content = "";
        }

    }
}
