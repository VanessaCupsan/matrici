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
    public partial class testare3 : Form
    {
        int[] t = new int[10];
        bool[] r = { false, false, false, false, false, false, false, false, false, false };
        int nIntrebare12,nIntrebare30,nIntrebare31,nIntrebare40,nIntrebare41,nIntrebare50,nIntrebare51,nIntrebare52;
        int[,] a = { { 3,5,7,9,11 }, { 5,8,11,14,17}, { 7,11,15,19,23 }, {9,14,19,24,29}, {11,17,23,29,35},{ 13,20,27,34,41} };
        int[,] v;

        private void evaluare_Click(object sender, EventArgs e)
        {
            int s = 0;
            for (int i = 1; i <= 9; i++)
                s = s + t[i];
            MessageBox.Show("Ai obtinut nota " + (s + 1).ToString());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (Int32.Parse(raspuns10.Text) == a[nIntrebare12 - 1, 0] && Int32.Parse(raspuns12.Text) == a[nIntrebare12 - 1, 1] && Int32.Parse(raspuns13.Text) == a[nIntrebare12 - 1, 2] && Int32.Parse(raspuns14.Text) == a[nIntrebare12 - 1, 3] && Int32.Parse(raspuns15.Text) == a[nIntrebare12 - 1, 4])
                t[1] = 1;
            else t[1] = 0;
            tab.SelectTab(1);
        }

        public testare3()
        {
            InitializeComponent();
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (radioButton6.Checked)
                t[4] = 1;
            else t[4] = 0;
            tab.SelectTab(4);
        }

        private void testare3_Load(object sender, EventArgs e)
        {
            //test
            for (int i = 0; i <= 9; i++)
                t[i] = 0;
            Random r = new Random();
            //generare intrebare 1
            nIntrebare12 = r.Next(1, 6);
            intrebare10.Text = " Matricea v are 6 linii și 5 coloane.";
            intrebare11.Text = " Scrieți, în ordine, în fiecare căsuță, elementele situate pe cea de a " + nIntrebare12.ToString() + "-a linie a matricei.";
            intrebare12.Text = " Elementele de pe linia " + nIntrebare12.ToString() + " sunt următoarele.";
            rIntrebare1.LoadFile("intrebare 1.rtf");
            //generare intrebare 2
            rEx20.LoadFile("ex20t3.rtf");
            rEx21.LoadFile("ex21t3.rtf");
            rEx22.LoadFile("ex22t3.rtf");
            rEx23.LoadFile("ex23t3.rtf");
            //generare intrebarea 3
            nIntrebare30 = r.Next(3, 9);
            nIntrebare31 = r.Next(3, 9);
            intrebare30.Text = " Fie matricea a cu " + nIntrebare30.ToString() + " linii și " + nIntrebare31.ToString() + " coloane.Algoritmul de mai jos generează elementele tabloului bidimensional a. Scrieți suma elementelor impare aflate în interiorul matricei.";
            intrebare31.Text = " for( i=0 ; i<" + nIntrebare30.ToString() + " ; i++ )";
            intrebare32.Text = " for( j=0 ; j<" + nIntrebare31.ToString() + " ; j++ )";
            //genrare intrebare 4
            nIntrebare40 = r.Next(3, 15);
            nIntrebare41 = r.Next(3, 15);
            intrebare40.Text = " În secvența de mai jos, variabila a memorează un tablou bidimensional cu n=" + nIntrebare40.ToString() + " linii și m=" + nIntrebare40.ToString() + " coloane, numerotate de la 1, cu elemente reale.Variabila s este reală, iar i este de tip întreg.";
            rEx40.LoadFile("ex40t3.rtf");
            rEx41.LoadFile("ex41t3.rtf");
            rEx42.LoadFile("ex42t3.rtf");
            rEx43.LoadFile("ex43t3.rtf");
            rEx4.LoadFile("ex4t3.rtf");
            //gnerare intrebarea 5

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int s = 0;
            v = new int[nIntrebare30, nIntrebare31];
            for (int i = 0; i < nIntrebare30; i++)
                for (int j = 0; j < nIntrebare31; j++)
                    v[i, j] = 5*i-j;
            for (int i = 1; i < (nIntrebare30 - 1); i++)
                for (int j = 1; j < (nIntrebare31 - 1); j++)
                    if (v[i, j] % 2 == 1)
                        s += v[i, j];
            if (Int32.Parse(raspuns30.Text) == s)
                t[3] = 1;
            else t[3] = 0;
            tab.SelectTab(3);
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton4.Checked)
                t[2] = 1;
            else t[2] = 0;
            tab.SelectTab(2);
        }
    }
}
