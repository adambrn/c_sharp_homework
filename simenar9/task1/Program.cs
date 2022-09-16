//Задайте двумерный массив. 
//Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
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
int tmp;
int min;
void SortMatrixRow(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            min = matrix[i,j];
            for (int k = j; k < matrix.GetLength(0); k++)
            {
                if (matrix[i,k] > matrix[i,j])
                {
                    tmp = matrix[i,k];
                    matrix[i,k] = matrix[i,j];
                    matrix[i,j] = tmp;
                }
            }
        }
    }
}
Console.Write("Введите количество строк: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int N = Convert.ToInt32(Console.ReadLine());
int[,] matrixNumbers = GenerateNewMatrix(M, N);
PrintMatrix(matrixNumbers);
SortMatrixRow(matrixNumbers);
Console.WriteLine();
PrintMatrix(matrixNumbers);