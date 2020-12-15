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
        public int meret;
        public UcPizza()
        {
            InitializeComponent();
            GetPizzas();
            UIRajzolas();
        }
        void GetPizzas()
        {
            string path = "Files/Pizzak.csv";
            
            
            using (StreamReader sr = new StreamReader(path, Encoding.Default))
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
        void UIRajzolas()
        {
            meret = 0;
            for (int i = 0; i < pizzak.Count; i++)
            {
                PizzaPanel pizzaPanel = new PizzaPanel(i);
                pizzaPanel.Top = i * (pizzaPanel.Height);
                this.Controls.Add(pizzaPanel);
                meret += pizzaPanel.Height;

            }
            this.Height = meret;
        }
    }


}

