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
            //GetPizzas();
            //UIRajzolas();
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
            int kepmeret = 175;
            meret = 0;
            for (int i = 0; i < pizzak.Count; i++)
            {
                meret += kepmeret + 20;
                string picturePath = "Files/" + (i + 1).ToString() +".png";
                PictureBox pbPizza = new PictureBox();
                pbPizza.Left = 0;
                pbPizza.Width = kepmeret;
                pbPizza.Height = kepmeret;
                pbPizza.Top = i * (kepmeret + 20);
                pbPizza.BackgroundImage = Image.FromFile(picturePath);
                pbPizza.BackgroundImageLayout = ImageLayout.Stretch;
                this.Controls.Add(pbPizza);

                Label lblNev = new Label();
                lblNev.Text = pizzak[i].Nev;
                lblNev.Left = kepmeret + 30;
                lblNev.Top = i * (kepmeret +20);
                lblNev.Font = new Font("Century", 12);
                lblNev.Width = 500;
                this.Controls.Add(lblNev);

                Label lblLeiras = new Label();
                lblLeiras.Text ="Leírás: " + pizzak[i].Leiras;
                lblLeiras.Left = kepmeret + 30;
                lblLeiras.Top = i * (kepmeret + 20) + 30;
                lblLeiras.Font = new Font("Century", 12);
                lblLeiras.Width = 500;
                this.Controls.Add(lblLeiras);

                Label lblAr = new Label();
                lblAr.Text = "Ár: " + pizzak[i].Ar.ToString() +" Ft";
                lblAr.Left = kepmeret + 30;
                lblAr.Top = i * (kepmeret + 20) + 60;
                lblAr.Font = new Font("Century", 12);
                lblAr.Width = 500;
                this.Controls.Add(lblAr);

                CartButton btnCart = new CartButton();
                btnCart.Tag = i;
                btnCart.Top = i * (kepmeret + 20) + 90;
                btnCart.Left = kepmeret + 30;
                btnCart.ID = i;
                this.Controls.Add(btnCart);
                btnCart.MouseClick += BtnCart_MouseClick;


            }
        }

        private void BtnCart_MouseClick(object sender, MouseEventArgs e)
        {
            
        }
    }
}
