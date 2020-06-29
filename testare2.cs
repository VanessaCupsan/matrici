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
    public partial class testare2 : Form
    {
        int[] t = new int[10];
        int nIntrebare10, nIntrebare11, nIntrebare12,nIntrebare20,nIntrebare21,nIntrebare22,nIntrebare30,nIntrebare31,nIntrebare40,nIntrebare41,nIntrebare42;

        private void button2_Click(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
                t[3] = 1;
            else t[3] = 0;
            tabControl1.SelectTab(3);
        }

        private void intrebare31_Click(object sender, EventArgs e)
        {

        }

        private void intrebare30_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n,m;
            try
            {
                n = Int32.Parse(raspuns20.Text);
                m = Int32.Parse(raspuns21.Text);
            }
            catch
            {
                n = 0;
                m = 0;
            }
            if (n == nIntrebare20 && m >= 0 && m < nIntrebare22)
                t[2] = 1;
            else t[2] = 0;
            tabControl1.SelectTab(2);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int ok1 = 0,ok2=0,ok3=0;
            int n = Int32.Parse(raspuns10.Text);
            int m = Int32.Parse(raspuns11.Text);
            if (nIntrebare10 == 2)
            {
                if (n == 0 && m == 0)
                    ok1 = 1;
                if (n == 0 && m == (nIntrebare12 - 1))
                    ok1 = 1;
                if (n == (nIntrebare11 - 1) && m == 0)
                    ok1 = 1;
                if (n == (nIntrebare11 - 1) && m == (nIntrebare12 - 1))
                    ok1 = 1;
                if (ok1 == 1)
                    t[1] = 1;
                else t[1] = 0;
            }
            if (nIntrebare10 == 3)
            {
                if (n == 0)
                    if (m > 0 && m < (nIntrebare12 - 1))
                        ok2 = 1;
                if (n == (nIntrebare11 - 1))
                    if (m > 0 && m < (nIntrebare12 - 1))
                        ok2 = 1;
                if (m == 0)
                    if (n > 0 && n < (nIntrebare11 - 1))
                        ok2 = 1;
                if (m == nIntrebare12 - 1)
                    if (n > 0 && n < (nIntrebare11 - 1))
                        ok2 = 1;
                if (ok2 == 1)
                    t[1] = 1;
                else t[1] = 0;
            }
            if (nIntrebare10 == 4)
            {
                if (n != 0 && m != 0 && n != (nIntrebare11 - 1) && m != (nIntrebare12 - 1))
                    ok3 = 1;
                if (ok3 == 1)
                    t[1] = 1;
                else t[1] = 0;
            }
            tabControl1.SelectTab(1);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int s = 0;
            for (int i = 1; i <= 9; i++)
                s = s + t[i];
            MessageBox.Show("Ai obtinut nota " + (s + 1).ToString());
        }

        public testare2()
        {
            InitializeComponent();
        }

        private void testare2_Load(object sender, EventArgs e)
        {
            //test
            for (int i = 0; i <= 9; i++)
                t[i] = 0;
            Random r = new Random();
            //generare intrebare 1
            nIntrebare10 = r.Next(2,4);
            nIntrebare11 = r.Next(3, 100);
            nIntrebare12 = r.Next(3, 100);
            intrebare10.Text = " Scrieți un element al tabloului bidimensional a, declarat mai jos, care are exact " + nIntrebare10.ToString() + " vecini.";
            intrebare11.Text = " int a[ " + nIntrebare11.ToString() + " ][ " + nIntrebare12.ToString() + " ] ;";
            //genereare intrebare 2
            nIntrebare20 = r.Next(0, nIntrebare21);
            nIntrebare21 = r.Next(15, 300);
            nIntrebare22 = r.Next(15, 300);
            intrebare2.Text = " Scrieți un element la alegere de pe linia " + nIntrebare20.ToString() + ", a matricei a, declarată mai jos.";
            intrebare21.Text = " int a[ " + nIntrebare21.ToString() + " ][ " + nIntrebare22.ToString() + " ] ;";
            //generare intrebare 3
            nIntrebare30 = r.Next(3, 100);
            nIntrebare31 = r.Next(3, 100);
            intrebare30.Text = " Variabilele i și j sunt de tip întreg, iar variabila m memorează un tabloul bidimensional cu " + nIntrebare30.ToString() + " linii și " + nIntrebare31.ToString() + " coloane, numerotate de la 0, cu elemente numere întregi.";
            intrebare31.Text = " O expresie C++ a cărei valoare este egală cu produsul dintre al treilea element de pe linia i și penultimul de pe coloana j din acest tablou este: ";
            varianta1.Text = " m[ 3 ][ i ] * m[ j ][ " + (nIntrebare31 - 2).ToString() + " ] ;";
            varianta2.Text = " m[ i ][ 3 ] * m[ " + (nIntrebare30 - 2).ToString() + " ][ j ] ;";
            varianta3.Text = " m( 3, i ) * m( j," + (nIntrebare30 - 2).ToString() + " ) ;";
            varianta4.Text = " m( i )( 3 ) * m( " + (nIntrebare31 - 2).ToString() + " )( j ) ;";
            //generare intrebare 4
            nIntrebare40 = r.Next(300, 1000);
            nIntrebare41 = r.Next(3, 100);
            nIntrebare42 = r.Next(3, 100);
            intrebare4.Text = " Scrieți numărul " + nIntrebare40.ToString() + " în căsuța corespunzătoare elementului a[ " + nIntrebare41.ToString() + " ][ " + nIntrebare42.ToString() + " ] a matricei.";
        }
    }
}
