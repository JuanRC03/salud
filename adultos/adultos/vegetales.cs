﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace adultos
{
    public partial class vegetales : Form
    {
        public vegetales()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void vegetales_MouseLeave(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}