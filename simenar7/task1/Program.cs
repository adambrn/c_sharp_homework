//Задайте двумерный массив размером m×n, заполненный случайными вещественными (тип double) числами.
int startInterval = 0;
int endInterval = 100;

double GenerateRandomDouble(int min, int max)
{
    return Math.Round(min + new Random().NextDouble() * (max - min),1);
}
Console.Write("Введите размерность массива через пробел: ");
string ? inputData = Console.ReadLine();
int M = Convert.ToInt32(inputData.Split(' ')[0]);
int N = Convert.ToInt32(inputData.Split(' ')[1]);

double[,] array = new double[M,N];
for (int i = 0; i < M; i++)
{
    for (int j = 0; j < N; j++)
    {
        array[i, j] = GenerateRandomDouble(startInterval, endInterval);
        Console.Write($"{array[i, j]} \t");
    }
    Console.WriteLine();
}
