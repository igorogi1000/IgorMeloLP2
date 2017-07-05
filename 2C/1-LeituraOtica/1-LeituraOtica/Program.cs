using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_LeituraOtica
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int j = 0; j < n; j++)
            {
                int[] notas = new int[5];
                for (int k = 0; k < 5; k++)
                {
                    notas[k] = int.Parse(Console.ReadLine());
                }
                Console.WriteLine(Marcada(notas));
            }
        }

        public static char Marcada(int[] notas)
        {
            char res = '*';
            char[] letras = new char[5] {'A', 'B', 'C', 'D', 'E'};
            bool jaMarcou = false;

            for (int i=0; i<notas.Length; i++) 
            {
                if (notas[i] <= 100)
                {
                    if (!jaMarcou) 
                    {
                        jaMarcou = true;
                        res = letras[i];
                    }
                    else
                    {
                        res = '*';
                        break;
                    }
                }
                else if (notas[i] < 155)
                {
                    res = '*';
                    break;
                }
            }
            return res;
        }
    }
}