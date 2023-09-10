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
    public partial class Verduras : Form
    {
        public Verduras()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Verduras_MouseLeave(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
