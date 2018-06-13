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
    public partial class Exer6 : Form
    {
        public Exer6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
               double num = System.Convert.ToDouble(txbNum.Text);

                txbResul2.Text = "Brasil";
                for (int i = 1; i < num; i++)
                {
                    txbResul2.Text += " Brasil";
                }
            }

        }

    
        
    }

