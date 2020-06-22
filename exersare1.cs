using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace matrici
{
    public partial class exersare1 : Form
    {
        int nIntrebare2;
        public exersare1()
        {
            InitializeComponent();
        }

        private void exersare1_Load(object sender, EventArgs e)
        {
            
            Random r = new Random();
            nIntrebare2 = r.Next(3, 200);
            intrebare2.Text = " Fiind dat un tablou bidimensional cu " + nIntrebare2.ToString() + " de linii și " + nIntrebare2.ToString() + " de coloane, câte elemente se găsesc strict deasupra diagonalei secundare a tabloului ?";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (butonRadio1.Checked)
                MessageBox.Show("Răspuns corect.");
            else MessageBox.Show("Răspunsul corect este int a[2][10], deoarece are exact 20 de elemente, toate numere întregi de cel mult 4 cifre");

        }

        private void label5_Click(object sender, EventArgs e)
        {
            
        }

        private void nrLinii_SelectedItemChanged(object sender, EventArgs e)
        {
            
        }

        private void nrColoane_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int raspuns2numar;
            int corect;
            corect = nIntrebare2 * (nIntrebare2 - 1) / 2;
            try 
            {
                raspuns2numar = Int32.Parse(raspuns2.Text);
            }
            catch
            {
                raspuns2numar = 0;
            }
            if (raspuns2numar == nIntrebare2 * (nIntrebare2 - 1) / 2)
                MessageBox.Show("Răspuns corect.");
            else MessageBox.Show("Răspunsul corect este " + corect +".");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (raspuns31.Text == "F" && raspuns32.Text == "A" && raspuns33.Text == "A" && raspuns34.Text == "F")
                MessageBox.Show("Răspuns corect.");
            else MessageBox.Show(" Răspunsurile corecte sunt b) și c) .");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked && checkBox6.Checked && checkBox11.Checked && checkBox12.Checked)
                MessageBox.Show("Răspuns corect.");
            else MessageBox.Show("Trebuiau bifate: prima și al patra căsuță pe orizontală și a doua și a treia căsuță pe verticală. ");
        }
    }
}
