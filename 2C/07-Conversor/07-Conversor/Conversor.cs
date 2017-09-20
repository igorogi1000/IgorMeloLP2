/* (C) 2017 Copyright Igor Melo. All rights reserved. */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Conversor
{
    public static class Conversor
    {
        // MASSA
        public static double KgParaG(double kg)
        {
            return kg * 1000;
        }

        public static double GParaKg(double g)
        {
            return g / 1000;
        }

        public static double KgParaT(double kg)
        {
            return kg / 1000;
        }

        public static double TParaKg(double t)
        {
            return t * 1000;
        }

        public static double KgParaLbs(double kg)
        {
            return kg * 2.20462;
        }

        public static double LbsParaKg(double lbs)
        {
            return lbs / 2.20462;
        }


        // TEMPERATURA
        public static double CparaK(double c)
        {
            return c + 273;
        }

        public static double KparaC(double k)
        {
            return k - 273;
        }

        public static double CparaF(double c)
        {
            return c / 5 * 9 + 32;
        }

        public static double FparaC(double f)
        {
            return (f - 32) / 9 * 5;
        }

        public static double KparaF(double k)
        {
            return CparaF(KparaC(k));
        }

        public static double FparaK(double f)
        {
            return CparaK(FparaC(f));
        }


        //DISTÂNCIA
        public static double MParaKm(double m)
        {
            return m / 1000;
        }

        public static double KmParaM(double km)
        {
            return km * 1000;
        }

        public static double KmParaMilha(double km)
        {
            return km * 0.621371;
        }

        public static double MilhaParaKm(double milha)
        {
            return milha / 0.621371;
        }

        public static double MParaPes(double m)
        {
            return m * 3.28084;
        }

        public static double PesParaM(double pes)
        {
            return pes / 3.28084;
        }

        public static double MParaPol(double m)
        {
            return m * 39.3701;
        }

        public static double PolParaM(double pol)
        {
            return pol / 39.3701;
        }

        public static double PesParaPol(double pes)
        {
            return MParaPol(PesParaM(pes));
        }

        public static double PolParaPes(double pol)
        {
            return MParaPes(PolParaM(pol));
        }
    }
}
