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
        int[] t = new int[10];
        int nIntrebare2,nIntrebare21,nIntrebare3;
        public testare1()
        {
            InitializeComponent();
        }

        private void testare1_Load(object sender, EventArgs e)
        {
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

        private void intrebare3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
