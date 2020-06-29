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
        int[] t = new int[10];
        int nIntrebare10, nIntrebare11, nIntrebare12;

        private void button5_Click(object sender, EventArgs e)
        {

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
        }
    }
}
