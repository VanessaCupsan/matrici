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
    public partial class suportTeoretic6 : Form
    {
        public suportTeoretic6()
        {
            InitializeComponent();
        }

        private void suportTeoretic6_Load(object sender, EventArgs e)
        {
            rtSumePartiale.LoadFile("sumePartiale.rtf");
            rtPointeri.LoadFile("pointeriMatrice.rtf");
        }

        private void button1_Click(object sender, EventArgs e)
        {

            codSumePartiale c = new codSumePartiale();
            c.ShowDialog();
        }
    }
}
