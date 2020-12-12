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
using Foodworks.UserControls;

namespace Foodworks
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            panel3.Top = 49;
            panel3.Left = 200;
            panel3.Width = this.Width - 50 -200;
            panel3.Visible = true;

            panel1.Width = this.Right -20;
            


        }
       public void Buttonok()
       { 
            
       }

        private void HomeBtn_Click(object sender, EventArgs e)
        {

        }

        private void MenuBtn_Click(object sender, EventArgs e)
        {
            UcPizza ucPizza = new UcPizza();
            panel3.Height = ucPizza.meret;
            panel3.Controls.Clear();
            panel3.Controls.Add(ucPizza);
            ucPizza.Dock = DockStyle.Fill;
        }

        private void AboutUsBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
