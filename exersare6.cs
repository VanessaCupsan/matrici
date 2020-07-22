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
    public partial class exersare6 : Form
    {
        int nExercitiul10, nExercitiul11,nExercitiul40,nExercitiul41,nExercitiul50,nExercitiul51;
        public exersare6()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int a, b, c, d, x, f, g, h, i, j, k,l;
            try
            {
                a = Int32.Parse(rt11.Text);
                b = Int32.Parse(rt12.Text);
                c = Int32.Parse(rt13.Text);
                d = Int32.Parse(rt14.Text);
                x = Int32.Parse(rt21.Text);
                f = Int32.Parse(rt22.Text);
                g = Int32.Parse(rt23.Text);
                h = Int32.Parse(rt24.Text);
                i = Int32.Parse(rt31.Text);
                j = Int32.Parse(rt32.Text);
                k = Int32.Parse(rt33.Text);
                l = Int32.Parse(rt34.Text);
            }
            catch
            {
                a = b = c = d = x = f = g = h = i = k = l =j= 0;
            }
            if (a == 2 && b == 9 && c == 18 && d == 21 && x == 7 && f == 15 && g == 32 && h == 41 && i == 11 && j == 28 && k == 47 && l == 63)
                MessageBox.Show(" Răspuns corect.");
            else MessageBox.Show(" Răspuns incorect. Regula este: s[i][j]=s[i-1][j]+s[i][j-1]-s[i-1][j-1]+a[i][j];");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Evaluare ev = new Evaluare();
            if (ev.EvaluareAfisare(codPointeri, rtEx5.Text, nExercitiul50, nExercitiul51) == 1) MessageBox.Show(" Răspuns corect.");
            else MessageBox.Show(" Răspuns greșit. Verifică algoritmul încă o dată.") ;
        }
        string codPointeri = @"
#include <iostream>
#include <fstream>
using namespace std;
ifstream fin(""test.txt"");
int n, a[100][100], i, j, s,m;
int main()
        {
            fin >> n>>m;
            for (i = 1; i <= n; i++)
                for (j = 1; j <= m; j++)
                    fin >> a[i][j];
            for(i = 1; i<=n; i+=2)
                for(j=1;j<=m;j++)
                    if(*(*(a+i)+j)%2==0)
                        cout <<*(*(a+i)+j)<<"" "";
            return 0;
        }
            ";

        private void button3_Click(object sender, EventArgs e)
        {
            Evaluare ev = new Evaluare();
            if (ev.EvaluareGenerare2("*(*(a+i)+j)=min(i,j);", rtExercitiul4.Text, nExercitiul40, nExercitiul41, 0) == 1)
                MessageBox.Show(" Răspuns corect.");
            else MessageBox.Show(" Răspuns incorect.");
        }

        private void tabPage5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton4.Checked)
                MessageBox.Show(" Răspuns corect.");
            else MessageBox.Show(" Răspunsul corect este c.");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (raspuns3.Text == "*(*(a+i)+j)")
                MessageBox.Show(" Răspuns corect.");
            else MessageBox.Show(" Folosind pointerii, elementul de pe linia i și coloana j se mai poate scrie scrie și ca : *(*(v+i)+j).");
        }

        private void exersare6_Load(object sender, EventArgs e)
        {
            Random r = new Random();
            //generare exercitiul 1
            nExercitiul10 = r.Next(3, 100);
            nExercitiul11 = r.Next(3, 100);
            //generare exercitiul 4
            nExercitiul40 = r.Next(2, 30);
            nExercitiul41 = r.Next(2, 30);
            exercitiul4.Text = @" Completează secvența de program de mai jos astfel încât să construiască o matrice a cu n=" + nExercitiul40.ToString() + " linii și m=" + nExercitiul41.ToString() + @" coloane în care a[i][j] memorează minimul dintre valorile i și j. Unde este posibil, se vor folosi pointerii.Pentru n=4 și m=5 se afișează matricea din dreapta.
                                 for(i=0;i<n;i++)
                                    for(j=0;j<m;j++)
                                        ...";
            exemplu4.Text = @"1 1 1 1 1
1 2 2 2 2
1 2 3 3 3
1 2 3 4 4";
            //generare exercitiul 5
            nExercitiul50 = r.Next(3, 98);
            nExercitiul51 = r.Next(3, 98);
            string comun = @"Ai o matrice a cu n=" + nExercitiul50.ToString() + " linii și n=" + nExercitiul51.ToString() + " coloane numerotate de la 1 și variabilele i și j declarate. Scrie o secvență de program care ";
            string comun2 = @"Scrie codul în căsuța de mai jos, fără a folosi alte variabile decât cele prezentate și utilizând peste tot unde este posibil pointeri, apoi apasă butonul Verifică.";
            exercitiul5.Text = comun + "afișează elementele pare aflate pe linii cu indici impari, separate prin câte un spațiu. " + comun2;
        }
    }
}
