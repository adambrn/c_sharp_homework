//Задайте двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Интервал генерации чисел
int startInterval = 0;
int endInterval = 10;

int[,] GenerateNewMatrix(int M, int N)
{
    Random rnd = new Random();
    int[,] matrix = new int[M, N];
    for (int i = 0; i < M; i++)
    {
        for (int j = 0; j < N; j++)
        {
            matrix[i, j] = rnd.Next(startInterval, endInterval);

        }
    }
    return matrix;
}
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} \t");

        }
        Console.WriteLine();
    }
}
int GetMinSumRow(int[,] matrix)
{
    int sum = endInterval * matrix.GetLength(1);
    int min = endInterval * matrix.GetLength(1);
    int result = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum += matrix[i, j];
        }
        if (sum < min)
        {
            min = sum;
            result = i + 1;
        }
        sum = 0;
    }
    return result;
}
Console.Write("Введите количество строк: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int N = Convert.ToInt32(Console.ReadLine());
int[,] matrixNumbers = GenerateNewMatrix(M, N);
PrintMatrix(matrixNumbers);
Console.Write("Номер строки с наименьшей суммой элементов: " + GetMinSumRow(matrixNumbers));
