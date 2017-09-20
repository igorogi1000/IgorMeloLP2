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
            string[] tiposDeConversao = new string[] { "Sair", "Massa", "Temperatura", "Distância" };
            
            string[,] conversao = new string[,] {
                {"Kg --> g", "g --> Kg", "Kg --> T", "T --> Kg", "Kg --> Lbs", "Lbs --> Kg"},
                {"ºC --> °F", "ºF --> °C", "°F --> °K", "°K --> °F", "°K --> °C", "°C --> °K"},
                {"Km --> Milha", "Milha --> Km", "m --> pés", "pés --> m", "m --> pol.", "pol. --> m", "pol. --> pés", "pés --> pol."}
            };
            
            int selecionou = -1;

            while (selecionou != 0)
            {
                Console.WriteLine("0) {0}", tiposDeConversao[0]);
                Console.WriteLine("1) {0}", tiposDeConversao[1]);
                Console.WriteLine("2) {0}", tiposDeConversao[2]);
                Console.WriteLine("3) {0}", tiposDeConversao[3]);

                selecionou = int.Parse(Console.ReadLine());

                
            }

            Console.WriteLine("É nóis");
        }
    }
}
