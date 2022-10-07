
//Задача 20: Напишите программу, которая
// принимает на вход координаты двух точек и
// находит расстояние между ними в 2D
// пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

// double num = 3.09987565; // 3.09
// double numRound = Math.Round(num, 2, MidpointRounding.ToZero);

Console.WriteLine("Введите число 1:");
int numAx = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число 2:");
int numBx = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число 3:");
int numAy = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число 4:");
int numBy = Convert.ToInt32(Console.ReadLine());


double LineOut(int aX,int aY, int bX, int bY)
{
    double result = Math.Sqrt(((bX - aX)*(bX - aX)) + ((bY - aY)*(bY - aY)));
    double numRound = Math.Round(result, 2, MidpointRounding.ToZero);
    return numRound;
}
double res = LineOut(numAx, numBx, numAy, numBy);
Console.WriteLine(res);