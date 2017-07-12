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

        public int PaginasPorDia(int pagPorHora, int horasPorDia)
        {
            return pagPorHora * horasPorDia;               
        }

        public double DiasLeitura(int pagPorHora, int horasPorDia)
        {
            return (double) numeroPaginas / PaginasPorDia(pagPorHora, horasPorDia);
        }

        public bool isPossivelLer(int pagPorHora, int horasPorDia)
        {
            return DiasLeitura(pagPorHora, horasPorDia) <= diasParaDevolucao;
        }
    }
}
