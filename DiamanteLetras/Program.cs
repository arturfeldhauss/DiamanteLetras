using System;

namespace DiamanteLetras
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string alfabeto = "abcdefghijklmnopqrstuvwxyz";
            char[] alfabetochar = alfabeto.ToCharArray();
            char letra;
            int linhas = 0;

            Console.WriteLine("Digite uma letra do alfabeto!!!");
            letra = Convert.ToChar(Console.ReadLine());


            for (int i = 1; i < alfabetochar.Length; i++)
            {
                if (alfabetochar[i] == letra)
                {
                    linhas = i;
                }
            }

            for(int i = 0; i <= linhas - 1 /2; i++)
            {
                for (int j = 1; j <= linhas - i; j++)
                {
                    Console.Write(" ");
                }
                Console.Write(alfabetochar[i]);
                for (int j = 1; j <= 2 * i - 1;j++)
                {
                    Console.Write(" ");
                }
               
                if(i == 0)
                {
                    Console.WriteLine("");
                }
                else
                {
                    Console.Write(alfabetochar[i]);
                    Console.WriteLine("");
                }
            }
            //baixo
            
            for (int i = linhas - 2 / 2; i >= 0; i--)
            {
                for (int j = 1; j <= linhas - i; j++)
                {
                    Console.Write(" ");
                }
                Console.Write(alfabetochar[i]);
                for (int j = 1; j <= 2 * i - 1; j++)
                {
                    Console.Write(" ");
                }

                if (i == 0)
                {
                    Console.WriteLine("");
                }
                else
                {
                    Console.Write(alfabetochar[i]);
                    Console.WriteLine("");
                }
                

            }
            Console.ReadLine();
        } 
    }
}
