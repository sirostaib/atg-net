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
using ATG_WPF.Manage_Department.New_Department_Add;

namespace ATG_WPF.Manage_Department
{
    /// <summary>
    /// Interaction logic for viewAddCoursePage.xaml
    /// </summary>
    public partial class viewAddCoursePage : Page
    {
        public viewAddCoursePage()
        {
            InitializeComponent();
        }

        private void Goback_click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Pages.dashboard());
        }

        private void addLecturerBtnClicked(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new addNewLecturerPage() );
        }
    }
}
