using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pikapika.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            //{
            //    string x = Console.ReadLine();
            //    x = x.Replace(" ", "");
            //    Console.WriteLine(x);
            //}
            //}
            //{/*int bin = Convert.ToInt32(Console.ReadLine());
            // double x = 0;
            // int i=0;
            // while (bin != 0)
            // {
            //     i++;
            //     int a;
            //     a = bin % 10;
            //     if (a == 1)
            //     {
            //         x = x + Math.Pow(2, i);
            //         bin = bin / 10;

            //     }
            //     else if (a == 0) 
            //     {
            //         bin = bin / 10;


            //     }
            //     else
            //     {
            //         Console.WriteLine("error");
            //         Console.ReadKey();
            //         return;
            //     }
            //     {




            //     }
            // }

            //  Console.WriteLine(x/2);


            //     //double x = Convert.ToDouble(Console.ReadLine());
            //     //double i = 1.2;
            //     //double s = 0;
            //     //while (i < 2)
            //     //{

            //     //    s = i * x;
            //     //    Console.WriteLine($"цена за {i} кг = {s}");
            //     //    i = i + 0.1;
            //     //}
            //     //Console.ReadKey();

            //     {
            //         /* Console.BackgroundColor = ConsoleColor.Black;
            //          Console.ForegroundColor = ConsoleColor.Magenta;
            //          int A = Convert.ToInt32(Console.ReadLine());
            //          int B = Convert.ToInt32(Console.ReadLine());
            //          int C = 0;
            //          int D = A;
            //          while (A <= B)
            //          {

            //              C = C + D;
            //              D++;
            //              A++;

            //          }
            //          Console.WriteLine(C);
            //          Console.ReadKey();*/


            //         {
            //             /*Console.BackgroundColor = ConsoleColor.Black;
            //             Console.ForegroundColor = ConsoleColor.Magenta;
            //             int A = Convert.ToInt32(Console.ReadLine());
            //             int B = Convert.ToInt32(Console.ReadLine());
            //             int C = 1;
            //             int D = A;
            //             while (A <= B)
            //             {

            //                 C = C * D;
            //                 D++;
            //                 A++;

            //             }
            //             Console.WriteLine(C);
            //             Console.ReadKey();*/
            //             {
            //                 /*Console.BackgroundColor = ConsoleColor.Black;
            //                 Console.ForegroundColor = ConsoleColor.Magenta;
            //                 double A = Convert.ToDouble(Console.ReadLine());
            //                 double B = Convert.ToDouble(Console.ReadLine());
            //                 double C = 1;
            //                 double D = A;
            //                 while (D <= B)
            //                 {

            //                     C = C + Math.Pow(D, 2);
            //                     D++;



            //                 }
            //                 Console.WriteLine(C-1);
            //                 Console.ReadKey();*/

            //                 {

            //                     /*double N = Convert.ToDouble(Console.ReadLine());
            //                     double i = 0;
            //                     double ent;
            //                     double sum = 0;
            //                     while (i <= N)
            //                     {
            //                         i++;
            //                         ent = 1 / i;
            //                         sum = ent + sum;
            //                         Console.WriteLine(sum);
            //                     }*/

            //                 }
            //                 /*{
            //         int x = 546;
            //         int a = x / 100;
            //         int b = x % 100 / 10;
            //         int c = x % 10;

            //         Console.WriteLine((b * 100) + (a * 10) + (c));
            //         Console.ReadKey();
            //     }*/
            /*{
                //Даны 2 скорости, одна в км/ч, одна в м/с, сравнить какая из них больше
                try
                {
                    Console.WriteLine("Скорость x (Км/ч)");
                    double x = Convert.ToDouble(Console.ReadLine()) + 0.0;
                    Console.WriteLine("Скорость y (м/с)");
                    double y = Convert.ToDouble(Console.ReadLine()) + 0.0;
                    if (x / 3.6 == y)
                    {
                        Console.WriteLine(x + "км/ч" + " = " + y + "м/с");
                    }
                    else if (x / 3.6 < y)
                    {
                        Console.WriteLine(x + "км/ч" + " < " + y + "м/с");
                    }
                    else if (x / 3.6 < y)
                    {
                        Console.WriteLine(x + "км/ч" + " > " + y + "м/с");
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                }
                catch (System.FormatException)
                {
                        Console.WriteLine("error");
                }
            }*/
            //                 /* {
            //                      int x = Convert.ToInt32(Console.ReadLine());
            //                      int a = x / 100;
            //                      int b = x % 100 / 10;
            //                      int c = x % 10;

            //                      Console.WriteLine((b * 100) + (a * 10) + (c));
            //                      Console.ReadKey();
            //                  }*/
            //                 /*{
            //                     int x = 456;
            //                     int a = x / 100;
            //                     int b = x % 100 / 10;
            //                     int c = x % 10;

            //                     Console.WriteLine((a * 100) + (c * 10) + (b));
            //                     Console.ReadKey();
            //                 }*/
            //                 /*{
            //                     int a = Convert.ToInt32(Console.ReadLine());
            //                     int b = Convert.ToInt32(Console.ReadLine());
            //                     if (a == b) Console.WriteLine("Числа равны");
            //                     else if (a > b) Console.WriteLine(a + " больше " + b);
            //                     else if (a < b) Console.WriteLine(a + " меньше " + b);
            //                     Console.ReadKey();
            //                 }*/
            //                 /*{
            //                     int a = Convert.ToInt32(Console.ReadLine());
            //                     int b = Convert.ToInt32(Console.ReadLine());
            //                     if (a == b) Console.WriteLine("Числа равны");
            //                     else if (a > b) Console.WriteLine(a + " наибольшее " + " \n" + b + " наименьшее ");
            //                     else if (a < b) Console.WriteLine(b + " наибольшее " + " \n" + a + " наименьшее ");
            //                     Console.ReadKey();
            //                 }*/
            //                 /*{
            //                     Console.WriteLine(" введите " + " километры ");
            //                     double a = Convert.ToDouble(Console.ReadLine());
            //                     Console.WriteLine("введите футы");
            //                     double b = Convert.ToDouble(Console.ReadLine());
            //                     if ((a * 1000) == (b * 0.305))
            //                     {
            //                         Console.WriteLine(a + " км равно " + b + " фут");
            //                     }
            //                     else if ((a * 1000) > (b * 0.305))
            //                     {
            //                         Console.WriteLine(a + " км больше " + b + " фут");
            //                     }

            //                     else if ((a * 1000) < (b * 0.305))
            //                     {

            //                         Console.WriteLine(a + " км меньше " + b + " фут");
            //                     }
            //                 }*/


            //                 /*{

            //                     Console.WriteLine("километры в час");
            //                     double a = Convert.ToDouble(Console.ReadLine());
            //                     Console.WriteLine("метры в секунду");
            //                     double b = Convert.ToDouble(Console.ReadLine());
            //                     if ((a) == (b * 3600))
            //                     {

            //                         Console.WriteLine(a + " км/ч равно " + b + " м/с");



            //                     }

            //                     else if ((a) > (b * 3600))

            //                     {
            //                         Console.WriteLine(a + " км/ч больше " + b + " м/с");



            //                     }

            //                     else if ((a) < (b * 3600))
            //                     {


            //                         Console.WriteLine(a + " км/ч меньше " + b + " м/с");



            //                     }*/
            //                 /*{
            //                     int x = 546;

            //                     int a = x % 10;
            //                     int b = x % 100 / 10;
            //                     int c = x / 100;
            //                     Console.WriteLine(b*100+a*10+c);








            //                 }*/
            //                 {
            //                     /*//25.10.21
            //                     int i = 0;
            //                     string z = Console.ReadLine();
            //                     int f = z.Length;            
            //                     char[] a = new char[f];
            //                     a = z.ToCharArray();
            //                     foreach  (char item in a) 
            //                     {
            //                         if (item == 'a')
            //                         i++; 
            //                     }
            //                     Console.WriteLine(i);*/
            //                     {
            //                         /*int i = 0;
            //                         string z = Console.ReadLine();
            //                         int f = z.Length;
            //                         char[] a = new char[f];
            //                         a = z.ToCharArray();
            //                         foreach (char item in a)
            //                         {

            //                             if (item == 'o')
            //                             {
            //                                 a[i]=' ';
            //                             }
            //                             i++;

            //                         }
            //                         for (int p = 0; p != f; p++)
            //                         {
            //                             if (a[p] != ' ')
            //                             {
            //                                 Console.Write(a[p]);
            //                             }
            //                         }*/
            //                         /* {
            //                              Console.WriteLine("Введите значения массива");
            //                              string z = Console.ReadLine();
            //                              int f = z.Length;
            //                              int[] a = new int[f];
            //                              int x = Convert.ToInt32(z);

            //                              while (x > 0)
            //                              {
            //                                  int k = 0;
            //                                  int l = x % 10;
            //                                  a[k] = l;
            //                                  x = x / 10;
            //                                  k++;

            //                              }

            //                              Console.WriteLine("Введите c");
            //                              int c = Convert.ToInt32(Console.ReadLine());
            //                              Console.WriteLine("Введите d");
            //                              int d = Convert.ToInt32(Console.ReadLine());
            //                              int i = 0;
            //                              int l = 0;
            //                              foreach (int item in a)
            //                              {


            //                                  if (a[i] == c)
            //                                  {
            //                                      foreach (int thing in a)
            //                                      {

            //                                          if (a[i] == d)
            //                                          {
            //                                              break;

            //                                          }
            //                                          l++;
            //                                      }
            //                                  }
            //                                  i++;


            //                              }*/
            //                         /*{

            //                             Console.WriteLine("Выберите номер задания (Введите 0 для списка заданий)");
            //                             int task = Convert.ToInt32(Console.ReadLine());
            //                             if (task == 0)
            //                             {
            //                                 Console.WriteLine("1.Удалить в трехзначном числе десятки.\n2.Определить число кратное 3 или 5\n3.Определить месяц по номеру\n4.Сумма/Произведение цифр четырехзначного числа\n5.Определяем високостный ли год");

            //                             }
            //                             else if (task == 1)
            //                             {
            //                                 Console.WriteLine("Понятия не имею что вы имели ввиду под этим заданием, поэтому я пока его пропустил");



            //                             }
            //                             else if (task == 2)
            //                             {
            //                                 Console.WriteLine("Определить число кратное 3 или 5");
            //                                 Console.WriteLine("Введите любое число");
            //                                 int x = Convert.ToInt32(Console.ReadLine());
            //                                 if ((x % 3) == 0 && (x % 5) == 0)
            //                                 {
            //                                     Console.WriteLine("Число кратно и 5, и 3");
            //                                 }
            //                                 else if ((x % 5) == 0)
            //                                 {
            //                                     Console.WriteLine("Число кратно 5");
            //                                 }
            //                                 else if ((x % 3) == 0)
            //                                 {
            //                                     Console.WriteLine("Число кратно 3");
            //                                 }
            //                                 else
            //                                 {
            //                                     Console.WriteLine("Число не кратно ни 5, ни 3");
            //                                 }

            //                             }
            //                             else if (task == 3)
            //                             {
            //                                 Console.WriteLine("Определить месяц по номеру");
            //                                 Console.WriteLine("Введите номер месяца");
            //                                 int x = Convert.ToInt32(Console.ReadLine());
            //                                 if (x == 1)
            //                                 {
            //                                     Console.WriteLine("Январь");
            //                                 }
            //                                 else if (x == 2)
            //                                 {
            //                                     Console.WriteLine("Февраль");
            //                                 }
            //                                 else if (x == 3)
            //                                 {
            //                                     Console.WriteLine("Март");
            //                                 }
            //                                 else if (x == 4)
            //                                 {
            //                                     Console.WriteLine("Апрель");
            //                                 }
            //                                 else if (x == 5)
            //                                 {
            //                                     Console.WriteLine("Май");
            //                                 }
            //                                 else if (x == 6)
            //                                 {
            //                                     Console.WriteLine("Июнь");
            //                                 }
            //                                 else if (x == 7)
            //                                 {
            //                                     Console.WriteLine("Июль");
            //                                 }
            //                                 else if (x == 8)
            //                                 {
            //                                     Console.WriteLine("Август");
            //                                 }
            //                                 else if (x == 9)
            //                                 {
            //                                     Console.WriteLine("Сентябрь");
            //                                 }
            //                                 else if (x == 10)
            //                                 {
            //                                     Console.WriteLine("Октябрь");
            //                                 }
            //                                 else if (x == 11)
            //                                 {
            //                                     Console.WriteLine("Ноябрь");
            //                                 }
            //                                 else if (x == 12)
            //                                 {
            //                                     Console.WriteLine("Декабрь");
            //                                 }
            //                                 else if (x <= 0 || x >= 13)
            //                                 {
            //                                     Console.WriteLine("error");
            //                                 }
            //                             }
            //                             else if (task == 4)
            //                             {
            //                                 Console.WriteLine("Проверить четырехзначное число на четность и найти сумму его цифр, если число четное, или произведение его цифр, если число нечетное");
            //                                 Console.WriteLine("Введите любое 4х значное число");
            //                                 int x = Convert.ToInt32(Console.ReadLine());
            //                                 int a = x / 1000;
            //                                 int b = x % 1000 / 100;
            //                                 int c = x % 100 / 10;
            //                                 int d = x % 10;
            //                                 if (x % 2 == 0)
            //                                 {
            //                                     Console.WriteLine("Число четное, ищем сумму цифер");
            //                                     Console.WriteLine(a + b + c + d);
            //                                 }
            //                                 else
            //                                 {
            //                                     Console.WriteLine("Число нечетное, ищем произведение его чисел");
            //                                     Console.WriteLine(a * b * c * d);
            //                                 }
            //                             }
            //                             else if (task == 5)
            //                             {
            //                                 Console.WriteLine("Определяем високосный ли год");
            //                                 Console.WriteLine("Введите год");
            //                                 int x = Convert.ToInt32(Console.ReadLine());
            //                                 if (x % 400 == 0 && x % 100 == 0) Console.WriteLine("Год високосный");
            //                                 else if (x % 4 == 0 && x % 100 != 0) Console.WriteLine("Год високосный");
            //                                 else Console.WriteLine("Год не високосный");
            //                             }
            //                             Console.WriteLine("0 для выхода\n1 Для выбора программы снова");
            //                             int e = Convert.ToInt32(Console.ReadLine());
            //                             else;
            //                         }*/



            //                     }
            //                 }
            //             }
            //         }
            //     }*/
            {
                /*{
                    //Вывести числа от A до B, каждое число выводится количество раз, равное порядку числа
                    int a = int.Parse(Console.ReadLine());
                    int b = int.Parse(Console.ReadLine());
                    Console.WriteLine();

                    for (int i = a; i > 0; i--)

                        Console.Write("{0}", a);

                    while (a < b)
                    {
                        a += 1;
                        Console.WriteLine();

                        for (int i = a; i > 0; i--)

                            Console.Write("{0}", a);
                    }
                }*/
                /*{
                    //Вывести числа от A до B, каждое число выводится количество раз, равное его значению
                    int a = int.Parse(Console.ReadLine());
                    int b = int.Parse(Console.ReadLine());
                    Console.WriteLine();

                    for (int i = 1; i <= a; i++)

                        Console.Write("{0}", a);

                    while (a < b)
                    {
                        a += 1;
                        Console.WriteLine();

                        for (int i = 1; i <= a; i++)

                            Console.Write("{0}", a);
                    }
                }*/
            }            
            Console.WriteLine("\nend.");
            Console.ReadKey(); 
           
        }
    }
}