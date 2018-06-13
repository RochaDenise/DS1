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
    public partial class Exerc7 : Form
    {
        public Exerc7()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
             double arlindo = 1.50;
             double manoel = 1.10;
             int i = 0;

             while (arlindo > manoel)
             {
                arlindo += 0.02;
                manoel += 0.03;
                i++;
             }
             txbResul.Text = i.ToString();
        }
        }

    
    }

