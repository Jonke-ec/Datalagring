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
    /// Interaction logic for ErrandsView.xaml
    /// </summary>
    public partial class ErrandsView : UserControl {

        private readonly ISubjectService subjectService = new SubjectService();
        
        public ErrandsView() {

            InitializeComponent();

            lvErrands.Items.Clear();
            foreach (var subject in subjectService.GetAll()) {
                lvErrands.Items.Add(subject);
            }


        }
    }
}
