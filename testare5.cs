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
    public partial class testare5 : Form
    {
        int nIntrebare10, nIntrebare11,nIntrebare20,nIntrebare21,nIntrebare40,nIntrebare41;
        int[] t = new int[10];
        public testare5()
        {
            InitializeComponent();
        }

        private void intrebarea2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Evaluare ev = new Evaluare();
            if (ev.EvaluareGenerare2("a[i][j]=a[i-1][j]+a[i][j-1];", rtIntrebare2.Text, nIntrebare20, nIntrebare21, 0) == 1)
                t[2] = 1;
            else t[2] = 0;
            tabControl1.SelectTab(2);
        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            t[3] = 1;
            tabControl1.SelectTab(3);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            t[3] = 0;
            tabControl1.SelectTab(3);
        }

        private void evaluare_Click(object sender, EventArgs e)
        {
            int s = 0;
            for (int i = 1; i <= 9; i++)
                s = s + t[i];
            MessageBox.Show("Ai obtinut nota " + (s + 1).ToString());
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Evaluare ev = new Evaluare();
            if (ev.EvaluareGenerare2("a[i][j]=(i*j)%10;", rtIntrebare1.Text, nIntrebare10, nIntrebare11, 0) == 1)
                t[1] = 1;
            else t[1] = 0 ;
            tabControl1.SelectTab(1);
        }

        private void testare5_Load(object sender, EventArgs e)
        {
            //test
            for (int i = 0; i <= 9; i++)
                t[i] = 0;
            Random r = new Random();
            //generare intrebarea 1
            nIntrebare10 = r.Next(2, 30);
            nIntrebare11 = r.Next(2, 30);
            intrebarea1.Text = @" Completează secvența de program de mai jos astfel încât să construiască o matrice a cu n=" + nIntrebare10.ToString() + " linii și m=" + nIntrebare11.ToString() + @" coloane în care a[i][j] memorează ultima cifră a produsului indicilor de linie și coloană. Pentru n=4 și m=5 se afișează matricea din dreapta.
                                 for(i=0;i<n;i++)
                                    for(j=0;j<=m;j++)
                                        ...";
            exemplu1.Text = @"0 0 0 0 0
0 1 2 3 4
0 2 4 6 8
0 3 6 9 2";
            //generare intrebarea 2
            nIntrebare20 = r.Next(2, 30);
            nIntrebare21 = r.Next(2, 30);
            intrebarea2.Text = @" Completează secvența de program de mai jos astfel încât să construiască o matrice a cu n=" + nIntrebare20.ToString() + " linii și m=" + nIntrebare21.ToString() + @" coloane în care a[i][j] memorează suma dintre elementul aflat cu o poziție deasupra lui și elementul aflat cu o poziție la stânga. Tabloul conţine pe prima linie numerele 1,2,...,n, iar pe prima coloană numerele 1,2,...,m. Pentru n=4 și m=5 se afișează matricea din dreapta.
                                 for(i=0;i<n;i++)
                                    a[i][0]=i+1;
                                 for(j=0;j<m;j++)
                                    a[0][j]=j+1;
                                 for(i=0;i<n;i++)
                                    for(j=0;j<=m;j++)
                                        ...";
            exemplu2.Text = @"1 2 3 4 5
2 4 7 11 16
3 7 14 25 41
4 11 25 50 91";
            //generare intrebare 4
            nIntrebare40 = r.Next(3, 98);
            nIntrebare41 = r.Next(3, 98);
            intre.Text = @"Variabilele i și j sunt de tip întreg, iar variabila a memorează un tablou bidimensional cu " + n.ToString() + " linii și " + m.ToString() + " coloane, numerotate începând de la 0, cu elemente numere întregi, inițial toate nule. Fără a utiliza alte variabile decât cele menționate, scrieți o secvență de instrucțiuni astfel încât, în urma executării acesteia, variabila a să un tabloul asemămător cu cel alăturat, dacă numărul de linii ar fi 4, iar numărul de coloane 5.";
            Exemplu.Text = @"5 4 3 2 1
10 9 8 7 6
15 14 13 12 11
20 19 18 17 16";
            gen1 = gen1.Replace("$1", n.ToString());
            gen1 = gen1.Replace("$2", m.ToString());
        }
    }
}
