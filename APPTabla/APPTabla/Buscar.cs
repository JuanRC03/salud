using AdultoMayor;
using System;
using System.Collections;
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
    public partial class Buscar : Form
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
        int op=0;
        String recomen = "";
        public Buscar()
        {
            InitializeComponent();
        }

        public void cargardatos(string[] nom1, string[] ape1, int[] eda1, double[] pes1, double[] tal1, double[] mc1, string[] est1, string[] cat1, string[] rec1, int pos1)
        {
            InitializeComponent();
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

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txbnombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar) == (char)Keys.Enter)
            {
                if (txbnombre.Text == "")
                {
                    MessageBox.Show("Por favor no deje en blanco el recuadro");
                }
                else
                {
                    
                }
            }
        }

      

        private void btnbuscar_Click(object sender, EventArgs e)
        {

            
            Boolean control = false;
            if ( txbnombre.Text == "")
            {
                MessageBox.Show("Los campos no están llenos");
            }
            else {
                tCed.Text = "";
                lnom.Text = "";
                lape.Text = "";
                leda.Text = "";
                lpes.Text = "";
                ltal.Text = "";
                lmas.Text = "";
                lest.Text = "";
                lgen.Text = "";

                ArrayList oa = new ArrayList();
                oa = null;
                cConexion oc = new cConexion();
                oa = oc.buscarUsuario(txbnombre.Text);
                if (oa[0].ToString() != "")
                {
                    tCed.Text= oa[0].ToString();
                    lnom.Text = oa[1].ToString();
                    lape.Text = oa[2].ToString();
                    leda.Text = oa[5].ToString();
                    lpes.Text = oa[4].ToString();
                    ltal.Text = oa[3].ToString();
                    lmas.Text = oa[7].ToString();
                    lest.Text = oa[9].ToString();
                    recomen= oa[8].ToString();
                    lgen.Text = oa[6].ToString();
                    MessageBox.Show("Los datos se encontraron dentro de los registros de la apicacion");
                    Reco.Enabled = true;
                    op = 1;
                }
                else
                {
                    ArrayList oa2 = new ArrayList();
                    oa2 = null;
                    oa2 = oc.buscarEstudiantesNoRegistrados(txbnombre.Text);

                    if (oa2[0].ToString() != "")
                    {
                        tCed.Text = oa2[0].ToString();
                        lnom.Text = oa2[1].ToString();
                        lape.Text = oa2[2].ToString();
                        MessageBox.Show("Los datos se encontraron en los estudantes");
                        op = 2;
                    }
                    else
                    {
                        MessageBox.Show("El usuario con el cedula " + txbnombre.Text + " no existe, ni sus registros, ni en la base de datos de los estiantes");
                        txbnombre.Clear();
                    }
                }

             }
        }

        private void Limpiar_Click(object sender, EventArgs e)
        {
            limpiar();
            Reco.Enabled = false;
        }
        public void limpiar()
        {
            txbnombre.Text = "";
            tCed.Text = "";
            lnom.Text = "";
            lape.Text = "";
            leda.Text = "";
            lpes.Text = "";
            ltal.Text = "";
            lmas.Text = "";
            lest.Text = "";
            lgen.Text = "";
        }


        private void Reco_Click(object sender, EventArgs e)
        {
            if (op == 1)
            {
                recomendacion or = new recomendacion(lnom.Text, lape.Text, double.Parse(lmas.Text), ltal.Text, recomen);
                or.ShowDialog();
            }
        }

        private void Buscar_Load(object sender, EventArgs e)
        {
            txbnombre.Focus();
        }

        private void txbnombre_MouseHover(object sender, EventArgs e)
        {
            txbnombre.Focus();
        }
    }
}