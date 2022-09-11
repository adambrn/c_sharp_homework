// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
int startInterval = 0;
int endInterval = 10;

int[,] GenerateNewArray(int M, int N)
{   Random rnd = new Random();
    int[,] array = new int[M,N];
    for (int i = 0; i < M; i++)
    {
        for (int j = 0; j < N; j++)
        {
            array[i, j] = rnd.Next(startInterval, endInterval);
            
        }
    }
    return array;
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} \t");
            
        }
        Console.WriteLine();
    }
}
Console.Write("Введите размерность массива через пробел: ");
string ? inputData = Console.ReadLine();
int M = Convert.ToInt32(inputData.Split(' ')[0]);
int N = Convert.ToInt32(inputData.Split(' ')[1]);
int[,] arrayNumbers = GenerateNewArray(M, N);
PrintArray(arrayNumbers);
double sum;
double avg;
for (int i = 0; i < arrayNumbers.GetLength(0); i++)
    {
        sum = 0;
        for (int j = 0; j < arrayNumbers.GetLength(1); j++)
        {
            sum += arrayNumbers[i, j];
        }
        avg =  Math.Round(sum / (arrayNumbers.GetLength(1)), 1);
        Console.WriteLine($"Среднее арифметическое строки {i} равно: {avg}");
    }