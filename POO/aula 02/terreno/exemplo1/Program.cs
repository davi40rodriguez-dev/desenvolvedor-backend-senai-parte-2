using System;
using System.Collections.Generic;
using System.Text;

namespace exemplo1
{
    internal class Produto
    {
        //Campos
        public string nome;
        public double preco;
        public int quantidade;

        //Métodos
        public double valor_Total_Em_Estoque()
        {
            return preco * quantidade;
        }
        public void Adicionar_Produtos(int qtd)
        {
            quantidade += qtd;

        }
        public void Remover_Produtos(int qtd)
        {
            quantidade -= qtd;
        }
        public string Dados_do_Produto()
        {
            return $"Nome: {nome}, Preço: R$ {preco}, Quantidade: {quantidade}, " + $"Total: {valor_Total_Em_Estoque()}";

        }
    }
}