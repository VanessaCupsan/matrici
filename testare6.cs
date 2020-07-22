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
    public partial class testare6 : Form
    {
        int[] t = new int[10];
        int nIntrebare1,nIntrebare2,nIntrebare30,nIntrebare31,nIntrebare32,nIntrebare4,n,m,linie1,linie2,coloana2,coloana1,nIntrebare6,nIntrebare70,nIntrebare71,nIntrebare80,nIntrebare81;
        int oriz = 15, vert = 115, latura = 24, pas = 24;

        private void button8_Click(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
                t[9] = 1;
            else t[9] = 0;
            MessageBox.Show(" Felicitări, ai ajuns la sfârșitul testului și al cursului!");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Evaluare ev = new Evaluare();
            if (ev.EvaluareGenerare(gen5, rIntrebare8.Text, nIntrebare80, nIntrebare81, 0) == 1) t[8] = 1;
            else t[8] = 0;
            tabControl1.SelectTab(8);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Evaluare ev = new Evaluare();
            if (ev.EvaluareGenerare2("a[i][j]=(i*i*j*j)/3;", rIntrebare7.Text, nIntrebare70, nIntrebare71, 0) == 1)
                t[7] = 1;
            else if (ev.EvaluareGenerare2("a[i][j]=i*i*j*j/3;", rIntrebare7.Text, nIntrebare70, nIntrebare71, 0) == 1)
                t[7] = 1;
            else t[7] = 0;
                tabControl1.SelectTab(7);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (raspuns60.Text == "i>j" && raspuns61.Text == "i+j>n+1")
                t[6] = 1;
            else if (raspuns60.Text == "i+j>n+1" && raspuns61.Text == "i>j")
                t[6] = 1;
            else t[6] = 0;
            tabControl1.SelectTab(6);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Evaluare ev = new Evaluare();
            if (ev.EvaluareAfisare(codArie, rIntrebare5.Text, n, m) == 1) t[5] = 1;
            else t[5] = 0;
            tabControl1.SelectTab(5);
        }

        TextBox[,] a;
        int[,] b = { { 576,78,4,89 }, { 3,0,34,7 }, { 12,44,678,9 }, {33,45,8,923} };
        public testare6()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (Int32.Parse(raspuns30.Text) == nIntrebare30 && Int32.Parse(raspuns31.Text) == nIntrebare31)
                t[3] = 1;
            else
                t[3] = 0;
            tabControl1.SelectTab(3);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Int32.Parse(raspuns40.Text) == vec[nIntrebare4 - 1, 0] && Int32.Parse(raspuns41.Text) == vec[nIntrebare4 - 1, 1] && Int32.Parse(raspuns42.Text) == vec[nIntrebare4 - 1, 2] && Int32.Parse(raspuns43.Text) == vec[nIntrebare4 - 1, 3] && Int32.Parse(raspuns44.Text) == vec [nIntrebare4 - 1, 4])
                t[4] = 1;
            else t[4] = 0;
            tabControl1.SelectTab(4);
        }

        private void testare6_Load(object sender, EventArgs e)
        {
            //generare matrice
            a = new TextBox[12, 12];
            for (int i = 0; i <= 10; i++)
                for (int j = 0; j <= 10; j++)
                {
                    a[i, j] = new TextBox();
                    tabPage2.Controls.Add(a[i, j]);
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
            //generare intrebarea 1
            nIntrebare1 = r.Next(3, 8) * 12;
            intrebarea1.Text = " Cum se poate declara o matrice a cu exact " + nIntrebare1.ToString() + " elemente, toate fiind caractere ?";
            //generare intrebarea 2
            nIntrebare2 = r.Next(1, 5);
            intrebarea2.Text = " Creați, utilizând instrumentul de mai jos, un tablou bidimensional cu numere întregi pozitive care ocupă " + (nIntrebare2 * 16).ToString() + " octeți.";
            //generare intrebarea 3
            nIntrebare30 = r.Next(0, 3);
            nIntrebare31 = r.Next(0, 3);
            nIntrebare32 = b[nIntrebare30, nIntrebare31];
            intrebarea3.Text = " Scrieți coordonatele elementului " + nIntrebare32.ToString() + " din matricea a, declarată mai jos.";
            //generare intrebarea 4
            nIntrebare4 = r.Next(1, 6);
            intrebare40.Text = " Matricea v are 6 linii și 5 coloane.";
            intrebare41.Text = " Scrieți, în ordine, în fiecare căsuță, elementele situate pe cea de a " + nIntrebare4.ToString() + "-a linie a matricei.";
            intrebare42.Text = " Elementele de pe linia " + nIntrebare4.ToString() + " sunt următoarele.";
            rIntrebare4.LoadFile("intrebare4t6.rtf");
            //generare intrebare 5
            n = r.Next(3, 98);
            m = r.Next(3, 98);
            linie1 = r.Next(1, n - 1);
            linie2 = r.Next(linie1, n);
            coloana1 = r.Next(1, m - 1);
            coloana2 = r.Next(coloana1, m);
            string comun = @"Ai o matrice a cu " + n.ToString() + " linii și " + m.ToString() + " coloane numerotate de la 1 și variabilele i și j declarate. Scrie o secvență de program care ";
            string comun2 = @"Scrie codul în căsuța de mai jos, fără a folosi alte variabile decât cele prezentate, apoi apasă butonul Raspunde.";
            intrebare5.Text = comun + " afișează elementele din zona cuprinsă între linia " + linie1.ToString() + " și linia " + linie2.ToString() + ", respectiv coloana " + coloana1.ToString() + " și coloana " + coloana2.ToString() + "."+comun2;
            codArie = codArie.Replace("$1", linie1.ToString());
            codArie = codArie.Replace("$2", linie2.ToString());
            codArie = codArie.Replace("$3", coloana1.ToString());
            codArie = codArie.Replace("$4", coloana2.ToString());
            //generare intrebarea 6
            nIntrebare6 = r.Next(3, 100);
            intrebare6.Text = " Se dă tabloul bidimensioanl a cu n=" + nIntrebare6.ToString() + " linii și n=" + nIntrebare6.ToString() + " coloane, indexate de la 1. Care sunt cele două relații dintre indicii i și j dacă elementul a[i][j] se află în zona de SUD a matricei ?";
            //generare intrebarea 7
            nIntrebare70 = r.Next(2, 30);
            nIntrebare71 = r.Next(2, 30);
            intrebarea7.Text = @" Completează secvența de program de mai jos astfel încât să construiască o matrice a cu n=" + nIntrebare70.ToString() + " linii și m=" + nIntrebare71.ToString() + @" coloane în care a[i][j] memorează câtul împărțirii la 3 a produsului pătratelor indicilor. Pentru n=4 și m=5 se afișează matricea din dreapta.
                                 for(i=0;i<n;i++)
                                    for(j=0;j<=m;j++)
                                        ...";
            exemplu7.Text = @"0 0 0 0 0
0 0 1 3 5
0 1 5 12 21
0 3 12 27 48";
            //generare intrebarea 8
            nIntrebare80 = r.Next(3, 98);
            nIntrebare81 = r.Next(3, 98);
            intrebarea8.Text = @"Variabilele i și j sunt de tip întreg, iar variabila a memorează un tablou bidimensional cu " + nIntrebare80.ToString() + " linii și " + nIntrebare81.ToString() + " coloane, numerotate începând de la 0, cu elemente numere întregi, inițial toate nule. Fără a utiliza alte variabile decât cele menționate și folosind peste tot unde este posibil pointeri, scrieți o secvență de instrucțiuni astfel încât, în urma executării acesteia, dacă un element se va afla pe o linie cu indice divizibil cu 3, acesta va fi egal cu pătratului indicelui de coloană, altfel, va fi egal cu suma dintre cei doi indici. Variabila a va genera un tablou asemănător cu cel alăturat, dacă numărul de linii ar fi 4, iar numărul de coloane 5.";
            exemplu8.Text = @"0 1 4 9 16
1 1 2 3 4
0 1 4 9 16
3 3 3 3 4";
            gen5 = gen5.Replace("$80", nIntrebare80.ToString());
            gen5 = gen5.Replace("$81", nIntrebare81.ToString());

        }
        string gen5 = @"for(i=0; i<$80; i++)
                            for(j=0; j<$81; j++)
                            {    
                                if(i%3==0)
                                    *(*(a+i)+j)=j*j;
                                else *(*(a+i)+j)=i+j;
                            } ";
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
        int[,] vec = { { 2,5,10,17,26}, {5,8,13,20,29}, {10,13,18,25,34}, {17,20,25,32,41}, {26,29,34,41,50 }, { 37,40,45,52,61} };

        private void evaluare_Click(object sender, EventArgs e)
        {
            int s = 0;
            for (int i = 1; i <= 9; i++)
                s = s + t[i];
            MessageBox.Show("Ai obtinut nota " + (s + 1).ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((nrLinii2.Value) * (nrColoane2.Value) * 4 == nIntrebare2 * 16)
                t[2] = 1;
            else t[2] = 0;
            tabControl1.SelectTab(2);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            int a, b;
            try
            {
                a = Int32.Parse(rasp10.Text);
                b = Int32.Parse(rasp11.Text);
            }
            catch
            {
                a = b = 0;
            }
            if (tipVariabila.Text == "char" && Int32.Parse(rasp10.Text) * Int32.Parse(rasp11.Text) == nIntrebare1)
                t[1] = 1;
            else t[1] = 0;
            tabControl1.SelectTab(1);
        }

        private void nrLinii8_ValueChanged(object sender, EventArgs e)
        {
            for (int i = 0; i <= 10; i++)
                for (int j = 0; j <= 10; j++)
                {
                    a[0, 0].Visible = false;
                    a[i, j].Visible = (i <= nrLinii2.Value && j <= nrColoane2.Value);
                }
        }

        private void nrColoane8_ValueChanged(object sender, EventArgs e)
        {
            for (int i = 0; i <= 10; i++)
                for (int j = 0; j <= 10; j++)
                {
                    a[0, 0].Visible = false;
                    a[i, j].Visible = (i <= nrLinii2.Value && j <= nrColoane2.Value);
                }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
