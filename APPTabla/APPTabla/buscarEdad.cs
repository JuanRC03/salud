using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WfNinios;
using AdultoMayor;
using jovenes;

namespace APPTabla
{
    public partial class buscarEdad : Form
    {
        public string[] rec = new string[50];
        public string[] nom = new string[50];
        public string[] ape = new string[50];
        public string[] cat = new string[50];
        public string[] est = new string[50];
        public int[] eda = new int[50];
        public double[] pes = new double[50];
        public double[] tal = new double[50];
        public double[] mc = new double[50];
        public int po;
        int pos = 0;
        public buscarEdad()
        {
            InitializeComponent();
        }

        public void cargardatos(string[] nom1, string[] ape1, int[] eda1, double[] pes1, double[] tal1, double[] mc1, string[] est1, string[] cat1, string[] rec1, int pos1)
        {
            rec = rec1;
            nom = nom1;
            ape = ape1;
            cat = cat1;
            est = est1;
            eda = eda1;
            pes = pes1;
            tal = tal1;
            mc = mc1;
            po = pos1;
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            if (estado.Text == "Niño" || estado.Text == "Joven" || estado.Text == "Adulto" || estado.Text == "Adulto Mayor")
            {
                cConexion oc = new cConexion();
                if(estado.Text == "Niño")
                {
                    dataGridView1.DataSource = oc.mostrarPorEdad("Niño");
                }else if(estado.Text == "Joven" )
                {
                    dataGridView1.DataSource=oc.mostrarPorEdad("Joven");
                }
                else if(estado.Text == "Adulto" )
                {
                    dataGridView1.DataSource= oc.mostrarPorEdad("Adulto");
                }
                else if(estado.Text == "Adulto Mayor")
                {
                    dataGridView1.DataSource=oc.mostrarPorEdad("Adulto Mayor");
                }
            }
            else
            {
                if (estado.Text == "" || estado.Text != "Niño" || estado.Text != "Joven" || estado.Text != "Adulto" || estado.Text != "Adulto Mayor")
                {
                    MessageBox.Show("Por favor escoja una categoria de edad");
                    estado.Text = "";
                }
            }

        }

        

        private void estado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buscarEdad_Load(object sender, EventArgs e)
        {

        }
    }
}
