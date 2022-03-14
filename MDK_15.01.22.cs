









using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp60
{
    class Student
    {
        public string name,surname;
        public string date;
        public int kurs;
        public string special;
        public string famaill()
        {
            return Convert.ToString(name + " " + surname[0]+".");
        }
        public string Age()
        {
            int day = Convert.ToInt32(Convert.ToString(date[0]) + Convert.ToString(date[1]));
            int month = Convert.ToInt32(Convert.ToString(date[3]) + Convert.ToString(date[4]));
            int year = Convert.ToInt32(Convert.ToString(date[6]) + Convert.ToString(date[7]) + Convert.ToString(date[8]) + Convert.ToString(date[9]));
            int Age_year = 2022-year;
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
    }
    
    class Program
    {
        
        static void Main(string[] args)
        {
            Student A = new Student();
            A.name = "Vladislav";
            A.surname = "Tkachuk";
            A.date = "31.08.2003";
            A.kurs = 1;
            A.special = "ИСИП";
            Student B = new Student();
            B.name = "Czurp";
            B.surname = "Cyberplugg";
            B.date = "24.01.2002";
            B.kurs = 1;
            B.special = "ИСИП";
            Console.WriteLine(A.famaill());
            Console.WriteLine(A.Age());
            Console.WriteLine(B.famaill());
            Console.WriteLine(B.Age());
            Console.ReadKey();
        }
    }
}
