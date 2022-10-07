Console.WriteLine("Введите координаты для первой точки:");
Console.Write("X1: ");
int numAx = Convert.ToInt32(Console.ReadLine());
Console.Write("Y1: ");
int numAy = Convert.ToInt32(Console.ReadLine());
Console.Write("Z1: ");
int numAz = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты для второй точки:");
Console.Write("X2: ");
int numBx = Convert.ToInt32(Console.ReadLine());
Console.Write("Y2: ");
int numBy = Convert.ToInt32(Console.ReadLine());
Console.Write("Z2: ");
int numBz = Convert.ToInt32(Console.ReadLine());

double LineOut(int aX,int aY, int aZ, int bX, int bY, int bZ)
{
    double result = Math.Sqrt(((bX - aX)*(bX - aX)) + ((bY - aY)*(bY - aY))+((bZ - aZ)*(bZ - aZ)));
    double numRound = Math.Round(result, 2, MidpointRounding.ToZero);
    return numRound;
}
double res = LineOut(numAx, numAy, numAz, numBx, numBy, numBz);
Console.WriteLine(res);
