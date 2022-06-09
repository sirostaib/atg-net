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
            
            semIDtext.Text =  random.Next(9999, 9999999).ToString() ;
        }




        private void insertSemester(object sender, RoutedEventArgs e)
        {
            if (semNumText.Text != "" && semSessionText.Text != "")
            {

                GlobalClass.con.Open();

                string command_insert = @" INSERT INTO `atg`.`semester` (`semid`, `session`, `semnum`) VALUES ("+
                    semIDtext.Text+", '"+semSessionText.Text+"', '"+semNumText.Text+"'); ";
                MySqlCommand sql_cmd = new MySqlCommand(command_insert, GlobalClass.con);
                GlobalClass.sql_dr = sql_cmd.ExecuteReader();
                GlobalClass.con.Close();

                MessageBox.Show("Successfully Added '" + semIDtext.Text + "', '" + semSessionText.Text + "', '" + semNumText.Text + "'");
                semIDtext.Text = "";
                semSessionText.Text = "";
                semNumText.Text = "";


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
