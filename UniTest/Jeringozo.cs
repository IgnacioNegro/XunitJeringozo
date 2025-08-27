using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniTest
{
    public class Jeringozo
    {

        public static string Encriptar(string texto)
        {
            string vocales = "aeiouAEIOU";
            string salida = "";

            foreach (char letra in texto)
            {
                if (vocales.Contains(char.ToLower(letra)))
                {
                    salida += letra + "p" + letra;
                }
                else
                {
                    salida += letra;
                }
            }

            return salida;
        }

        public static string Desencriptar(string texto)
        {
            string[] abreviado = { "apa", "epe", "ipi", "opo", "upu" };
            string salida = "";
            int i = 0;
            while (i < texto.Length)
            {
                char letra = texto[i];
                salida += letra;

                if ("aeiouAEIOU".Contains(letra) && i + 2 < texto.Length)
                {
                    i += 2;
                }

                i++;
            }

            return salida;
        }

    }
}
