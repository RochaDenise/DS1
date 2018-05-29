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
    public partial class FormTeste1 : Form
    {
        public FormTeste1()
        {
            InitializeComponent();
            
        }

        private void FormTeste1_Load(object sender, EventArgs e)
        {
            FormTeste1 tst1 = new FormTeste1();
            tst1.MdiParent = this;
            tst1.Show();

        }

        private void FormTeste1_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Deseja sair?", "Titulo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                MessageBox.Show("Saindo");
            else
            {
                MessageBox.Show("Ficando");
                e.Cancel = true;
            }
        }

        private void btnCads_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nome: "+txbnome.Text+"\nCPF:"+txbnome.Text+"\nRG:"+txbnome.Text);
            MessageBox.Show("Cadastrado com sucesso!!!");
        }

       
    }
}
