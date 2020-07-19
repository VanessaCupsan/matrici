using System;
using System.Windows.Forms;

namespace matrici
{
    public partial class testare5 : Form
    {
        int nIntrebare10, nIntrebare11,nIntrebare20,nIntrebare21,nIntrebare40,nIntrebare41,nIntrebare50,nIntrebare51,nIntrebare6,nIntrebare80,nIntrebare81,nIntrebare90,nIntrebare91;
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
            t[3] = 0;
            tabControl1.SelectTab(3);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show(@"1. Mai întâi inițializează toată matricea cu 3,apoi modifică elementele unde este necesar.
2. Folosește doar de două ori structura repetitivă for.");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Evaluare ev = new Evaluare();
            if (ev.EvaluareGenerare(gen3, rtIntrebare5.Text, nIntrebare50, nIntrebare51, nIntrebare50*nIntrebare51) == 1) t[5] = 1;
            else t[5] = 0;
            tabControl1.SelectTab(5);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Evaluare ev = new Evaluare();
            if (ev.EvaluareGenerare(gen4, rtIntrebare6.Text, nIntrebare6, nIntrebare6, 0) == 1) t[6] = 1;
            else t[6] = 0;
            tabControl1.SelectTab(6);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int a, b, c, d, x, f, g, h, i;
            try
            {
                a = Int32.Parse(r00.Text);
                b = Int32.Parse(r01.Text);
                c = Int32.Parse(r02.Text);
                d = Int32.Parse(r10.Text);
                x = Int32.Parse(r11.Text);
                f = Int32.Parse(r12.Text);
                g = Int32.Parse(r20.Text);
                h = Int32.Parse(r21.Text);
                i = Int32.Parse(r22.Text);
            }
            catch
            {
                a = b = c = d = x = f = g = h = i = 0;
            }
            int n = Int32.Parse(r00.Text) + Int32.Parse(r01.Text) + Int32.Parse(r02.Text);
            int m = Int32.Parse(r10.Text) + Int32.Parse(r11.Text) + Int32.Parse(r12.Text);
            int p = Int32.Parse(r20.Text) + Int32.Parse(r21.Text) + Int32.Parse(r22.Text);
            int q = Int32.Parse(r00.Text) + Int32.Parse(r10.Text) + Int32.Parse(r20.Text);
            int s = Int32.Parse(r01.Text) + Int32.Parse(r11.Text) + Int32.Parse(r21.Text);
            int r = Int32.Parse(r02.Text) + Int32.Parse(r12.Text) + Int32.Parse(r22.Text);
            int diagp = Int32.Parse(r00.Text) + Int32.Parse(r11.Text) + Int32.Parse(r22.Text);
            int diags = Int32.Parse(r02.Text) + Int32.Parse(r11.Text) + Int32.Parse(r20.Text);
            if (n == m && n == p && n == q && n == s && n == r && n == diagp && n == diags)
                t[7] = 1;
            else t[7] = 0;
            tabControl1.SelectTab(7);

        }

        private void button11_Click(object sender, EventArgs e)
        {
            Evaluare ev = new Evaluare();
            if (ev.EvaluareGenerare2("a[i][j]=3*i*j;", rtIntrebare9.Text, nIntrebare90, nIntrebare91, 0) == 1)
                t[9] = 1;
            else t[9] = 0;
            MessageBox.Show(" Felicitări, ai ajuns la sfârșitul testului!");
        }

        private void tabPage8_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            Evaluare ev = new Evaluare();
            if (ev.EvaluareGenerare(gen5, rtIntrebarea8.Text, nIntrebare80, nIntrebare81, 0) == 1) t[8] = 1;
            else t[8] = 0;
            tabControl1.SelectTab(8);
        }

