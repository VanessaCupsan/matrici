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
    public partial class generareMatrici : Form
    {
        public generareMatrici()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            suportTeoretic5 c = new suportTeoretic5();
            c.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            exersare5 v = new exersare5();
            v.ShowDialog();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            testare5 s = new testare5();
            s.ShowDialog();
        }
    }
}
