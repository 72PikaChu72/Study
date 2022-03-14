using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp70
{
    class Product
    {
        public string name,opisanie;
        public string date;
        public int cena,skidka;
        public int age()
        {
            int Year = Convert.ToInt32(DateTime.Today.Year);
            int Month = Convert.ToInt32(DateTime.Today.Month);
            int Day = Convert.ToInt32(DateTime.Today.Day);

            int MyYear = Convert.ToInt32(Convert.ToString(date[6] + "" + date[7] + "" + date[8] + "" + date[9]));
            int MyMonth = Convert.ToInt32(Convert.ToString(date[3] + "" + date[4]));
            int MyDay = Convert.ToInt32(Convert.ToString(date[0] + "" + date[1]));

            int age = Month - MyMonth;

            if (MyDay > Day)
            {
                age -= 1;
            }
            
            return age;
        }
        public string Show()
        {
            return $"{name} {opisanie}\n{date}\n{cena} {skidka}"
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
                Console.WriteLine("1-Создать новый продукт\n2-Показать продукт по id\n3-\n4-\n5-\n6-");  
                int ask = Convert.ToInt32(Console.ReadLine());

                switch (ask)
                {
                    case 1:
                        {
                            Console.Clear();

                            Product product = new Product();
                            Console.WriteLine("Введите имя продукта");
                            product.name = Console.ReadLine();
                            Console.WriteLine("Введите описание продукта");
                            product.opisanie = Console.ReadLine();

                            Console.WriteLine("Введите дату рождения продукта :)");
                            product.date = Console.ReadLine();

                            Console.WriteLine("Введите цену продукта");
                            product.cena = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("Введите скидку студента");
                            product.skidka = Convert.ToInt32(Console.ReadLine());
                            product.id = id;
                            id++;
                            list.Add(product);
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine(Show());
                            
                        }
                   
                }

            }
        }
    }
}
