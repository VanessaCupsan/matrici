﻿using System;
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
        int nIntrebare12, nIntrebare30, nIntrebare31, nIntrebare40, nIntrebare41, nIntrebare50, nIntrebare51, nIntrebare52, nIntrebare90,nIntrebare91;
        int[] ok = new int[5];
        private void tabPage9_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (radioButton11.Checked)
                t[9] = 1;
            else t[9] = 0;
        }

        int[,] a = { { 3,5,7,9,11 }, { 5,8,11,14,17}, { 7,11,15,19,23 }, {9,14,19,24,29}, {11,17,23,29,35},{ 13,20,27,34,41} };

        private void button7_Click(object sender, EventArgs e)
        {
            Evaluare ev = new Evaluare();
            if (ev.EvaluareAfisare(codLinie, rtLinie.Text, n, m) == 1) t[7] = 1;
            else t[7] = 0;
            tab.SelectTab(7);
        }
        string codLinie = @"
#include <iostream>
#include <fstream>
using namespace std;
ifstream fin(""test.txt"");
int n, m, a[100][100], i, j, s;
int main()
        {
            fin >> n >> m;
            for (i = 1; i <= n; i++)
                for (j = 1; j <= m; j++)
                    fin >> a[i][j];
            for(i = 1; i<=m; i++)
                cout <<a[$$][i]<<"" "";
            return 0;
        }
            ";
        string codColoana = @"
#include <iostream>
#include <fstream>
using namespace std;
ifstream fin(""test.txt"");
int n, m, a[100][100], i, j, s;
int main()
        {
            fin >> n >> m;
            for (i = 1; i <= n; i++)
                for (j = 1; j <= m; j++)
                    fin >> a[i][j];
            for(i = 1; i<=n; i++)
                cout <<a[i][$$]<<"" "";
            return 0;
        }
            ";
        string codArie = @"
#include <iostream>
#include <fstream>
using namespace std;
ifstream fin(""test.txt"");
int n, m, a[100][100], i, j, s;
int main()
        {
            fin >> n >> m;
            for (i = 1; i <= n; i++)
                for (j = 1; j <= m; j++)
                    fin >> a[i][j];
            for(i = $1; i<=$2; i++)
             {
                for(j=$3;j<=$4;j++)
                    cout <<a[i][j]<<"" "";
                cout<<endl;
             }           
                
            return 0;
        }
            ";

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            Evaluare ev = new Evaluare();
            if (ev.EvaluareAfisare(codColoana, rtColoana.Text, n, m) == 1) t[8] = 1;
            else t[8] = 0;
            tab.SelectTab(8);
        }

        int[,] v;
        int[,] vector;

        private void tabPage8_Click(object sender, EventArgs e)
        {

        }

        int[] vec = new int[5];

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

        private void button10_Click(object sender, EventArgs e)
        {
            Evaluare ev = new Evaluare();
            if (ev.EvaluareAfisare(codArie, rtArie.Text, n, m) == 1) t[9] = 1;
            else t[9] = 0;
            MessageBox.Show(" Felicitări, ai ajuns la finalul testului !");
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            if (radioButton11.Checked)
                t[6] = 1;
            else t[6] = 0;
            tab.SelectTab(6);
        }

        int linie, coloana, linie1, linie2, coloana1, coloana2, n, m;

        private void button4_Click(object sender, EventArgs e)
        {
            int x = 0, nr = 1, nr0 = 0;
            vector = new int[nIntrebare50, nIntrebare51];
            ok = new int[5];
            for (int i = 0; i < nIntrebare50; i++)
                for (int j = 0; j < nIntrebare51; j++)
                    vector[i, j] = i * j + 2;
            for (int y = 2; y < 4; y++)
                for (int z = 1; z < 3; z++)
                {
                    nr = 1;
                    x = vector[z, y];
                    while(x>=10)
                    {
                        x /= 10;
                        nr++;
                    }
                    if(nr==1)
                    {
                        ok[nr0] = vector[z, y];
                        nr0++;
                    }
                }
            if (textBox1.Text == "4,6,5,8")
                t[5] = 1;
            else t[5] = 0;
            tab.SelectTab(5);
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
            nIntrebare50 = r.Next(5, 12);
            nIntrebare51 = r.Next(5, 12);
            nIntrebare52 = r.Next(0, nIntrebare51);
            intrebare50.Text = " Fie matricea a cu " + nIntrebare50.ToString() + " linii și " + nIntrebare51.ToString() + " coloane, numerotate de la 0 și i și j, numere întregi. Scrieți în căsuța de mai jos, separate printr-o virgulă și un spațiu( ca în exemplul de mai jos ), elementele ce vor fi afișate în urma rulării algoritmului următor.";
            rEx5t3.LoadFile("ex5t3.rtf");
            //generare intrebare 7,8,9
            n = r.Next(3, 98);
            m = r.Next(3, 98);
            linie = r.Next(1, n);
            linie1 = r.Next(1, n-1);
            linie2 = r.Next(linie1, n);
            coloana = r.Next(1, m);
            coloana1 = r.Next(1, m-1);
            coloana2 = r.Next(coloana1, m);
            string comun = @"Ai o matrice a cu " + n.ToString() + " linii și " + m.ToString() + " coloane numerotate de la 1 și variabilele i și j declarate. Scrie o secvență de program care ";
            string comun2 = @"Scrie codul în căsuța de mai jos, fără a folosi alte variabile decât cele prezentate, apoi apasă butonul Raspunde.";
            cerLinie.Text = comun + "afișează elementele de pe linia " + linie.ToString() + ", separate prin câte un spațiu. " + comun2;
            cerColoana.Text = comun + "afișează elementele de pe coloana " + coloana.ToString() + ", separate prin câte un spațiu. " + comun2;
            cerArie.Text = comun + " afișează elementele din zona cuprinsă între linia " + linie1.ToString() + " și linia " + linie2.ToString() + ", respectiv coloana " + coloana1.ToString() + " și coloana " + coloana2.ToString() + ".";
            codLinie = codLinie.Replace("$$", linie.ToString());
            codColoana = codColoana.Replace("$$", coloana.ToString());
            codArie = codArie.Replace("$1", linie1.ToString());
            codArie = codArie.Replace("$2", linie2.ToString());
            codArie = codArie.Replace("$3", coloana1.ToString());
            codArie = codArie.Replace("$4", coloana2.ToString());
            //generare intrebare 6
            nIntrebare90 = r.Next(5, 100);
            nIntrebare91 = r.Next(5, 100);
            intrebare9.Text = " Se dă matricea a cu n=" + nIntrebare90.ToString() + " linii și m=" + nIntrebare91.ToString() + " coloane, numerotate de la 0. Care este rolul bucății de cod următoare ?";
            rEx9.LoadFile("ex9t3.rtf");

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
