// ConsoleApplication1.cpp : Этот файл содержит функцию "main". Здесь начинается и заканчивается выполнение программы.
//

#include <iostream>

int main()
{
#include <iostream>

    using namespace std;
    int main();
    {
        setlocale(0, "rus");
        cout.setf(ios::boolalpha);
        
        /*{
            int a;
            cout << endl << "Введите A" << endl; cin >> a;
            int b;
            cout << endl << "Введите B" << endl; cin >> b;
            int c;
            cout << endl << "Введите C" << endl; cin >> c;
            bool x;
            x = a > b && b > c || a < b&& b < c;
            cout << endl << x;
        }*/
        /*{
            int a;
            cout << endl << "Введите A" << endl; cin >> a;
            int b;
            cout << endl << "Введите B" << endl; cin >> b;
            bool sea = a % 2 == b % 2;
            cout << endl << sea;
        }*/
        //if-else
        /*{
            int a;
            cout << endl << "Введите A" << endl; cin >> a;
            int b;
            cout << endl << "Введите B" << endl; cin >> b;
            int c;
            cout << endl << "Введите C" << endl; cin >> c;
            int x;
            if (a > b)
            {
                a = b;
            }
            else if (a > c) {
                a = c;
            }
            if (a > b)
            {
                a = b;
            }
            else if (a > c) {
                a = c;
            }
            cout << endl << a;
        }*/


        {
            int month;
            cout << "Введите число месяца: "; cin >> month;
            switch (month)
            {
            case 1:
                cout << "\nЯнварь";
                break;
            case 2:
                cout << "\nФевраль";
                break;
            case 3:
                cout << "\nМарт";
                break;
            case 4:
                cout << "\nАрель";
                break;
            case 5:
                cout << "\nМай";
                break;
            case 6:
                cout << "\nИюнь";
                break;
            case 7:
                cout << "\nИюль";
                break;
            case 8:
                cout << "\nАвгуст";
                break;
            case 9:
                cout << "\nСентябрь";
                break;
            case 10:
                cout << "\nОктябрь";
                break;
            case 11:
                cout << "\nНоябрь";
                break;
            case 12:
                cout << "\nДекабрь";
                break;
            default:
                cout << "\n Error.\n";
                break;
            }
        }



        //{
            /*int a;
            cout << endl << "Введите число: "; cin >> a;
            bool sea;
            sea = a > 0;
            cout << "Число положительное? : " << sea;
        }
        {
            int a;
            cout << endl << "Введите число: "; cin >> a;
            bool sea;
            sea = a % 2 == 1;
            cout << endl << "Число нечетное? : " << sea;

            {
                int a = 3;
                if (a > 0) {
                    cout << "Число положительное";
                }
                else if (a == 0) {
                    cout << "Число равно нулю";
                }
                else {
                    cout << "Число отрицательное";
                }

                int one, two;
                cout << endl << "Введите первое число: "; cin >> one;
                cout << endl << "Введите второе число: "; cin >> two;
                if (one > two) {
                    cout << endl << "Наибольшее число: " << one;
                }
                else {
                    cout << "Наибольшее число: " << two;
                }

                float a, b;
                cout << endl << "Введите первое число: "; cin >> a;
                cout << endl << "Введите первое число: "; cin >> b;
                if (a > b) {
                    swap(a, b);
                    cout << endl << "A= " << a << "\nB= " << b;
                }

                int day;
                cout << "Введите день недели: "; cin >> day;
                switch (day)
                {
                case 1:
                    cout << "\nПонедельник";
                    break;
                case 2:
                    cout << "\nВторник";
                    break;
                case 3:
                    cout << "\nСреда";
                    break;
                case 4:
                    cout << "\nЧетверг";
                    break;
                case 5:
                    cout << "\nПятница";
                    break;
                case 6:
                    cout << "\nСуббота";
                    break;
                case 7:
                    cout << "\nВоскресенье";
                    break;
                default:
                    cout << "\n Error.\n";
                    break;
                }

                int a, b;
                cout << "Выберите единицу длины: \n1. Дециметр\n2. Километр\n3. Метр\n4. Миллиметр\n5. Сантиметр";
                cout << "\nВвод: "; cin >> a;
                cout << endl << "Введите длину отрезка: "; cin >> b;
                switch (a)
                {
                case 1:
                    cout << "Дециметров в метрах: " << b / 10;
                    break;
                case 2:
                    cout << "Километров в метрах: " << b * 1000;
                    break;
                case 3:
                    cout << "Метров в метрах: " << b;
                    break;
                case 4:
                    cout << "Миллиметров в метрах: " << b / 1000;
                    break;
                case 5:
                    cout << "Сантиметров в метрах: " << b / 100;
                    break;*/















    }
}

