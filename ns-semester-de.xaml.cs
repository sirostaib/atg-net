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

namespace ATG_WPF
{
    /// <summary>
    /// Interaction logic for ns_semester_de.xaml
    /// </summary>
    public partial class ns_semester_de : Page
    {
        public ns_semester_de()
        {
            InitializeComponent();
            MaxHeight = SystemParameters.MaximizedPrimaryScreenHeight;
            MaxWidth = SystemParameters.MaximizedPrimaryScreenWidth;

            // generate random id for this new semester
            System.Random random = new System.Random();
            semIDtext.Text += " ";
            semIDtext.Text +=  random.Next(9999, 9999999).ToString() ;
        }

        private void Goback_click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Pages.dashboard());
        }
    }
}
