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
    public partial class suportTeoretic3 : Form
    {
        public suportTeoretic3()
        {
            InitializeComponent();
        }

        private void richTextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            rCitire.LoadFile("citire.rtf");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            rAfisare.LoadFile("afisare.rtf");
        }

        private void richTextBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
