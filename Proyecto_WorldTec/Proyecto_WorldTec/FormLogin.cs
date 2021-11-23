using BL.Tecnologia;
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
    public partial class FormLogin : Form
    {
        SeguridadBL _seguridad;
        public FormLogin()
        {
            InitializeComponent();
            _seguridad = new SeguridadBL();
           
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            _login();
        }

       private void _login()
        {
            string usuario;
            string contrasena;

            usuario = textBox1.Text;
            contrasena = textBox2.Text;

            var usuarios = _seguridad.Autorizar(usuario, contrasena);
            bool _Existe = false;
            foreach (var usuarioDB in usuarios)
            {
                if (usuario == usuarioDB.UsuarioId && contrasena == usuarioDB.Contrasena)
                {
                    textBox2.Text = "";
                    _Existe = true;
                    Utilidades.UsuarioStatus = usuario;
                    MessageBox.Show("Bienvenido al Sistema" + " " + usuarioDB.Nombre);
                    Program.mostrarMenu();
                }
            }
            if(!_Existe)
            {
                MessageBox.Show("Usuario o Contraseña incorrecta");
                textBox1.Text = "";
                textBox2.Text = "";
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar==(char)Keys.Enter && !string.IsNullOrEmpty(textBox1.Text)) 
            {
                textBox2.Focus();
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter && !string.IsNullOrEmpty(textBox2.Text))
            {
                _login();
            }
        }
    }
}
