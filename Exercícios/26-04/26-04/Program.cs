using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        //Classificar("celta", 123, 120);
        static string Classificar(string nome, double kmRodados, int potenciaMotor)
        {
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

            return nome + " " + idade + " " + potenciaPorExtenso;
        }

        static void Main(string[] args)
        {
            
            int quantidadeVeiculos;
            
            Console.WriteLine("Digite a quantidade de veículos: ");
            quantidadeVeiculos = int.Parse(Console.ReadLine());

            for (int i=0; i < quantidadeVeiculos; i++)
            {
                string modelo;
                double kmRodados;
                int potenciaMotor;

                //Recebendo valores
                Console.WriteLine("Digite o modelo: ");
                modelo = Console.ReadLine();
                Console.WriteLine();

                Console.WriteLine("Digite a quilometragem rodada: ");
                kmRodados = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine();

                Console.WriteLine("Digite a potencia do motor: ");
                potenciaMotor = int.Parse(Console.ReadLine());
                Console.WriteLine("----------------");


                string resultado = Classificar(modelo, kmRodados, potenciaMotor);
                Console.WriteLine(resultado);
            }

        }
    }
}
