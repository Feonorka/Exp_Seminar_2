Console.WriteLine("Введите число:");
int num = Convert.ToInt32(Console.ReadLine());
// Метод перегонящий число в массив в обратном порядке, преобразующий его в int и сравнивающий с исходным
void Switcher(int number)
{
    int i = 0;
    int result = number;
    int[] array = new int[KolNumber(number)];
    int finalScore = 0;
    while (i < KolNumber(number))
    {
        int result_new = result % 10;
        array[i] = result_new;
        result = result / 10;
        i++;
    }
    for (int j = 0; j < array.Length; j++)
    {
        finalScore += array[j] * Convert.ToInt32(Math.Pow(10, array.Length-j-1));
    }
        if (number == finalScore) Console.WriteLine("Число является полиндромом");
    else Console.Write("Не является полиндромом");
}
// Метод определяющий количество цифр в числе
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
Switcher(num);
