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

namespace ATG_WPF.Manage_Department
{
    /// <summary>
    /// Interaction logic for viewAddManageStudent.xaml
    /// </summary>
    public partial class viewAddManageStudent : Page
    {
        public viewAddManageStudent()
        {
            InitializeComponent();
        }

        private void Goback_click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Pages.dashboard());
        }
    }
}
