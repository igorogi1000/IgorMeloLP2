/* (C) 2017 Copyright Igor Melo. All rights reserved. */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Conversor
{
    class Program
    {
        static void Main(string[] args)
        {
            int selecionou = -1;

            while (selecionou != 0)
            {
                Console.WriteLine("Escolha uma conversão: ");
                
                Console.WriteLine("1) Kg --> g");
                Console.WriteLine("2) g --> Kg");
                Console.WriteLine("3) Kg --> T");
                Console.WriteLine("4) T --> Kg");
                Console.WriteLine("5) °C --> °F");
                Console.WriteLine("6) °F --> °C");

                
                selecionou = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite o valor a ser convertido: ");
                double valor = double.Parse(Console.ReadLine());

                switch (selecionou)
                {
                    case 1:
                        Console.WriteLine("{0:0.0} g", Conversor.KgParaG(valor));
                        break;
                    case 2:
                        Console.WriteLine("{0:0.0} kg", Conversor.GParaKg(valor));
                        break;
                    case 3:
                        Console.WriteLine("{0:0.0} T", Conversor.KgParaT(valor));
                        break;
                    case 4:
                        Console.WriteLine("{0:0.0} kg", Conversor.TParaKg(valor));
                        break;
                    case 5:
                        Console.WriteLine("{0:0.0} ºF", Conversor.CparaF(valor));
                        break;
                    case 6:
                        Console.WriteLine("{0:0.0} ºC", Conversor.FparaC(valor));
                        break;
                }
            }
        }
    }
}
