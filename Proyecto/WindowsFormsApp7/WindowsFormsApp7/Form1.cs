using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using OfficeOpenXml;
using System.IO;

namespace WindowsFormsApp7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (ExcelPackage excel = new ExcelPackage())
            {
                FileInfo excelFile = new FileInfo(@".\test.xlsx");
                excel.Workbook.Worksheets.Add("Worksheet1");
                var worksheet = excel.Workbook.Worksheets["Worksheet1"];


                for (int i = 1; i < 1500; i++)
                {
                    String s = "A" + i.ToString();
                    worksheet.Cells[s].Value = i.ToString();
                }
                
                worksheet.Cells["A2"].Value = "Hola Mundo!";
                worksheet.Cells["A3"].Value = "Good Bye";

                worksheet.Cells["A1"].Style.Font.Bold = true;
                worksheet.Cells["A2"].Style.Font.Size = 14;
                worksheet.Cells["A3"].Style.Font.Color.SetColor(System.Drawing.Color.Blue);
                

                excel.SaveAs(excelFile);
            }
        }
    }
}
