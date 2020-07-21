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
    public partial class problemeDiverse : Form
    {
        public problemeDiverse()
        {
            InitializeComponent();
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            suportTeoretic6 s = new suportTeoretic6();
            s.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            exersare6 v = new exersare6();
            v.ShowDialog();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            testare6 t = new testare6();
            t.ShowDialog();
        }
    }
}
