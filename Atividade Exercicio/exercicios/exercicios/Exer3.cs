using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace exercicios
{
    public partial class Exer3 : Form
    {
        public Exer3()
        {
            InitializeComponent();
        }

        private void btnResul_Click(object sender, EventArgs e)
        {
            double valor1 = System.Convert.ToDouble(txbValor1.Text);
            double valor2 = System.Convert.ToDouble(txbValor2.Text);
            double valor3 = System.Convert.ToDouble(txbValor3.Text);


            if (valor1 == valor2 && valor2 == valor3)
            {
                lblResul.Text = ("Triângulo Equilátero ");

            }

            else if (valor1 != valor2 && valor2 == valor3 || valor1 == valor2 && valor2 != valor3 || valor2 == valor3 && valor1 != valor3)
            {
                lblResul.Text = ("Triângulo Isósceles  ");

            }

            else if (valor1 != valor2 && valor2 != valor3 && valor3 != valor1)
            {
                lblResul.Text = ("Triângulo Escaleno ");

            }
             if  (valor1 >= 50 && valor2 <= 10 || valor2 >= 50 && valor3 <= 10 || valor3 >= 50 && valor1 <= 10 || valor2 >= 50 && valor1 <= 10 || valor3 >= 50 && valor2 <= 10)
            {
                lblResul.Text = ("Não forma um triângulo");

            }
           


        }
    }
}
