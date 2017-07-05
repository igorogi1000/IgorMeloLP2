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

            Livro l = new Livro();

            //l.TempoDeLeitura(12);

            string[] impossiveis = new string[n];
            int qtdImpossiveis = 0;

            double horasParaLerTudo = 0;

            Console.WriteLine("Digite a velocidade de leitura de Hermione: ");
            int velocidade = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                livros[i] = new Livro();
                
                Console.WriteLine("Digite o nome do livro: ");
                livros[i].titulo = Console.ReadLine();

                Console.WriteLine("Digite o número de páginas: ");
                livros[i].numeroPaginas = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite o número de dias para devolução: ");
                livros[i].diasParaDevolucao = int.Parse(Console.ReadLine());

                Console.Write("\n\n");

                double tempoAtual = livros[i].TempoDeLeitura(velocidade);

                horasParaLerTudo += tempoAtual;
                if (tempoAtual / 24 > livros[i].diasParaDevolucao) {
                    impossiveis[qtdImpossiveis] = livros[i].titulo;
                    qtdImpossiveis++;
                }
            }

            if (qtdImpossiveis > 0)
            {
                Console.WriteLine("Estes livros são impossíveis de serem lidos com essa lerdeza: ");
                for (int i = 0; i < qtdImpossiveis-1; i++)
                {
                    Console.WriteLine("{0}, ", impossiveis[i]);
                }
                Console.WriteLine(impossiveis[qtdImpossiveis - 1]);
            }
            
        }
    }
}
