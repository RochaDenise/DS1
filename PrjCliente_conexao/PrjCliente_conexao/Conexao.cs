using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Data;
using System.Windows.Forms;

namespace PrjCliente_conexao
{
    class Conexao
    {
        //Declare o objeto de conexão passando como parâmetro a string de conexão
        private static string connString = @"Provider=Microsoft.Ace.OLEDB.12.0;Data Source=DB_Cliente.accdb";
        //Variável que representa a conexao com o banco
        private static OleDbConnection conn = null;

        //***********************************************************************
        //                  método que permite obter a conexão
        //***********************************************************************

        public static OleDbConnection obterConexao()
        {
            //vamos criar a conexao
            conn = new OleDbConnection(connString);
            //a conexao foi feita com sucesso?
            try
            {
                //abre a conexão e a devolver ao chamado do método
                conn.Open();
            }
            catch (Exception)
            {
                conn = null;
                MessageBox.Show("Conexão não estabelecida!!");
                //Ops! o que aconteceu?
                //uma boa idéia auiq é gravar a exceção em um arquivo de log
            }
            return conn;
        }

        //***********************************************************************
        //                  método que permite fechar a conexão
        //***********************************************************************
        public static void fecharConexao()
        {
            if (conn != null)
            {
                conn.Close();
            }
        }

    }
}