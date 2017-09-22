/* (C) 2017 Copyright Igor Melo. All rights reserved. */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Empresa
{
    class Gerente : Funcionario
    {
        public string Setor { get; set; }
        public double Bonus { get; set; }

        public Gerente(int registro)
            : base(registro)
        {

        }
    }
}
