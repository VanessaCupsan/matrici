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
    public partial class testare2 : Form
    {
        int[,] a = { { -576, -56, 6, 78, 34, -7 }, { 0, 7, 9, -12, 34, -789 }, { 45, 34, 67, 7, -78, -6 }, { 0, 45, 3, 5, -9, 56 }, { 5566, 56, -123, 34, -8, 0 } };
        int[] t = new int[10];
        bool[] r = { false, false, false, false, false, false, false, false, false, false };
        int nIntrebare10, nIntrebare11, nIntrebare12,nIntrebare20,nIntrebare21,nIntrebare22,nIntrebare30,nIntrebare31,nIntrebare40,nIntrebare41,nIntrebare42,nIntrebare50,nIntrebare51,nIntrebare52,nIntrebare53,nIntrebare70,nIntrebare71,nIntrebare72,nIntrebare73;

        private void button3_Click(object sender, EventArgs e)
        {
            int linie = nIntrebare41, coloana = nIntrebare42;
            if (nIntrebare40 == Convert.ToInt32(v[linie, coloana].Text))
                t[4] = 1;
            else t[4] = 0;
            tabControl1.SelectTab(4);
        }

        MaskedTextBox[,] v; 

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            int n, m, p,ok=0;
            try
            {
                n = Int32.Parse(raspuns70.Text);
                m = Int32.Parse(raspuns71.Text);
                p = Int32.Parse(raspuns72.Text);
            }
            catch
            {
                n = 0;
                m = 0;
                p = 0;
            }
            if(nIntrebare72>=0 && nIntrebare72<nIntrebare70 && nIntrebare73>=0 && nIntrebare73<nIntrebare71)
            {
                if (nIntrebare72 == 0 && nIntrebare73 == 0 && p == 2)
                    ok = 1;
                if (nIntrebare72 == (nIntrebare70 - 1) && nIntrebare73 == (nIntrebare71 - 1) && p == 2)
                    ok = 1;
                if (nIntrebare72 == 0 && nIntrebare73 != 0 && nIntrebare73 != (nIntrebare71 - 1) && p == 3)
                    ok = 1;
                if (nIntrebare72 ==( nIntrebare70 - 1) && nIntrebare73 != 0 && nIntrebare73 != (nIntrebare71 - 1) && p == 3)
                    ok = 1;
                if (nIntrebare72 != 0 && nIntrebare72 != (nIntrebare70 - 1) && nIntrebare73 == 0 && p == 3)
                    ok = 1;
                if (nIntrebare72 != 0 && nIntrebare72 != (nIntrebare70 - 1) && nIntrebare73 == (nIntrebare71 - 1) && p == 3)
                    ok = 1;
                if (nIntrebare72 != 0 && nIntrebare72 != (nIntrebare70 - 1) && nIntrebare73 != 0 && nIntrebare73 != (nIntrebare71 - 1) && p == 4)
                    ok = 1;
            }
            if (n == nIntrebare72 && m == nIntrebare73 && ok == 1)
                t[7] = 1;
            else t[7] = 0;
            tabControl1.SelectTab(7);
        }

        private void tabPage7_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            int a, b, c, d, x, f, g, h, i, j, k,l,m,n,o,p;
            try
            {
                a = Int32.Parse(raspuns00.Text);
                b = Int32.Parse(raspuns01.Text);
                c = Int32.Parse(raspuns02.Text);
                d = Int32.Parse(raspuns03.Text);
                x = Int32.Parse(raspuns04.Text);
                f = Int32.Parse(raspuns05.Text);
                g = Int32.Parse(raspuns06.Text);
                h = Int32.Parse(raspuns07.Text);
                i = Int32.Parse(raspuns08.Text);
                j = Int32.Parse(raspuns09.Text);
                k = Int32.Parse(raspuns010.Text);
                l = Int32.Parse(raspuns011.Text);
                m = Int32.Parse(raspuns012.Text);
                n = Int32.Parse(raspuns013.Text);
                o = Int32.Parse(raspuns014.Text);
                p = Int32.Parse(raspuns015.Text);
            }
            catch
            {
                a = b = c = d = x = f = g = h = i = j = k = l = m = n = o = p = 0;
            }
            if ((a + b + c + d + h + l + p + o + n + m + i + x) == 15 && (f * g * j * k) == 24)
                t[6] = 1;
            else t[6] = 0;
            tabControl1.SelectTab(6);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int n, m,d1=2,p1=1,x=a[nIntrebare50,nIntrebare51-1],s=0,y=a[nIntrebare50, nIntrebare51 + 1],d2=2,p2=1, z = a[nIntrebare50-1, nIntrebare51],d3=2,p3=1,u = a[nIntrebare50 + 1, nIntrebare51],d4=2,p4=1,nr=0;
            int b = a[nIntrebare52, nIntrebare53 - 1], c = a[nIntrebare52, nIntrebare53 + 1], v = a[nIntrebare52 - 1, nIntrebare53], f = a[nIntrebare52 + 1, nIntrebare53];
            try
            {
                n = Int32.Parse(raspuns50.Text);
                m = Int32.Parse(raspuns51.Text);
            }
            catch
            {
                n = 0;
                m = 0;
            }
            while(d1<=(x/2))
            {
                if (x % d1 == 0)
                    p1 = 0;
                d1++;
            }
            if (p1 == 1 && x != 0 && x != 1)
                nr++;

            while (d2 <= (y / 2))
            {
                if (y % d2 == 0)
                    p2 = 0;
                d2++;
            }
            if (p2 == 1 && y != 0 && y != 1)
                nr++;

            while (d3 <= (z / 2))
            {
                if (z % d3 == 0)
                    p3 = 0;
                d3++;
            }
            if (p3 == 1 && z != 0 && z != 1)
                nr++;

            while (d4 <= (u / 2))
            {
                if (u % d4 == 0)
                    p4 = 0;
                d4++;
            }
            if (p4 == 1 && u != 0 && u != 1)
                nr++;
            s = 0;
            if (b %2==1)
                s += b;
            if (c %2==1)
                s += c;
            if (v %2==1)
                s += v;
            if (f %2==1)
                s += f;
            if (nr == n && s == m)
                t[5] = 1;
            else
            {
                t[5] = 0;
                MessageBox.Show(nr.ToString() + " " + s.ToString());
            }
            tabControl1.SelectTab(5);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
                t[3] = 1;
            else t[3] = 0;
            tabControl1.SelectTab(3);
        }

        private void intrebare31_Click(object sender, EventArgs e)
        {

        }

        private void intrebare30_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n,m;
            try
            {
                n = Int32.Parse(raspuns20.Text);
                m = Int32.Parse(raspuns21.Text);
            }
            catch
            {
                n = 0;
                m = 0;
            }
            if (n == nIntrebare20 && m >= 0 && m < nIntrebare22)
                t[2] = 1;
            else t[2] = 0;
            tabControl1.SelectTab(2);
            r[1] = true;
            bool x = false;
            for (int i = 0; i <= 9; i++)
                x = x && r[i];
            evaluare.Enabled = x;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int ok1 = 0,ok2=0,ok3=0;
            int n = Int32.Parse(raspuns10.Text);
            int m = Int32.Parse(raspuns11.Text);
            if (nIntrebare10 == 2)
            {
                if (n == 0 && m == 0)
                    ok1 = 1;
                if (n == 0 && m == (nIntrebare12 - 1))
                    ok1 = 1;
                if (n == (nIntrebare11 - 1) && m == 0)
                    ok1 = 1;
                if (n == (nIntrebare11 - 1) && m == (nIntrebare12 - 1))
                    ok1 = 1;
                if (ok1 == 1)
                    t[1] = 1;
                else t[1] = 0;
            }
            if (nIntrebare10 == 3)
            {
                if (n == 0)
                    if (m > 0 && m < (nIntrebare12 - 1))
                        ok2 = 1;
                if (n == (nIntrebare11 - 1))
                    if (m > 0 && m < (nIntrebare12 - 1))
                        ok2 = 1;
                if (m == 0)
                    if (n > 0 && n < (nIntrebare11 - 1))
                        ok2 = 1;
                if (m == nIntrebare12 - 1)
                    if (n > 0 && n < (nIntrebare11 - 1))
                        ok2 = 1;
                if (ok2 == 1)
                    t[1] = 1;
                else t[1] = 0;
            }
            if (nIntrebare10 == 4)
            {
                if (n != 0 && m != 0 && n != (nIntrebare11 - 1) && m != (nIntrebare12 - 1))
                    ok3 = 1;
                if (ok3 == 1)
                    t[1] = 1;
                else t[1] = 0;
            }
            tabControl1.SelectTab(1);
            r[0] = true;
            bool x = false;
            for (int i = 0; i<= 9;i++)
                x=x && r[i];
            evaluare.Enabled = x;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int s = 0;
            for (int i = 1; i <= 9; i++)
                s = s + t[i];
            MessageBox.Show("Ai obtinut nota " + (s + 1).ToString());
        }

        public testare2()
        {
            InitializeComponent();
        }

        private void testare2_Load(object sender, EventArgs e)
        {
            //test
            for (int i = 0; i <= 9; i++)
                t[i] = 0;
            Random r = new Random();
            //generare intrebare 1
            nIntrebare10 = r.Next(2,4);
            nIntrebare11 = r.Next(3, 100);
            nIntrebare12 = r.Next(3, 100);
            intrebare10.Text = " Scrieți un element al tabloului bidimensional a, declarat mai jos, care are exact " + nIntrebare10.ToString() + " vecini.";
            intrebare11.Text = " int a[ " + nIntrebare11.ToString() + " ][ " + nIntrebare12.ToString() + " ] ;";
            //genereare intrebare 2
            nIntrebare20 = r.Next(0, nIntrebare21);
            nIntrebare21 = r.Next(15, 300);
            nIntrebare22 = r.Next(15, 300);
            intrebare2.Text = " Scrieți un element la alegere de pe linia " + nIntrebare20.ToString() + ", a matricei a, declarată mai jos.";
            intrebare21.Text = " int a[ " + nIntrebare21.ToString() + " ][ " + nIntrebare22.ToString() + " ] ;";
            //generare intrebare 3
            nIntrebare30 = r.Next(3, 100);
            nIntrebare31 = r.Next(3, 100);
            intrebare30.Text = " Variabilele i și j sunt de tip întreg, iar variabila m memorează un tabloul bidimensional cu " + nIntrebare30.ToString() + " linii și " + nIntrebare31.ToString() + " coloane, numerotate de la 0, cu elemente numere întregi.";
            intrebare31.Text = " O expresie C++ a cărei valoare este egală cu produsul dintre al treilea element de pe linia i și penultimul de pe coloana j din acest tablou este: ";
            varianta1.Text = " m[ 3 ][ i ] * m[ j ][ " + (nIntrebare31 - 2).ToString() + " ] ;";
            varianta2.Text = " m[ i ][ 3 ] * m[ " + (nIntrebare30 - 2).ToString() + " ][ j ] ;";
            varianta3.Text = " m( 3, i ) * m( j," + (nIntrebare30 - 2).ToString() + " ) ;";
            varianta4.Text = " m( i )( 3 ) * m( " + (nIntrebare31 - 2).ToString() + " )( j ) ;";
            //generare intrebare 4
            nIntrebare40 = r.Next(1, 999);
            nIntrebare41 = r.Next(0,4);
            nIntrebare42 = r.Next(0,5);
            intrebare4.Text = " Scrieți numărul " + nIntrebare40.ToString() + " în căsuța corespunzătoare elementului a[ " + nIntrebare41.ToString() + " ][ " + nIntrebare42.ToString() + " ] a matricei.";
            v = new MaskedTextBox[4, 5];
            v[0, 0] = a00;
            v[0, 1] = a01;
            v[0, 2] = a02;
            v[0, 3] = a03;
            v[0, 4] = a04;
            v[1, 0] = a10;
            v[1, 1] = a11;
            v[1, 2] = a12;
            v[1, 3] = a13;
            v[1, 4] = a14;
            v[2, 0] = a20;
            v[2, 1] = a21;
            v[2, 2] = a22;
            v[2, 3] = a23;
            v[2, 4] = a24;
            v[3, 0] = a30;
            v[3, 1] = a31;
            v[3, 2] = a32;
            v[3, 3] = a33;
            v[3, 4] = a34;
            //generare întrebare 5
            nIntrebare50 = r.Next(1, 3);
            nIntrebare51 = r.Next(1, 4);
            nIntrebare52 = r.Next(1, 3);
            nIntrebare53 = r.Next(1, 4);
            intrebare50.Text = " Câți vecini numere prime are elementul a[ " + nIntrebare50.ToString() + " ][ " + nIntrebare51.ToString() + " ] ?";
            intrebare51.Text = " Care este suma vecinilor impari ai elementului a[ " + nIntrebare52.ToString() + " ][ " + nIntrebare53.ToString() + "] ?";
            //generare intrebare 7
            nIntrebare70 = r.Next(3, 100);
            nIntrebare71 = r.Next(3, 100);
            nIntrebare72 = r.Next(0, nIntrebare70);
            nIntrebare73 = r.Next(0, nIntrebare71);
            intrebare70.Text = " int a[ " + nIntrebare70.ToString() + " ][ " + nIntrebare71.ToString() + " ] ;";
            intrebare71.Text = " Declarați elementul de pe linia " + nIntrebare72.ToString() + " și coloana " + nIntrebare73.ToString() + " și precizați câți vecini are acesta.";
        }
    }
}
