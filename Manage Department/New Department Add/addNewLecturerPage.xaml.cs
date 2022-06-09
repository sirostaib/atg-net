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

namespace ATG_WPF.Manage_Department.New_Department_Add
{
    /// <summary>
    /// Interaction logic for addNewLecturerPage.xaml
    /// </summary>
    public partial class addNewLecturerPage : Page
    {
        public addNewLecturerPage(string depn)
        {
            InitializeComponent();
            depName = depn;
        }

        string depName;

      

        private void addLecturerSubmit(object sender, RoutedEventArgs e)
        {
            if (lecturerNameText.Text != "" && lecturerEmailText.Text != "" )
            {

                GlobalClass.con.Open();

                string command_insert = @"INSERT INTO `atg`.`lecturer` (`lemail`, `lname`) VALUES ('"+
                    lecturerEmailText.Text+"','"+lecturerNameText.Text+"');";
                MySqlCommand sql_cmd = new MySqlCommand(command_insert, GlobalClass.con);
                GlobalClass.sql_dr = sql_cmd.ExecuteReader();
                GlobalClass.con.Close();

                MessageBox.Show("Successfully Added '" + lecturerNameText.Text + "', '" + lecturerEmailText.Text + "'");
                lecturerEmailText.Text = "";
                lecturerNameText.Text = "";
               


            }
            else
            {
                MessageBox.Show("Please don't leave any feild blank!");
            }

        }



        private void Goback_click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new viewAddCoursePage(depName));
        }

    }
}
