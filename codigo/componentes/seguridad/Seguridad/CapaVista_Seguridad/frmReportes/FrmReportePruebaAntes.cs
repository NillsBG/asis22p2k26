using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Microsoft.Reporting.WinForms;
using CapaControlador_Seguridad.Modelos_de_controladores;

namespace CapaVista_Seguridad.frmReportes
{
    public partial class FrmReportePruebaAntes : Form
    {
        private ClsModeloPruebaReporte Reporte;

        public FrmReportePruebaAntes()
        {
            InitializeComponent();

            Reporte = new ClsModeloPruebaReporte();
        }

        private void FrmReportePruebaAntes_Load(object sender, EventArgs e)
        {
            ReportDataSource reportDataSourceReporte =
                new ReportDataSource(
                    "DataSet1",
                    Reporte.SeguridadMetObtenerTodos()
                );

            reportViewer1.LocalReport.ReportEmbeddedResource =
                "CapaVista_Seguridad.Reportes.ReportePruebaAntesParcial.rdlc";

            reportViewer1.LocalReport.DataSources.Clear();

            reportViewer1.LocalReport.DataSources.Add(
                reportDataSourceReporte
            );

            reportViewer1.RefreshReport();
        }
    }
}