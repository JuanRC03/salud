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
    public partial class Proteinas : Form
    {
        public Proteinas()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Proteinas_MouseLeave(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
