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
        int n, m;
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
            exercitiul1.Text = @" Completează secvența de program de mai jos astfel încât să construiască o matrice a cu n="+n.ToString()+ " linii și m="+m.ToString()+@" coloane în care a[i][j] memorează minimul dintre valorile i și j. Pentru n=4 și m=5 se afișează matricea din dreapta.
                                 for(i=0;i<n;i++)
                                    for(j=0;j<=m;j++)
                                        ...";
            exemplu1.Text = @"0 1 2 3 4
1 1 2 3 4
2 2 2 3 4
3 3 3 3 4";
        }
    }
}
