using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicioLunes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double n1 = Convert.ToDouble(txtNota1.Text);
            double n2 = Convert.ToDouble(txtNota2.Text);
            double n3 = Convert.ToDouble(txtNota3.Text);
            double n4 = Convert.ToDouble(txtNota4.Text);

            double promedio = (n1 + n2 + n3 + n4) / 4;
            txtPromedio.Text = promedio.ToString("0.00");

            if (promedio > 69)
            {
                txtResultado.Text = "Aprobado";
            }
            else
            {
                txtNotaCompletivo.Enabled = true;

                if (txtNotaCompletivo.Text != "")
                {
                    double notaComp = Convert.ToDouble(txtNotaCompletivo.Text);
                    double notaCompletivoFinal = (promedio * 0.50) + (notaComp * 0.50);

                    if (notaCompletivoFinal > 69)
                    {
                        txtResultado.Text = "Aprobado por Completivo";
                    }
                    else
                    {
                        txtNotaExtra.Enabled = true;

                        if (txtNotaExtra.Text != "")
                        {
                            double notaExtra = Convert.ToDouble(txtNotaExtra.Text);
                            double notaExtraFinal = (promedio * 0.30) + (notaExtra * 0.70);

                            if (notaExtraFinal > 69)
                                txtResultado.Text = "Aprobado por Extraordinario";
                            else
                                txtResultado.Text = "REPROBADO";
                        }
                    }
                }
}
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNota1.Clear();
            txtNota2.Clear();
            txtNota3.Clear();
            txtNota4.Clear();
            txtPromedio.Clear();
            txtNotaCompletivo.Clear();
            txtNotaExtra.Clear();
            txtResultado.Clear();

            txtNotaCompletivo.Enabled = false;
            txtNotaExtra.Enabled = false;
        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtResultado_TextChanged(object sender, EventArgs e)
        {

        }
    }
} 

