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
    /// Interaction logic for addNewStudentPage.xaml
    /// </summary>
    public partial class addNewStudentPage : Page
    {
        public addNewStudentPage()
        {
            InitializeComponent();
        }

      

        public static void insert_New_Student(TextBox isidText, TextBox sNameText, TextBox matricText)
        {

            GlobalClass.con.Open();

            string command_insert = @"INSERT INTO `atg`.`student` (`isid`,`sname`,
`matric`)
VALUES
('" + isidText.Text + "', '" + sNameText.Text + "','" + matricText.Text + "'); ";
            MySqlCommand sql_cmd = new MySqlCommand(command_insert, GlobalClass.con);
            GlobalClass.sql_dr = sql_cmd.ExecuteReader();
            GlobalClass.con.Close();


        }

        private void addStudentSubmit(object sender, RoutedEventArgs e)
        {
            if (sNameText.Text != "" && isidText.Text != "" && matricText.Text != "")
            {
                insert_New_Student(isidText, sNameText, matricText);
                MessageBox.Show("Successfully Added '" + sNameText.Text + "', '" + isidText.Text + "', '" + matricText.Text + "'");
                sNameText.Text = "";
                isidText.Text = "";
                matricText.Text = "";


            }
            else
            { 
                MessageBox.Show("Please don't leave any feild blank!");
            }

        }


        private void Goback_click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Pages.dashboard());
        }
    }
}
