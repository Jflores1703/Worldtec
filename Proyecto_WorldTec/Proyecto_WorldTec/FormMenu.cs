using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_WorldTec
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Login();
            SubmenuUsuario.Visible = false;

        }

        private void Login()
        {
            var formlogin = new FormLogin();
            formlogin.ShowDialog();
        }

        private void MenuPrincipal2_Load(object sender, EventArgs e)
        {
          //  Login();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SubmenuUsuario.Visible = true;
        }

        private void botonReporte_Click(object sender, EventArgs e)
        {
                Submenu.Visible = true;
        }

        private void botonreporteventa_Click(object sender, EventArgs e)
        {
            var formreporteventas = new FormReporteVentas();
            formreporteventas.MdiParent = this;
            this.WindowState = FormWindowState.Maximized;

            formreporteventas.Show();

            Submenu.Visible =false  ;
        }

        private void botonreporteproducto_Click(object sender, EventArgs e)
        {
            var formreporteproductos = new FormReporteProductos();
            formreporteproductos.MdiParent = this;
            this.WindowState = FormWindowState.Maximized;

            formreporteproductos.Show();

            Submenu.Visible = false;
        }

        private void botonreportecliente_Click(object sender, EventArgs e)
        {
            var formreporteclientes = new FormReporteClientes();
            formreporteclientes.MdiParent = this;

            formreporteclientes.Show();
            Submenu.Visible = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var formproductos = new FormProductos();
            formproductos.MdiParent = this;

            formproductos.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var formclientes = new FormClientes();
            formclientes.MdiParent = this;

            formclientes.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var formfacturas = new FormFacturas();
            formfacturas.MdiParent = this;

            formfacturas.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var formusuarios = new FormUsuarios();
            formusuarios.MdiParent = this;

            formusuarios.Show();
            SubmenuUsuario.Visible = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbhora.Text = DateTime.Now.ToString("HH:mm:ss");
            lbfecha.Text = DateTime.Now.ToLongDateString();


                }
    }
}
