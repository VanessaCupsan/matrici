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
    public partial class suportTeoretic5 : Form
    {
        public suportTeoretic5()
        {
            InitializeComponent();
        }

        private void suportTeoretic5_Load(object sender, EventArgs e)
        {
            rGenerareaMatricilor1.LoadFile("generareaMatricilor1.rtf");
            rGenerarePatrateMagice.LoadFile("generarePatrateMagice.rtf");
        }
    }
}
