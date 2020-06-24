using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace matrici
{
    public partial class testare1 : Form
    {
        TextBox[,] a;
        int oriz = 15, vert = 115, latura = 24, pas = 24;
        int[] t = new int[10];
        int nIntrebare2,nIntrebare21,nIntrebare3,nIntrebare4;
        public testare1()
        {
            InitializeComponent();
        }

        private void testare1_Load(object sender, EventArgs e)
        {
            //generare matrice
            a = new TextBox[12, 12];
            for (int i = 0; i <= 10; i++)
                for (int j = 0; j <= 10; j++)
                {
                    a[i, j] = new TextBox();
                    tabPage4.Controls.Add(a[i, j]);
                    a[i, j].Left = oriz + j * pas;
                    a[i, j].Top = vert + i * pas;
                    a[i, j].Width = latura;
                    a[i, j].Height = 2 * latura;
                    if (i == 0) { a[i, j].BackColor = Color.Red; a[i, j].Text = (j - 1).ToString(); a[i, j].ReadOnly = true; }
                    if (j == 0) { a[i, j].BackColor = Color.Yellow; a[i, j].Text = (i - 1).ToString(); a[i, j].ReadOnly = true; }
                    a[i, j].Visible = false;
                }
            //test
            for (int i = 0; i <= 9; i++)
                t[i] = 0;
            Random r = new Random();
            //generez intrebarea 2
            nIntrebare2 = r.Next(3, 300);
            nIntrebare21 = r.Next(3, 300);
            intrebare2.Text = " Câte elemente cu exact 4 vecini există în matricea a[ "+nIntrebare2.ToString()+" ][ "+nIntrebare21.ToString()+" ] ?";
            //generez intrebarea 3
            nIntrebare3 = r.Next(3, 50);
            intrebare3.Text = " Cum se poate nota o matrice oarecare cu exact " + (nIntrebare3 * 10).ToString() + " de elemente numere întregi?";
            //genrez intrebarea 4
            nIntrebare4 = r.Next(3, 10);
            intrebare4.Text = " Construiți, folosind instrumentul de mai jos, un tablou bidimensioanl oarecare cu " + (nIntrebare4 * 10).ToString() + " elemente.";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int s = 0;
            for (int i = 1; i <= 9; i++)
                s = s + t[i];
            MessageBox.Show("Ai obtinut nota " + (s + 1).ToString());
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (radioButton4.Checked)
                t[1] = 1;
            else t[1] = 0;
            tabControl1.SelectTab(1);
        }

        private void nrLinii4_ValueChanged(object sender, EventArgs e)
        {
            for (int i = 0; i <= 10; i++)
                for (int j = 0; j <= 10; j++)
                {
                    a[0, 0].Visible = false;
                    a[i, j].Visible = (i <= nrLinii4.Value && j <= nrColoane4.Value);
                }
        }

        private void nrColoane4_ValueChanged(object sender, EventArgs e)
        {
            for (int i = 0; i <= 10; i++)
                for (int j = 0; j <= 10; j++)
                {
                    a[0, 0].Visible = false;
                    a[i, j].Visible = (i <= nrLinii4.Value && j <= nrColoane4.Value);
                }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i <= 10; i++)
                for (int j = 0; j <= 10; j++)
                {
                    a[0, 0].Visible = false;
                    a[i, j].Visible = (i <= nrLinii4.Value && j <= nrColoane4.Value);
                }
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (radioButton5.Checked)
                t[5] = 1;
            else t[5] = 0;
            tabControl1.SelectTab(5);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if ((nrLinii4.Value) * (nrColoane4.Value) == nIntrebare4 * 10)
                t[4] = 1;
            else t[4] = 0;
            tabControl1.SelectTab(4);
        }

        private void tabPage6_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //evaluare raspuns
            if (checkBox1.Checked && checkBox3.Checked && checkBox5.Checked && checkBox8.Checked && checkBox12.Checked)
                t[6] = 1;
            else t[6] = 0;
            tabControl1.SelectTab(6);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //evaluare raspuns
            int nrElemente;
            try
            {
                nrElemente = Int32.Parse(raspuns1.Text);
            }
            catch
            {
                nrElemente = 0;
            }
            if (nrElemente ==(nIntrebare2-2)*(nIntrebare21-2))
                t[2] = 1;
            else t[2] = 0;
            tabControl1.SelectTab(2);
        }

        private void tabPage9_Click(object sender, EventArgs e)
        {

        }

        private void raspuns3_Click(object sender, EventArgs e)
        {
            //evaluare raspuns
            int linie, coloana;
            try
            {
                linie = Int32.Parse(nrLinii.Text); coloana = Int32.Parse(nrColoane.Text);
            }
            catch
            {
                linie = coloana = 0;
            }
            if (linie*coloana == nIntrebare3*10)
                t[3] = 1;
            else t[3] = 0;
            tabControl1.SelectTab(3);
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void intrebare3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
