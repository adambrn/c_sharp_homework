//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
Console.Write("Введите координаты первой точки через пробел: ");
string? FirstPointString = Console.ReadLine();
int[] FirstPoint = FirstPointString.Split(' ').Select(Int32.Parse).ToArray();
Console.Write("Введите координаты первой точки через пробел: ");
string? SecondPointString = Console.ReadLine();
int[] SecondPoint = SecondPointString.Split(' ').Select(Int32.Parse).ToArray();

double distance = Math.Sqrt(Math.Pow(FirstPoint[0] - SecondPoint[0], 2)
    + Math.Pow(FirstPoint[1] - SecondPoint[1], 2)
    + Math.Pow(FirstPoint[2] - SecondPoint[2], 2));

Console.WriteLine("Расстояние между этими точками равно:  " + Math.Abs(Math.Round(distance, 2)));