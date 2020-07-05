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
    public partial class parcurgereMatrici : Form
    {
        public parcurgereMatrici()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            suportTeoretic3 x = new suportTeoretic3();
            x.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            exersare3 s = new exersare3();
            s.ShowDialog();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            testare3 c = new testare3();
            c.ShowDialog();
        }
    }
}
