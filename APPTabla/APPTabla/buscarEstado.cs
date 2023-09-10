using AdultoMayor;
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
    public partial class buscarEstado : Form
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
        public buscarEstado()
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
            if (estado.Text == "Sobrepeso" || estado.Text == "Bajo peso" || estado.Text == "Normal")
            {
                cConexion oc = new cConexion();
                if (estado.Text == "Sobrepeso")
                {
                    dataGridView1.DataSource = oc.mostrarPorEstadoSalud("Sobrepeso");
                }
                else if (estado.Text == "Bajo peso")
                {
                    dataGridView1.DataSource = oc.mostrarPorEstadoSalud("Bajo peso");
                }
                else if (estado.Text == "Normal")
                {
                    dataGridView1.DataSource = oc.mostrarPorEstadoSalud("Normal");
                }
            }
            else  if (estado.Text == "" || estado.SelectedIndex !=0 || estado.SelectedIndex != 1 || estado.SelectedIndex != 2)
            {
                MessageBox.Show("Por favor escoja un estado de salud");
                estado.Text = "";
            }
        }

        private void buscarEstado_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
