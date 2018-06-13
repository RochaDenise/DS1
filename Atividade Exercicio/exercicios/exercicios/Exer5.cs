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
    public partial class Exer5 : Form
    {
        public Exer5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double num = System.Convert.ToDouble(textBox1.Text);

            for (int cont = 1; cont <= num; cont++)
            {
                textBox2.Text += cont + ", ";
            }


            if(num>50)
            {
                textBox2.Text = ("Até o número 50");

            }
        }

       

      

     
    }
}
