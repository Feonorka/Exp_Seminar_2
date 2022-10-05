// Задача 22: Напишите программу, которая
// принимает на вход число (N) и выдаёт таблицу
// квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

Console.WriteLine("Введите число:");
int num = Convert.ToInt32(Console.ReadLine());

// Метод, который возводит в квадрат
int Deegri(int iskomoe)
{
    int res = 0;
    res = iskomoe * iskomoe;
    return res;
}

// Метод, который ставит нужное количество пробелов
string Probel(int num)
{
string result = String.Empty;
for (int i = 1; i <= num; i++)
    {
        result += " ";
    }
return result;
}

// Метод, который определяет сколько цифр в числе
int KolNumber(int numA)
{
    int res = 0;
    while (numA != 0)
    {
        res++;
        numA = numA / 10;
    }
return res;
}

// Метод, который производит вывод
void SuperM(int numM)
{
    int i = 1;
    int itog = Deegri(numM);
    int kolvoOut = KolNumber(itog);
    while (i <= numM)
    {
        int resultOfdeegre = Deegri(i);                 // Происходит возведение в степень
        int kolvoIn = KolNumber(resultOfdeegre);        // У числа происходит подсчет цифр в числе
        int nuMpro = kolvoOut - kolvoIn;
        string probelStr = Probel(nuMpro);            // Пропечатывается нужное количество пробелов

        Console.Write($"{resultOfdeegre}{probelStr}-");
        Console.WriteLine($"{i}");
        i++;
    }
}
SuperM(num);
