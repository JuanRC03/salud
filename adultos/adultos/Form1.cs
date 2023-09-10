using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void l_Click(object sender, EventArgs e)
        {
            lacteos ol = new lacteos();
            ol.ShowDialog();
        }

        private void p_Click(object sender, EventArgs e)
        {
            proteina op = new proteina();
            op.ShowDialog();
        }

        private void v_Click(object sender, EventArgs e)
        {
            vegetales ov = new vegetales();
            ov.ShowDialog();
        }

        private void f_Click(object sender, EventArgs e)
        {
            Frutas of = new Frutas();
            of.ShowDialog();
        }

        private void c_Click(object sender, EventArgs e)
        {
            carbohidratos oc = new carbohidratos();
            oc.ShowDialog();
        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void l_MouseHover(object sender, EventArgs e)
        {
            lacteos oLac = new lacteos();
            oLac.ShowDialog();
        }

        private void p_MouseHover(object sender, EventArgs e)
        {
            proteina oPro = new proteina();
            oPro.ShowDialog();
        }

        private void v_MouseHover(object sender, EventArgs e)
        {
            vegetales oVeg = new vegetales();
            oVeg.ShowDialog();
        }

        private void f_MouseHover(object sender, EventArgs e)
        {
            Frutas oFru = new Frutas();
            oFru.ShowDialog();
        }

        private void c_MouseHover(object sender, EventArgs e)
        {
            carbohidratos oCar = new carbohidratos();
            oCar.ShowDialog();
        }
    }
}
