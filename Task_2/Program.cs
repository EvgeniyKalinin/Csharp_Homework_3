try
{
    Console.WriteLine("Введите X первой точки.");
    int x1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите Y первой точки.");
    int y1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите Z первой точки.");
    int z1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите X второй точки.");
    int x2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите Y второй точки.");
    int y2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите Z второй точки.");
    int z2 = Convert.ToInt32(Console.ReadLine());

    double Dist(int x1, int x2, int y1, int y2, int z1, int z2)
    {
        double hyp = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
        double hyp2 = Math.Sqrt(hyp * hyp + (z2 - z1) * (z2 - z1));
        return hyp2;
    }

    double rez = Dist(x1, x2, y1, y2, z1, z2);
    Console.WriteLine($"Расстояние между точками {rez}.");
}
catch
{
    Console.WriteLine("Ошибка ввода!");
}
