using System;
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
    public partial class FormNinios : Form
    {
        public FormNinios()
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
            verduras obv = new verduras();
            obv.ShowDialog();
        }

        private void f_Click(object sender, EventArgs e)
        {
            frutas obf = new frutas();
            obf.ShowDialog();
        }

        private void c_Click(object sender, EventArgs e)
        {
            carboidratos obc = new carboidratos();
            obc.ShowDialog();
        }

        private void l_MouseHover(object sender, EventArgs e)
        {
            lacteos oLac = new lacteos();
            oLac.ShowDialog();
        }

        private void p_MouseHover(object sender, EventArgs e)
        {
            Proteinas oPro = new Proteinas();
            oPro.ShowDialog();
        }

        private void v_MouseHover(object sender, EventArgs e)
        {
            verduras oVer = new verduras();
            oVer.ShowDialog();
        }

        private void f_MouseHover(object sender, EventArgs e)
        {
            frutas oFru = new frutas();
            oFru.ShowDialog();
        }

        private void c_MouseHover(object sender, EventArgs e)
        {
            carboidratos oCar = new carboidratos();
            oCar.ShowDialog();
        }

        
    }
}
