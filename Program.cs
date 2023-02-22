using System;

namespace csharp_learning
{
    class Program
    {
        public static void Main(string[] args)
        {
            int idade = int.Parse(Console.ReadLine());

            if (idade >= 18)
            {
                Console.WriteLine("Adulto");
            } 
            else if (idade < 18 && idade >= 12) 
            {
                Console.WriteLine("Adolescente");
            }
             else 
            {
                Console.WriteLine("Criança");
            }
            /*
            C# é uma cópia de Java hahah
            A única coisa que mudaram foi a indentação das chaves,
            sendo que posso organizá-las da mesma forma que em Java.
            Mas vou usar conforme a linguagem pede para diferenciar uma da outra.
            */
        }
    }
}
