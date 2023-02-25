using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WendyCalix
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }



        private async void Genfactbutton_Click(object sender, EventArgs e)
        {
            Decimal Producto1 = Convert.ToDecimal(Product1txt.Text);
            Decimal Producto2 = Convert.ToDecimal(Product2txt.Text);
            Decimal Impuesto = Convert.ToDecimal(Imptxt.Text);
            Decimal Descuento = Convert.ToDecimal(Desctxt.Text);


            Decimal GenerarFactura = await GenerarFacturaAsync(Producto1,Producto2,Impuesto,Descuento);
            

            MessageBox.Show($"El Descuento es:{GenerarFactura}");
        }

        private async Task<Decimal> GenerarFacturaAsync(Decimal Prod1, Decimal Prod2, Decimal IMP, Decimal DESC)
        {
            Decimal Factura = await Task.Run(() =>
            {
                return (Prod1 + Prod2 * IMP - DESC);
            });
            return Factura;
        }
        
    }
} 
