﻿using System;
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
using ATG_WPF.Pages;
using MySql.Data.MySqlClient;

namespace ATG_WPF
{
    /// <summary>
    /// Interaction logic for Pump_Check.xaml
    /// </summary>
    public partial class Pump_Check : Page
    {
   

        public Pump_Check()
        {
            InitializeComponent();
            MaxHeight = SystemParameters.MaximizedPrimaryScreenHeight;
            MaxWidth = SystemParameters.MaximizedPrimaryScreenWidth;
            //DateTime_lable.Text = GlobalClass.GetNistTime().ToString("yyyy-MM-dd HH:mm");

           

           // s_d = GlobalClass.GetNistTime();


        }

        private bool validateSubmit()
        {

            // code...


            return false;
        }


        /*
      p1
      */

       




    
        private void Goback_click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Pages.dashboard());
        }
    }
}
