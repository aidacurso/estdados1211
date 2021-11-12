using System;
using System.Collections.Generic;

namespace estdados1211
{
    class Program
    {
        public static string PALAVRA;
        public static int QUANT = 0;
        static List<string> letras = new List<string>();
        public static void INICIAR()
        {
            Console.WriteLine("DIGITE A QUANTIDADE DE LETRAS QUE VOCÊ IRÁ UTILIZAR NA FORCA.");
            QUANT = int.Parse(Console.ReadLine());

            Console.WriteLine("DIGITE A PALAVRA PARA UTILIZAR NA FORCA");
            PALAVRA = Console.ReadLine();
        }
        public static void FORCA()
        {
            Console.WriteLine("_________");
            Console.WriteLine("|       |");
            Console.WriteLine("|");
            Console.WriteLine("|");
            Console.WriteLine("|");
            Console.WriteLine("|");
            for (int i = 0; i < QUANT; i++)
            {
                Console.Write(" ___ ");
            }
        }
        public static void VALIDAR()
        {
            Console.WriteLine("DIGITE UMA LETRA");
            string letra = Console.ReadLine();
            for (int i = 0; i < QUANT; i++)
            {
                letras.Add(PALAVRA.Substring(i, 1));
            }
            foreach (string c in letras)
            {

                Console.Clear();

                Console.WriteLine("_________");
                Console.WriteLine("|       |");
                Console.WriteLine("|");
                Console.WriteLine("|");
                Console.WriteLine("|");
                Console.WriteLine("|");
                if (letra != c)
                {
                    Console.Write(" ___ ");
                }
                if (letra == c)
                {
                    Console.Write($" {c} ");
                }
            }
            static void Main(string[] args)
            {
                INICIAR();
                FORCA();


            }
        }
    }
}
