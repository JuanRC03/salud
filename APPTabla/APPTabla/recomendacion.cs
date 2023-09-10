using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APPTabla
{
    public partial class recomendacion : Form
    {
        string nom;
        string ape;
        double mc;
        string rec;
        string est;

        public recomendacion(string n,string a, double m, string e,string r)
        {
            InitializeComponent();
            nom = n;
            ape = a;
            mc = m;
            rec = r;
            est = e;
            lnom.Text ="Nombre: "+ nom + " " + ape;
            lmc.Text = ("Indice de masa corporal: " + mc).ToString();
            lr1.Text = "Estado: " + est;
            lr2.Text = rec;
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void recomendacion_Load(object sender, EventArgs e)
        {

        }
    }
}
