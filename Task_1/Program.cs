Console.WriteLine("Введите пятизначное число.");
try
{
    int num = Convert.ToInt32(Console.ReadLine());
}
catch
{
    Console.WriteLine("Ошибка ввода! Введите целое число.");
}
int save = num;
int rev = 0;
if (num < 99)
{
    Console.WriteLine("Введено некорректное число.");
}
else
{
    while (num > 0)
    {
        int ost = num % 10;
        rev = rev * 10 + ost;
        num = num / 10;
    }
    if (save == rev)
    {
        Console.WriteLine($"Число {save} является палиндромом.");
    }
    else
    {
        Console.WriteLine($"Число {save} не является палиндромом.");
    }
}