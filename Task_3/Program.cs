try
{
Console.WriteLine("Введите число.");

    int num = Convert.ToInt32(Console.ReadLine());

    int st = 3;
    int Exponentiation(int save, int degree)
    {
        int deg = 0;
        int num = save;
        for (deg = 2; deg <= degree; deg++)
        {
            num = num * save;
        }
        return num;
    }
    int save = num;
    for (int i = 1; i <= save; i++)
    {
        int res = Exponentiation(i, st);
        Console.Write($"{res} ");
    }
}
catch
{
    Console.WriteLine("Ошибка ввода! Введите целое число.");
}