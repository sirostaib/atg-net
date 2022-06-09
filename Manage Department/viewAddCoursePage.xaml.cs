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
using MySql.Data.MySqlClient;

namespace ATG_WPF.Manage_Department
{
    /// <summary>
    /// Interaction logic for viewAddCoursePage.xaml
    /// </summary>
    public partial class viewAddCoursePage : Page
    {
        public viewAddCoursePage(string selectedName)
        {
            InitializeComponent();
            depNameText.Text = selectedName;
        }

        private void Goback_click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Pages.dashboard());
        }

        private void addLecturerBtnClicked(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new addNewLecturerPage(depNameText.Text) );
        }

        private void insertCourse(object sender, RoutedEventArgs e)
        {
            System.Random random = new System.Random();

             

                GlobalClass.con.Open();

                string command_insert = @"INSERT INTO `atg`.`course`
(`courseid`,
`ccode`,
`cname`,
`ccredit`,
`lemail`)
VALUES ('"+ random.Next(999999, 999999999).ToString() + "', '" +
                    cCodeInput.Text + "','" + cNameInput.Text + "' , "+ cCreditInput.Text + ", '"+ lEmailInput.Text + "');";
                MySqlCommand sql_cmd = new MySqlCommand(command_insert, GlobalClass.con);
                GlobalClass.sql_dr = sql_cmd.ExecuteReader();
                GlobalClass.con.Close();

                MessageBox.Show("Successfully Added '" + cNameInput.Text + "'...");
            cCodeInput.Text = "";
            cNameInput.Text = "";
            cCreditInput.Text = "";
            lEmailInput.Text = "";





        }


    }
}
