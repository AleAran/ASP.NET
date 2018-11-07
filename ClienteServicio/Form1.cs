using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClienteServicio
{
    public partial class Form1 : Form
    {
        // creo obj del servicio
        curso.Servicios objServicio = new curso.Servicios();

        public Form1()
        {
            InitializeComponent();
            objServicio.SumarCompleted += ObjServicio_SumarCompleted;
        }

        private void ObjServicio_SumarCompleted(object sender, curso.SumarCompletedEventArgs e)
        {
            // se ejecuta cuando el hilo secundario termino de  procesar
            lblSuma.Text = e.Result.ToString();
        }

        private void btnSumaSinc_Click(object sender, EventArgs e)
        {
            int intN1 = Convert.ToInt32(txtNumero1.Text);
            int intN2 = Convert.ToInt32(txtNumero2.Text);
            lblSuma.Text = objServicio.Sumar(intN1, intN2).ToString();
        }

        private void btnSumaAsinc_Click(object sender, EventArgs e)
        {
            int intN1 = Convert.ToInt32(txtNumero1.Text);
            int intN2 = Convert.ToInt32(txtNumero2.Text);
            // llamdo asincronico
            objServicio.SumarAsync(intN1, intN2);
        }

        private void btnRestar_Click(object sender, EventArgs e)
        {
            int intN1 = Convert.ToInt32(txtNumero1.Text);
            int intN2 = Convert.ToInt32(txtNumero2.Text);
            lblResta.Text = objServicio.Restar(intN1, intN2).ToString();


        }
    }
}
