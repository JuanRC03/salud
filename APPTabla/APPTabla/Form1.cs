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
using AdultoMayor;

namespace APPTabla
{


    public partial class Form1 : Form
    {

        public string[] recomendacion = new string[50];
        public string[] nombre = new string[50];
        public string[] apellido = new string[50];
        public string[] categoria = new string[50];
        public string[] estado = new string[50];
        public int[] edad = new int[50];
        public double[] peso = new double[50];
        public double[] talla = new double[50];
        public double[] mc = new double[50];
        public int pos = 0;
        Form x = new adultos.Form1();
        Form ninios = new WfNinios.FormNinios();
        Form AdMayor = new AdultoMayor.FormAdultoMayor();
        Form jovenes = new jovenes.FormJovenes();
        guardarpersona og = new guardarpersona();
        modificar_usuarios om = new modificar_usuarios();
        Buscar ob = new Buscar();
        buscarEdad obe = new buscarEdad();
        buscarEstado obes = new buscarEstado();
        int gx = 0;
        int mx = 0;


        public Form1()
        {
            InitializeComponent();
            
            pinicio.Visible = true;
            pingresar.Visible = false;
            pmodificar.Visible = false;
            pbuscar.Visible = false;
          
        }
        private void openChildForm(Form childForm) // Method to open a form in a panel
        {

            foreach (Form ActiveForm in panel3.Controls) ActiveForm.Close();
            childForm.TopLevel = false;
            childForm.Dock = DockStyle.Fill;

            this.panel3.Controls.Add(childForm);
            this.panel3.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }


        private void inicio_Click(object sender, EventArgs e)
        {
            ob.limpiar();
            if (pbuscar.Visible == true)
            {
                pnlbuscarOpciones.Visible = false;
                pinicio.Visible = true;
                pbuscar.Visible = false;
            }
            obes.Visible = false;
            obe.Visible = false;
            if (panel3.Controls.Count > 0)
            {
                panel3.Controls.RemoveAt(0);
            }
            openChildForm(new FormInicio());
            pinicio.Visible = true;
            pingresar.Visible = false;
            pmodificar.Visible = false;
            pbuscar.Visible = false;
            
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            ob.limpiar();
            if (pbuscar.Visible == true)
            {
                pnlbuscarOpciones.Visible = false;
                pinicio.Visible = true;
                pbuscar.Visible = false;
            }
            obes.Visible = false;
            obe.Visible = false;
            pinicio.Visible = false;
            pingresar.Visible = true;
            pmodificar.Visible = false;
            pbuscar.Visible = false;
            og.nom = nombre;
            og.ape = apellido;
            og.pes = peso;
            og.tal = talla;
            og.mc = mc;
            og.est = estado;
            og.cat = categoria;
            og.rec = recomendacion;
            og.po = pos;
            if (panel3.Controls.Count > 0)
            {
                panel3.Controls.RemoveAt(0);
            }
            gx = 1;
            mx = 0;
            foreach (Form ActiveForm in panel3.Controls) ActiveForm.Close();
            og.TopLevel = false;
            og.Dock = DockStyle.Fill;
            this.panel3.Controls.Add(og);
            this.panel3.Tag = og;
            og.BringToFront();
            og.Show();


        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            pinicio.Visible = false;
            pingresar.Visible = false;
            pmodificar.Visible = false;

            if (pbuscar.Visible == true)
            {
                pnlbuscarOpciones.Visible = false;
                pinicio.Visible = true;
                pbuscar.Visible = false;
                if (panel3.Controls.Count > 0)
                {
                    panel3.Controls.RemoveAt(0);
                }
                openChildForm(new FormInicio());
            }
            else
            {
                pbuscar.Visible = true;
                pnlbuscarOpciones.Visible = true;
            }

        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            ob.limpiar();
            if (pbuscar.Visible == true)
            {
                pnlbuscarOpciones.Visible = false;
                pinicio.Visible = true;
                pbuscar.Visible = false;
            }

            pinicio.Visible = false;
            pingresar.Visible = false;
            pmodificar.Visible = true;
            pbuscar.Visible = false;

            obe.Visible = false;
            obes.Visible = false;
            recomendacion = og.rec;
            nombre = og.nom;
            apellido = og.ape;
            categoria = og.cat;
            estado = og.est;
            edad = og.eda;
            peso = og.pes;
            talla = og.tal;
            pos = og.po;
            mc = og.mc;
            og.Visible = false;

            om.nom = nombre;
            om.ape = apellido;
            om.pes = peso;
            om.tal = talla;
            om.eda = edad;
            om.mc = mc;
            om.est = estado;
            om.cat = categoria;
            om.rec = recomendacion;
            om.po = pos;

            if (panel3.Controls.Count > 0)
            {
                panel3.Controls.RemoveAt(0);
            }
            mx = 1;
            gx = 0;
            foreach (Form ActiveForm in panel3.Controls) ActiveForm.Close();
            om.TopLevel = false;
            om.Dock = DockStyle.Fill;
            om.cargardatos(nombre, apellido, edad, peso, talla, mc, estado, categoria, recomendacion, pos);
            this.panel3.Controls.Add(om);
            this.panel3.Tag = om;
            om.BringToFront();
            om.Show();

            
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (pbuscar.Visible == true)
            {
                pnlbuscarOpciones.Visible = false;
                pinicio.Visible = true;
                pbuscar.Visible = false;
            }
            if (panel3.Controls.Count > 0)
            {
                panel3.Controls.RemoveAt(0);
            }
            openChildForm(new FormInicio());
            pinicio.Visible = true;
            pingresar.Visible = false;
            pmodificar.Visible = false;
            pbuscar.Visible = false;

        }

       


