using System;
using System.Collections.Generic;

namespace estdados1211
{
    public class Program
    {
        public static int menu = 0;
        public static List<string> palavras = new List<string>();
        public static int QUANT = 0;
        static List<string> letras = new List<string>();
        public static void MENU()
        {
            //menu
            Console.WriteLine("digite 1 para inserir palavra");
            Console.WriteLine("digite 2 para jogar");
            Console.WriteLine("digite 3 para ver maior pontuação");
            Console.WriteLine("digite 4 para conhecer a desenvolvedora do jogo");
            Console.WriteLine("digite 9 para sair do jogo");
            menu = int.Parse(Console.ReadLine());
        }
        public static void OP1()
        {
            Console.Clear();
            Console.WriteLine("DIGITE A QUANTIDADE DE LETRAS QUE VOCÊ IRÁ UTILIZAR NA FORCA.");
            QUANT = int.Parse(Console.ReadLine());

            Console.WriteLine("DIGITE A PALAVRA PARA UTILIZAR NA FORCA");
            palavras.Add(Console.ReadLine());
            
        }
        public static void OP2()
        {
            Console.WriteLine("digite uma letra");
            string letra = Console.ReadLine();
            for (int i = 0; i < QUANT; i++)
            {
                for (int j = 0; j < palavras.Count; j++)
                    letras.Add(palavras[j].Substring(i, 1));
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
        

         static void Main(string[] args)
         {
            bool m = true;
            
            while (m) {
                MENU();
                switch (menu)
                {
                    case 1: OP1();
                            break;
                        
                    case 2: OP2();
                            break;
                        
                    //case 3 OP3();
                    //    break;
                    //case 4: OP4();
                    //    break;
                    case 9: return;


                }
                    }

         }
        }
    }

