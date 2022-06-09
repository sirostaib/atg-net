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
    /// Interaction logic for NewDepPage.xaml
    /// </summary>
    public partial class NewDepPage : Page
    {
        public NewDepPage()
        {
            InitializeComponent();
            System.Random random = new System.Random();
            
            depIDtext.Text = random.Next(999999, 999999999).ToString();
        }

        private void Goback_click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Pages.dashboard());
        }


        public static void insert_New_Department(TextBlock depIDtext, TextBox depNameText)
        {

            GlobalClass.con.Open();
            
            string command_insert = @"INSERT INTO `atg`.`department`
            (`depid`,
            `depname`)
            VALUES
            ('" + depIDtext.Text + "', '" + depNameText.Text + "');";
            MySqlCommand sql_cmd = new MySqlCommand(command_insert, GlobalClass.con);
            GlobalClass.sql_dr = sql_cmd.ExecuteReader();
            GlobalClass.con.Close();


        }

        private void addDepSubmit(object sender, RoutedEventArgs e)
        {
            if (depNameText.Text != "")
            {
                insert_New_Department(depIDtext, depNameText);
                MessageBox.Show("Successfully Added '" + depIDtext.Text + "', '" + depNameText.Text + "'");
                depNameText.Text = "";
                System.Random random = new System.Random();
                depIDtext.Text = random.Next(999999, 999999999).ToString();
            }
            else
            {
                MessageBox.Show("Please Enter The Department Name!");
            }

        }
    }
}
