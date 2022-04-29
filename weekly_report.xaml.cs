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

using MySql.Data.MySqlClient;



namespace ATG_WPF.Pages

{
    /// <summary>
    /// Interaction logic for weekly_report.xaml
    /// </summary>
    public partial class weekly_report : Page
    {

       

        public weekly_report()
        {
            InitializeComponent();
            


        }




        void LoadData()
        {
            
              

        }



        private void Goback_btn(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Pages.view_report());
        }

        private void Download_btn(object sender, RoutedEventArgs e)
        {

           
            download_buttonn(); 

        }

        private void Refresh_Button_Click(object sender, RoutedEventArgs e)
        {
            //LoadData();
        }




        void download_buttonn()
        {

            Microsoft.Office.Interop.Excel.Application excel;
            Microsoft.Office.Interop.Excel.Workbook worKbooK;
            Microsoft.Office.Interop.Excel.Worksheet worKsheeT;
            Microsoft.Office.Interop.Excel.Range celLrangE;
            /*
            try
            {
                
                excel = new Microsoft.Office.Interop.Excel.Application();
                excel.Visible = false;
                excel.DisplayAlerts = false;
                worKbooK = excel.Workbooks.Add(Type.Missing);


                worKsheeT = (Microsoft.Office.Interop.Excel.Worksheet)worKbooK.ActiveSheet;
                worKsheeT.Name = "Weekly Report";

                worKsheeT.Range[worKsheeT.Cells[1, 1], worKsheeT.Cells[1, 18]].Merge();
                DateTime tempDate = currentDate.AddDays(6);
                worKsheeT.Cells[1, 1] = "Weekly Report, " + currentDate.ToString("yyyy-MM-dd") + " - " + tempDate.ToString("yyyy-MM-dd");
                worKsheeT.Cells.Font.Size = 15;


            

                for (int i = 1; i < weekly_report1.Columns.Count + 1; i++)
                {
                    worKsheeT.Cells[2, i] = weekly_report1.Columns[i - 1].Header.ToString();
                }

                for (int i = 0; i < weekly_report1.Items.Count; i++)
                {
                    
                    worKsheeT.Cells[i + 3, 1] = wData[i].v_codee;
                    worKsheeT.Cells[i + 3, 2] = wData[i].P1;
                    worKsheeT.Cells[i + 3, 3] = wData[i].P2;
                    worKsheeT.Cells[i + 3, 4] = wData[i].P3;
                    worKsheeT.Cells[i + 3, 5] = wData[i].P4;
                    worKsheeT.Cells[i + 3, 6] = wData[i].P5;
                    worKsheeT.Cells[i + 3, 7] = wData[i].P6;
                    worKsheeT.Cells[i + 3, 8] = wData[i].P7;
                    worKsheeT.Cells[i + 3, 9] = wData[i].P8;
                    worKsheeT.Cells[i + 3, 10] = wData[i].P9;
                    worKsheeT.Cells[i + 3, 11] = wData[i].P10;
                    worKsheeT.Cells[i + 3, 12] = wData[i].P11;
                    worKsheeT.Cells[i + 3, 13] = wData[i].P12;
                    worKsheeT.Cells[i + 3, 14] = wData[i].P13;
                    worKsheeT.Cells[i + 3, 15] = wData[i].P14;
                    worKsheeT.Cells[i + 3, 16] = wData[i].P15;
                    worKsheeT.Cells[i + 3, 17] = wData[i].P16;
                    worKsheeT.Cells[i + 3, 18] = wData[i].weeklyNote;
                    worKsheeT.Cells.Font.Color = System.Drawing.Color.Black;
                    
                }


                celLrangE = worKsheeT.Range[worKsheeT.Cells[1, 1], worKsheeT.Cells[weekly_report1.Items.Count+2, weekly_report1.Columns.Count]];
                celLrangE.EntireColumn.AutoFit();
                Microsoft.Office.Interop.Excel.Borders border = celLrangE.Borders;
                
                border.LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
                border.Weight = 2d;

                celLrangE.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                celLrangE.VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;

                celLrangE = worKsheeT.Range[worKsheeT.Cells[1, 1], worKsheeT.Cells[2, weekly_report1.Columns.Count]];

                //worKbooK.SaveAs();
                Microsoft.Win32.SaveFileDialog dlg = new Microsoft.Win32.SaveFileDialog() { };


                dlg.ShowDialog();
                string folderPath = "";

                    if (dlg.CheckPathExists)
                    {
                        folderPath =  ""+dlg.FileName +"-"+currentDate.ToString("yyyy-MM-dd") +".xlsx";
                    }
                


                worKbooK.SaveAs(folderPath, Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookDefault, Type.Missing, Type.Missing, true, false, (Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlNoChange), Type.Missing, Type.Missing, Type.Missing);
                //"C:\\Users\\Unimaginable\\Documents\\excell\\outputt.xls"
                worKbooK.Close();
                excel.Quit();
                if (dlg.FileName != "")
                    MessageBox.Show("Successfully Created the file!");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("There was a problem during the creation of Excel file!");

            }
            finally
            {
                worKsheeT = null;
                celLrangE = null;
                worKbooK = null;
            }
            */
        }
      
      




    }
}
