using System;

namespace Palíndromo_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {

                Console.WriteLine("Digite:");
                string palavra = Console.ReadLine();
                string result = string.Empty;
                int tamanhoPalavra = palavra.Length - 1;

                for (int i = 0; i < palavra.Length; i++)
                {
                    result += palavra[tamanhoPalavra - i].ToString();
                }

                if (palavra == result)
                    Console.WriteLine("É palindromo");
                else
                    Console.WriteLine("Não é palindromo");
           
        }
      
       
    }
}
