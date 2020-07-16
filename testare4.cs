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
    public partial class testare4 : Form
    {
        int nExercitiul5;
        int[] t = new int[10];
        public testare4()
        {
            InitializeComponent();
        }

        private void testare4_Load(object sender, EventArgs e)
        {
            //test
            for (int i = 0; i <= 9; i++)
                t[i] = 0;
            Random r = new Random();
            //generare intrebarea 5
            nExercitiul5 = r.Next(3, 100);
            exercitiul5.Text = " În secvența de program următoare, variabila t memorează o matrice cu n=" + nExercitiul5.ToString() + " linii și n=" + nExercitiul5.ToString() + " coloane, numerotate de la 0 la " + (nExercitiul5 - 1).ToString() + ", cu elemente numere întregi, iar celelalte variabile sunt întregi.";
            rEx5.LoadFile("ex5exersare4.rtf");
        }

        

        private void evaluare_Click(object sender, EventArgs e)
        {
            int s = 0;
            for (int i = 1; i <= 9; i++)
                s = s + t[i];
            MessageBox.Show("Ai obtinut nota " + (s + 1).ToString());
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            if (radioButton8.Checked)
                t[5] = 1;
            else t[5] = 0;
            tabControl1.SelectTab(5);
        }
    }
}
