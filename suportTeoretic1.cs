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
    public partial class suportTeoretic1 : Form
    {
        TextBox[,] a;
        int oriz = 30, vert = 200, latura = 24, pas = 24;
        int[] t = new int[10];
        public suportTeoretic1()
        {
            InitializeComponent();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void suportTeoretic1_Load(object sender, EventArgs e)
        {
            //generare matrice
            a = new TextBox[12, 12];
            for (int i = 0; i <= 10; i++)
                for (int j = 0; j <= 10; j++)
                {
                    a[i, j] = new TextBox();
                    tabPage4.Controls.Add(a[i, j]);
                    a[i, j].Left = oriz + j * pas;
                    a[i, j].Top = vert + i * pas;
                    a[i, j].Width = latura;
                    a[i, j].Height = 2 * latura;
                    if (i == 0) { a[i, j].BackColor = Color.GreenYellow; a[i, j].Text = (j - 1).ToString(); a[i, j].ReadOnly = true; }
                    if (j == 0) { a[i, j].BackColor = Color.DarkOliveGreen; a[i, j].Text = (i - 1).ToString(); a[i, j].ReadOnly = true; }
                    a[i, j].Visible = false;
                }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            for (int i = 0; i <= 10; i++)
                for (int j = 0; j <= 10; j++)
                {
                    a[0, 0].Visible = false;
                    a[i, j].Visible = (i <= numericUpDown1.Value && j <= numericUpDown2.Value);
                }
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            for (int i = 0; i <= 10; i++)
                for (int j = 0; j <= 10; j++)
                {
                    a[0, 0].Visible = false;
                    a[i, j].Visible = (i <= numericUpDown1.Value && j <= numericUpDown2.Value);
                }
        }

        private void richTextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }
    }
}
