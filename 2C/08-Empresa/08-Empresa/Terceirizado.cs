/* (C) 2017 Copyright Igor Melo. All rights reserved. */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Empresa
{
    class Terceirizado : Empregado
    {
        public string EmpresaMatriz { get; set; }

        public Terceirizado(int registro)
            : base(registro)
        {

        }
    }
}
