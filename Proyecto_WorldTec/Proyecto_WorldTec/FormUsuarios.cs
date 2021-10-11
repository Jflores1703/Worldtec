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
    public partial class FormUsuarios : Form
    {
        public FormUsuarios()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUsuarios));
            this.SuspendLayout();
            // 
            // FormUsuarios
            // 
            this.ClientSize = new System.Drawing.Size(878, 399);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormUsuarios";
            this.Text = "Usuarios del Sistema";
            this.Load += new System.EventHandler(this.FormUsuarios_Load);
            this.ResumeLayout(false);

        }

        private void FormUsuarios_Load(object sender, EventArgs e)
        {

        }
    }
}
