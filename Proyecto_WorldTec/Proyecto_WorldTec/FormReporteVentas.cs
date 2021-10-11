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
    public partial class FormReporteVentas : Form
    {
        public FormReporteVentas()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormReporteVentas));
            this.SuspendLayout();
            // 
            // FormReporteVentas
            // 
            this.ClientSize = new System.Drawing.Size(877, 434);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormReporteVentas";
            this.Text = "Reporte de Ventas";
            this.Load += new System.EventHandler(this.FormReporteVentas_Load);
            this.ResumeLayout(false);

        }

        private void FormReporteVentas_Load(object sender, EventArgs e)
        {

        }
    }
}
