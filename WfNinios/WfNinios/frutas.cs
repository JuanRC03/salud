﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WfNinios
{
    public partial class frutas : Form
    {
        public frutas()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frutas_MouseLeave(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
