using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Temperatura
{
    class Program
    {
        static void Main(string[] args)
        {
            TemperaturaCelsius t = new TemperaturaCelsius();
            Console.WriteLine("Digite a temperatura em ºC: ");
            t.modulo = double.Parse(Console.ReadLine());
            Console.WriteLine(t.ConverterParaFarenheit());
        }
    }
}
