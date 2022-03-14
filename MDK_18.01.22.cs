using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp60
{
    class Student
    {
        public string name, surname;
        public string date;
        public int kurs;
        public string special;


        public string famaill()
        {
            if (name != null && surname != null) return Convert.ToString(name + " " + surname[0] + ".");
            else return null;
           
            
        }
        public string Age()
        {
            int day = Convert.ToInt32(Convert.ToString(date[0]) + Convert.ToString(date[1]));
            int month = Convert.ToInt32(Convert.ToString(date[3]) + Convert.ToString(date[4]));
            int year = Convert.ToInt32(Convert.ToString(date[6]) + Convert.ToString(date[7]) + Convert.ToString(date[8]) + Convert.ToString(date[9]));
            int Age_year;
            if (month > 1)
            {
                Age_year -= 1;
            }
            else if (month == 1)
            {
                if (day > 15)
                {
                    Age_year -= 1;
                }
            }
            Console.WriteLine(Age_year);
            return "Done";
        }

        public string full()
        { 
            return $"{name} {surname}\n {date} \n {kurs} \n {special}";
        }

        public string Create()
        {

            Console.WriteLine("Имя");
            this.name = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Фамилия");
            this.surname = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Д/Р");
            this.date = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Курс");
            this.kurs = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Специальность");
            this.special = Console.ReadLine();
            Console.Clear();
            return "Done";

        }
        public string Delete()
        {

            this.name = null;
            this.surname = null;
            this.date = null;
            this.kurs = 0;
            this.special = null;
            return "Done";

        }
    }
    
    class Program
    {
        
        
        static void Main(string[] args)
        {
            Student A = new Student();
            Student B = new Student();
            Student C = new Student();
            Student D = new Student();
            Student E = new Student();
            Student F = new Student();
            Student G = new Student();
            Student H = new Student();
            int i = 1;
            int last;
            while(true)
            {
                #region Ask
                Console.Clear();
                Console.WriteLine("1-Создать нового студента\n2-Вывести конкретного студента\n3-Вывести всех студентов\n4-Удалить студента из списка(beta)\n");
                int Ask = Convert.ToInt32(Console.ReadLine());

                #endregion
                if (Ask == 1)
                {
                    #region Creation
                    {
                        Console.Clear();
                        Console.WriteLine($"Создание студента {i}");
                        if (i == 1)
                        {
                            Console.WriteLine(A.Create());
                            i++;
                        }
                        else if (i == 2)
                        {
                            Console.WriteLine(B.Create());
                            i++;
                        }
                        else if (i == 3)
                        {
                            Console.WriteLine(C.Create());
                            i++;
                        }
                        else if (i == 4)
                        {
                            Console.WriteLine(D.Create());
                            i++;
                        }
                        else if (i == 5)
                        {
                            Console.WriteLine(E.Create());
                            i++;
                        }
                        else if (i == 6)
                        {
                            Console.WriteLine(F.Create());
                            i++;
                        }
                        else if (i == 7)
                        {
                            Console.WriteLine(G.Create());
                            i++;
                        }
                        else if (i == 8)
                        {
                            Console.WriteLine(H.Create());
                            i++;
                        }
                    }
                    #endregion
                }
                else if (Ask == 2)
                {
                    #region 1StudentVivod
                    Console.Clear();
                    Console.WriteLine("Введите номер студента");
                    int StNum = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();
                    if (StNum == 1)
                    {
                        Console.WriteLine(A.full());

                    }
                    else if (StNum == 2)
                    {
                        Console.WriteLine(B.full());

                    }
                    else if (StNum == 3)
                    {
                        Console.WriteLine(C.full());

                    }
                    else if (StNum == 4)
                    {
                        Console.WriteLine(D.full());

                    }
                    else if (StNum == 5)
                    {
                        Console.WriteLine(E.full());

                    }
                    else if (StNum == 6)
                    {
                        Console.WriteLine(F.full());

                    }
                    else if (StNum == 7)
                    {
                        Console.WriteLine(G.full());

                    }
                    else if (StNum == 8)
                    {
                        Console.WriteLine(H.full());
                    }
                    #endregion
                }
                else if (Ask == 3)
                {

                    #region AllStudents
                    int j = 1;
                    Console.Clear();
                    Console.WriteLine($"{j}. {A.famaill()}");
                    j++;
                    Console.WriteLine($"{j}. {B.famaill()}");
                    j++;
                    Console.WriteLine($"{j}. {C.famaill()}");
                    j++;
                    Console.WriteLine($"{j}. {D.famaill()}");
                    j++;
                    Console.WriteLine($"{j}. {E.famaill()}");
                    j++;
                    Console.WriteLine($"{j}. {F.famaill()}");
                    j++;
                    Console.WriteLine($"{j}. {G.famaill()}");
                    j++;
                    Console.WriteLine($"{j}. {H.famaill()}");
                    j = 1;


                    #endregion
                }
                else if (Ask == 4)
                {
                    #region Delete
                    Console.Clear();
                    Console.WriteLine("Введите номер студента");
                    int StNum = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();
                    if (StNum == 1)
                    {
                        A.Delete();
                    }
                    else if (StNum == 2)
                    {
                        B.Delete();

                    }
                    else if (StNum == 3)
                    {
                        C.Delete();

                    }
                    else if (StNum == 4)
                    {
                        D.Delete();

                    }
                    else if (StNum == 5)
                    {
                        E.Delete();

                    }
                    else if (StNum == 6)
                    {
                        F.Delete();

                    }
                    else if (StNum == 7)
                    {
                        G.Delete();

                    }
                    else if (StNum == 8)
                    {
                        H.Delete();
                    }
                    #endregion
                }
                else break;
                Console.WriteLine("Нажмите любую кнопку для продолжения");
                Console.ReadKey();
            }


            
        }
    }
}

