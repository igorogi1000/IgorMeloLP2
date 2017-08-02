using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Temperatura
{
    class TemperaturaCelsius
    {
        public double modulo;
        public double ConverterParaFarenheit()
        {
            return (double) modulo / 5 * 9 + 32;
        }

        public double ConverterParaKelvin()
        {
            return modulo + 273;
        }
    }
}
 