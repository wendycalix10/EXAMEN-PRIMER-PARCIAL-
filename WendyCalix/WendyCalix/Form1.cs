using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WendyCalix
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List <string> listbox1 = new List <string>();
        private void button1_Click(object sender, EventArgs e)
        {
            Decimal Valor = Convert.ToDecimal(Valortxt.Text);
            Double Interes = 0.015;
            Interes = Convert.ToDouble(Interestxt.Text);
            DateTime Fecha = CalculardateTimePicker.Value;
            


            int[,] Meses = new int[12, 1]
                                        {
                                          {1},
                                          {2},
                                          {3},
                                          {4},
                                          {5},
                                          {6},
                                          {7},
                                          {8},
                                          {9},
                                          {10},
                                          {11},
                                          {12}
                                        };

            for (int i = 0 ; i< Meses.GetLength(0) ; i++) 
            {
                for (int col = 0; col < Meses.GetLength(1); col++)
                { 
                    lisboxejer1.Items.Add("Enero: [" + i +" , " + col + "] = " +Meses[i, col]);
                    lisboxejer1.Items.Add("Febrero: [" + i +" , " + col + "] = " +Meses[i, col]);
                    lisboxejer1.Items.Add("Marzo: [" + i +" , " + col + "] = " +Meses[i, col]);
                    lisboxejer1.Items.Add("Abril: [" + i +" , " + col + "] = " +Meses[i, col]);
                    lisboxejer1.Items.Add("Mayo: [" + i +" , " + col + "] = " +Meses[i, col]);
                    lisboxejer1.Items.Add("Junio: [" + i +" , " + col + "] = " +Meses[i, col]);
                    lisboxejer1.Items.Add("Julio: [" + i +" , " + col + "] = " +Meses[i, col]);
                    lisboxejer1.Items.Add("Agosto: [" + i +" , " + col + "] = " +Meses[i, col]);
                    lisboxejer1.Items.Add("Septiembre: [" + i +" , " + col + "] = " +Meses[i, col]);
                    lisboxejer1.Items.Add("Octubre: [" + i +" , " + col + "] = " +Meses[i, col]);
                    lisboxejer1.Items.Add("Noviembre: [" + i +" , " + col + "] = " +Meses[i, col]);
                    lisboxejer1.Items.Add("Diciembre: [" + i +" , " + col + "] = " +Meses[i, col]);


                }

            }
        }
    }
}
