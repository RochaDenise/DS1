using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data;


namespace PrjCliente_conexao
{
    public partial class Cadastro : Form
    {
        //conectar através da class Conexão
        OleDbConnection conn = Conexao.obterConexao();
        //Declarar o DataReader -- Tabela virtual somente leitura
        OleDbDataReader dr_clientes;
        //Declare o BindingSouce -- tabela virtual editável
        BindingSource bs_clientes = new BindingSource();
        //Criando a variavel que receberá a query (comando sql)
        String _query;
                                            
        public Cadastro()
        {
            InitializeComponent();
        }
        private void carregar_grid()
        {
            //Determine a query desejada
            _query = "SELECT * FROM clientes";
            //Declare o objeto DataComand passado a query e o objeto de Conexão
            OleDbCommand _dataCommand = new OleDbCommand(_query,conn);
            //Execute o método ExecuteReader que retornará um DataReader preenchido com a query
            dr_clientes = _dataCommand.ExecuteReader();
            //Teste para verificar se retornaram linhas
            if (dr_clientes.HasRows == true)
            {
                bs_clientes.DataSource = dr_clientes;
                dgv_clientes.DataSource = bs_clientes;
                igualar_Text();
            }
            else
            {
                MessageBox.Show("Não temos Clientes cadastrados !!!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void igualar_Text()
        {
            lblMatricula2.DataBindings.Add("Text", bs_clientes, "Matricula");
            lblMatricula2.DataBindings.Clear();
            dtp_nasc.DataBindings.Add("Text", bs_clientes, "Nasc");
            dtp_nasc.DataBindings.Clear();
            txbNome.DataBindings.Add("Text", bs_clientes, "Nome");
            txbNome.DataBindings.Clear();
            txbEnd.DataBindings.Add("Text", bs_clientes, "Endereco");
            txbEnd.DataBindings.Clear();
            txbNumero.DataBindings.Add("Text", bs_clientes, "numero");
            txbNumero.DataBindings.Clear();
            mskCep.DataBindings.Add("Text",bs_clientes,"cep");
            mskCep.DataBindings.Clear();
           
        }
        

        private void dgv_clientes_Click(object sender, EventArgs e)
        {
            igualar_Text();
        }

        private void dgv_clientes_KeyUp(object sender, KeyEventArgs e)
        {
            igualar_Text();
        }

        
        private void Cadastro_Load(object sender, EventArgs e)
        {
            carregar_grid();
        }

        private void txbPesquisar_TextChanged_1(object sender, EventArgs e)
        {
            _query = "SELECT * FROM clientes WHERE Nome LIKE '" + txbPesquisar.Text + "%'";
            OleDbCommand _dataCommand = new OleDbCommand(_query, conn);
            dr_clientes = _dataCommand.ExecuteReader();

            if (dr_clientes.HasRows == true)
            {
                bs_clientes.DataSource = dr_clientes;
            }
            else
            {
                MessageBox.Show("Não temos cliente cadastrado com este nome !!!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txbPesquisar.Text = "";
            }
        }

    


    
    }
}

