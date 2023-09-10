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
    public partial class modificar_usuarios : Form
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
        int op = 0;
        public modificar_usuarios()
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
            Boolean control = false;
            if ( txbnombre1.Text == "")
            {
                MessageBox.Show("Los campos no están llenos");
                txbnombre.Text = "";
                txbapellido.Text = "";
                txbedad1.Text = "";
                txttalla.Text = "";
                txbpeso.Text = "";
                gmodificar.Enabled = false;
            }
            else
            {
                ArrayList oa = new ArrayList();
                oa = null;
                cConexion oc = new cConexion();
                oa=oc.buscar(txbnombre1.Text);
                if (oa[0].ToString()!="")
                {
                    txtCedula.Text = oa[0].ToString();
                    txbnombre.Text = oa[1].ToString();
                    txbapellido.Text= oa[2].ToString();
                    txbpeso.Text= oa[3].ToString();
                    txbedad1.Text= oa[4].ToString();
                    txttalla.Text= oa[5].ToString();
                    groupBox1.Enabled = false;
                    gmodificar.Enabled = true;
                    txbnombre1.Clear();
                    MessageBox.Show("Los datos se encontraron dentro de los registros de la apicacion");
                    op = 1;
                }
                else
                {
                    ArrayList oa2 = new ArrayList();
                    oa2 = null;
                    oa2 = oc.buscarEstudiantes(txbnombre1.Text);
                    
                    if (oa2[0].ToString() != "")
                    {
                        txtCedula.Text = oa2[0].ToString();
                        txbnombre.Text = oa2[1].ToString();
                        txbapellido.Text = oa2[2].ToString();
                        groupBox1.Enabled = false;
                        gmodificar.Enabled = true;
                        txbnombre1.Clear();
                        MessageBox.Show("Los datos se encontraron en los estudantes");
                        op = 2;
                    }
                    else
                    {
                        MessageBox.Show("El usuario con el cedula " + txbnombre1.Text + " no existe, ni sus registros, ni en la base de datos de los estiantes");
                        txbnombre1.Clear();
                    }
                }
            }
        }

        private void txbnombre1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar) == (char)Keys.Enter)
            {
                if (txbnombre1.Text == "")
                {
                    MessageBox.Show("Por favor no dejen en blanco el recuadro");
                }
                else
                {
                    
                }
            }
        }

        private void txbnombre1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            txbnombre1.Clear();
            txbapellido.Clear();
            txbedad1.Clear();
            txbpeso.Clear();
            txttalla.Clear();
            gmodificar.Enabled = false;
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            txtCedula.Text = "";
            txbnombre1.Clear();
            txbnombre.Clear();
            txbapellido.Clear();
            txbedad1.Clear();
            txbpeso.Clear();
            txttalla.Clear();
            groupBox1.Enabled = true;
            gmodificar.Enabled = false;
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guardar_Click(object sender, EventArgs e)
        {
            Boolean control = false;
            for (int i = 0; i < po; i++)
            {
                if (pos != i)
                {
                    if (txbnombre.Text == nom[i] && txbapellido.Text == ape[i])
                    {
                        control = true;
                    }
                }
            }
            if (txbapellido.Text != "" && txbapellido.Text != "" && txbedad1.Text != "" && txttalla.Text != "" && txbpeso.Text != "")
            {
                if (int.Parse(txbedad1.Text) < 0 || int.Parse(txbedad1.Text) > 150)
                {
                    MessageBox.Show("La edad ingresada no se encuentra dentro de los límites de 0-150");
                }
                else
                {
                    if (double.Parse(txttalla.Text) < 20 || double.Parse(txttalla.Text) > 210)
                    {
                        MessageBox.Show("La talla ingresada no se encuentra dentro de los límites de 0,20 a 2,5");
                    }
                    else
                    {
                        if (int.Parse(txbpeso.Text) < 1 || int.Parse(txbpeso.Text) > 1000)
                        {
                            MessageBox.Show("La talla ingresada no se encuentra dentro de los límites de 1 a 1000");
                        }
                        else
                        {
                            if (control == false)
                            {
                                string NoAp;
                                nombre_apellido oNomApe = new nombre_apellido();
                                NoAp = oNomApe.validarNombreApellido(txbnombre.Text);
                                nom[pos] = NoAp;
                                NoAp = oNomApe.validarNombreApellido(txbapellido.Text);
                                ape[pos] = NoAp;
                                eda[pos] = int.Parse(txbedad1.Text);
                                pes[pos] = double.Parse(txbpeso.Text);
                                tal[pos] = double.Parse(txttalla.Text);
                                mc[pos] = Math.Round(masaCorporal(), 2);
                                if (eda[pos] >= 0 && eda[pos] <= 11)
                                {
                                    cat[pos] = "Niño";
                                    Estado_recomen_n oEst = new Estado_recomen_n(eda[pos], pes[pos]);
                                    est[pos] = oEst.verificar();
                                    rec[pos] = oEst.Recomendacion_estado();
                                }
                                if (eda[pos] > 11 && eda[pos] <= 19)
                                {
                                    cat[pos] = "Joven";
                                    Estado_recomen_Jov oEst = new Estado_recomen_Jov((tal[pos]/100), pes[pos]);
                                    est[pos] = oEst.verificar();
                                    rec[pos] = oEst.Recomendacion_estado();
                                }
                                if (eda[pos] > 19 && eda[pos] <= 50)
                                {
                                    cat[pos] = "Adulto";
                                    Estado_recomen oEst = new Estado_recomen((tal[pos]/100), mc[pos]);
                                    est[pos] = oEst.verificar();
                                    rec[pos] = oEst.Recomendacion_estado();
                                }
                                if(eda[pos] > 50 && eda[pos] <= 150)
                                {
                                    cat[pos] = "Adulto Mayor";
                                    Estado_recomen_ad oEst = new Estado_recomen_ad(eda[pos], pes[pos]);
                                    est[pos] = oEst.verificar(mc[po]);
                                    rec[pos] = oEst.Recomen_Estado_AdulMay();
                                }
                                cConexion oc = new cConexion();
                                if (op == 1)
                                {
                                    oc.editarUsuario(txtCedula.Text, txbnombre.Text, txbapellido.Text, float.Parse(txttalla.Text), float.Parse(txbpeso.Text), int.Parse(txbedad1.Text), cat[po], mc[po], rec[po], est[po]);
                                }
                                else
                                {
                                    oc.agregarEstudiante(txtCedula.Text, txbnombre.Text, txbapellido.Text, float.Parse(txttalla.Text), float.Parse(txbpeso.Text), int.Parse(txbedad1.Text), cat[po], mc[po], rec[po], est[po]);
                                    oc.editarEstudiante(txtCedula.Text, txbnombre.Text, txbapellido.Text);
                                }
                                txtCedula.Text = "";
                                txbnombre.Text = "";
                                txbapellido.Text = "";
                                txbedad1.Text = "";
                                txttalla.Text = "";
                                txbpeso.Text = "";
                                MessageBox.Show("Datos guardados correctamente");
                                gmodificar.Enabled = false;
                                groupBox1.Enabled = true;
                            }
                            else
                            {
                                MessageBox.Show("El nombre del ususario ya se encuentra registrado");
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Aun no ingresa datos para modificar");
            }
        }
        public double masaCorporal()
        {
            double masa = Math.Pow((tal[pos]/100), 2);
            masa = pes[pos] / masa;
            return masa;
        }

        private void txbnombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar) == (char)Keys.Enter)
            {
                if (txbnombre.Text == "")
                {
                    MessageBox.Show("Por favor no deje en blanco los recuadros");
                }
                else
                {
                    txbapellido.Focus();
                }
            }
        }

        private void txbapellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar) == (char)Keys.Enter)
            {
                if (txbapellido.Text == "")
                {
                    MessageBox.Show("Por favor no deje en blanco los recuadros");
                }
                else
                {
                    txbedad1.Focus();
                }
            }
        }

        private void txbedad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar) == (char)Keys.Enter)
            {
                if (txbedad1.Text == "")
                {
                    MessageBox.Show("Por favor no dejen en blanco los recuadros");
                }
                else
                {
                    try
                    {
                        int x = int.Parse(txbedad1.Text);
                        if (x > 150)
                        {
                            MessageBox.Show("Por favor ingresar edades entre 0 y 150");
                            txbedad1.Clear();
                        }
                        else
                        {
                            txttalla.Focus();
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Algo salio mal por favor intente de nuevo");
                        txbedad1.Clear();
                    }
                }

            }
        }

        private void txbpeso_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar) == (char)Keys.Enter)
            {
                if (txbpeso.Text == "")
                {
                    MessageBox.Show("Por favor no dejen en blanco los recuadros");
                }
                else
                {
                    try
                    {
                        double x = double.Parse(txbpeso.Text);
                        if (x > 1000 || x < 1)
                        {
                            MessageBox.Show("Por favor no ingres un peso entre 1 y 1000 ");
                            txbpeso.Clear();
                        }

                    }
                    catch
                    {
                        MessageBox.Show("Por favor solo ingrese peso en kg");
                        txbpeso.Clear();
                    }
                }

            }
        }

        private void modificar_usuarios_Load(object sender, EventArgs e)
        {
            txbnombre1.Focus();
        }

        private void txbnombre1_MouseHover(object sender, EventArgs e)
        {
            txbnombre1.Focus();
        }

        private void Limpiar_Click(object sender, EventArgs e)
        {
            
        }

        private void Limpiar_Click_1(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txbapellido1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar) == (char)Keys.Enter)
            {
                if ( txbnombre1.Text != "")
                {
                    btnbuscar.Enabled = true;
                    btnbuscar.Focus();
                }
                else
                {
                    if (txbapellido.Text == "")
                    {
                        MessageBox.Show("El aplellido no ha sido ingresado");
                    }
                    else
                    {
                        MessageBox.Show("El nombre no ha sido ingresado");
                    }
                }
            }
        }

        private void txttalla_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar) == (char)Keys.Enter)
            {
                if (txttalla.Text == "")
                {
                    MessageBox.Show("Por favor no dejen en blanco los recuadros");
                }
                else
                {
                    try
                    {
                        double x = double.Parse(txttalla.Text);
                        if (x > 210 || x < 20)
                        {
                            MessageBox.Show("Por favor ingresar estaturas entre 0,2 y 2,1");
                            txttalla.Clear();
                        }
                        else
                        {
                            txbpeso.Focus();
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Por favor solo ingrese estaturas en metros. Ejemplo 1,70");
                        txttalla.Clear();
                    }
                }

            }
        }

        private void gmodificar_Enter(object sender, EventArgs e)
        {

        }
    }
}
