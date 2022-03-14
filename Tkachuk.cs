using System;
using System.Collections.Generic;
namespace _15._11._2021_Списки
{
    class Program
    
    {

        static void Main(string[] args)       
        {
            List<int> a = new List<int> { 5, 1, 6, 8, 3, 0, 12, 25, 10 };
            a.Add(7);
            a.Add(2);
            a.Add(16);
            a.Remove(25);
            var x = a[0];
            var b = a;
            var min = b[0];
            for (int i = 1; i < b.Count; i++)
            {
                if (b[i] <= min)
                {
                    min = b[i];
                }
            }
            Console.WriteLine($"Минимальное значение= {min} Находится под номером= {b.IndexOf(min) + 1}");


            for (int i = 0; i < a.Count; i++) //Удаляет все нечетные значения
            {
                if (a[i] % 2 != 0)
                {
                    a.RemoveAt(i);
                    i--;
                }
            }




            //for (int i = 0; i < a.Count; i++) Console.WriteLine(a[i]); //Выводит все значения в списке

            List<string> l = new List<string> { "asd", "oasdo","олды","opopop","why","lol","zaz"};
            for (int i = 0;i<l.Count; i++)
            {
                if (Convert.ToChar(l[i][0]) == 'o'|| Convert.ToChar(l[i][0]) == 'о')
                    Console.WriteLine(l[i]);
            }
            Console.ReadKey();
        }
    }
}
