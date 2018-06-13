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
    public partial class Exer1 : Form
    {
        public Exer1()
        {
            InitializeComponent();
        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            double valor1 = System.Convert.ToDouble(txbValor1.Text);
            double valor2 = System.Convert.ToDouble(txbValor2.Text);
            double resul=0;


            resul = valor1 + valor2;


            if (resul > 20) 
            {
               
                resul += 8;
                
                lblResul.Text = resul.ToString();
                
                        
            }

            else if (resul<=20)
            {
                resul -= 5;

                lblResul.Text = resul.ToString();
            }



        }
    }
}
