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
            //Receber os nomes dos produtos e os seus valores digitados armazenando nas variáveis da classe

            produto1.nome=Txt_Produto1.Text; //Atribuindo o campo digitado para dentro da variável 
            produto1.preco=double.Parse(Txt_Valor1.Text); //Atribuindo o valor digitado e convertido para double para dentro da variável

            produto2.nome=Txt_Produto2.Text;
            produto2.preco=Convert.ToDouble(Txt_Valor2.Text);

            produto3.nome=Txt_Produto3.Text;
            produto3.preco = double.Parse(Txt_Valor3.Text);

            //Mostrando os produtos e valores que estão na memória

            Lbl_Resultado.Text = "Produto 1: " + produto1.nome + "\n" + "Preço Inicial: " + produto1.preco.ToString("c2") + "\n";
            produto1.Atualiza_Preco(10); //Usando o Método para Reajustar o Valor em 10%
            Lbl_Resultado.Text += "Novo Preço: " + produto1.preco.ToString("c2") + "\n\n";

            Lbl_Resultado.Text += "Produto 2: " + produto2.nome + "\n" + "Preço Inicial: " + produto2.preco.ToString("c2") + "\n";
            produto2.Atualiza_Preco(10); //Usando o Método para Reajustar o Valor em 10%
            Lbl_Resultado.Text += "Novo Preço: " +produto2.preco.ToString("c2") + "\n\n";

            Lbl_Resultado.Text += "Produto 3: " + produto3.nome + "\n" + "Preço Inicial: " + produto3.preco.ToString("c2") + "\n";
            produto3.Atualiza_Preco(10); //Usando o Método para Reajustar o Valor em 10%
            Lbl_Resultado.Text += "Novo Preço: " + produto3.preco.ToString("c2") + "\n\n";
        }
    }
}
