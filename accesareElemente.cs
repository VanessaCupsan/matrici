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
    public partial class accesareElemente : Form
    {
        public accesareElemente()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            suportTeoretic2 v = new suportTeoretic2();
            v.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            exersare2 s = new exersare2();
            s.ShowDialog();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            testare2 r = new testare2();
            r.ShowDialog();
        }
    }
}
