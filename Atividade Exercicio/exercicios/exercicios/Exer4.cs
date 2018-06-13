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
    public partial class Exer4 : Form
    {
        public Exer4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int mes= Convert.ToInt32(textBox1.Text);

            if(mes ==1)
            {
                lblResul.Text = ("Janeiro");
            }
            else if (mes == 2)
            {
                lblResul.Text = ("Fevereiro");
            }
            else if (mes == 3)
            {
                lblResul.Text = ("Março");
            }
            else if (mes == 4)
            {
                lblResul.Text = ("Abril");
            }
            else if (mes == 5)
            {
                lblResul.Text = ("Maio");
            }
            else if (mes == 6)
            {
                lblResul.Text = ("Junho");
            }
            else if (mes == 7)
            {
                lblResul.Text = ("Julho");
            }
            else if (mes == 8)
            {
                lblResul.Text = ("Agosto");
            }
            else if (mes == 9)
            {
                lblResul.Text = ("Setembro");
            }
            else if (mes == 10)
            {
                lblResul.Text = ("Outubro");
            }
            else if (mes == 11)
            {
                lblResul.Text = ("Novembro");
            }
            else if (mes == 12)
            {
                lblResul.Text = ("Dezembro");
            }

            else if (mes > 12)
            {
                lblResul.Text = ("Digitar de 1 a 12");
            }









        }
    }
}
