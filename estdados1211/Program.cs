using System;
using System.Collections.Generic;

namespace estdados1211
{
    public class Program
    {
        public struct dados
        {
            public static int pontuacao = 0;
            public static bool m = true; /*ativa o switch*/
            public static int menu = 0; /*variavel reponsavel pelo switcj*/
            public static List<int> QUANT = new List<int>(); /*quantidade de letras que tem na palavra*/
            public static List<string> palavras = new List<string>(); /*lista de palavras que foram usadas como palpite*/
        }
        public static void MENU()
        {
            //menu
            Console.WriteLine("digite 1 para inserir palavra");
            Console.WriteLine("digite 2 para jogar");
            Console.WriteLine("digite 3 para ver maior pontuação");
            Console.WriteLine("digite 4 para conhecer a desenvolvedora do jogo");
            Console.WriteLine("digite 9 para sair do jogo");
            dados.menu = int.Parse(Console.ReadLine());
            /*mostra o menu e pede o numero pra usar no switch e escolher a opção*/
        }
        public static void OP1()
        {
            Console.Clear();

            Console.WriteLine("DIGITE A PALAVRA PARA UTILIZAR NA FORCA");
            string cu = Console.ReadLine();
            dados.palavras.Add(cu);
            dados.QUANT.Add(cu.Length);
            /*pede a palavra a ser utilizada*/

        }
        public static void OP2()
        {
            List<string> letras = new List<string>();
            List<string> acertou = new List<string>();
            string letra = "";
            int vidas = 5;
            int numacer = 0;
            int jota = -1;
            Random r = new Random();
            int rand = r.Next(dados.palavras.Count);
            for (int i = 0; i < dados.QUANT[rand]; i++)
            {
                    letras.Add(dados.palavras[rand].Substring(i, 1));
            }
            /*adiciona as letras da palavra dentro de uma lista*/
            while (vidas > 0 && numacer != dados.palavras[rand].Length)
            {
                FORCA();
            
                foreach (string c in letras)
                {

                    if (letra != c && !acertou.Contains(c))
                    {
                    Console.Write(" ___ ");                    
                    }
                    /*se a letra palpite estiver errada ele coloca um espaço no lufgar*/
                    else if (letra == c)
                    {
                    Console.Write($" {c} ");
                        acertou.Add(c);
                        numacer++;
                    }
                    else if(acertou.Contains(c)) 
                    {
                        Console.Write($" {c} ");
                    }
                    /*se a letra palpite estiver certa ele coloca a letra no local*/
                }
                if(jota == numacer)
                {
                    Console.WriteLine("letra errada");
                    vidas--;
                }
                else
                {
                    jota = numacer;
                }
                Console.WriteLine($"você ainda tem {vidas} vidas restantes");
                if (numacer == dados.palavras[rand].Length)
                {
                    Console.WriteLine("parabens voce ganhou, pressione enter para continuar");
                }else if (vidas == 0)
                {
                    Console.WriteLine("sinto muito, voce perdeu, pressione enter para continuar");
                }
                else
                {
                    Console.WriteLine("digite uma letra");
                }
                letra = Console.ReadLine();
                Console.Clear();
                /*palpite*/
            }
            
            if (vidas > dados.pontuacao)
            {
                dados.pontuacao = vidas;
            }
            
        }
        public static void OP4()
        {
            Console.Clear();
            Console.WriteLine("Esse jogo foi desenvolvido por Aída, aluna do segundo módulo do curso técnico de informática do CEET Vasco Coutinho");
        }
        public static void OP3()
        {
            Console.WriteLine($"a maior pontuacao foi: {dados.pontuacao}");
        }
        public static void FORCA()
        {
            Console.WriteLine("_________");
            Console.WriteLine("|       |");
            Console.WriteLine("|");
            Console.WriteLine("|");
            Console.WriteLine("|");
            Console.WriteLine("|");
            //for (int i = 0; i < dados.QUANT; i++)
            //{
            //    Console.Write(" ___ ");
            //}
        }
        

         static void Main(string[] args)
         {
            
            
            while (dados.m) {
                MENU();
                switch (dados.menu)
                {
                    case 1: OP1();
                            break;
                        
                    case 2: OP2();
                            break;

                    case 3: OP3();
                            break;
                    case 4: OP4();
                           break;
                    case 9: return;


                }
                    }

         }
        }
    }

