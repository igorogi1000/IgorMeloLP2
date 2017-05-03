using System;

namespace exercicios_lp2
{
    class Program
    {
        // (Revisão de struct)

        struct Carro
        {
            public string nome;
            public double kmRodados;
            public int potenciaMotor;
        }

        static string Classificar(Carro carrito)
        {
            string idade;
            string potenciaPorExtenso;

            //Idade do carro
            if (carrito.kmRodados <= 5000)
                idade = "novo";

            else if (carrito.kmRodados > 5000 && carrito.kmRodados <= 30000)
                idade = "seminovo";

            else
                idade = "velho";

            //Potencia 
            if (carrito.potenciaMotor >= 120 && carrito.potenciaMotor <= 200)
                potenciaPorExtenso = "forte";

            else if (carrito.potenciaMotor > 200)
                potenciaPorExtenso = "potente";

            else
                potenciaPorExtenso = "popular";

            //return carrito.nome + " " + idade + " " + potenciaPorExtenso;
            return String.Format("{0} - {1} - {2}", carrito.nome, idade, potenciaPorExtenso);
        }





        static void Main(string[] args)
        {

            int quantidadeVeiculos;
            string[] classificacoes;

            Console.WriteLine("Digite a quantidade de veículos: ");
            quantidadeVeiculos = int.Parse(Console.ReadLine());

            classificacoes = new string[quantidadeVeiculos];

            for (int i = 0; i < quantidadeVeiculos; i++)
            {
                Carro carroAtual = new Carro();

                //Recebendo valores

                Console.WriteLine("Digite o modelo: ");
                carroAtual.nome = Console.ReadLine();
                Console.WriteLine();

                Console.WriteLine("Digite a quilometragem rodada: ");
                carroAtual.kmRodados = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine();

                Console.WriteLine("Digite a potencia do motor: ");
                carroAtual.potenciaMotor = int.Parse(Console.ReadLine());
                Console.WriteLine("----------------");


                classificacoes[i] = Classificar(carroAtual);
            }

            foreach (string cl in classificacoes)
            {
                Console.WriteLine(cl);
            }

        }
    }
}
