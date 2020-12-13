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
    public partial class UcHome : UserControl
    {
        List<Pizza> pizzak = new List<Pizza>();
        public UcHome()
        {
            InitializeComponent();
            GetPizzas();
            UIRajzolas();

        }
        void UIRajzolas()
        {
            int kepmeret = 100;
            
            for (int i = 0; i < 6; i++)
            {
               
                string picturePath = "Files/" + (i + 1).ToString() + ".png";
                PictureBox pbPizza = new PictureBox();
                pbPizza.Left = i*(kepmeret+10);
                pbPizza.Width = kepmeret;
                pbPizza.Height = kepmeret;
                pbPizza.Top = 200;
                pbPizza.BackgroundImage = Image.FromFile(picturePath);
                pbPizza.BackgroundImageLayout = ImageLayout.Stretch;
                this.Controls.Add(pbPizza);

                Label lblPizza = new Label();
                lblPizza.Top = pbPizza.Top - 30;
                lblPizza.Left = i * (kepmeret + 10);
                lblPizza.Text = pizzak[i].Nev;
                lblPizza.Width = kepmeret;
                lblPizza.Font = new Font("Century", 8);
                this.Controls.Add(lblPizza);
            }

            Label lblCim = new Label();
            lblCim.Text = "KRICH'S FOODWORKS";
            lblCim.Left = 100;
            lblCim.Top = 0;
            lblCim.Width = 800;
            lblCim.Height = 50;
            lblCim.Font = new Font("Century", 25);
            lblCim.ForeColor = Color.FromArgb(255, 100, 100);
            this.Controls.Add(lblCim);

            Label lblMotto = new Label();
            lblMotto.Text = "The best food in the Milky Way";
            lblMotto.Left = 50;
            lblMotto.Top = lblCim.Top + 50;
            lblMotto.Width = 800;
            lblMotto.Height = 50;
            lblMotto.Font = new Font("Century", 25);
            lblMotto.ForeColor = Color.FromArgb(100, 100, 255);
            this.Controls.Add(lblMotto);


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
    }
}
