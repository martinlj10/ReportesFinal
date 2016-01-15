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

namespace WindowsFormsApplication1
{
    public partial class FacturaRpt : Form
    {
        //
        //Cree dos listas una para el Encabezado y otra para el detalle
        //
        public List<EFactura> Invoice = new List<EFactura>();
        public List<EArticulo> Detail = new List<EArticulo>();
        //
        //Cree las propiedades publicas Titulo y Empresa
        //
        public string Titulo { get; set; }
        public string Empresa { get; set; }

        public FacturaRpt()
        {
            InitializeComponent();
        }

        private void FacturaRpt_Load(object sender, EventArgs e)
        {
            //this.reportViewer1.RefreshReport();
            
            //Se limpia el data source del informe
            reportViewer1.LocalReport.DataSources.Clear();

            //
            //Establezcamos los parámetros que enviaremos al reporte
            //recuerde que son dos para el titulo del reporte y para el nombre de la empresa
            //
            ReportParameter[] parameters = new ReportParameter[2];
            parameters[0] = new ReportParameter("parametroTitulo", Titulo);
            parameters[1] = new ReportParameter("parametroEmpresa", Empresa);

            //
            //Establezcamos la lista como Datasource del informe
            //
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("Encabezado", Invoice));
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("Detalle", Detail));
            //
            //Enviemos la lista de parametros
            //
            reportViewer1.LocalReport.SetParameters(parameters);
            //
            //Hagamos un refresh al reportViewer
            //
            reportViewer1.RefreshReport();
        }
    }
}
