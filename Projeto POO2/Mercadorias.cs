using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_POO2
{
    public class Mercadorias //Criando uma classe usando o Encapsulamento (tipo de acesso a classe que será publica (tem acesso externo))
    {
        //Atributos ou Propriedades da Classe (Variáveis da Classe) Encapsulamento Público (permitir acesso externo)

        public string nome;
        public double preco, valor_reajuste, valor_total;
        public int quantidade;

        //Criando o Método da Classe com Acesso Externo (Encapsulamento Público)

        public void Atualiza_Preco(double porcentagem)
        {
            valor_reajuste = preco + (preco * porcentagem /100);
        }

        public void Fechar_Pedido()
        {
            valor_total = preco * quantidade;
        }
    
    }
}
