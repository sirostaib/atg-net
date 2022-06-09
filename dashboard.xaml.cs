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
using ATG_WPF.Manage_Department;

namespace ATG_WPF.Pages
{
    /// <summary>
    /// Interaction logic for dashboard.xaml
    /// </summary>
    public partial class dashboard : Page
    {
        public dashboard()
        {
            InitializeComponent();
        }

        private void manage_Checked(object sender, RoutedEventArgs e)
        {
            if (GlobalClass.CheckForInternetConnection())
            {
                this.NavigationService.Navigate(new SelectDepPage());
                //MessageBox.Show("Warning: This is not finished yet!");
            }
            else
            {
                MessageBox.Show("Warning: you are not connected to internet!");
            }
            
        }


        private void Gen_Checked(object sender, RoutedEventArgs e)
        {
            
            if (GlobalClass.CheckForInternetConnection())
            {
                //this.NavigationService.Navigate(new Pump_Check());
                MessageBox.Show("Warning: This is not finished yet");
            }
            else
            {
                MessageBox.Show("Warning: you are not connected to internet!");
            }
        }

        private void Sem_Checked(object sender, RoutedEventArgs e)
        {
            
            if (GlobalClass.CheckForInternetConnection())
            {
                this.NavigationService.Navigate(new ns_semester_de());
                //MessageBox.Show("Warning: This page has been removed");
            }
            else
            {
                MessageBox.Show("Warning: you are not connected to internet!");
            }
        }

        private void newDepClicked(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new NewDepPage());
        }

        
        private void studentManageClicked(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new addNewStudentPage());
        }
    }
}
