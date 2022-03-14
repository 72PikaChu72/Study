using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp70
{
    class Student
    {
        public string name, surname;
        public string date;
        public int kurs,id;
        public string special;
        public int age()
        {
            int Year = Convert.ToInt32(DateTime.Today.Year);
            int Month = Convert.ToInt32(DateTime.Today.Month);
            int Day = Convert.ToInt32(DateTime.Today.Day);

            int MyYear = Convert.ToInt32(Convert.ToString(date[6] + "" + date[7] + "" + date[8] + "" + date[9]));
            int MyMonth = Convert.ToInt32(Convert.ToString(date[3] + "" + date[4]));
            int MyDay = Convert.ToInt32(Convert.ToString(date[0] + "" + date[1]));

            int age = Year - MyYear;

            if (MyMonth > Month)
            {
                age -= 1;
            }
            else if (MyMonth == Month)
            {
                if (MyDay >= Day)
                {
                    age -= 1;
                }
            }
            return age;
        }
    }

    class Program
    {
        static List<Student> list = new List<Student>();
        static void Main(string[] args)
        {
            int id = 1;
            while (true)
            {
                Console.Clear();
                Console.WriteLine("1-Создать нового студента\n2-Вывести конкретного студента\n3-Вывести всех студентов\n4-Удалить студента из списка\n5-Вывести всех студентов старше 20\n6-Вывести всех студентов с фамилией на букву А");
                Console.WriteLine("7-Изменить студента");
                int ask = Convert.ToInt32(Console.ReadLine());
                
                switch (ask)
                {
                    case 1:
                        {
                            Console.Clear();
                            
                            Student student = new Student();
                            Console.WriteLine("Введите имя студента");
                            student.name = Console.ReadLine();
                            
                            Console.WriteLine("Введите фамилию студента");
                            student.surname = Console.ReadLine();
                            
                            Console.WriteLine("Введите дату рождения студента");
                            student.date = Console.ReadLine();
                            
                            Console.WriteLine("Введите специальность студента");
                            student.special = Console.ReadLine();
                           
                            Console.WriteLine("Введите курс студента");
                            student.kurs = Convert.ToInt32(Console.ReadLine());
                            student.id = id;
                            id++;
                            list.Add(student);
                            break;
                        }
                    case 2:
                        {
                            Console.Clear();
                            Console.WriteLine("Введите id студента");
                            int waitid = (Convert.ToInt32(Console.ReadLine()))-1;
                            if (waitid < id && id != 1)
                            {
                                Console.Clear();
                                Console.WriteLine($"{list[waitid].id}. {list[waitid].name} {list[waitid].surname}\n{list[waitid].date}\n{list[waitid].kurs} курс {list[waitid].special}\nНажмите любую кнопку для продолжения");
                            }
                            else Console.WriteLine("error\nНажмите любую кнопку для продолжения");
                            Console.ReadKey();
                            break;
                        }
                    case 3:
                        {
                            Console.Clear();
                            foreach(var a in list)
                            {  
                                Console.WriteLine($"{a.id}. {a.surname} {a.name[0]}.");
                            }
                            Console.WriteLine("Нажмите любую кнопку");
                            Console.ReadKey();
                            break;
                        }
                    case 4:
                        {
                            Console.Clear();
                            Console.WriteLine("Введите id студента");
                            int waitid = Convert.ToInt32(Console.ReadLine());
                            foreach(var a in list)
                            {
                                if (waitid == a.id)
                                {
                                    list.Remove(a);
                                    Console.Clear();
                                    Console.WriteLine("Done!\nНажмите любую кнопку для продолжения");
                                    Console.ReadKey();
                                    break;
                                }
                            }
                            break;
                        }
                    case 5:
                        {
                            Console.Clear();
                            foreach(var a in list)
                            {
                                
                                if (a.age() >= 20)
                                {
                                    Console.WriteLine($"{a.id}. {a.name} {a.surname}\nВозраст: {a.age()}");
                                }
                                
                            }
                            Console.WriteLine("Нажмите любую кнопку для продолжения");
                            Console.ReadKey();
                            break; 
                        }
                    case 6:
                        {
                            foreach(var a in list)
                            {
                                if(a.surname[0]=='A'|| a.surname[0] == 'a')
                                {
                                    Console.WriteLine($"{a.id}. {a.name} {a.surname}");
                                }
                            }
                            break;
                        }
                    case 7:
                        {
                            Console.Clear();
                            Console.WriteLine("Введите id студента");
                            int waitid = Convert.ToInt32(Console.ReadLine());
                            foreach(var a in list)
                            {
                                if (a.id == waitid)
                                {
                                    Console.Clear();
                                    Console.WriteLine("1.Изменить Имя\n2.Изменить фамилию\n3.Изменить дату рождения\n4.Изменить курс\n5.Изменить специальность");
                                    int ask1 = Convert.ToInt32(Console.ReadLine());
                                    switch(ask1)
                                    {
                                        case 1:
                                            {
                                                Console.WriteLine("Введите имя");
                                                a.name = Console.ReadLine();
                                                break;
                                            }
                                        case 2:
                                            {
                                                Console.WriteLine("Введите фамилию");
                                                a.surname = Console.ReadLine();
                                                break;
                                            }
                                        case 3:
                                            {
                                                Console.WriteLine("Введите дату рождения");
                                                a.date = Console.ReadLine();
                                                break;
                                            }
                                        case 4:
                                            {
                                                Console.WriteLine("Введите курс");
                                                a.kurs = Convert.ToInt32(Console.ReadLine());
                                                break;
                                            }
                                        case 5:
                                            {
                                                Console.WriteLine("Введите специальность");
                                                a.special = Console.ReadLine();
                                                break;
                                            }
                                    }
                                    
                                }
                            }
                            break;
                        }
                    case 8:
                        {
                            Console.WriteLine("Введите фамилию")
                                string fam = Console.
                            break;
                        }
                }
                
            }
        }
    }
}
