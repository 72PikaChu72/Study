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
            int Age_year = 2022 - year;
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
            return Convert.ToString(Age_year);
        }
        public string full()
        {
            return $"{name} {surname}\n {date} \n {kurs} \n {special}";
        }
        public string Create()
        {
            Console.WriteLine("Имя");
            name = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Фамилия");
            this.surname = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Д/Р");
            this.date = Console.ReadLine();
            Console.Clear
    }
}