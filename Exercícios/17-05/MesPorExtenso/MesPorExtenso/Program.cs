using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MesPorExtenso
{
    class Program
    {
        static void Main(string[] args)
        {
            string ata = mesPorExtenso(Console.ReadLine());
            Console.WriteLine(ata);
        }

        static string mesPorExtenso(string data)
        {
            string[] meses = {"janeiro", "feveiro", "março", "abril", "maio", "junho", 
                             "julho", "agosto", "setembro", "outubro", "novembro", "dezembro"};

            string dia = data.Substring(0, 2);
            int mes = int.Parse(data.Substring(3, 2));
            string ano = data.Substring(6, 4);

            return String.Format("{0} de {1} de {2}", dia, meses[mes-1], ano);
        }
    }
}
