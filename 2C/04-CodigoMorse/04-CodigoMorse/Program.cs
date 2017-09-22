/* (c) Copyright Igor Melo, all rights not reserved. */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_CodigoMorse
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Mensagem m = new Mensagem();
            Mensagem m2 = new Mensagem();

            m.Texto = "VOCE DESTRUIU O MEU OVO";

            Console.WriteLine(m.PortuguesParaMorse());

            m2.Texto = m.PortuguesParaMorse();
            m2.Codificada = true;
            Console.WriteLine(m2.MorseParaPortugues());

            m.Transmitir();*/
         
            while (true)
            {
                Console.WriteLine("Escolha uma opção: ");

                Console.WriteLine("1 - Codificar");
                Console.WriteLine("2 - Decodificar");
                Console.WriteLine("3 - Transmitir");
                Console.WriteLine("0 - Sair");

                int opcao = int.Parse(Console.ReadLine());
                if (opcao == 0)
                    break;

                Mensagem mAtual = new Mensagem();

                switch (opcao)
                {
                    case 1:
                        Console.WriteLine("Digite a mensagem para ser codificada: ");
                        mAtual.Texto = Console.ReadLine();
                        Console.WriteLine(mAtual.PortuguesParaMorse());
                        break;

                    case 2:
                        Console.WriteLine("Digite a mensagem para ser decodificada: ");
                        mAtual.Texto = Console.ReadLine();
                        mAtual.Codificada = true;
                        Console.WriteLine(mAtual.MorseParaPortugues());
                        break;

                    case 3:
                        Console.WriteLine("Digite a mensagem para ser transmitida (em português): ");
                        mAtual.Texto = Console.ReadLine();
                        mAtual.Transmitir();
                        break;

                    default:
                        break;
                }
            }
        }
    }
}
