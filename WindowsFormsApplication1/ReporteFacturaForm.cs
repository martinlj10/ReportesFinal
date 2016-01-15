using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class ReporteFacturaForm : Form
    {
        public ReporteFacturaForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Funcion encargada de llenar el control DataGridView
        /// <autor>Martin Lopez Jordan</autor>
        /// </summary>
        /// <returns>Una lista generica de la clase artículo</returns>
        private static List<EArticulo> FillDgv()
        {
            //
            //Cree una lista generica de la entidad EArticulo
            //
            List<EArticulo> listaArticulos = new List<EArticulo>();

            //
            //Instancie la clase EArticulo para agregar datos a la lista
            //
            EArticulo item = new EArticulo
            {
                //Establezca valores a cada una de las propiedades
                Numero = 1,
                Upc = "7501020405680",
                Descripcion = "Descripción del artículo 1",
                Piezas = 6,
                Precio = new decimal(12.50),
                Importe = (decimal)(6 * 12.5),
            };
            //
            //Agregamos el Item a la lista
            //
            listaArticulos.Add(item);

            EArticulo item1 = new EArticulo
            {
                Numero = 2,
                Upc = "7501040805610",
                Descripcion = "Descripción del artículo 2",
                Piezas = 3,
                Precio = new decimal(22.50),
                Importe = (decimal)(3 * 22.5),
            };
            listaArticulos.Add(item1);

            EArticulo item2 = new EArticulo
            {
                Numero = 3,
                Upc = "0412200805610",
                Descripcion = "Descripción del artículo 3",
                Piezas = 20,
                Precio = new decimal(52.80),
                Importe = (decimal)(20 * 52.80),
            };
            listaArticulos.Add(item2);

            return listaArticulos;
        }

        private void ReporteFacturaForm_Load(object sender, EventArgs e)
        {
            //
            //La funcion GenerateNumber() se utiliza unicamente para generar un Número
            //aleatorio que simulara ser el numerod e factura
            txtnumero.Text = GenerateNumber().ToString();

            //Establecemos la propiedad AutoGenerateColumns en False para evitar que se agreguen
            //nuevas columnas a la derecha de las que creamos en tiempo de diseño.
            //
            dgvdetalle.AutoGenerateColumns = false;
            //
            //Establecemos el DataSource del control DataGridView
            //
            dgvdetalle.DataSource = FillDgv();
            //
            //Mapeamos las propiedades de la clase devuelta por la Funcion FillDgv()
            //recuerde que esta funcion devuelve una lista del tipo EArticulo
            //
            dgvdetalle.Columns["columnNumero"].DataPropertyName = "Numero";
            dgvdetalle.Columns["columnUpc"].DataPropertyName = "Upc";
            dgvdetalle.Columns["columnDescripcion"].DataPropertyName = "Descripcion";
            dgvdetalle.Columns["columnPiezas"].DataPropertyName = "Piezas";
            dgvdetalle.Columns["columnPrecio"].DataPropertyName = "Precio";
            dgvdetalle.Columns["columnImporte"].DataPropertyName = "Importe";

            //
            //Hacemos las sumatorias usando un método de extensión de Linq
            //
            decimal sum = FillDgv().Sum(x => x.Importe);
            decimal iva = (Math.Round(((sum / 116) * 16), 2));
            decimal subtotal = Math.Round(sum - iva, 2);

            txttotal.Text = Convert.ToString(Math.Round(sum, 2));
            txtsubtotal.Text = Convert.ToString(iva);
            txtsubtotal.Text = Convert.ToString(subtotal);
        }

        private static int GenerateNumber()
        {
            Random rdm = new Random();

            return rdm.Next();

        }
        private void InvoiceGenerate()
        {
            //
            //Hacemos una instancia de la clase EFactura para
            //llenarla con los valores contenidos en los controles del Formulario
            EFactura invoice = new EFactura();
            invoice.Numero = Convert.ToInt32(txtnumero.Text);
            invoice.Nombre = txtnombre.Text;
            invoice.IVA = txtrfc.Text;
            invoice.Direccion = txtdireccion.Text;
            invoice.FechaFacturacion = dtpfecha.Value.Date;
            invoice.Subtotal = Convert.ToDecimal(txtsubtotal.Text);
            invoice.Iva = Convert.ToDecimal(txtsubtotal.Text);
            invoice.Total = Convert.ToDecimal(txttotal.Text);
            invoice.CUIT = txtcuit.Text;

            //Recorremos los Rows existentes actualmente en el control DataGridView
            //para asignar los datos a las propiedades
            foreach (DataGridViewRow row in dgvdetalle.Rows)
            {
                EArticulo article = new EArticulo();
                //
                //Vamos tomando los valores de las celdas del row que estamos 
                //recorriendo actualmente y asignamos su valor a la propiedad de la clase intanciada
                //
                article.Numero = Convert.ToInt32(row.Cells["columnNumero"].Value);
                article.Upc = Convert.ToString(row.Cells["columnUpc"].Value);
                article.Descripcion = Convert.ToString(row.Cells["columnDescripcion"].Value);
                article.Piezas = Convert.ToDecimal(row.Cells["columnPiezas"].Value);
                article.Precio = Convert.ToDecimal(row.Cells["columnPrecio"].Value);
                article.Importe = Convert.ToDecimal(row.Cells["columnImporte"].Value);

                //
                //Vamos agregando el Item a la lista del detalle
                //
                invoice.Detail.Add(article);
            }

            //
            //Creamos una instancia del Formulario que contiene nuestro
            //ReportViewer
            //
            FacturaRpt frm = new FacturaRpt();
            //
            //Usamos las propiedades publicas del formulario, aqui es donde enviamos el valor
            //que se mostrara en los parametros creados en el LocalReport, para este ejemplo
            //estamos Seteando los valores directamente pero usted puede usar algun control
            //
            frm.Titulo = "Factura";
            frm.Empresa = "Mundo Renault";
            //
            //Recuerde que invoice es una Lista Generica declarada en el FacturaRtp, es una lista
            //porque el origen de datos del LocalReport unicamente permite ser enlazado a objetos que 
            //implementen IEnumerable.
            //
            //Usamos el metod Add porque Invoice es una lista e invoice es una entidad simple
            frm.Invoice.Add(invoice);
            //
            //Enviamos el detalle de la Factura, como Detail es una lista e invoide.Details tambien
            //es un lista del tipo EArticulo bastara con igualarla
            //
            frm.Detail = invoice.Detail;
            frm.Show();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            InvoiceGenerate();
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            //FacturaRpt formulario = new FacturaRpt();
            //formulario.ShowDialog();

            InvoiceGenerate();
        }

       
    }
}
