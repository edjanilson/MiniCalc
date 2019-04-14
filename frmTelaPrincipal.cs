using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniCalc
{
    public partial class frmTelaPrincipal : Form
    {
        public frmTelaPrincipal()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //Declarando as variáveis.
            double num1, num2, adicao, subtracao, multiplicacao, divisao;

            if (txtNum1.Text == "" || txtNum2.Text == "")
            {
                MessageBox.Show("Ocorreu algo errado, verifique as informações e tente novamente.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {



                    //Inicializando as variáveis.
                    num1 = double.Parse(txtNum1.Text);
                    num2 = double.Parse(txtNum2.Text);

                    //Se a opção Adição for marcada.
                    if (rbAdicao.Checked == true)
                    {
                        //Então será realizada uma adição dos números inseridos.
                        adicao = num1 + num2;
                        //E mostrará o resultado.
                        txtResultado.Text = adicao.ToString();
                    }

                    //Senão se a opção Subtração for marcada.
                    else
                        if (rbSubtracao.Checked == true)
                    {
                        //Então será realizada uma subtração.
                        subtracao = num1 - num2;
                        //E mostrará o resultado.
                        txtResultado.Text = subtracao.ToString();
                    }

                    //Senão se a opção Multiplicação for marcada.
                    else
                        if (rbMultiplicacao.Checked == true)
                    {
                        //Então será realizada uma Multiplicação.
                        multiplicacao = num1 * num2;
                        //E mostrará o resultado.
                        txtResultado.Text = multiplicacao.ToString();
                    }

                    //Senão se a opção Divisão for marcada.
                    else
                        if (rbDivisao.Checked == true)
                    {
                        //Então será realizada uma Divisão.
                        divisao = num1 / num2;
                        //E mostrará o resultado.
                        txtResultado.Text = divisao.ToString();
                    }
                }catch(FormatException)
                {
                    MessageBox.Show("Você dever digitar apenas números, tente novamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Aparece uma mensagem perguntando se realmente desejamos fechar o programa.
            if(MessageBox.Show("Tem certeza que deseja fechar o programa?","Atenção",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                //Caso a resposta seja sim, o programa irá fechar.
                this.Close();
            }
        }

        private void btnApagarValores_Click(object sender, EventArgs e)
        {
            //Apaga todos os valores numéricos do formulário.
            txtNum1.Clear();
            txtNum2.Clear();
            txtResultado.Clear();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //Apga o conteúdo do TextBox 1.
            txtNum1.Clear();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            //Apaga o conteúdo do TextBox 2
            txtNum2.Clear();
        }
    }
}
