using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetosNoPlano
{
    class Program
    {
        static void Main(string[] args)
        {
            int W = 800;
            int H = 600;

            bool continuar = true;

            Objeto2D o = new Objeto2D();

            Console.WriteLine("Digite x inicial: ");
            o.x = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite y inicial: ");
            o.y = int.Parse(Console.ReadLine());
            Console.WriteLine("Pressione o comando");

            while (continuar) {
                
                ConsoleKey comando = Console.ReadKey().Key;
                Console.WriteLine();

                if (comando == ConsoleKey.D && o.x + Objeto2D.PASSO <= W)
                    o.moveX(Objeto2D.POSITIVO);

                else if (comando == ConsoleKey.A && o.x - Objeto2D.PASSO >= 0)
                    o.moveX(Objeto2D.NEGATIVO);

                else if (comando == ConsoleKey.W && o.y + Objeto2D.PASSO <= H)
                    o.moveY(Objeto2D.POSITIVO);

                else if (comando == ConsoleKey.S && o.y - Objeto2D.PASSO >= 0)
                    o.moveY(Objeto2D.NEGATIVO);

                else if (comando == ConsoleKey.Escape)
                    continuar = false;

                Console.WriteLine("[{0}, {1}]", o.x, o.y);
            }

            Console.WriteLine("Nice-ended");
        }
    }
}
