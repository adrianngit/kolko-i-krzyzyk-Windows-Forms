using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gra_kółko_i_krzyżyk
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bool gracz1 = true;
        int ruch = 0;

        private void btnRestartuj_Click(object sender, EventArgs e)
        {
            Restartuj();
            wynikO.Text = "0";
            wynikX.Text = "0";
            lblkto.Text = "0";
            gracz1 = true;
        }

        private void Restartuj()
        {
            ruch = 0;
            Button[] all = new Button[9];
            all[0] = bnt1;
            all[1] = bnt2;
            all[2] = bnt3;
            all[3] = bnt4;
            all[4] = bnt5;
            all[5] = bnt6;
            all[6] = bnt7;
            all[7] = bnt8;
            all[8] = bnt9;
            foreach(Button b in all)
            {
                b.Enabled = true;
                b.Text = "";
            }
        }

        private void bnt1_Click(object sender, EventArgs e)
        {
            ruch++;
            ((Button)sender).Text = gracz1 ? "O" : "X";
            ((Button)sender).Enabled = false;
            if(ruch >= 5)
            {
                Sprawdz();
            }
            gracz1 = !gracz1;
            lblkto.Text = gracz1 ? "O" : "X";
        }


        private void bnt2_Click(object sender, EventArgs e)
        {
            ruch++;
            ((Button)sender).Text = gracz1 ? "O" : "X";
            ((Button)sender).Enabled = false;
            if (ruch >= 5)
            {
                Sprawdz();
            }
            gracz1 = !gracz1;
            lblkto.Text = gracz1 ? "O" : "X";
        }

        private void bnt3_Click(object sender, EventArgs e)
        {
            ruch++;
            ((Button)sender).Text = gracz1 ? "O" : "X";
            ((Button)sender).Enabled = false;
            if (ruch >= 5)
            {
                Sprawdz();
            }
            gracz1 = !gracz1;
            lblkto.Text = gracz1 ? "O" : "X";
        }

        private void bnt4_Click(object sender, EventArgs e)
        {
            ruch++;
            ((Button)sender).Text = gracz1 ? "O" : "X";
            ((Button)sender).Enabled = false;
            if (ruch >= 5)
            {
                Sprawdz();
            }
            gracz1 = !gracz1;
            lblkto.Text = gracz1 ? "O" : "X";
        }

        private void bnt5_Click(object sender, EventArgs e)
        {
            ruch++;
            ((Button)sender).Text = gracz1 ? "O" : "X";
            ((Button)sender).Enabled = false;
            if (ruch >= 5)
            {
                Sprawdz();
            }
            gracz1 = !gracz1;
            lblkto.Text = gracz1 ? "O" : "X";
        }

        private void bnt6_Click(object sender, EventArgs e)
        {
            ruch++;
            ((Button)sender).Text = gracz1 ? "O" : "X";
            ((Button)sender).Enabled = false;
            if (ruch >= 5)
            {
                Sprawdz();
            }
            gracz1 = !gracz1;
            lblkto.Text = gracz1 ? "O" : "X";
        }

        private void bnt7_Click(object sender, EventArgs e)
        {
            ruch++;
            ((Button)sender).Text = gracz1 ? "O" : "X";
            ((Button)sender).Enabled = false;
            if (ruch >= 5)
            {
                Sprawdz();
            }
            gracz1 = !gracz1;
            lblkto.Text = gracz1 ? "O" : "X";
        }

        private void bnt8_Click(object sender, EventArgs e)
        {
            ruch++;
            ((Button)sender).Text = gracz1 ? "O" : "X";
            ((Button)sender).Enabled = false;
            if (ruch >= 5)
            {
                Sprawdz();
            }
            gracz1 = !gracz1;
            lblkto.Text = gracz1 ? "O" : "X";
        }

        private void bnt9_Click(object sender, EventArgs e)
        {
            ruch++;
            ((Button)sender).Text = gracz1 ? "O" : "X";
            ((Button)sender).Enabled = false;
            if (ruch >= 5)
            {
                Sprawdz();
            }
            gracz1 = !gracz1;
            lblkto.Text = gracz1 ? "O" : "X";
        }
        private void Sprawdz()
        {
            if(bnt1.Text != "" && bnt1.Text == bnt2.Text && bnt2.Text == bnt3.Text)
            {
                wygrana();
            }
            else if (bnt4.Text != "" && bnt4.Text == bnt5.Text && bnt5.Text == bnt6.Text)
            {
                wygrana();
            }
            else if (bnt7.Text != "" && bnt7.Text == bnt8.Text && bnt8.Text == bnt9.Text)
            {
                wygrana();
            }
            else if (bnt1.Text != "" && bnt1.Text == bnt4.Text && bnt4.Text == bnt7.Text)
            {
                wygrana();
            }
            else if (bnt2.Text != "" && bnt2.Text == bnt5.Text && bnt5.Text == bnt8.Text)
            {
                wygrana();
            }
            else if (bnt3.Text != "" && bnt3.Text == bnt6.Text && bnt6.Text == bnt9.Text)
            {
                wygrana();
            }
            else if (bnt1.Text != "" && bnt1.Text == bnt5.Text && bnt5.Text == bnt9.Text)
            {
                wygrana();
            }
            else if (bnt3.Text != "" && bnt3.Text == bnt5.Text && bnt5.Text == bnt7.Text)
            {
                wygrana();
            }
            else if(ruch == 9)
            {
                MessageBox.Show("Remis", "Koniec gry", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Restartuj();
            }
        }

        private void wygrana()
        {
            MessageBox.Show("Wygrywa gracz: " + (gracz1 ? "O" : "X"), "Wygrana", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            if (gracz1)
            {
                wynikO.Text = ((int.Parse(wynikO.Text)) + 1).ToString();
            }
            else
            {
                wynikX.Text = ((int.Parse(wynikX.Text)) + 1).ToString();
            }
            Restartuj();
        }
    }
}
