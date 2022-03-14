using System;

namespace ConsoleApp44
{
    public abstract class Cman
    {
        private string name, sex;
        private int age, weight, height;
        static int male = 0, female = 0;
        public string namecheck
        {
            get { return name; }
            set
            {
                if (value.Length > 2)
                {
                    name = value;
                }
                else
                {
                    Console.WriteLine("error");
                }
            }

        }
        public string sexcheck
        {
            get { return sex; }
            set
            {
                if (value == "male" || value == "female")
                {
                    if (value == "male")
                    {
                        male++;
                    }
                    else if (value == "female")
                    {
                        female++;
                    }
                    sex = value;
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
        }
        public int agecheck
        {
            get { return age; }
            set
            {
                if (value > 0 && value < 150)
                {
                    age = value;
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
        }
        public int weightcheck
        {
            get { return weight; }
            set
            {
                if (value > 0)
                {
                    weight = value;
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
        }
        public int heightcheck
        {
            get { return height; }
            set
            {
                if (value > 0 && value < 300)
                {
                    height = value;
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
        }
        public string info()
        {

            return Convert.ToString(name + "\n" + sex + "\n" + age + "\n" + weight + "\n" + height);
        }
        public double coef()
        {
            return weight / (height - 100);
        }
        public void cngweigh(int a)
        {

            weight = Convert.ToInt32(a);

        }
        public void cngweigh(int a, int b)
        {
            weight = a;
            height = b;
        }
        public void cngage(int a)
        {
            age += a;
        }
        public void cngage()
        {
            age++;
        }

        public static int operator +(Cman weight, int a)
        {
            return weight.weight + a;
        }
        public static int operator -(Cman weight, int a)
        {
            return weight.weight + a;
        }
        public static bool operator <(Cman age1, Cman age2)
        {
            return age1.age > age2.age;
        }
        public static bool operator >(Cman age1, Cman age2)
        {
            return age1.age > age2.age;
        }
        public abstract string InfoNew();
        public abstract bool CheckInfoNew(string a);


    }
    public class TStudent : Cman
    {
        private bool infonew = false;
        private string VUZ;
        private int Curs,srok;
        private string spetiality;
        
        public string VUZcheck
        {
            get { return VUZ; }
            set { VUZ = value; }
        }
        public int CURScheck
        {
            get { return Curs; }
            set { Curs = value; }
        }
        public string spetialitycheck
        {
            get { return spetiality; }
            set { spetiality = value; }
        }
        public int srokcheck
        {
            get { return srok; }
            set { srok = value; }
        }
        public static bool operator <(TStudent curs, TStudent curs2)
        {
            return curs.Curs < curs2.Curs;
        }
        public static bool operator >(TStudent curs, TStudent curs2)
        {
            return curs.Curs > curs2.Curs;
        }
        public static bool operator == (TStudent curs, TStudent curs2)
        {
            return curs.Curs == curs2.Curs;
        }
        public static bool operator !=(TStudent curs, TStudent curs2)
        {
            return curs.Curs != curs2.Curs;
        }
        public int Konez()
        {  
            return agecheck + srok;
        }
        public override string InfoNew()
        {
            return VUZcheck + " " + CURScheck + " " + spetialitycheck + " " + srokcheck + " " + agecheck + " " + sexcheck;
        }
        public override bool CheckInfoNew(string a)
        {
            bool ppp = a == "y";
            return ppp;
        }
    }
        class Program
        {
            static void Main(string[] args)
            {
             TStudent Vlad = new TStudent();
             Vlad.agecheck = 18;
             Vlad.weightcheck = 11;
             Vlad.namecheck = "Vlad";
             Vlad.VUZcheck = "KCPT";
             Vlad.sexcheck = "Male";
             
             Console.WriteLine("Студент= " + Vlad.CheckInfoNew("y"));
             Console.WriteLine(Vlad.InfoNew());
             Console.ReadKey();
            }
        }
    
}
