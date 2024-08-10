using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_POO2
{
    public partial class Frm_Mercadorias : Form
    {
        public Frm_Mercadorias()
        {
            InitializeComponent();
        }

        //Criando os Objetos da Classe em instâncias

        Mercadorias produto1 = new Mercadorias();
        Mercadorias produto2 = new Mercadorias();
        Mercadorias produto3 = new Mercadorias();


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Txt_Produto1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Btn_Reajuste_Click(object sender, EventArgs e)
        {

            if ((Txt_Produto1.Text != "" && Txt_Valor1.Text != "" && txt_Quant1.Text != "") && (Txt_Produto2.Text != "" && Txt_Valor2.Text != "" && txt_Quant2.Text != "") && (Txt_Produto3.Text != "" && Txt_Valor3.Text != "" && txt_Quant3.Text != "") && (txt_Valor_Reajuste.Text != ""))
            {
                MessageBox.Show("Pedido Adicionado!", "Adicionado", MessageBoxButtons.OK,MessageBoxIcon.Information);

                //Receber os nomes dos produtos e os seus valores digitados armazenando nas variáveis da classe

                produto1.nome = Txt_Produto1.Text; //Atribuindo o campo digitado para dentro da variável 
                produto1.preco = double.Parse(Txt_Valor1.Text); //Atribuindo o valor digitado e convertido para double para dentro da variável
                produto1.valor_reajuste = double.Parse(txt_Valor_Reajuste.Text); //atribuindo o valor de reajuste digitado pelo usuario



                produto2.nome = Txt_Produto2.Text;
                produto2.preco = Convert.ToDouble(Txt_Valor2.Text);
                produto2.valor_reajuste = double.Parse(txt_Valor_Reajuste.Text);


                produto3.nome = Txt_Produto3.Text;
                produto3.preco = double.Parse(Txt_Valor3.Text);
                produto3.valor_reajuste = double.Parse(txt_Valor_Reajuste.Text);

                //Mostrando os produtos e valores que estão na memória

                Lbl_Resultado.Text = "Produto 1: " + produto1.nome + "\n" + "Preço Inicial: " + produto1.preco.ToString("c2") + "\n";
                //produto1.Atualiza_Preco(10); //Usando o Método para Reajustar o Valor em 10%
                produto1.Atualiza_Preco(produto1.valor_reajuste); //aplicando o metodo para reajuste de valor 
                Lbl_Resultado.Text += "Novo Preço: " + produto1.valor_reajuste.ToString("c2") + "\n\n";

                Lbl_Resultado.Text += "Produto 2: " + produto2.nome + "\n" + "Preço Inicial: " + produto2.preco.ToString("c2") + "\n";
                //produto2.Atualiza_Preco(10); //Usando o Método para Reajustar o Valor em 10%
                produto2.Atualiza_Preco(produto2.valor_reajuste); //aplicando o metodo para reajuste de valor 
                Lbl_Resultado.Text += "Novo Preço: " + produto2.valor_reajuste.ToString("c2") + "\n\n";

                Lbl_Resultado.Text += "Produto 3: " + produto3.nome + "\n" + "Preço Inicial: " + produto3.preco.ToString("c2") + "\n";
                //produto3.Atualiza_Preco(10); //Usando o Método para Reajustar o Valor em 10%
                produto3.Atualiza_Preco(produto3.valor_reajuste); //aplicando o metodo para reajuste de valor 
                Lbl_Resultado.Text += "Novo Preço: " + produto3.valor_reajuste.ToString("c2") + "\n\n";
            }
            else
            {
                MessageBox.Show("O valor de reajuste deve ser digitado!", "Atenção!", MessageBoxButtons.OK,MessageBoxIcon.Error);

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Lbl_Titulo_Click(object sender, EventArgs e)
        {

        }

        private void Lbl_Produto2_Click(object sender, EventArgs e)
        {

        }

        private void Lbl_Valor2_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Sair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Certeza que deseja sair?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
                Application.Exit();
            }
            else {
                Txt_Produto1.Focus();
            }
            
            
        }

        private void Btn_Limpar_Click(object sender, EventArgs e)
        {
            Controls.Clear();
            InitializeComponent();
            Txt_Produto1.Focus();
            
        }

        private void txt_Valor_Reajuste_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_fecharPedido_Click(object sender, EventArgs e)
        {
            if ((Txt_Produto1.Text != "" && Txt_Valor1.Text != "" && txt_Quant1.Text != "") && (Txt_Produto2.Text != "" && Txt_Valor2.Text != "" && txt_Quant2.Text != "") && (Txt_Produto3.Text != ""  && Txt_Valor3.Text != "" && txt_Quant3.Text != ""))
            {
                produto1.quantidade = int.Parse(txt_Quant1.Text); //atribuindo variavel quantidade
                produto2.quantidade = int.Parse(txt_Quant2.Text);
                produto3.quantidade = int.Parse(txt_Quant3.Text);

                produto1.preco = double.Parse(Txt_Valor1.Text); //atribuindo variavel preco
                produto2.preco = double.Parse(Txt_Valor2.Text);
                produto3.preco = double.Parse(Txt_Valor3.Text);

                produto1.Fechar_Pedido(); //aplicando o metodo
                produto2.Fechar_Pedido();
                produto3.Fechar_Pedido();



                txt_Total1.Text = produto1.valor_total.ToString("c2");
                //convertendo double para string em formato de moeda
                txt_Total2.Text = produto2.valor_total.ToString("c2");
                txt_Total3.Text = produto3.valor_total.ToString("c2");

                txt_valorFinal.Text = (produto1.valor_total + produto2.valor_total + produto3.valor_total).ToString("c2");

                MessageBox.Show("Fechado", "Pedido Fechado!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Alguns campos não foram preenchidos!", "Atenção!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
          
        }
    }
}