        private void buscarnombre_Click(object sender, EventArgs e)
        {
            obe.Visible = false;
            obes.Visible = false;
            if (gx == 1)
            {
                recomendacion = og.rec;
                nombre = og.nom;
                apellido = og.ape;
                categoria = og.cat;
                estado = og.est;
                edad = og.eda;
                peso = og.pes;
                talla = og.tal;
                pos = og.po;
                mc = og.mc;
                og.Visible = false;
                gx=0;
            }
            if (mx == 1)
            {
                recomendacion = om.rec;
                nombre = om.nom;
                apellido = om.ape;
                categoria = om.cat;
                estado = om.est;
                edad = om.eda;
                peso = om.pes;
                talla = om.tal;
                pos = om.po;
                mc = om.mc;
                om.Visible = false;
                mx = 0;
            }

            ob.nom = nombre;
            ob.ape = apellido;
            ob.pes = peso;
            ob.eda = edad;
            ob.tal = talla;
            ob.mc = mc;
            ob.est = estado;
            ob.cat = categoria;
            ob.rec = recomendacion;
            ob.po = pos;

            if (panel3.Controls.Count > 0)
            {
                panel3.Controls.RemoveAt(0);
            }
            foreach (Form ActiveForm in panel3.Controls) ActiveForm.Close();
            ob.TopLevel = false;
            ob.Dock = DockStyle.Fill;
            this.panel3.Controls.Add(ob);
            this.panel3.Tag = ob;
            ob.BringToFront();
            ob.Show();

           

            pbuscar.Visible = true;
            
        }

