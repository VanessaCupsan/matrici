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
    public partial class exersare4 : Form
    {
        int nExercitiul10,nExercitiul2,nExercitiul3,nExercitiul4;
        int[,] a;
        int n;
        public exersare4()
        {
            InitializeComponent();
        }

        private void exersare4_Load(object sender, EventArgs e)
        {
            Random r = new Random();
            //generare exercitiul 1
            nExercitiul10 = r.Next(3, 100);
            exercitiul1.Text = " Se dă tabloul bidimensioanl a, cu " + nExercitiul10.ToString() + " linii și " + nExercitiul10.ToString() + " coloane indexate de la 1. Știind că notăm cu a[i][j] elementul aflat pe linia i și coloana j, care este valoarea expresiei i-j dacă a[i][j] se află pe diagonala principală a matricei ?";
            //generare exercitiul 2
            nExercitiul2 = r.Next(3, 100);
            exercitiul2.Text = " Fiind dat un tablou bidimensional cu n="+nExercitiul2.ToString()+" linii și n="+nExercitiul2.ToString()+" coloane, câte elemente se găsesc strict deasupra diagonalei secundare ?";
            exercitiul20.Text = " a)" + (nExercitiul2 * (nExercitiul2 - 1) / 2).ToString();
            exercitiul21.Text = " b)" + (nExercitiul2 * (nExercitiul2 - 1) / 2 + nExercitiul2).ToString();
            exercitiul22.Text=" c)"+ (nExercitiul2 * nExercitiul2  / 2).ToString();
            exercitiul23.Text=" d)"+ (nExercitiul2 * nExercitiul2 / 2-nExercitiul2).ToString();
            //generare exercitiul 3
            nExercitiul3 = r.Next(3, 10);
            exercitiul3.Text = " Care este ultima cifră a produsului numerelor aflate sub diagonala secundară (exclusiv diagonala secundară), în cazul unui tabel bidimensional cu " + nExercitiul3.ToString() + " linii și " + nExercitiul3.ToString() + " coloane generat după aceeași regulă ?";
            //generare exercitiul 4
            nExercitiul4 = r.Next(3, 6);
            exercitiul4.Text = " În secvența de mai jos, variabila a memorează elementele unui tablou bidimensional cu n=" + nExercitiul4.ToString() + " linii și n=" + nExercitiul4.ToString() + " coloane, indexate de la 0, iar toate celelalte variabile sunt de tip întreg.";
            rEx4.LoadFile("ex4exersare4.rtf");
            //generare exercitiul 5
            n = r.Next(3, 98);
            string comun = @"Ai o matrice a cu " + n.ToString() + " linii și " + n.ToString() + " coloane numerotate de la 1 și variabilele i și j declarate. Scrie o secvență de program care ";
            string comun2 = @"Scrie codul în căsuța de mai jos, fără a folosi alte variabile decât cele prezentate, apoi apasă butonul evaluare.";
            cerDeasupraDiagP.Text = comun + "afișează elementele aflate strict deasupra diagonalei principale, separate prin câte un spațiu. " + comun2;
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            Evaluare2 ev = new Evaluare2();
            if (ev.EvaluareAfisare(codDiagP, rtDiagP.Text, n) == 1) MessageBox.Show("Corect");
            else MessageBox.Show("Incorect");
        }
        string codDiagP = @"
#include <iostream>
#include <fstream>
using namespace std;
ifstream fin(""test.txt"");
int n, a[100][100], i, j, s;
int main()
        {
            fin >> n;
            for (i = 1; i <= n; i++)
                for (j = 1; j <= n; j++)
                    fin >> a[i][j];
            for(i = 1; i<=n; i++)
                for(j= i+1; j<= n; j++)
                cout <<a[i][j]<<"" "";
            return 0;
        }
            ";

        private void button4_Click(object sender, EventArgs e)
        {
            a = new int[nExercitiul4, nExercitiul4];
            int i, j, x=1, s = 0;
            for(i=0;i<nExercitiul4;i++)
                for(j=0;j<nExercitiul4;j++)
                {
                    if (i == j)
                    {
                        a[i, j] = 2 * x;
                        s += a[i, j];

                    }
                    else a[i, j] = x;
                    x++;
                }
            if (Int32.Parse(raspunsEx4.Text) == s)
                MessageBox.Show(" Răspuns corect.");
            else MessageBox.Show(" Răspunsul corect este " + s.ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Int32.Parse(raspunsEx3.Text) == 0)
                MessageBox.Show(" Răspuns corect.");
            else MessageBox.Show(" Răspunsul corect este 0, deoarece va exista mereu un multiplu de 2 și un multiplu de 5 printre elementele aflate sub diagonala secundară.");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
                MessageBox.Show(" Răspuns corect.");
            else MessageBox.Show(" Răspunsul corect este a, iar ecuația care rezolvă problema este : n*(n-1)/2, unde n este numărul de linii/coloane.");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Int32.Parse(raspuns1.Text) == 0)
                MessageBox.Show(" Răspuns corect.");
            else MessageBox.Show(" Întrucât elementul a[i][j] se află pe diagonala principală, i=j. De aceea, valoarea expresiei i-j este 0.");
        }
    }
}
