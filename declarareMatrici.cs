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
    public partial class declarareMatrici : Form
    {
        public declarareMatrici()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            suportTeoretic1 s = new suportTeoretic1();
            s.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            exersare1 v = new exersare1();
            v.ShowDialog();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            testare1 r = new testare1();
            r.ShowDialog();
        }
    }
}
