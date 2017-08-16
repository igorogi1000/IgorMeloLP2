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
            m.codificada = false;
            m.texto = "ola marilene";
            m.Transmitir();
            //Console.WriteLine(m.PortuguesParaMorse("opa valeu"));
        }
    }
}
