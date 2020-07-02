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
    public partial class exersare3 : Form
    {
        int[,] a = { { 3, 2, 1, 0 }, { 6, 5, 4, 3 }, { 9, 8, 7, 6 } };
        int nIntrebare1,nIntrebare30,nIntrebare31,nIntrebare40,nIntrebare41;
        int[,] v;
        private void button3_Click(object sender, EventArgs e)
        {
            int s=0;
            v = new int[nIntrebare30, nIntrebare31];
            for (int i = 0; i < nIntrebare30; i++)
                for (int j = 0; j < nIntrebare31; j++)
                    v[i, j] = i + j - 1;
            for(int m=0;m<nIntrebare31;m++)
                s += v[0, m]+v[nIntrebare30-1,m];
            for (int n = 0; n < nIntrebare30; n++)
                s += v[n, 0] + v[n, nIntrebare31 - 1];
            if (Int32.Parse(raspuns30.Text) == s)
                MessageBox.Show(" Răspuns corect.");
            else MessageBox.Show(" Răspunsul corect este " + s.ToString() + ".");
        }

        public exersare3()
        {
            InitializeComponent();
        }

        private void exersare3_Load(object sender, EventArgs e)
        {
            Random r = new Random();
            //genrare intrebare 1
            nIntrebare1 = r.Next(1, 4);
            intrebare10.Text = " Matricea v are 3 linii și 4 coloane.";
            intrebare11.Text = " Scrieți, în ordine, în fiecare căsuță, un element situat pe cea de a " + nIntrebare1.ToString() + "-a coloană a matricei.";
            rEx1.LoadFile("ex1.rtf");
            intrebare12.Text = " Elementele de pe coloana " + nIntrebare1.ToString() + " sunt următoarele :";
            //generare intrebare 2
            rEx20.LoadFile("ex20.rtf");
            rEx21.LoadFile("ex21.rtf");
            rEx22.LoadFile("ex22.rtf");
            rEx23.LoadFile("ex23.rtf");
            //generare intrebare 3
            nIntrebare30 = r.Next(3, 9);
            nIntrebare31 = r.Next(3, 9);
            intrebare30.Text = " Fie matricea a cu " + nIntrebare30.ToString() + " linii și " + nIntrebare31.ToString() + " coloane.Algoritmul de mai jos generează elementele tabloului bidimensional a. Scrieți suma elementelor aflate pe conturul matricei.";
            intrebare31.Text = " for( i=0 ; i<" + nIntrebare30.ToString() + " ; i++ )";
            intrebare32.Text = " for( j=0 ; j<" + nIntrebare31.ToString() + " ; j++ )";
            //generare intrebare 4
            nIntrebare40 = r.Next(3, 15);
            nIntrebare41 = r.Next(3, 15);
            intrebare40.Text = " În secvența de mai jos, variabila a memorează un tablou bidimensional cu " + nIntrebare40.ToString() + " linii și " + nIntrebare40.ToString() + " coloane, numerotate de la 1, cu elemente reale.Variabila p este reală, iar i este de tip întreg.";
            rEx4.LoadFile("ex4.rtf");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Int32.Parse(raspuns10.Text) == a[0, nIntrebare1-1] && Int32.Parse(raspuns11.Text) == a[1, nIntrebare1-1] && Int32.Parse(raspuns12.Text) == a[2, nIntrebare1-1])
                MessageBox.Show(" Răspuns corect.");
            else MessageBox.Show(" Elementele de pe coloana " + nIntrebare1.ToString() + " sunt :" + a[0, nIntrebare1-1].ToString() + ", " + a[1, nIntrebare1-1].ToString() + " și " + a[2, nIntrebare1-1].ToString());
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton5.Checked)
                MessageBox.Show(" Răspuns corect.");
            else MessageBox.Show(" Răspunsul corect este c, deoarece sunt hașurate liniile 1, 2 și 3 și coloanele 3, 4, 5, 6.");
        }
    }
}