        private void button3_Click_2(object sender, EventArgs e)
        {
            ob.limpiar();
            pnlbuscarOpciones.Visible = false;
                pbuscar.Visible = false;
            pinicio.Visible = false;
            pmodificar.Visible = false;
            pingresar.Visible = false;
            
            if (gx == 1)
            {
                recomendacion = og.rec;
                nombre = og.nom;
                apellido = og.ape;
                categoria = og.cat;
                estado = og.est;
                edad = og.eda;
                peso = og.pes;
                talla = og.tal;
                pos = og.po;
                mc = og.mc;
                og.Visible = false;
                gx = 0;
            }
            if (mx == 1)
            {
                recomendacion = om.rec;
                nombre = om.nom;
                apellido = om.ape;
                categoria = om.cat;
                estado = om.est;
                edad = om.eda;
                peso = om.pes;
                talla = om.tal;
                pos = om.po;
                mc = om.mc;
                om.Visible = false;
                mx = 0;
            }


            og.Visible = false;
            om.Visible = false;
            ob.Visible = false;
            obe.Visible = false;
            obes.Visible = false;
            if (panel3.Controls.Count > 0)
            {
                panel3.Controls.RemoveAt(0);
            }
            openChildForm(new adultos.Form1());
        }

        private void iconButton5_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void iconButton6_Click(object sender, EventArgs e)
        {
            ob.limpiar();
            //obe.dataGridView1.Rows.Clear();
            cConexion oc = new cConexion();
            obe.dataGridView1.DataSource = oc.mostrarPorEdad();


            if (gx == 1)
            {
                recomendacion = og.rec;
                nombre = og.nom;
                apellido = og.ape;
                categoria = og.cat;
                estado = og.est;
                edad = og.eda;
                peso = og.pes;
                talla = og.tal;
                pos = og.po;
                mc = og.mc;
                og.Visible = false;
                gx = 0;
            }
            if (mx == 1)
            {
                recomendacion = om.rec;
                nombre = om.nom;
                apellido = om.ape;
                categoria = om.cat;
                estado = om.est;
                edad = om.eda;
                peso = om.pes;
                talla = om.tal;
                pos = om.po;
                mc = om.mc;
                om.Visible = false;
                mx = 0;
            }

            obe.nom = nombre;
            obe.ape = apellido;
            obe.pes = peso;
            obe.eda = edad;
            obe.tal = talla;
            obe.mc = mc;
            obe.est = estado;
            obe.cat = categoria;
            obe.rec = recomendacion;
            obe.po = pos;


            if (panel3.Controls.Count > 0)
            {
                panel3.Controls.RemoveAt(0);
            }

            foreach (Form ActiveForm in panel3.Controls) ActiveForm.Close();
            obe.TopLevel = false;
            obe.Dock = DockStyle.Fill;
            this.panel3.Controls.Add(obe);
            this.panel3.Tag = obe;
            obe.BringToFront();
            obe.Show();

            pbuscar.Visible = true;
            
        }

