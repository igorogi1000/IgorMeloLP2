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
            Produto crescefast = new Produto(1, "CresceFast - Para unhas 100g", 6.666);
            crescefast.Reposicao(10);
            crescefast.Retirada(1);

            Produto churros = new Produto(2, "Churros chocolate/leite condensado - 300g", 2.3);
            crescefast.Reposicao(2);

            Console.WriteLine(crescefast.ToString());
            Console.WriteLine(churros.ToString());
        }
    }
}
