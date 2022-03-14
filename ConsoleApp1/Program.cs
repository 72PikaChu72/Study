using System;

namespace ConsoleApp1
{
    class Program
    {

        static int fact(int n)
        {
            
            if (n == 0 || n == 1) return n;
            return fact(n - 1) + fact(n - 2);                                                                                                  
        }
        static void Main(string[] args)

        {
            int n = Convert.ToInt32(Console.ReadLine());
            n = n-1 ;
            Console.WriteLine(fact(n));
            
            
        }
    }
}
