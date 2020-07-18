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
    public partial class exersare5 : Form
    {
        int n, m,nExercitiul20,nExercitiul21;

        private void exemplu2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Evaluare ev = new Evaluare();
            if (ev.EvaluareGenerare(gen1, rtEx3.Text, n, m, 0) == 1) MessageBox.Show("Corect");
            else MessageBox.Show("Incorect");
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (radioButton4.Checked)
                MessageBox.Show(" Răspuns corect.");
            else MessageBox.Show(" Răspunsul corect este d) deoarece suma tuturor liniilor,coloanelor și diagonalelor este egala cu 34.");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (raspunsEx5.Text == "Albrecht Durer" || raspunsEx5.Text == "albrecht durer" || raspunsEx5.Text == "Albrecht Dürer" || raspunsEx5.Text == "albrecht dürer")
                MessageBox.Show(" Răspuns corect.");
            else MessageBox.Show(" Numele artistului este Albrecht Dürer.");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Evaluare ev = new Evaluare();
            if (ev.EvaluareGenerare2("a[i][j]=i+j;", rtEx2.Text, n, m, 0) == 1)
                MessageBox.Show(" Răspuns corect.");
            else MessageBox.Show(" Răspuns incorect.");
        }
        string gen1 = @"for(i=0; i<$1; i++)
                        for(j=0; j<$2; j++)
                          a[i][j]=i*$2 + $2 - j;";

        public exersare5()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           Evaluare ev = new Evaluare();
            if (ev.EvaluareGenerare2("a[i][j]=max(i,j);", rtEx1.Text, n, m, 0) == 1)
                MessageBox.Show(" Răspuns corect.");
            else MessageBox.Show(" Răspuns incorect.");
        }

        private void exersare5_Load(object sender, EventArgs e)
        {
            //generare ex 1
            Random r = new Random();
            n = r.Next(2, 30);
            m = r.Next(2, 30);
            exercitiul1.Text = @" Completează secvența de program de mai jos astfel încât să construiască o matrice a cu n="+n.ToString()+ " linii și m="+m.ToString()+@" coloane în care a[i][j] memorează maximul dintre valorile i și j. Pentru n=4 și m=5 se afișează matricea din dreapta.
                                 for(i=0;i<n;i++)
                                    for(j=0;j<=m;j++)
                                        ...";
            exemplu1.Text = @"0 1 2 3 4
1 1 2 3 4
2 2 2 3 4
3 3 3 3 4";
            //generare exercitiul 2
            nExercitiul20 = r.Next(2, 30);
            nExercitiul21 = r.Next(2, 30);
            exercitiul2.Text = @" Completează secvența de program de mai jos astfel încât să construiască o matrice a cu n=" + nExercitiul20.ToString() + " linii și m=" + nExercitiul21.ToString() + @" coloane în care a[i][j] memorează suma dintre valorile i și j. Pentru n=4 și m=5 se afișează matricea din dreapta.
                                 for(i=0;i<n;i++)
                                    for(j=0;j<=m;j++)
                                        ...";
            exemplu2.Text = @"0 1 2 3 4
1 2 3 4 5
2 3 4 5 6
3 4 5 6 7";
            //generare exercitiul 3
            cerGen.Text = @"Variabilele i și j sunt de tip întreg, iar variabila a memorează un tablou bidimensional cu " + n.ToString() + " linii și " + m.ToString() + " coloane, numerotate începând de la 0, cu elemente numere întregi, inițial toate nule. Fără a utiliza alte variabile decât cele menționate, scrieți o secvență de instrucțiuni astfel încât, în urma executării acesteia, variabila a să un tabloul asemămător cu cel alăturat, dacă numărul de linii ar fi 4, iar numărul de coloane 5.";
            exemplu3.Text = @"5 4 3 2 1
10 9 8 7 6
15 14 13 12 11
20 19 18 17 16";
            gen1 = gen1.Replace("$1", n.ToString());
            gen1 = gen1.Replace("$2", m.ToString());

        }
    }
}
