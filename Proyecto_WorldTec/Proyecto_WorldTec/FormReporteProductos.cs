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
    public partial class FormReporteProductos : Form
    {
        public FormReporteProductos()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormReporteProductos));
            this.SuspendLayout();
            // 
            // FormReporteProductos
            // 
            this.ClientSize = new System.Drawing.Size(827, 432);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormReporteProductos";
            this.Text = "Reporte de Productos";
            this.Load += new System.EventHandler(this.FormReporteProductos_Load);
            this.ResumeLayout(false);

        }

        private void FormReporteProductos_Load(object sender, EventArgs e)
        {

        }
    }
}
