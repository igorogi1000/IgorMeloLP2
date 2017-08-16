using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_CodigoMorse
{
    class Mensagem
    {
        public string texto { get; set;}
        public bool codificada { get; set; }

        private int frequenciaNatural = 600; //par
        private int duracaoNatural = 200; //par
        private int pausaFreq = 137;
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

        public void test()
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
        }

        public string PortuguesParaMorse()
        {
            string res = "";
            char[] input = texto.ToUpper().ToCharArray();

            for (int i = 0; i < texto.Length; i++)
            {
                int index = input[i] - 'A';
                string somar = "";  

                if (index >= 0 && index < alfabetoMorse.Length)
                {
                    somar = alfabetoMorse[input[i] - 'A'];
                }
                    
                else if (input[i].ToString() == " ")
                    somar = "\t";

                else
                    somar = input[i] + "";

                res += somar;
                res += " ";
            }
            return res;
        }

        public string MorseParaPortugues()
        {
            string res = "";
            string[] letras = texto.Split(' ');

            for (int j = 0; j < letras.Length; j++)
            {
                string somar = "";
                int i = Array.IndexOf(alfabetoMorse, letras[j]);
                
                if (i == -1)
                {
                    if (letras[j] == "" || letras[j] == "/" && res[res.Length-1] != ' ')
                    {
                        somar = " ";
                        //Console.WriteLine("KKKKK");
                    }

                    else
                    {
                        somar = letras[j];
                    }
                }

                else
                {
                    char ch = (char) (i + 'a');
                    somar = ch + "";
                    //Console.WriteLine(somar);
                }

                res += somar;
                somar = "";
            }

            return res;
        }

        public void Transmitir()
        {
            string emMorse = texto;

            if (!codificada)
                emMorse = PortuguesParaMorse();

            for (int i = 0; i < emMorse.Length; i++)
            {
                if (emMorse[i] == '.')
                    Console.Beep(frequenciaNatural, duracaoNatural/2);
                else if (emMorse[i] == '-')
                    Console.Beep(frequenciaNatural, duracaoNatural);
                else
                    Console.Beep(pausaFreq, duracaoNatural);
            }
        }
    }
}
