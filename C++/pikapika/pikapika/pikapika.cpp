#include <iostream>
using namespace std;

int main()
{

    setlocale(0, "rus");
    //Задание 1,2
    int a;
    cout << "Введите сторону квадрата"; cout << endl; cin >> a;
    cout << endl << "P= ";
    cout << a * 4;
    cout << endl << "S= ";
    cout << a * a;


    //Задание 3
    int A, B, C;
    cout << "Введите А" << endl; cin >> A;
    cout << endl << "Введите B" << endl; cin >> B;
    C = A;
    A = B;
    B = C;
    cout << "A= " << A << " B= " << B;

    //Задание 4
    int L;
    cout << "Введите в см " << endl; cin >> L;
    cout << endl << "В метрах= "; cout << L / 100;

    //Задание 5
    int A;
    cout << "Введите двузначное число " << endl; cin >> A;
    cout << endl; cout << A / 10; cout << endl; cout << A % 10;
}