        private void iconButton7_Click(object sender, EventArgs e)
        {
            ob.limpiar();
            cConexion oc = new cConexion();
            obes.dataGridView1.DataSource = oc.mostrarPorEstadoSalud();
            if (gx == 1)
            {
                recomendacion = og.rec;
                nombre = og.nom;
                apellido = og.ape;
                categoria = og.cat;
                estado = og.est;
                edad = og.eda;
                peso = og.pes;
                talla = og.tal;
                pos = og.po;
                mc = og.mc;
                og.Visible = false;
                gx = 0;
            }
            if (mx == 1)
            {
                recomendacion = om.rec;
                nombre = om.nom;
                apellido = om.ape;
                categoria = om.cat;
                estado = om.est;
                edad = om.eda;
                peso = om.pes;
                talla = om.tal;
                pos = om.po;
                mc = om.mc;
                om.Visible = false;
                mx = 0;
            }

            obes.nom = nombre;
            obes.ape = apellido;
            obes.pes = peso;
            obes.eda = edad;
            obes.tal = talla;
            obes.mc = mc;
            obes.est = estado;
            obes.cat = categoria;
            obes.rec = recomendacion;
            obes.po = pos;


            if (panel3.Controls.Count > 0)
            {
                panel3.Controls.RemoveAt(0);
            }
            foreach (Form ActiveForm in panel3.Controls) ActiveForm.Close();
            obes.TopLevel = false;
            obes.Dock = DockStyle.Fill;
            this.panel3.Controls.Add(obes);
            this.panel3.Tag = obes;
            obes.BringToFront();
            obes.Show();

            pbuscar.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ob.limpiar();
            pnlbuscarOpciones.Visible = false;
                pbuscar.Visible = false;
            pinicio.Visible = false;
            pmodificar.Visible = false;
            pingresar.Visible = false;
            if (gx == 1)
            {
                recomendacion = og.rec;
                nombre = og.nom;
                apellido = og.ape;
                categoria = og.cat;
                estado = og.est;
                edad = og.eda;
                peso = og.pes;
                talla = og.tal;
                pos = og.po;
                mc = og.mc;
                og.Visible = false;
                gx = 0;
            }
            if (mx == 1)
            {
                recomendacion = om.rec;
                nombre = om.nom;
                apellido = om.ape;
                categoria = om.cat;
                estado = om.est;
                edad = om.eda;
                peso = om.pes;
                talla = om.tal;
                pos = om.po;
                mc = om.mc;
                om.Visible = false;
                mx = 0;
            }
            og.Visible = false;
            om.Visible = false;
            ob.Visible = false;
            obe.Visible = false;
            obes.Visible = false;
            if (panel3.Controls.Count > 0)
            {
                panel3.Controls.RemoveAt(0);
            }
            openChildForm(new WfNinios.FormNinios());

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ob.limpiar();
            pnlbuscarOpciones.Visible = false;
                pbuscar.Visible = false;
            pinicio.Visible = false;
            pmodificar.Visible = false;
            pingresar.Visible = false;

            if (gx == 1)
            {
                recomendacion = og.rec;
                nombre = og.nom;
                apellido = og.ape;
                categoria = og.cat;
                estado = og.est;
                edad = og.eda;
                peso = og.pes;
                talla = og.tal;
                pos = og.po;
                mc = og.mc;
                og.Visible = false;
                gx = 0;
            }
            if (mx == 1)
            {
                recomendacion = om.rec;
                nombre = om.nom;
                apellido = om.ape;
                categoria = om.cat;
                estado = om.est;
                edad = om.eda;
                peso = om.pes;
                talla = om.tal;
                pos = om.po;
                mc = om.mc;
                om.Visible = false;
                mx = 0;
            }
            og.Visible = false;
            om.Visible = false;
            ob.Visible = false;
            obe.Visible = false;
            obes.Visible = false;
            if (panel3.Controls.Count > 0)
            {
                panel3.Controls.RemoveAt(0);
            }
            openChildForm(new jovenes.FormJovenes());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ob.limpiar();
            pnlbuscarOpciones.Visible = false;
                pbuscar.Visible = false;
            pinicio.Visible = false;
            pmodificar.Visible = false;
            pingresar.Visible = false;
            if (gx == 1)
            {
                recomendacion = og.rec;
                nombre = og.nom;
                apellido = og.ape;
                categoria = og.cat;
                estado = og.est;
                edad = og.eda;
                peso = og.pes;
                talla = og.tal;
                pos = og.po;
                mc = og.mc;
                og.Visible = false;
                gx = 0;
            }
            if (mx == 1)
            {
                recomendacion = om.rec;
                nombre = om.nom;
                apellido = om.ape;
                categoria = om.cat;
                estado = om.est;
                edad = om.eda;
                peso = om.pes;
                talla = om.tal;
                pos = om.po;
                mc = om.mc;
                om.Visible = false;
                mx = 0;
            }
            og.Visible = false;
            om.Visible = false;
            ob.Visible = false;
            obe.Visible = false;
            obes.Visible = false;
            if (panel3.Controls.Count > 0)
            {
                panel3.Controls.RemoveAt(0);
            }
            openChildForm(new FormAdultoMayor());

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelCentral_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pinicio_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
