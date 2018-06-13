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
    public partial class Exer2 : Form
    {
        public Exer2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            txbResultado.Text = "";

            if (System.Convert.ToDouble(txbNum.Text) % 2 == 0 || System.Convert.ToDouble(txbNum.Text) % 5 == 0 || System.Convert.ToDouble(txbNum.Text) % 10 == 0)
            {
                txbResultado.Text = "É divisível por ";
            }
            else
            {
                txbResultado.Text = "Não é divisível por 2, 5 e 10";
            }

            if (System.Convert.ToDouble(txbNum.Text) % 2 == 0)
            {
                txbResultado.Text += "2 ";
            }
            if (System.Convert.ToDouble(txbNum.Text) % 5 == 0)
            {
                txbResultado.Text += "5 ";
            }
            if (System.Convert.ToDouble(txbNum.Text) % 10 == 0)
            {
                txbResultado.Text += "10 ";
            }
            
        }
    }
}
