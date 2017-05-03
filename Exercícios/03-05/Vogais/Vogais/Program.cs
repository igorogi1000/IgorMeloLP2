using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vogais
{
    class Program
    {
        static void Main(string[] args)
        {
            string frase = Console.ReadLine().ToLower();
            char[] vogais = { 'a', 'e', 'i', 'o', 'u' };

            int qtdVogais = 0;


            for (int i = 0; i < frase.Length; i++)
            {
                if (vogais.Contains(frase[i]))
                    qtdVogais++;
            }

            Console.WriteLine("Contém {0} vogais na frase", qtdVogais);
        }
    }
}
