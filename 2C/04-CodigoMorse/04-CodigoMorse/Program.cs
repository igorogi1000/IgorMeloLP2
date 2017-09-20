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
            Mensagem m = new Mensagem();

            m.texto = "OVO CASA";
            Console.WriteLine(m.PortuguesParaMorse());
            Console.WriteLine(m.MorseParaPortugues());
            //Console.WriteLine(m.PortuguesParaMorse("opa valeu"));
        }
    }
}
