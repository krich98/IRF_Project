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
            this.Height = 180;
            this.Width = 720;
            AddControls();
        }

        private void B_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (nud.Value == 0)
                    MessageBox.Show("A hozzáadott mennyiség nem lehet 0.", "KRICH' FOODWORKS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    Tetel ujtetel = new Tetel();
                    ujtetel.Mennyiseg = (int)nud.Value;
                    ujtetel.Ar = pizzak[Sorszam].Ar;
                    ujtetel.Nev = pizzak[Sorszam].Nev;
                    Rendeles.tetelek.Add(ujtetel);
                    MessageBox.Show("A tétel sikeresen hozzáadva a kosárhoz.", "KRICH'S FOODWORKS");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
        private void GetPizzas()
        {
            try
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
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
        private void AddControls()
        {
            try
            {
                int kepmeret = 175;
                PictureBox pizzaPicture = new PictureBox();
                pizzaPicture.Height = kepmeret;
                pizzaPicture.Width = kepmeret;
                pizzaPicture.Top = 0;
                pizzaPicture.BackgroundImage = Image.FromFile("Files/" + pizzak[Sorszam].Sorszam + ".png");
                pizzaPicture.BackgroundImageLayout = ImageLayout.Stretch;
                this.Controls.Add(pizzaPicture);


                Label lblNev = new Label();
                lblNev.Text = pizzak[Sorszam].Nev;
                lblNev.Left = kepmeret + 30;
                lblNev.Top = 0;
                lblNev.Font = new Font("Century", 12);
                lblNev.Width = 500;
                this.Controls.Add(lblNev);

                Label lblLeiras = new Label();
                lblLeiras.Text = "Leírás: " + pizzak[Sorszam].Leiras;
                lblLeiras.Left = kepmeret + 30;
                lblLeiras.Top = 30;
                lblLeiras.Font = new Font("Century", 12);
                lblLeiras.Width = 500;
                this.Controls.Add(lblLeiras);

                Label lblAr = new Label();
                lblAr.Text = "Ár: " + pizzak[Sorszam].Ar.ToString() + " Ft";
                lblAr.Left = kepmeret + 30;
                lblAr.Top = 60;
                lblAr.Font = new Font("Century", 12);
                lblAr.Width = 500;
                this.Controls.Add(lblAr);

                CustomButton b = new CustomButton();
                b.Height = 40;
                b.Width = 40;
                b.Top = 90;
                b.Left = kepmeret + 90;
                b.BackgroundImage = Image.FromFile("Files/Shopping-Cart.png");
                b.BackgroundImageLayout = ImageLayout.Stretch;
                b.MouseClick += B_MouseClick;
                this.Controls.Add(b);

                nud.BackColor = Color.FromArgb(220, 220, 255);
                nud.ForeColor = Color.Black;
                nud.Left = kepmeret + 30;
                nud.Top = 90;
                nud.Width = 40;
                nud.Height = 40;
                nud.Value = 1;
                this.Controls.Add(nud);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