        private void intrebarea8_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Evaluare ev = new Evaluare();
            if (ev.EvaluareGenerare(gen2, rtIntrebare4.Text, nIntrebare40, nIntrebare41, 0) == 1) t[4] = 1;
            else t[4] = 0;
            tabControl1.SelectTab(4);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            t[3] = 1;
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
        string gen2 = @"for(i=0; i<$%; i++)
                            for(j=0; j<$#; j++)
                                if(i%2==1)
                                    a[i][j]=i;
                                else a[i][j]=j;";
        string gen3 = @"k=$50*$51;
                        for(i=0; i<$50; i++)
                            for(j=0; j<$51; j++)
                            {    
                                a[i][j]=k;
                                k--;
                            } ";
        string gen4 = @"for(i=0; i<$6; i++)
                            for(j=0; j<$6; j++)
                            {    
                                a[i][j]=3;
                                if(i<j)
                                    a[i][j]=1;
                                if(i==j)
                                    a[i][j]=2;
                            } ";
        string gen5 = @"for(i=0; i<$80; i++)
                            for(j=0; j<$81; j++)
                            {    
                                if(i%2==0)
                                    a[i][j]=j*j;
                                else a[i][j]=max(i,j);
                            } ";


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
            intrebare4.Text = @"Variabilele i și j sunt de tip întreg, iar variabila a memorează un tablou bidimensional cu " + nIntrebare40.ToString() + " linii și " + nIntrebare41.ToString() + " coloane, numerotate începând de la 0, cu elemente numere întregi, inițial toate nule. Fără a utiliza alte variabile decât cele menționate, scrieți o secvență de instrucțiuni astfel încât, în urma executării acesteia, elementele de pe liniile cu indice impar vor fi egale cu indicele de linie, iar elementele de pe linii pare cu indicele de coloană. Variabila a va genera un tablou asemănător cu cel alăturat, dacă numărul de linii ar fi 4, iar numărul de coloane 5.";
            exemplu4.Text = @"0 1 2 3 4
1 1 1 1 1
0 1 2 3 4
3 3 3 3 3";
            gen2 = gen2.Replace("$%", nIntrebare40.ToString());
            gen2 = gen2.Replace("$#", nIntrebare41.ToString());
            //generare intrebare 5
            nIntrebare50 = r.Next(3, 98);
            nIntrebare51 = r.Next(3, 98);
            intrebarea5.Text = @"Variabilele i, j și k sunt de tip întreg, iar variabila a memorează un tablou bidimensional cu " + nIntrebare50.ToString() + " linii și " + nIntrebare51.ToString() + " coloane, numerotate începând de la 0, cu elemente numere întregi, inițial toate nule. Fără a utiliza alte variabile decât cele menționate, scrieți o secvență de instrucțiuni astfel încât, în urma executării acesteia, dacă matricea va fi parcursă linie cu linie, de sus în jos și fiecare linie de la stânga la dreapta, se vor obține în ordine descrescătoare toate numerele naturale de la 1 la n*m. Variabila a va genera un tablou asemănător cu cel alăturat, dacă numărul de linii ar fi 4, iar numărul de coloane 5.";
            exemplu5.Text = @"20 19 18 17 16
15 14 13 12 11
10 9 8 7 6
5 4 3 2 1";
            gen3 = gen3.Replace("$50", nIntrebare50.ToString());
            gen3 = gen3.Replace("$51", nIntrebare51.ToString());
            //generare intrebare 6
            nIntrebare6 = r.Next(3, 98);
            intrebare6.Text = @"Variabilele i și j sunt de tip întreg, iar variabila a memorează un tablou bidimensional cu " + nIntrebare6.ToString() + " linii și " + nIntrebare6.ToString() + " coloane, numerotate începând de la 0, cu elemente numere întregi, inițial toate nule. Fără a utiliza alte variabile decât cele menționate, scrieți o secvență de instrucțiuni astfel încât, în urma executării acesteia, elementele deasupra diagonalei principale a tabloului vor fi egale cu 1, cele de pe diagonala principală cu 2, iar restul cu 3. Variabila a va genera un tablou asemănător cu cel alăturat, dacă numărul de linii și de coloane va fi 4.";
            exempu6.Text = @"2 1 1 1
3 2 1 1
3 3 2 1
3 3 3 2";
            gen4 = gen4.Replace("$6", nIntrebare6.ToString());
            //generare intrebarea 8
            nIntrebare80 = r.Next(3, 98);
            nIntrebare81 = r.Next(3, 98);
            intrebarea8.Text = @"Variabilele i și j sunt de tip întreg, iar variabila a memorează un tablou bidimensional cu " + nIntrebare80.ToString() + " linii și " + nIntrebare81.ToString() + " coloane, numerotate începând de la 0, cu elemente numere întregi, inițial toate nule. Fără a utiliza alte variabile decât cele menționate, scrieți o secvență de instrucțiuni astfel încât, în urma executării acesteia, dacă un element se va afla pe o linie cu indice par, acesta va fi egal cu pătratului indicelui de coloană, altfel, va fi egal cu maximul dintre cei doi indici. Variabila a va genera un tablou asemănător cu cel alăturat, dacă numărul de linii ar fi 4, iar numărul de coloane 5.";
            exemplu8.Text = @"0 1 4 9 16
1 1 2 3 4
0 1 4 9 16
3 3 3 3 4";
            gen5 = gen5.Replace("$80", nIntrebare80.ToString());
            gen5 = gen5.Replace("$81", nIntrebare81.ToString());
            //generare intrebarea 9
            nIntrebare90 = r.Next(2, 30);
            nIntrebare91 = r.Next(2, 30);
            intrebarea9.Text = @" Completează secvența de program de mai jos astfel încât să construiască o matrice a cu n=" + nIntrebare90.ToString() + " linii și m=" + nIntrebare91.ToString() + @" coloane în care a[i][j] memorează triplul produsului indicilor de linie și coloană. Pentru n=4 și m=5 se afișează matricea din dreapta.
                                 for(i=0;i<n;i++)
                                    for(j=0;j<=m;j++)
                                        ...";
            exemplu9.Text = @"0 0 0 0 0
0 3 6 9 12
0 6 12 18 24
0 9 18 27 36";
        }
    }
}
