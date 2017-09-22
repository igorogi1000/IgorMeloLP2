/* (C) 2017 Copyright Igor Melo. All rights reserved. */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Empresa
{
    class Empregado : Funcionario
    {
        public Gerente GerenteDele { get; set; }
        public string DataDeEntrada { get; set; }

        public Empregado(int registro)
            : base(registro)
        {
            
        }

    }
}
