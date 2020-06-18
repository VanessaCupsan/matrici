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
    public partial class matrici : Form
    {
        public matrici()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void declarareMatrici_Click(object sender, EventArgs e)
        {
            declarareMatrici p = new declarareMatrici();
            p.ShowDialog();
        }

        private void accesareaElementelor_Click(object sender, EventArgs e)
        {
            accesareElemente t = new accesareElemente();
            t.ShowDialog();
        }

        private void matriciPatratice_Click(object sender, EventArgs e)
        {
            parcurgereMatrici m = new parcurgereMatrici();
            m.ShowDialog();
        }

        private void generareMatrici_Click(object sender, EventArgs e)
        {
            matriciPatratice s = new matriciPatratice();
            s.ShowDialog();
        }

        private void parcurgereMatriciOarecare_Click(object sender, EventArgs e)
        {
            generareMatrici v = new generareMatrici();
            v.ShowDialog();
        }

        private void problemeDiverse_Click(object sender, EventArgs e)
        {
            problemeDiverse w = new problemeDiverse();
            w.ShowDialog();
        }
    }
}
