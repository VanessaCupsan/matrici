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
    public partial class exersare2 : Form
    {
        int[,] a = { { 45, 6, 4, -354, 78 }, { 5, 64, 34, 5, 0 }, { 88, 56, 455, 24, 689 }, { 68, 6756, 56, 56, 4 }, { 68, 0, 24, 7, 5 }, { 7455, 45, 4, -98, -10 }, { 39, 0, 1, 7, 4 } };
        int nIntrebare1,nIntrebare12,nIntrebare2,nIntrebare21,nIntrebare22,nIntrebare3,nIntrebare31,nIntrebare4,nIntrebare41,nIntrebare42,nIntrebare50,nIntrebare51,nIntrebare52,nIntrebare53;

        private void label3_Click(object sender, EventArgs e)
        {

        }

        MaskedTextBox[,] v;
        private void button4_Click(object sender, EventArgs e)
        {
            int linie = nIntrebare4, coloana = nIntrebare41;
            if (nIntrebare42 == Convert.ToInt32(v[linie, coloana].Text))
                MessageBox.Show(" Răspuns corect.");
            else MessageBox.Show(" Numărul " + nIntrebare42.ToString() + " trebuie pus în căsuța de pe linia" + nIntrebare4.ToString() + " și coloana " + nIntrebare41.ToString() + ".");
                
        }

        private void intrebare4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (raspuns34.Checked)
                MessageBox.Show(" Răspuns corect.");
            else MessageBox.Show(" Răspunsul corect este ultimul.");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Int32.Parse(raspuns21.Text) >= 0 && Int32.Parse(raspuns21.Text) <= nIntrebare22 && Int32.Parse(raspuns22.Text) == nIntrebare21)
                MessageBox.Show(" Răspuns corect.");
            else MessageBox.Show(" Numărul din prima căsuță trebuie să aparțină intervalului [0," + nIntrebare22.ToString() + "], iar numărul din cea de-a doua casetă trebuie să fie numărul"+nIntrebare21.ToString()+".");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int maxim = 0;
            if (a[nIntrebare50 - 1, nIntrebare51] > maxim)
                maxim = a[nIntrebare50 - 1, nIntrebare51];
            if (a[nIntrebare50 + 1, nIntrebare51] > maxim)
                maxim = a[nIntrebare50 + 1, nIntrebare51];
            if (a[nIntrebare50, nIntrebare51 - 1] > maxim)
                maxim = a[nIntrebare50, nIntrebare51 - 1];
            if (a[nIntrebare50, nIntrebare51 + 1] > maxim)
                maxim = a[nIntrebare50, nIntrebare51 + 1];
            int nr = 0;
            if (a[nIntrebare52 - 1, nIntrebare53] % 2 == 0)
                nr++;
            if (a[nIntrebare52 + 1, nIntrebare53] % 2 == 0)
                nr++;
            if (a[nIntrebare52, nIntrebare53 - 1] % 2 == 0)
                nr++;
            if (a[nIntrebare52, nIntrebare53 + 1] % 2 == 0)
                nr++;
            if (Int32.Parse(raspuns1.Text) == maxim && Int32.Parse(raspuns2.Text) == nr)
                MessageBox.Show(" Răspuns corect.");
            else MessageBox.Show(" Răspunsurile corecte sunt: 1. " + maxim.ToString() + " și 2. " + nr.ToString() + ".");

        }

        private void tabPage5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        public exersare2()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Int32.Parse(raspuns1Linie.Text) < nIntrebare1 && Int32.Parse(raspuns1Coloana.Text) < nIntrebare12 && Int32.Parse(raspuns1Linie.Text) > 0 && Int32.Parse(raspuns1Coloana.Text) > 0)
                MessageBox.Show(" Răspuns corect.");
            else MessageBox.Show(" Primul număr trebuie să aparțină intervalului (0, " + nIntrebare1.ToString() + "], iar cel de-al număr să aparțină intervalului (0, " + nIntrebare12.ToString() + "].") ;
        }

        private void exersare2_Load(object sender, EventArgs e)
        {
            //creare întrebare 1
            Random r = new Random();
            nIntrebare1 = r.Next(3,100);
            nIntrebare12 = r.Next(3, 100);
            intrebare1.Text = " a[  " + nIntrebare1.ToString() + " ][  " + nIntrebare12.ToString() + " ]";
            //creare întrebare 2
            nIntrebare2 = r.Next(3, 100);
            nIntrebare21 = r.Next(3, nIntrebare2);
            nIntrebare22 = r.Next(3, 100);
            intrebare2.Text = " Scrieți un element la alegere de pe coloana " + nIntrebare21.ToString() + " a matrciei a, declarată mai jos.";
            intrebare22.Text = "int a[" + nIntrebare22.ToString() + "][" + nIntrebare2.ToString() + "] ;";
            //creare intrebare 3
            nIntrebare3 = r.Next(3, 100);
            nIntrebare31 = r.Next(3, 100);
            intrebare3.Text = " Variabilele i și j sunt de tip întreg, iar variabila m memorează un tabloul bidimensional cu " + nIntrebare3.ToString() + " linii și " + nIntrebare31.ToString() + " coloane, numerotate de la 0, cu elemente numere întregi.";
            intrebare31.Text = " O expresie C++ a cărei valoare este egală cu produsul dintre primul element de pe linia i și ultimul de pe coloana j din acest tablou este: ";
            varianta1.Text = " m[ 0 ][ i ] * m[ j ][ " + (nIntrebare31 - 1).ToString() + " ] ;";
            varianta2.Text=" m( 0, i ) * m( j," + (nIntrebare3 - 1).ToString() + " ) ;";
            varianta3.Text = " m( i )( 0 ) * m( " + (nIntrebare3 - 1).ToString() + " )( j ) ;";
            varianta4.Text = " m[ i ][ 0 ] * m[ " + (nIntrebare3 - 1).ToString() + " ][ j ] ;";
            //creare întrebare 4
            nIntrebare4 = r.Next(0, 3);
            nIntrebare41 = r.Next(0, 5);
            nIntrebare42 = r.Next(1000, 5000);
            intrebare4.Text = " Scrieți numărul " + nIntrebare42.ToString() + " în căsuța corespunzătoare elementului a[" + nIntrebare4.ToString() + "][" + nIntrebare41.ToString() + "] a matricei :";
            v = new MaskedTextBox[4, 6];
            v[0, 0] = a00;
            v[0, 1] = a01;
            v[0, 2] = a02;
            v[0, 3] = a03;
            v[0, 4] = a04;
            v[0, 5] = a05;
            v[1, 0] = a10;
            v[1, 1] = a11;
            v[1, 2] = a12;
            v[1, 3] = a13;
            v[1, 4] = a14;
            v[1, 5] = a15;
            v[2, 0] = a20;
            v[2, 1] = a21;
            v[2, 2] = a22;
            v[2, 3] = a23;
            v[2, 4] = a24;
            v[2, 5] = a25;
            v[3, 0] = a30;
            v[3, 1] = a31;
            v[3, 2] = a32;
            v[3, 3] = a33;
            v[3, 4] = a34;
            v[3, 5] = a35;
            //creare intrebare 5
            nIntrebare50 = r.Next(1, 5);
            nIntrebare51 = r.Next(1, 3);
            nIntrebare52 = r.Next(1, 5);
            nIntrebare53 = r.Next(1, 3);
            intrebare51.Text = " Care este valoarea celui mai mare vecin al elementului a[" + nIntrebare50.ToString() + " ][" + nIntrebare51.ToString() + "] ?";
            intrebare52.Text = " Câți vecini numere pare ale elementul a[" + nIntrebare52.ToString() + "][" + nIntrebare53.ToString() + "] ?";

        }
    }
}
