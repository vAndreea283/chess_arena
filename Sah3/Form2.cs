using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace chessv2
{
    public partial class Form2 : Form
    {
        cJocSah sah;
        int dimensiune = 55;
        int distanta = 80;

        Button[,] tabla = new Button[8, 8];

        int counter_click = 1;
        int i1, j1;
        public culoare jucator;

        public Form2(culoare jucator)
        {
            this.jucator = jucator;
            InitializeComponent();
        }

        private void Joc_Load(object sender, EventArgs e)
        {
            sah = new cJocSah();
            sah.AfiseazaConsola();

            AfiseazaTabla();
        }

        private void AfiseazaTabla()
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    tabla[i, j] = new Button();
                    tabla[i, j].Name = i.ToString() + " " + j.ToString();

                    tabla[i, j].Left = distanta + dimensiune * j;

                    if (jucator == culoare.alb)
                    {
                        tabla[i, j].Top = distanta + dimensiune * i;
                    }
                    else
                    {
                        tabla[i, j].Top = distanta + dimensiune * (7 - i);
                    }

                    tabla[i, j].Width = tabla[i, j].Height = dimensiune;
                    tabla[i, j].Font = new Font("Consolas", dimensiune / 2);

                    tabla[i, j].BackColor = (i + j) % 2 == 0 ? Color.Beige : Color.RosyBrown;
                    tabla[i, j].BackgroundImageLayout = ImageLayout.Stretch;

                    if (sah.mTabla[i, j] != null)
                    {
                        tabla[i, j].BackgroundImage =
                           Image.FromFile("Resources\\" + sah.mTabla[i, j].imagine);
                    }
                    tabla[i, j].Click += ClickPeCelula;

                    this.Controls.Add(tabla[i, j]);
                }
            }
        }
        private void ClickPeCelula(object sender, EventArgs e)
        {
            Button celula = sender as Button;

            int i = Convert.ToInt32(celula.Name.Split(' ')[0]);
            int j = Convert.ToInt32(celula.Name.Split(' ')[1]);

            if (counter_click == 1 && sah.mTabla[i, j] == null)
            {
                Console.WriteLine("Nu e piesa");
                return;
            }

            if (counter_click == 1)
            {
                i1 = i;
                j1 = j;
                VeziMutariValide();
            }
            else
            {
                ReseteazaCuloriTabla();
                if (sah.MutareValida(i1, j1, i, j))
                {

                    sah.Muta(i1, j1, i, j);

                    tabla[i1, j1].BackgroundImage = null;
                    tabla[i, j].BackgroundImage = Image.FromFile("Resources\\" + sah.mTabla[i, j].imagine);
                }

            }

            Console.WriteLine("Click:" + counter_click + " la :" + i.ToString() + ","
                + j.ToString());

            counter_click = counter_click == 1 ? 2 : 1;
        }

        private void VeziMutariValide()
        {
            List<(int, int)> mutariPosibile = sah.mTabla[i1, j1].EsteMutareValida(sah, i1, j1);

            foreach (var t in mutariPosibile)
            {
                tabla[t.Item1, t.Item2].BackColor = Color.GreenYellow;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ReseteazaCuloriTabla()
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    tabla[i, j].BackColor = (i + j) % 2 == 0 ? Color.Beige : Color.RosyBrown;
                }
            }
        }
    }
}
