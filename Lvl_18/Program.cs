//Задача 18: Напишите программу, которая по
//заданному номеру четверти, показывает диапазон
//возможных координат точек в этой четверти (x и y).

Console.WriteLine("Введите четверть");
string x = Console.ReadLine();

string FindRange(string num)
{
    if (num == "1") return "Диапазон x > 0 и y > 0";
    if (num == "2") return "Диапазон x < 0 и y > 0";
    if (num == "3") return "Диапазон x < 0 и y < 0";
    if (num == '4') return "Диапазон x > 0 и y < 0";
    return "Неправильное значение";
}

string res = FindRange(x);
Console.WriteLine(res);