//Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
//значения b1, k1, b2 и k2 задаются пользователем.

Console.Write("Введите x первой точки: ");
double k1 =Convert.ToInt32(Console.ReadLine());
Console.Write("Введите y первой точки: ");
double b1 =Convert.ToInt32(Console.ReadLine());
Console.Write("Введите x второй точки: ");
double k2 =Convert.ToInt32(Console.ReadLine());
Console.Write("Введите y второй точки: ");
double b2 =Convert.ToInt32(Console.ReadLine());


if(k1 - k2 == 0 && b2 - b1 != 0)
    {
        Console.WriteLine("Прямые паралельны");
    }
else if (k1 - k2 == 0 && b2 - b1 == 0)
    {
        Console.WriteLine("Прямые совпадают");
    }
else
{
    double x = Math.Round(((b2-b1) / (k1-k2)),2);
    double y = k1 * x + b1;
    Console.WriteLine($"Точка пересечения: ({x};{y})");
}