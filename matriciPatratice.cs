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
    public partial class matriciPatratice : Form
    {
        public matriciPatratice()
        {
            InitializeComponent();
        }

        private void matriciPatratice_Load(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            suportTeoretic4 c = new suportTeoretic4();
            c.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            exersare4 x = new exersare4();
            x.ShowDialog();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            testare4 d = new testare4();
            d.ShowDialog();
        }
    }
}
