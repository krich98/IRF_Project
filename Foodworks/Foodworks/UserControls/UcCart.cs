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

namespace Foodworks.UserControls
{
    public partial class UcCart : UserControl
    {
        public UcCart()
        {
            InitializeComponent();
            Rendeles rendeles = new Rendeles();

            var tetellista = from x in Rendeles.tetelek
                             group x by x.Nev into y
                             select new { Név = y.Key, Mennyiség = y.Sum(z => z.Mennyiseg) };

            dataGridView1.DataSource = tetellista;

            label1.Text = rendeles.SzallitasiKoltseg.ToString();
        }
       
    }
}
