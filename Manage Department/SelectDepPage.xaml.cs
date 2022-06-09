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
using MySql.Data.MySqlClient;

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
            getListOfDepartments();


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

        }

        private void Goback_click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Pages.dashboard());
        }

        private void nextClicked(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new viewAddCoursePage(departmentList.SelectedValue.ToString()));
        }



        public void getListOfDepartments()
        {


            List<string> depList = new List<string>();
            List<string> depIDList = new List<string>();


            GlobalClass.con.Open();
            string command_select = "SELECT * FROM atg.department; ";
            MySqlCommand sql_cmd = new MySqlCommand(command_select, GlobalClass.con);
            GlobalClass.sql_dr = sql_cmd.ExecuteReader();

            while (GlobalClass.sql_dr.Read())
            {
                depIDList.Add(GlobalClass.sql_dr.GetString(0));
                depList.Add(GlobalClass.sql_dr.GetString(1));
                
                
                

            }

            GlobalClass.con.Close();
            try
            {
                // Binding  

                this.departmentList.ItemsSource = depList;
                this.departmentList.Text = "Choose Department";
            }
            catch (Exception ex)
            {
                Console.Write(ex);
            }


        }
    }
}
