﻿using System;
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
    public partial class codSumePartiale : Form
    {
        public codSumePartiale()
        {
            InitializeComponent();
        }

        private void codSumePartiale_Load(object sender, EventArgs e)
        {
            rtCod.LoadFile("codst6.rtf");
        }
    }
}
