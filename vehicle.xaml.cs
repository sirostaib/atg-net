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

namespace ATG_WPF.Pages
{
    /// <summary>
    /// Interaction logic for vehicle.xaml
    /// </summary>
    public partial class vehicle : Page
    {
        public vehicle()
        {
            InitializeComponent();
        }

        private void Loader_Checked(object sender, RoutedEventArgs e)
        {
            if (GlobalClass.CheckForInternetConnection())
            {
                //this.NavigationService.Navigate(new Loader_check());
                MessageBox.Show("Warning: This page has been deleted!");
            }
            else
            {
                MessageBox.Show("Warning: you are not connected to internet!");
            }
            
        }


        private void Pump_Checked(object sender, RoutedEventArgs e)
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

        private void Mixer_Checked(object sender, RoutedEventArgs e)
        {
            
            if (GlobalClass.CheckForInternetConnection())
            {
                //this.NavigationService.Navigate(new Mixer_check());
                MessageBox.Show("Warning: This page has been removed");
            }
            else
            {
                MessageBox.Show("Warning: you are not connected to internet!");
            }
        }
    }
}
