using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Foodworks.Entities
{
    class PizzaPanel : Panel
    {
        NumericUpDown nud = new NumericUpDown();
        Tetel ujtetel = new Tetel();
        List<Pizza> pizzak = new List<Pizza>();
        int Sorszam;
        public PizzaPanel(int sorszam)
        {
            Sorszam = sorszam;
            GetPizzas();
            this.Height = 202;
            this.Width = 720;

            int kepmeret = 175;
            PictureBox pizzaPicture = new PictureBox();
            pizzaPicture.Height = kepmeret;
            pizzaPicture.Width = kepmeret;
            pizzaPicture.Top = Sorszam * (kepmeret + 5);
            pizzaPicture.BackgroundImage = Image.FromFile("Files/" + pizzak[Sorszam].Sorszam + ".png");
            pizzaPicture.BackgroundImageLayout = ImageLayout.Stretch;
            this.Controls.Add(pizzaPicture);


            Label lblNev = new Label();
            lblNev.Text = pizzak[Sorszam].Nev;
            lblNev.Left = kepmeret + 30;
            lblNev.Top = Sorszam * (kepmeret + 5);
            lblNev.Font = new Font("Century", 12);
            lblNev.Width = 500;
            this.Controls.Add(lblNev);

            Label lblLeiras = new Label();
            lblLeiras.Text = "Leírás: " + pizzak[Sorszam].Leiras;
            lblLeiras.Left = kepmeret + 30;
            lblLeiras.Top = Sorszam * (kepmeret + 5) + 30;
            lblLeiras.Font = new Font("Century", 12);
            lblLeiras.Width = 500;
            this.Controls.Add(lblLeiras);

            Label lblAr = new Label();
            lblAr.Text = "Ár: " + pizzak[Sorszam].Ar.ToString() + " Ft";
            lblAr.Left = kepmeret + 30;
            lblAr.Top = Sorszam * (kepmeret + 5) + 60;
            lblAr.Font = new Font("Century", 12);
            lblAr.Width = 500;
            this.Controls.Add(lblAr);

            Button b = new Button();
            b.Height = 40;
            b.Width = 40;
            b.Top = Sorszam * (kepmeret + 5) + 90;
            b.Left = kepmeret + 90;
            b.BackgroundImage = Image.FromFile("Files/Shopping-Cart.png");
            b.BackgroundImageLayout = ImageLayout.Stretch;
            b.MouseClick += B_MouseClick;
            this.Controls.Add(b);

            nud.BackColor = Color.FromArgb(220, 220, 255);
            nud.ForeColor = Color.Black;
            nud.Left = kepmeret + 30;
            nud.Top = Sorszam * (kepmeret + 5) + 90;
            nud.Width = 40;
            nud.Height = 40;
            this.Controls.Add(nud);

        }

        private void B_MouseClick(object sender, MouseEventArgs e)
        {
            Tetel ujtetel = new Tetel();
            ujtetel.Mennyiseg = (int)nud.Value;
            ujtetel.Ar = pizzak[Sorszam].Ar;
            ujtetel.Nev = pizzak[Sorszam].Nev;
            Rendeles.tetelek.Add(ujtetel);
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
