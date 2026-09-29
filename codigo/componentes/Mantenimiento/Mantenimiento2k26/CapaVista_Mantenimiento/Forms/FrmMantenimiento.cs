using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVista_Mantenimiento.Forms
{
    public partial class FrmMantenimiento : Form
    {
        public FrmMantenimiento()
        {
            InitializeComponent();
            navegador1.NavegadorMetConfigurar("facultades", 4, 5);
        }

        private void Reporte_Click(object sender, EventArgs e)
        {
            frmReportes.FrmReportePruebaAntes reporte = new frmReportes.FrmReportePruebaAntes();
            reporte.Show();

        }
    }
}
