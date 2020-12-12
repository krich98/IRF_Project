using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Foodworks.Entities;

namespace Foodworks.UserControls
{
    public partial class UcPizza : UserControl
    {
        List<Pizza> pizzak = new List<Pizza>();
        public UcPizza()
        {
            InitializeComponent();
            GetPizzas();
        }
        public void GetPizzas()
        {
            string path = "Files/Pizzak.cs";
            
            using (StreamReader sr = new StreamReader(path, Encoding.UTF8))
            {
                while (!sr.EndOfStream)
                {
                    var line = sr.ReadLine().Split(';');
                    Pizza p = new Pizza();
                    p.Sorszam = int.Parse(line[0]);
                    p.Nev = line[1];
                    p.Ar = int.Parse(line[2]);
                    p.Leiras = line[3];
                    pizzak.Add(p);

                }
            }
            
        }
    }
}
