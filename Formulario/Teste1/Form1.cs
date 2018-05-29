using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Teste1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            IsMdiContainer = true;
            
        }

        private void teste1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
           

        }


        private void Form1_Load(object sender, EventArgs e)
        {
            lblData.Text = "Data: " + DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHora.Text = "Hora: " + DateTime.Now.ToString("HH:mm:ss");
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            FormTeste1 tst1 = new FormTeste1();
            tst1.MdiParent = this;
            tst1.Show();


        }

        private void btn3_Click(object sender, EventArgs e)
        {
            this.Close();


        }
       
    }
}
