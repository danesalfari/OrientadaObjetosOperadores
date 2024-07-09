using Operadores.Operadores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Operadores
{
    public partial class Form1 : Form
    {
        operadores op = new operadores();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            op.sumar(double.Parse(txtop1.Text), double.Parse(txtop2.Text), double.Parse(txtop3.Text), double.Parse(txtop4.Text));
            txtResultado.Text = op.Resultado1.ToString();
        }

        private void btnRestar_Click(object sender, EventArgs e)
        {
            op.restar(double.Parse(txtop1.Text), double.Parse(txtop2.Text), double.Parse(txtop3.Text), double.Parse(txtop4.Text));
            txtResultado.Text = op.Resultado1.ToString();
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            op.multiplicar(double.Parse(txtop1.Text), double.Parse(txtop2.Text), double.Parse(txtop3.Text), double.Parse(txtop4.Text));
            txtResultado.Text = op.Resultado1.ToString();
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            op.dividir(double.Parse(txtop1.Text), double.Parse(txtop2.Text), double.Parse(txtop3.Text), double.Parse(txtop4.Text));
            txtResultado.Text = op.Resultado1.ToString();
        }

        private void btnPromediar_Click(object sender, EventArgs e)
        {
            op.promediar(double.Parse(txtop1.Text), double.Parse(txtop2.Text), double.Parse(txtop3.Text), double.Parse(txtop4.Text));
            txtResultado.Text = op.Resultado1.ToString();
        }

        private void btnPotencia_Click(object sender, EventArgs e)
        {
            op.potencia(double.Parse(txtop1.Text), double.Parse(txtop2.Text), double.Parse(txtop3.Text), double.Parse(txtop4.Text));
            txtResultado.Text = op.Resultado1.ToString();
        }

        private void btnRaiz_Click(object sender, EventArgs e)
        {
            op.raiz(double.Parse(txtop1.Text), double.Parse(txtop2.Text), double.Parse(txtop3.Text), double.Parse(txtop4.Text));
            txtResultado.Text = op.Resultado1.ToString();
        }
    }
}
