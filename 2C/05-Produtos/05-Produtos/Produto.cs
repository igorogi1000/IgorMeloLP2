using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Produtos
{
    class Produto
    {
        private int id;
        public int Id { 
            get{return id;}
        }

        private int quantidade;
        public int Quantidade
        {
            get { return quantidade; }
        }

        private string nome;
        public string Nome {
            get { return nome; }
        }


        private double preco;
        public double Preco {
            get { return preco; } 
            set{
                if (value <= 0)
                    throw new Exception();
                preco = value;
            }
        }

        public Produto(int id, string nome, double preco)
        {
            this.id = id;
            this.nome = nome;
            this.preco = preco;
            this.quantidade = 0;
        }

        public void Reposicao(int qtd)
        {
            if (qtd <= 0)
                throw new Exception();
            quantidade += qtd;
        }

        public void Retirada(int qtd)
        {
            if (qtd <= 0 || qtd > quantidade)
                throw new Exception();
            quantidade -= qtd;
        }

        public string Imprimir()
        {
            return String.Format("PRODUTO: {0}\tPRECO: R$ {1:0.00}\tQTE: {2}", nome, Preco, quantidade);
        }
    }
}
