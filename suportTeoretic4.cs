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
    public partial class suportTeoretic4 : Form
    {
        public suportTeoretic4()
        {
            InitializeComponent();
        }

        private void suportTeoretic4_Load(object sender, EventArgs e)
        {
            rMatricePatratica.LoadFile("matricePatratica.rtf");
            rDiagonalaPrincipala.LoadFile("diagonalaPrincipala.rtf");
            rDiagonalaSecundara.LoadFile("diagonalaSecundara.rtf");
            rZoneleMatricei.LoadFile("zoneleMatricei.rtf");

        }
    }
}
