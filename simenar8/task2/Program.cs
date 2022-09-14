//Задайте две квадратные матрицы одного размера. 
//Напишите программу, которая будет находить произведение двух матриц.

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
void PrintMatrix(int[,] array)
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
int[,] MultiplicationMatrix(int[,] matrix1, int[,] matrix2)
{
    int[,] matrixResult = new int[matrix1.GetLength(0), matrix1.GetLength(1)];
   for (int i = 0; i < matrix1.GetLength(0); i++)
            {
                for (int j = 0; j < matrix2.GetLength(1); j++)
                {
                    for (int k = 0; k < matrix2.GetLength(0); k++)
                    {
                        matrixResult[i,j] += matrix1[i,k] * matrix2[k,j];
                    }
                }
            }
    return matrixResult;
}
Console.Write("Введите размерность умножамых матриц: ");
int M = Convert.ToInt32(Console.ReadLine());
int[,] matrixOne = GenerateNewMatrix(M, M);
PrintMatrix(matrixOne);
Console.WriteLine();
int[,] matrixTow = GenerateNewMatrix(M, M);
PrintMatrix(matrixTow);
Console.WriteLine("Произведение матриц");
PrintMatrix(MultiplicationMatrix(matrixOne,matrixTow));



