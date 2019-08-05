using System;
using System.Collections.Generic;
namespace ConsoleApp147
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            for(int i = 10; i > -1; i--)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Vamos lá chaqualhar");
            for(int i = 0; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
            List<int> VALOR = new List<int>();
            VALOR.Add(15);
            VALOR.Add(30);
            VALOR.Add(45);
            VALOR.Add(60);
            
            foreach(int obj in VALOR )
            {
                Console.WriteLine(obj);
            }
        }
    }
}
