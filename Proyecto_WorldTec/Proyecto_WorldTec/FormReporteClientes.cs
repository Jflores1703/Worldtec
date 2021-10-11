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
    public partial class FormReporteClientes : Form
    {
        public FormReporteClientes()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormReporteClientes));
            this.SuspendLayout();
            // 
            // FormReporteClientes
            // 
            this.ClientSize = new System.Drawing.Size(816, 395);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormReporteClientes";
            this.Text = "Reporte de Clientes";
            this.Load += new System.EventHandler(this.FormReporteClientes_Load);
            this.ResumeLayout(false);

        }

        private void FormReporteClientes_Load(object sender, EventArgs e)
        {

        }
    }
}
