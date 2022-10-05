//Задача 17. Напишите программу
// 1. Принимает на вход координаты точки (X и Y)
// 2. Причём X ≠ 0 и Y ≠ 0
// 3. Выдаёт номер четверти плоскости, в которой находится эта точка.

Console.WriteLine("Введите координаты точки");
Console.Write("X: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты точки");
Console.Write("Y: ");
int y = Convert.ToInt32(Console.ReadLine());

int qwoter = Chetverti(x,y);
string result = qwoter > 0 ? $"Указанные координаты соответствтуют -> {qwoter.ToString()} четверти" : "Введены некорректные координаты";
Console.WriteLine(result);


int Chetverti(int a, int b)
{
    if (x > 0 && y > 0) return 1;
    if (x < 0 && y > 0) return 2;
    if (x < 0 && y < 0) return 3;
    if (x > 0 && y < 0) return 4;
    return 0;
}