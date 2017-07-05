using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiaDoAno
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a data por extenso:");
            int ata = convertToDiaDoAno(Console.ReadLine());
            Console.WriteLine(ata);
        }

        static int convertToDiaDoAno(string data)
        {
            string[] meses = {"janeiro", "fevereiro", "março", "abril", "maio", "junho", 
                             "julho", "agosto", "setembro", "outubro", "novembro", "dezembro"};

            int diaDoMes = 0;

            int[] qtdDias = { 31, 28, 31, 30, 31, 30, 31, 30, 31, 30, 31, 30 };
            string[] s = data.Split(' ');

            int dia = int.Parse(s[0]);
            string mes = s[2].ToLower();

            for (int i = 0; i < 12; i++)
            {
                if (mes == meses[i])
                {
                    diaDoMes += dia;
                    break;
                }

                else
                {
                    diaDoMes += qtdDias[i];
                }
            }

            return diaDoMes;
        }
    }
}
