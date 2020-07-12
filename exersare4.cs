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
        int nExercitiul10,nExercitiul2,nExercitiul3,nExercitiul4,nExercitiul5;
        int[,] a;
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
            nExercitiul5 = r.Next(3, 100);
            exercitiul5.Text = " În secvența de program următoare, variabila t memorează o matrice cu n=" + nExercitiul5.ToString() + " linii și n=" + nExercitiul5.ToString() + " coloane, numerotate de la 0 la " + (nExercitiul5 - 1).ToString() + ", cu elemente numere întregi, iar celelalte variabile sunt întregi.";
            rEx5.LoadFile("ex5exersare4.rtf");
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (radioButton8.Checked)
                MessageBox.Show(" Răspuns corect.");
            else MessageBox.Show(" Răspunsul corect este b).");
        }

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
