/* (C) 2017 Copyright Igor Melo. All rights reserved. */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Empresa
{
    class Funcionario
    {
        private int registro;
        public int Registro { get { return registro; } }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Email { get; set; }
        public double Salario { get; set; }

        public Funcionario(int registro)
        {
            this.registro = registro;
        }

    }
}
