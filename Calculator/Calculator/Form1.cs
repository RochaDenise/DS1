using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Calculator
{ 

    public partial class frmCalc : Form
    {
     string operacao=""; //Declarando uma variavel do tipo string 
     double valor1; //Declarando uma variavel do tipo double com o nome Valor1
        public frmCalc()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {//adicionando o valor 1 na textbox

            
                txbResult.Text += "1";
                lblResul.Text = lblResul.Text + 1;
            

        }

        private void btn2_Click(object sender, EventArgs e)
        {

               txbResult.Text += "2";
               lblResul.Text = lblResul.Text + 2;
            
        }

        private void btn3_Click(object sender, EventArgs e)
        {
                        
                txbResult.Text += "3";
                lblResul.Text = lblResul.Text + 3;
            

        }

        private void btn4_Click(object sender, EventArgs e)
        {
            
                txbResult.Text += "4";
                lblResul.Text = lblResul.Text + 4;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            
                txbResult.Text += "5";
                lblResul.Text = lblResul.Text + 5;
        }
        private void btn6_Click(object sender, EventArgs e)
        {
           
                txbResult.Text += "6";
                lblResul.Text = lblResul.Text + 6;
            
        }


        private void btn7_Click(object sender, EventArgs e)
        {

                txbResult.Text += "7";
                lblResul.Text = lblResul.Text + 7;
            
        }

        private void btn8_Click(object sender, EventArgs e)
        {
                txbResult.Text += "8";
                lblResul.Text = lblResul.Text + 8;
            

        }

        private void btn9_Click(object sender, EventArgs e)
        {
            
                txbResult.Text += "9";
                lblResul.Text = lblResul.Text + 9;
            

        }

        private void btn0_Click(object sender, EventArgs e)
        {
            
                txbResult.Text += "0";
                lblResul.Text = lblResul.Text + 0;
            

        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            btnIgual.PerformClick();//faz basicamente a mesma coisa que o botão igual, p variavel receber o q está na textBox             
            operacao = "+";// armazenando a variavel "+" na operacao declarada no inicio do codigo 
            lblResul.Text = lblResul.Text + " + ";
            txbResult.Clear ();//limpando a variavel, fazendo com que as operações seguintes funcionem
           /* string resu = lblResul.Text + " + ";
            lblResul.Text = resu;*/
           
            
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            btnIgual.PerformClick();
            operacao = "-";
            lblResul.Text = lblResul.Text + " - ";
            txbResult.Clear();
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            btnIgual.PerformClick();
            operacao = "*";
            lblResul.Text = lblResul.Text + " * ";
            txbResult.Clear();
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            btnIgual.PerformClick();
            operacao = "/";
            lblResul.Text = lblResul.Text + " / ";
            txbResult.Clear();
            
        }
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            lblResul.Text = "";
            txbResult.Text = "";
            valor1 = 0;

        }


        private void btnIgual_Click(object sender, EventArgs e)
        {
                      
            switch(operacao) {
                case "+"://a operação declarado no botão somar
                    txbResult.Text = (valor1 + Double.Parse(txbResult.Text)).ToString();
                    // o visor recebe o primeiro valor, faz a soma com o valor 1, com o digitado na textbox e converte p double
                    break; //termina a operação
                case "-":
                    txbResult.Text = (valor1 - Double.Parse(txbResult.Text)).ToString();
                     break;
                case "*":
                    txbResult.Text = (valor1 * Double.Parse(txbResult.Text)).ToString();
                 
                    break;
                case "/":
                    txbResult.Text = (valor1 / Double.Parse(txbResult.Text)).ToString();
                   
                    break;
                default:
                    break;
              }
            valor1 = Double.Parse(txbResult.Text);//convertendo o q ta na textbox e passando p valor1 antes de limpar 
            operacao = "";
            

            
           
        }

        private void txbResult_TextChanged(object sender, EventArgs e)
        {

        }

      
        
       
        
       
    }
}
