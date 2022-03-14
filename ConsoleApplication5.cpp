using namespace std;
int main()
{
    setlocale(0, "rus");
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