using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_LivrosHermione
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a quantidade de livros: ");
            int n = int.Parse(Console.ReadLine());

            Livro[] livros = new Livro[n];
            string[] impossiveis = new string[n];
            int qtdImpossiveis = 0;

            double tempoTotal = 0;

            Console.WriteLine("Digite a velocidade de leitura de Hermione: ");
            int velocidade = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a quantidade de horas dedicadas aos livros: ");
            int horasPorDia = int.Parse(Console.ReadLine());

            Console.WriteLine("Mec. Agora vem a parte chata...\n\n\n");

            for (int i = 0; i < n; i++)
            {
                Livro l = new Livro();

                Console.WriteLine("Digite o título do livro: ");
                l.titulo = Console.ReadLine();
                Console.WriteLine();

                Console.WriteLine("Digite o número de páginas de {0}: ", l.titulo);
                l.numeroPaginas = int.Parse(Console.ReadLine());
                Console.WriteLine();

                Console.WriteLine("Digite o número de dias para devolver o livro {0}: ", l.titulo);
                l.diasParaDevolucao = int.Parse(Console.ReadLine());
                Console.WriteLine();

                tempoTotal += l.DiasLeitura(velocidade, horasPorDia);

                if (!l.isPossivelLer(velocidade, horasPorDia))
                {
                    impossiveis[qtdImpossiveis] = l.titulo;
                    qtdImpossiveis++;
                }
            }
            
            Console.WriteLine("\n\n\n");
            Console.WriteLine("Hermione levará {0} dias para ler todos os livros.", Math.Ceiling(tempoTotal));
            Console.WriteLine("Esses livros são impossíveis de ser lidos: ");

            for (int i = 0; i < qtdImpossiveis - 1; i++)
            {
                Console.Write("{0}, ", impossiveis[i]);
            }

            Console.WriteLine(impossiveis[qtdImpossiveis - 1]);
        }
    }
}