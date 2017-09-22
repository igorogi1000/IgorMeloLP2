/* (c) Copyright Igor Melo, all rights not reserved. */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace _04_CodigoMorse
{
    class Mensagem
    {
        public string Texto { get; set; }
        public bool Codificada { get; set; }

        private int frequenciaNatural = 2000; //par
        private int duracaoNatural = 240; //par
        private int pausaDuracao = 300;
        private string[] alfabetoMorse = new string[] {
            ".-",
            "-...",
            "-.-.",
            "-..",
            ".",
            "..-.",
            "--.",
            "....",
            "..",
            ".---",
            "-.-",
            ".-..",
            "--",
            "-.",
            "---",
            ".--.",
            "--.-",
            ".-.",
            "...",
            "-",
            "..-",
            "...-",
            ".--",
            "-..-",
            "-.--",
            "--..",
        };

        /*public void test()
        {
            int vezes = 0;
            
            for (int i = 0; i < alfabetoMorse.Length - 1; i++)
            {
                for (int j = i + 1; j < alfabetoMorse.Length; j++) 
                {
                    if (alfabetoMorse[i] == alfabetoMorse[j])
                        vezes++;

                    if (vezes > 1) 
                    {
                        Console.WriteLine("EITA, {0}", alfabetoMorse[j]);
                    }
                        
                }
                
                vezes = 0;
            }
        }*/

        public string PortuguesParaMorse()
        {
            string res = "";
            char[] input = Texto.ToCharArray();

            for (int i = 0; i < Texto.Length; i++)
            {
                int index = input[i] - 'A';
                string somar = "";  

                if (index >= 0 && index < alfabetoMorse.Length)
                {
                    somar = alfabetoMorse[input[i] - 'A'];
                }
                    
                else if (input[i].ToString() == " ")
                    somar = "  ";

                else
                    somar = input[i] + "";

                res += somar;
                res += " ";
            }
            
            return res;
        }

        public string MorseParaPortugues()
        {
            if (Codificada)
            {
                string res = "";

                string[] letras = Texto.Split(' ');

                foreach (string letra in letras)
                {
                    int index = Array.IndexOf(alfabetoMorse, letra);
                    
                    if (index != -1)
                    {
                        char ch = (char)(index + 'A');
                        Console.Write(ch);
                    }
                    else
                        Console.Write(" ");
                }
                return res;
            }

            throw new Exception("A mensagem não está codificada!");
        }

        public void Transmitir()
        {
            string emMorse = Texto;
            
            if (!Codificada)
                emMorse = PortuguesParaMorse();

            for (int i = 0; i < emMorse.Length; i++)
            {
                if (emMorse[i] == '.')
                    Console.Beep(frequenciaNatural, duracaoNatural / 2);
                else if (emMorse[i] == '-')
                    Console.Beep(frequenciaNatural, duracaoNatural);
                else
                    Thread.Sleep(pausaDuracao);
                    //Console.Beep(pausaFreq, duracaoNatural);
            }
        }

        public Mensagem()
        {
            Codificada = false;
        }
    }
}
