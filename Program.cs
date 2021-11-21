using System;

namespace Tabuada
{
    class Program
    {
        static void Main(string[] args)
        {
            int c, n, tab; 
            c = 0;

            Console.Write("Digite um número : ");
            n = Convert.ToInt32(Console.ReadLine());

            while(c<=10)
            {
                tab = n * c;

                Console.WriteLine($"{n} X {c} = {tab}");

                c = c + 1;
            }
        }
    }
}
