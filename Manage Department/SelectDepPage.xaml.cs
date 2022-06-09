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
    /// Interaction logic for SelectDepPage.xaml
    /// </summary>
    public partial class SelectDepPage : Page
    {
        public SelectDepPage()
        {
            InitializeComponent();

            /*
             <ComboBox x:Name="cmbCountryList"   
                                    Width="220"   
                                    Height="50"  
                                    FontSize="18"    
                                    HorizontalAlignment="Center"   
                                    VerticalAlignment="Top"  
                                    BorderThickness="0"  
                                    VerticalContentAlignment="Center"  
                                    Padding="15,0,0,0"   
                                    Background="Transparent"  
                                    Foreground="Black"  
                                    IsEditable="True"   
                                    Margin="0"/>
            */

            List<string> lst = new List<string>();
            lst.Add("Software Test");
            lst.Add("Network Test");
            lst.Add("Biomedical Test");
            lst.Add("Pharmacy Test");
            


            try
            {
                // Binding  
                
                this.departmentList.ItemsSource = lst;
                this.departmentList.Text = "Choose Department";
            }
            catch (Exception ex)
            {
                Console.Write(ex);
            }
        }

        private void Goback_click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Pages.dashboard());
        }

        private void nextClicked(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new viewAddCoursePage());
        }
    }
}
