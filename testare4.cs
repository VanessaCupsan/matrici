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
    public partial class testare4 : Form
    {
        int nExercitiul5,nIntrebare1,nIntrebare2,nIntrebare3,nIntrebare4,nIntrebare6;
        int[] t = new int[10];
        int[,] a;
        int[,] v;
        int n,m,p;
        public testare4()
        {
            InitializeComponent();
        }

        private void testare4_Load(object sender, EventArgs e)
        {
            //test
            for (int i = 0; i <= 9; i++)
                t[i] = 0;
            Random r = new Random();
            //generare intrebarea 5
            nExercitiul5 = r.Next(3, 100);
            exercitiul5.Text = " În secvența de program următoare, variabila t memorează o matrice cu n=" + nExercitiul5.ToString() + " linii și n=" + nExercitiul5.ToString() + " coloane, numerotate de la 0 la " + (nExercitiul5 - 1).ToString() + ", cu elemente numere întregi, iar celelalte variabile sunt întregi.";
            rEx5.LoadFile("ex5exersare4.rtf");
            //generare intrebare 1
            nIntrebare1 = r.Next(3, 50);
            intrebare1.Text=" Se dă tabloul bidimensional a cu "+nIntrebare1.ToString()+ " linii și "+nIntrebare1.ToString()+ " coloane, indexate de la 1. Știind că notăm cu a[i][j] elementul aflat pe linia i și coloana j, care este valoarea expresiei i+j dacă a[i][j] se află pe diagonala secundară a matricei ?";
            //generare intrebare 2
            nIntrebare2 = r.Next(3, 20);
            intrebarea2.Text=" Fiind dat un tablou bidimensional cu n="+nIntrebare2.ToString()+ " linii și n="+nIntrebare2.ToString()+ " coloane, câte elemente se găsesc sub diagonala principală (inclusiv aceasta) ?";
            intrebarea21.Text= " a) "+(nIntrebare2*nIntrebare2/2).ToString();
            intrebarea22.Text= " b) " + (((nIntrebare2-1)* nIntrebare2)/2).ToString();
            intrebarea23.Text= " c) " + (((nIntrebare2 - 1) * nIntrebare2) / 2+6).ToString();
            intrebarea24.Text= " d) " + ((((nIntrebare2 - 1) * nIntrebare2) / 2)+nIntrebare2).ToString();
            //generare intrebare 3
            nIntrebare3 = r.Next(3, 6);
            intrebarea3.Text=" Fie o matrice a cu "+nIntrebare3.ToString()+ " linii și "+nIntrebare3.ToString()+ " coloane indexate de la 0. Pentru fiecare element a[i][j] expresia a[i][j]=2*(i+10)-j este nenula. Aflați suma elementelor de pe diagonala secundară .";
            //generare intrebare 4
            rIntrebare4.LoadFile("intrebare4.rtf");
            nIntrebare4 = r.Next(3, 6);
            intrebarea4.Text = " În secvența de mai jos, variabila a memorează un tablou bidimensional cu " + nIntrebare4.ToString() + " linii și " + nIntrebare4.ToString() + " coloane, indexate de la 0, iar toate celelalte variabile sunt de tip întreg.";
            //generare intrebare 6
            nIntrebare6 = r.Next(20, 30);
            intrebare6.Text = " Variabila a memorează elementele unui tablou bidimensional cu " + nIntrebare6.ToString() + " linii și " + nIntrebare6.ToString() + " coloane, numerotate începând cu 1. Un element aflat pe diagonala secundară a tabloului poate fi accesat prin :";
            intrebare61.Text = " a) a[ " + (nIntrebare6-1).ToString() + " ][ 0 ]";
            intrebare62.Text= " b) a[ " + (nIntrebare6 - 17).ToString() + " ][ 18 ]";
            intrebare63.Text= " c) a[ 1 ][ 0 ]";
            intrebare64.Text= " d) a[ " + (nIntrebare6 - 1).ToString() + " ][ "+nIntrebare6.ToString()+" ]";
            //generare intrebare 7
            n = r.Next(3, 98);
            string comun = @"Ai o matrice a cu n=" + n.ToString() + " linii și n=" + n.ToString() + " coloane numerotate de la 1 și variabilele i și j declarate. Scrie o secvență de program care ";
            string comun2 = @"Scrie codul în căsuța de mai jos, fără a folosi alte variabile decât cele prezentate, apoi apasă butonul răspunde.";
            cerDiagSec.Text = comun + "afișează elementele aflate pe diagonala secundară, separate prin câte un spațiu. " + comun2;
            //generare intrebare 8
            m = r.Next(3, 98);
            string comun1 = @"Ai o matrice a cu n=" + m.ToString() + " linii și n=" + m.ToString() + " coloane numerotate de la 1 și variabilele i și j declarate. Scrie o secvență de program care ";
            string comun3 = @"Scrie codul în căsuța de mai jos, fără a folosi alte variabile decât cele prezentate, apoi apasă butonul răspunde.";
            cerSubDiagP.Text = comun1 + "afișează elementele aflate sub diagonala principală, separate prin câte un spațiu. " + comun3;
            //generare intrebarea 9
            p = r.Next(3, 98);
            string comun5 = @"Ai o matrice a cu n=" + p.ToString() + " linii și n=" + p.ToString() + " coloane numerotate de la 1 și variabilele i și j declarate. Scrie o secvență de program care ";
            string comun7 = @"Scrie codul în căsuța de mai jos, fără a folosi alte variabile decât cele prezentate, apoi apasă butonul răspunde.";
            cerZonaV.Text = comun5 + "afișează elementele aflate în zona de Vest a matricei, separate prin câte un spațiu. " + comun7;
        }



        private void evaluare_Click(object sender, EventArgs e)
        {
            int s = 0;
            for (int i = 1; i <= 9; i++)
                s = s + t[i];
            MessageBox.Show("Ai obtinut nota " + (s + 1).ToString());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (radioButton12.Checked)
                t[6] = 1;
            else t[6] = 0;
            tabControl1.SelectTab(6);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Evaluare ev = new Evaluare();
            if (ev.EvaluareAfisare(codDiagS, rtDiagS.Text, n,n) == 1) t[7] = 1 ;
            else t[7]=0;
            tabControl1.SelectTab(7);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Evaluare ev = new Evaluare();
            if (ev.EvaluareAfisare(codSubDiagP, rtSubDiagP.Text, m,m) == 1) t[8] = 1;
            else t[8] = 0;
            tabControl1.SelectTab(8);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Evaluare ev = new Evaluare();
            if (ev.EvaluareAfisare(codZonaV, rtZonaV.Text, p,p) == 1) t[9] = 1;
            else t[9] = 0;
            MessageBox.Show(" Felicitări! Ai ajuns la sfârșitul testului.");
        }

        string codDiagS = @"
#include <iostream>
#include <fstream>
using namespace std;
ifstream fin(""test.txt"");
int n, a[100][100], i, j, s,m;
int main()
        {
            fin >> n>>m;
            for (i = 1; i <= n; i++)
                for (j = 1; j <= n; j++)
                    fin >> a[i][j];
            for(i = 1; i<=n; i++)
                cout <<a[i][n-i+1]<<"" "";
            return 0;
        }
            ";

        private void button10_Click(object sender, EventArgs e)
        {
            int x;
            try
            {
                x = Int32.Parse(raspuns1.Text);
            }
            catch
            {
                x = 0;
            }
            if (x == nIntrebare1 + 1)
                t[1] = 1;
            else t[1] = 0;
            tabControl1.SelectTab(1);
        }

        string codSubDiagP = @"
#include <iostream>
#include <fstream>
using namespace std;
ifstream fin(""test.txt"");
int n, a[100][100], i, j, s,m;
int main()
        {
            fin >> n>>m;
            for (i = 1; i <= n; i++)
                for (j = 1; j <= n; j++)
                    fin >> a[i][j];
            for(i = 1; i<=n; i++)
                for(j=1;j<=n;j++)
                    if(i>j)
                        cout <<a[i][j]<<"" "";
            return 0;
        }
            ";
        string codZonaV = @"
#include <iostream>
#include <fstream>
using namespace std;
ifstream fin(""test.txt"");
int n, a[100][100], i, j, s,m;
int main()
        {
            fin >> n>>m;
            for (i = 1; i <= n; i++)
                for (j = 1; j <= n; j++)
                    fin >> a[i][j];
            for(i = 1; i<=n; i++)
                for(j=1;j<=n;j++)
                    if(i>j && i+j<=n)
                        cout <<a[i][j]<<"" "";
            return 0;
        }
            ";

        private void button3_Click(object sender, EventArgs e)
        {
            int x;
            try
            {
                x = Int32.Parse(raspuns4.Text);
            }
            catch
            {
                x = 0;
            }
            v = new int[nIntrebare4, nIntrebare4];
            int i, j,suma=0;
            for(i=0;i<nIntrebare4;i++)
                for(j=0;j<nIntrebare4;j++)
                {
                    if(i<j && (i+j)<(nIntrebare4-1))
                    {
                        v[i, j] = 1;
                        suma=suma+v[i,j];
                    }
                }
            if (x == suma)
                t[4] = 1;
            else t[4] = 0;
            tabControl1.SelectTab(4);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            int x;
            try
            {
                x = Int32.Parse(raspuns3.Text);
            }
            catch
            {
                x = -20;
            }
            a = new int[nIntrebare3, nIntrebare3];
            int i, j, s = 0;
            for (i = 0; i < nIntrebare3; i++)
                for (j = 0; j < nIntrebare3; j++)
                    a[i, j] = 2 * (i + 10) - j;
            for (i = 0; i < nIntrebare3; i++)
                s += a[i,nIntrebare3 - i-1];
            if (x == s)
                t[3] = 1;
            else t[3] = 0;
           tabControl1.SelectTab(3);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
                t[2] = 1;
            else t[2] = 0;
            tabControl1.SelectTab(2);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Int32.Parse(raspuns1.Text) == nIntrebare1 + 1)
                t[1] = 1;
            else t[1] = 0;
            tabControl1.SelectTab(1);
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            if (radioButton8.Checked)
                t[5] = 1;
            else t[5] = 0;
            tabControl1.SelectTab(5);
        }
    }
}
