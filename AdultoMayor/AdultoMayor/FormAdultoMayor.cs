using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdultoMayor
{
    public partial class FormAdultoMayor : Form
    {
        public FormAdultoMayor()
        {
            InitializeComponent();
        }

        private void l_Click(object sender, EventArgs e)
        {
            lacteos obl = new lacteos();
            obl.ShowDialog();
        }

        private void p_Click(object sender, EventArgs e)
        {
            Proteinas obp = new Proteinas();
            obp.ShowDialog();
        }

        private void v_Click(object sender, EventArgs e)
        {
            Verduras obv = new Verduras();
            obv.ShowDialog();
        }

        private void f_Click(object sender, EventArgs e)
        {
            Frutas obf = new Frutas();
            obf.ShowDialog();
        }

        private void c_Click(object sender, EventArgs e)
        {
            Carbohidratos obc = new Carbohidratos();
            obc.ShowDialog();
        }

        private void l_MouseHover(object sender, EventArgs e)
        {
            lacteos oLac = new lacteos();
            oLac.ShowDialog();
        }

        private void c_MouseHover(object sender, EventArgs e)
        {
            Carbohidratos oCar = new Carbohidratos();
            oCar.ShowDialog();
        }

        private void f_MouseHover(object sender, EventArgs e)
        {
            Frutas oFru = new Frutas();
            oFru.ShowDialog();
        }

        private void p_MouseHover(object sender, EventArgs e)
        {
            Proteinas oPro = new Proteinas();
            oPro.ShowDialog();
        }

        private void v_MouseHover(object sender, EventArgs e)
        {
            Verduras oVer = new Verduras();
            oVer.ShowDialog();
        }
    }
}
