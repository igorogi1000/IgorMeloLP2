using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_LivrosHermione
{
    class Livro
    {
        public string titulo;
        public int numeroPaginas;
        public int diasParaDevolucao;

        public int TempoDeLeitura(int pagPorHora, int horasPorDia)
        {
            return pagPorHora * horasPorDia;               
        }
    }
}
