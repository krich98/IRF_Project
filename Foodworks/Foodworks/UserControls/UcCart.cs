using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Foodworks.Entities;
using Excel = Microsoft.Office.Interop.Excel;
using System.Reflection;

namespace Foodworks.UserControls
{
    public partial class UcCart : UserControl
    {
        Excel.Application xlApp; 
        Excel.Workbook xlWB; 
        Excel.Worksheet xlSheet;
        dynamic tetellista;
        
        public UcCart()
        {
            InitializeComponent();
            TetelekOsszesit();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CreateTable();            
        }
        private void TetelekOsszesit()
        {
            try
            {
                if (Rendeles.tetelek.Count != 0)
                {
                    Rendeles rendeles = new Rendeles();

                    tetellista = (from x in Rendeles.tetelek
                                  group x by x.Nev into y
                                  select new { Név = y.Key, Mennyiség = y.Sum(z => z.Mennyiseg), Egységár = y.Average(z => z.Ar) }).ToList();

                    var osszeadas = (from a in Rendeles.tetelek
                                     select new { Osszeg = a.Mennyiseg * a.Ar }).ToList();
                    var vegosszeg = (from x in osszeadas select x.Osszeg).Sum();

                    dataGridView1.DataSource = tetellista;

                    labelOsszesen.Text = "Összesen: ";
                    labelSzallDij.Text = "Szállítáí díj:";
                    labelOsszeg.Text = (vegosszeg + rendeles.SzallitasiKoltseg).ToString() + " Ft";
                    labelSzallDijSzam.Text = rendeles.SzallitasiKoltseg.ToString() + " Ft";
                }
                else 
                {
                    labelOsszeg.Visible = false;
                    labelOsszesen.Visible = false;
                    labelSzallDij.Visible = false;
                    labelSzallDijSzam.Visible = false;
                    customButton1.Visible = false;

                    Label ures = new Label();
                    ures.Text = "A kosarad üres.";
                    ures.Top = this.Height / 2 +50;
                    ures.Font = new Font("Century", 30);
                    ures.Width = 1000;
                    ures.Height = 500;
                    this.Controls.Add(ures);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void CreateTable()
        {
            try
            {
                xlApp = new Excel.Application();

                xlWB = xlApp.Workbooks.Add(Missing.Value);

                xlSheet = xlWB.ActiveSheet;

                xlSheet.Cells[1, 1] = "Nyugta";
                xlSheet.Range[xlSheet.Cells[1, 1], xlSheet.Cells[1, 3]].Merge();

                string[] headers = new string[] { "Név", "Mennyiség", "Egységár" };
                for (int i = 0; i < headers.Length; i++)
                {
                    xlSheet.Cells[2, i + 1] = headers[i];
                }

                object[,] values = new object[tetellista.Count, headers.Length];

                int counter = 0;
                foreach (var t in tetellista)
                {
                    values[counter, 0] = t.Név;
                    values[counter, 1] = t.Mennyiség;
                    values[counter, 2] = t.Egységár;

                    counter++;
                }

                Excel.Range tetelekRange = xlSheet.get_Range(
                GetCell(3, 1),
                GetCell(2 + values.GetLength(0), values.GetLength(1)));
                tetelekRange.Value2 = values;
                tetelekRange.VerticalAlignment = Excel.XlVAlign.xlVAlignCenter;
                tetelekRange.EntireColumn.AutoFit();

                Excel.Range TitleRange = xlSheet.get_Range(GetCell(1, 1), GetCell(1, headers.Length));
                TitleRange.Font.Bold = true;
                TitleRange.Font.Size = 20;
                TitleRange.VerticalAlignment = Excel.XlVAlign.xlVAlignCenter;
                TitleRange.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                TitleRange.EntireColumn.AutoFit();
                TitleRange.RowHeight = 40;
                TitleRange.Interior.Color = Color.LightBlue;
                TitleRange.BorderAround2(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlThick);

                Excel.Range headerRange = xlSheet.get_Range(GetCell(2, 1), GetCell(2, headers.Length));
                headerRange.Font.Bold = true;
                headerRange.VerticalAlignment = Excel.XlVAlign.xlVAlignCenter;
                headerRange.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                headerRange.EntireColumn.AutoFit();
                headerRange.RowHeight = 20;
                headerRange.BorderAround2(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlMedium);

                int lastRowID = xlSheet.UsedRange.Rows.Count;
                Excel.Range teljesRange = xlSheet.get_Range(GetCell(1, 1), GetCell(lastRowID, headers.Length));
                teljesRange.BorderAround2(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlThick);

                xlApp.Visible = true;
                xlApp.UserControl = true;
            }
            catch (Exception ex)
            {
                string errMsg = string.Format("Error: {0}\nLine: {1}", ex.Message, ex.Source);
                MessageBox.Show(errMsg, "Error");

                xlWB.Close(false, Type.Missing, Type.Missing);
                xlApp.Quit();
                xlWB = null;
                xlApp = null;
            }

        }
        private string GetCell(int x, int y)
        {
            string ExcelCoordinate = "";
            int dividend = y;
            int modulo;

            while (dividend > 0)
            {
                modulo = (dividend - 1) % 26;
                ExcelCoordinate = Convert.ToChar(65 + modulo).ToString() + ExcelCoordinate;
                dividend = (int)((dividend - modulo) / 26);
            }
            ExcelCoordinate += x.ToString();

            return ExcelCoordinate;
        }

        private void customButton1_Click(object sender, EventArgs e)
        {
            CreateTable();
        }
    }
}
