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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void exercicio1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Exer1 ex1 = new Exer1();
            ex1.MdiParent = this;
            ex1.Show();
        }

        private void exercicio2ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Exer2 ex2 = new Exer2();
            ex2.MdiParent = this;
            ex2.Show();

        }

        private void exercicio3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Exer3 ex3 = new Exer3();
            ex3.MdiParent = this;
            ex3.Show();


        }

        private void exercicio4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Exer4 ex4 = new Exer4();
            ex4.MdiParent = this;
            ex4.Show();

        }

        private void exercicio5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Exer5 ex5 = new Exer5();
            ex5.MdiParent = this;
            ex5.Show();

        }

        private void exercicio6ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Exer6 ex6 = new Exer6();
            ex6.MdiParent = this;
            ex6.Show();
        }

        private void exercicio7ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Exerc7 ex7 = new Exerc7();
            ex7.MdiParent = this;
            ex7.Show();

        }



       

     

    }
}
