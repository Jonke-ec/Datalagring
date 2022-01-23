using EntityFramework_WPF.Models;
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
    /// Interaction logic for LogErrandView.xaml
    /// </summary>
    public partial class LogErrandView : UserControl {

        private readonly ISubjectService subjectService = new SubjectService();

        string errandTitle ;
        string status;

        public LogErrandView() {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e) {
            if (!string.IsNullOrEmpty(tbErrandDescription.Text)) {
                if (subjectService.Create(errandTitle, tbErrandDescription.Text, status, int.Parse(tbCustomerId.Text)))
                    ClearFields();
            }
        }

        private void ClearFields() {
            tbCustomerId.Text = "";
            tbErrandDescription.Text = "";
            rbChangeReturn.IsChecked = false;
            rbComplaint.IsChecked = false;
            rbCompleted.IsChecked = false;
            rbDelivery.IsChecked = false;
            rbNotStarted.IsChecked = false;
            rbOrdering.IsChecked = false;
            rbOther.IsChecked = false;
            rbTreated.IsChecked = false;
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e) {
            errandTitle = "Reklamation";
        }

        private void RadioButton_Checked_1(object sender, RoutedEventArgs e) {
            errandTitle = "Beställning";
        }

        private void RadioButton_Checked_2(object sender, RoutedEventArgs e) {
            errandTitle = "Leverans";
        }

        private void RadioButton_Checked_3(object sender, RoutedEventArgs e) {
            errandTitle = "Byte/ Retur";
        }

        private void RadioButton_Checked_4(object sender, RoutedEventArgs e) {
            errandTitle = "Övrigt";
        }

        private void RadioButton_Checked_5(object sender, RoutedEventArgs e) {
            status = "Ej påbörjad";
        }

        private void RadioButton_Checked_6(object sender, RoutedEventArgs e) {
            status = "Behandlas";
        }

        private void RadioButton_Checked_7(object sender, RoutedEventArgs e) {
            status = "Avslutad";
        }
    }
}
