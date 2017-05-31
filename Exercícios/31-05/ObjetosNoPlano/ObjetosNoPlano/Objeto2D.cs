using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetosNoPlano
{
    class Objeto2D
    {
        public int x;
        public int y;

        public const bool POSITIVO = true;
        public const bool NEGATIVO = false;
        public const int PASSO = 3;

        public void moveX(bool direita)
        {
            if (direita)
                x += PASSO;
            else
                x -= PASSO;
        }

        public void moveY(bool cima)
        {
            if (cima)
                y += PASSO;
            else
                y -= PASSO;
        }

        public string Coordenadas()
        {
            return String.Format("[{0}, {1}]", x, y);
        }

        /*public string CordenadasString(int w, int h)
        {
            char[,] resultado = new char[h, w];
            for (int l = 0; l < w; l++)
            {
                for (int c = 0; c < h; c++) 
                {
                    if (l == x && c == y)
                        resultado[l,c] = '!';
                    else 
                        resultado[l,c] = '.';
                }
                    
            }
            return resultado.ToString();
        }*/
    }
}
