
Console.WriteLine("Введите число:");
int num = Convert.ToInt32(Console.ReadLine());

// Метод, который возводит в куб
int Cub(int iskomoe)
{
    int res = 0;
    res = iskomoe * iskomoe* iskomoe;
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
    if (numM > 0 )
    {
    int i = 1;
    int itog = Cub(numM);
    int kolvoOut = KolNumber(itog);
    while (i <= numM)
    {
        int resultOfdeegre = Cub(i);                 // Происходит возведение в степень
        int kolvoIn = KolNumber(resultOfdeegre);        // У числа происходит подсчет цифр в числе
        int nuMpro = kolvoOut - kolvoIn;
        string probelStr = Probel(nuMpro);            // Пропечатывается нужное количество пробелов

        Console.Write($"|{resultOfdeegre}{probelStr}|->");
        Console.WriteLine($"|{i,3}|");
        i++;
    }
    }
    else Console.WriteLine("Вы ввели отрицательное число");
}
SuperM(num);

