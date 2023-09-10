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
    public partial class guardarpersona : Form
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
        public int po = 0;
        public int pos = 0;

        public int n = 0, a = 0, ed = 0, t = 0, p = 0;

        
        public guardarpersona()
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

        private void txbapellido_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txbnombre_KeyPress(object sender, KeyPressEventArgs e)
        {

            
            
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txbpeso_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar) == (char)Keys.Enter)
            {
                if (txbpeso.Text == "")
                {
                    MessageBox.Show("Por favor no deje en blanco el peso");
                }
                else
                {
                    if (int.Parse(txbpeso.Text) >= 1 && int.Parse(txbpeso.Text) <= 1000)
                    {
                        p = 1;
                        guardar.Focus();
                        Limpiar.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("Por favor ingrese un peso entre el rango de 1 a 1000 kg");
                    }

                }
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guardarpersona_Load(object sender, EventArgs e)
        {
            txbnombre.Select();
            txbnombre.Focus();
        }

        private void txbapellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar) == (char)Keys.Enter)
            {
                if (txbapellido.Text == "")
                {
                    MessageBox.Show("Por favor no deje en blanco el apellido");
                }
                else
                {
                    cedula.Focus();
                    Limpiar.Enabled = true;
                    a = 1;
                }
            }
        }

        private void Limpiar_Click(object sender, EventArgs e)
        {
            cedula.Clear();
            txbnombre.Clear();
            txbapellido.Clear();
            txbedad.Clear();
            txttalla.Clear();
            txbpeso.Clear();
            txbnombre.Focus();
        }

        private void txttalla_TextChanged(object sender, EventArgs e)
        {

        }

        private void txttalla_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }
            if ((e.KeyChar) == (char)Keys.Enter)
            {
                if (txbnombre.Text == "")
                {
                    MessageBox.Show("Por favor no deje en blanco la talla");
                }
                else
                {
                    try
                    {
                        float x = float.Parse(txttalla.Text);
                        if (x > 20 && x < 210)
                        {
                            txbpeso.Focus();
                            t = 1;
                            Limpiar.Enabled = true;
                        }
                        else
                        {
                            MessageBox.Show("Por favor no ingrese una estatura entre 0.20 y 2.1");
                            txttalla.Clear();
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Por favor no ingrese una estatura en metros ejemplo 1,70");
                        txttalla.Clear();
                    }
                }
            }
        }

        private void txbnombre_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar) == (char)Keys.Enter)
            {
                if (txbnombre.Text == "")
                {
                    MessageBox.Show("Por favor no deje en blanco el nombre");
                }
                else
                {
                    txbapellido.Focus();
                    Limpiar.Enabled = true;
                    n = 1;
                }
            }
        }

        private void txbnombre_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void txbnombre_MouseHover(object sender, EventArgs e)
        {
            txbnombre.Focus();
        }

        

        private void txbedad_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void cedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar) == (char)Keys.Enter)
            {
                if (cedula.Text == "")
                {
                    MessageBox.Show("Por favor no deje en blanco el apellido");
                }
                else
                {
                    txbedad.Focus();
                    Limpiar.Enabled = true;
                    a = 1;
                }
            }
        }

        private void guardar_Click_1(object sender, EventArgs e)
        {
            bool control = false;
            for (int i = 0; i < po; i++)
            {
                if (txbnombre.Text == nom[i] && txbapellido.Text == ape[i])
                {
                    control = true;
                }
            }
            if (txbnombre.Text != "" && txbapellido.Text != "" && txbedad.Text != "" && txttalla.Text != "" && txbpeso.Text != "")
            {
                if (int.Parse(txbedad.Text) < 0 || int.Parse(txbedad.Text) > 150)
                {
                    txbedad.Clear();
                    MessageBox.Show("La edad ingresada no se encuentra dentro de los limetes de 0-150");
                }
                else
                {
                    if (double.Parse(txttalla.Text) < 20 || double.Parse(txttalla.Text) > 210)
                    {
                        txttalla.Clear();
                        MessageBox.Show("La talla ingresada no se encuentra dentro de los limetes de 0,20 a 2,5");
                    }
                    else
                    {
                        if (int.Parse(txbpeso.Text) < 1 || int.Parse(txbpeso.Text) > 1000)
                        {
                            txbpeso.Clear();
                            MessageBox.Show("El peso ingresado no se encuentra dentro de los limetes de 1 a 700");
                        }
                        else
                        {
                            if (control == false)
                            {
                                
                                string NoAp;
                                nombre_apellido oNomApe = new nombre_apellido();
                                NoAp = oNomApe.validarNombreApellido(txbnombre.Text);
                                nom[po] = NoAp;
                                NoAp = oNomApe.validarNombreApellido(txbapellido.Text);
                                ape[po] = NoAp;
                                eda[po] = int.Parse(txbedad.Text);
                                pes[po] = double.Parse(txbpeso.Text);
                                tal[po] = double.Parse(txttalla.Text);
                                mc[po] = Math.Round(masaCorporal(), 2);
                                if (eda[po] >= 0 && eda[po] <= 11)
                                {
                                    cat[po] = "Niño";

                                    Estado_recomen_n oEst = new Estado_recomen_n(eda[po], pes[po]);
                                    est[po] = oEst.verificar();
                                    rec[po] = oEst.Recomendacion_estado();

                                }
                                else if (eda[po] > 11 && eda[po] <= 19)
                                {
                                    cat[po] = "Joven";
                                    Estado_recomen_Jov oEst = new Estado_recomen_Jov((tal[po]/100), pes[po]);
                                    est[po] = oEst.verificar();
                                    rec[po] = oEst.Recomendacion_estado();
                                }
                                else if (eda[po] > 19 && eda[po] <= 50)
                                {
                                    cat[po] = "Adulto";
                                    Estado_recomen oEst = new Estado_recomen((tal[po] / 100), mc[po]);
                                    est[po] = oEst.verificar();
                                    rec[po] = oEst.Recomendacion_estado();

                                }
                                else if (eda[po] > 50 && eda[po] <= 150)
                                {
                                    cat[po] = "Adulto Mayor";
                                    Estado_recomen_ad oEst = new Estado_recomen_ad(eda[po], pes[po]);
                                    est[po] = oEst.verificar(mc[po]);
                                    rec[po] = oEst.Recomen_Estado_AdulMay();

                                }
                                cConexion oc = new cConexion();
                                
                                oc.agregarUsuario(cedula.Text, txbnombre.Text, txbapellido.Text, float.Parse(txttalla.Text),float.Parse(txbpeso.Text),int.Parse(txbedad.Text), cat[po], mc[po], rec[po], est[po]);
                                cedula.Text = "";
                                txbnombre.Text = "";
                                txbapellido.Text = "";
                                txbedad.Text = "";
                                txttalla.Text = "";
                                txbpeso.Text = "";
                                n = 0;
                                a = 0;
                                ed = 0;
                                t = 0;
                                p = 0;
                                MessageBox.Show("Datos guardados correctamente");
                                po++;
                                Limpiar.Enabled = false;


                            }
                            else
                            {
                                MessageBox.Show("El nombre ingresado ya se encuentra registrado");
                            }
                        }
                    }
                }

            }
            else
            {
                MessageBox.Show("Aún no ha ingresado datos para guardar");
            }
            txbnombre.Focus();
        }


        private void txbedad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar) == (char)Keys.Enter)
            {
                if (txbedad.Text == "")
                {
                    MessageBox.Show("Por favor no deje en blanco el recuadro");
                }
                else
                {
                    if (int.Parse(txbedad.Text) <= 150)
                    {
                        txttalla.Focus();
                        ed = 1;
                        Limpiar.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("Edades admitidas entre 0 y 150 años");
                        txbedad.Clear();
                    }
                }
                  
            }
        }

        private void txttalla_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }
            if ((e.KeyChar) == (char)Keys.Enter)
            {
                if (txbnombre.Text == "")
                {
                    MessageBox.Show("Por favor no deje en blanco la talla");
                }
                else
                {
                    try
                    {
                        float x = float.Parse(txttalla.Text);
                        if (x > 0.20 && x < 2.1)
                        {
                            txbpeso.Focus();
                            t = 1;
                            Limpiar.Enabled = true;
                        }
                        else
                        {
                            MessageBox.Show("Por favor no ingrese una estatura entre 0.20 y 2,1");
                            txttalla.Clear();
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Por favor no ingrese una estatura en metros ejemplo 1,70");
                        txttalla.Clear();
                    }
                }
            }
        }

        public double masaCorporal()
        {
            double masa = Math.Pow((tal[po]/100), 2);
            masa = pes[po] / masa;
            return masa;
        }
    }
}
