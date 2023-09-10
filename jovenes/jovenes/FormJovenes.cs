using adultos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jovenes
{
    public partial class FormJovenes : Form
    {
        public FormJovenes()
        {
            InitializeComponent();
        }

        private void l_Click(object sender, EventArgs e)
        {
          
        }

        private void p_Click(object sender, EventArgs e)
        {
          
        }

        private void v_Click(object sender, EventArgs e)
        {
         
        }

        private void f_Click(object sender, EventArgs e)
        {
    
        }

        private void c_Click(object sender, EventArgs e)
        {
           
        }

        private void l_MouseHover(object sender, EventArgs e)
        {
           
        }

        private void p_MouseHover(object sender, EventArgs e)
        {
           
        }

        private void v_MouseHover(object sender, EventArgs e)
        {
          
        }

        private void f_MouseHover(object sender, EventArgs e)
        {
        
        }

        private void c_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void l_MouseLeave(object sender, EventArgs e)
        {
            this.Close();
        }

        private void iconButton5_MouseHover(object sender, EventArgs e)
        {

        }

        private void l_MouseHover_1(object sender, EventArgs e)
        {
            LacteosJ oL = new LacteosJ();
            oL.ShowDialog();
        }

        private void p_MouseHover_1(object sender, EventArgs e)
        {
            ProteinaJ oP = new ProteinaJ();
            oP.ShowDialog();
        }

        private void v_MouseHover_1(object sender, EventArgs e)
        {
            VerduraJ oV = new VerduraJ();
            oV.ShowDialog();
        }

        private void f_MouseHover_1(object sender, EventArgs e)
        {
            FrutaJ oF = new FrutaJ();
            oF.ShowDialog();
        }

        private void c_MouseHover_1(object sender, EventArgs e)
        {
            CarbohidratoJ oC = new CarbohidratoJ();
            oC.ShowDialog();
        }

       
    }
}
