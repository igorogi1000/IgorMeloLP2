using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Produtos
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto proud = new Produto(1, "CresceFast - Para unhas 100g", 6.666);
            proud.Reposicao(10);
            proud.Retirada(1);

            Console.WriteLine(proud.Imprimir());
        }
    }
}
