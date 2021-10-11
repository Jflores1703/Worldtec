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
    public partial class FormFacturas : Form
    {
        public FormFacturas()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFacturas));
            this.SuspendLayout();
            // 
            // FormFacturas
            // 
            this.ClientSize = new System.Drawing.Size(796, 406);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormFacturas";
            this.Text = "Facturas";
            this.Load += new System.EventHandler(this.FormFacturas_Load);
            this.ResumeLayout(false);

        }

        private void FormFacturas_Load(object sender, EventArgs e)
        {

        }
    }
}
