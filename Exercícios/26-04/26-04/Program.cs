using System;

namespace exercicios_lp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantidadeVeiculos;
            string nome;
            double kmRodados;
            int potenciaMotor;


            Console.WriteLine("Digite a quantidade de veículos: ");
            quantidadeVeiculos = int.Parse(Console.ReadLine());

            for (int i = 0; i < quantidadeVeiculos; i++)
            {

                //Recebendo valores

                Console.WriteLine("Digite o modelo: ");
                nome = Console.ReadLine();
                Console.WriteLine();

                Console.WriteLine("Digite a quilometragem rodada: ");
                kmRodados = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine();

                Console.WriteLine("Digite a potencia do motor: ");
                potenciaMotor = int.Parse(Console.ReadLine());
                Console.WriteLine("----------------");

                string idade;
                string potenciaPorExtenso;

                //Idade do carro
                if (kmRodados <= 5000)
                    idade = "novo";

                else if (kmRodados > 5000 && kmRodados <= 30000)
                    idade = "seminovo";

                else
                    idade = "velho";

                //Potencia 
                if (potenciaMotor >= 120 && potenciaMotor <= 200)
                    potenciaPorExtenso = "forte";

                else if (potenciaMotor > 200)
                    potenciaPorExtenso = "potente";

                else
                    potenciaPorExtenso = "popular";

                Console.WriteLine("{0} - {1} {2}", nome, idade, potenciaPorExtenso);
            }
        }
    }
}
