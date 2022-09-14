//Сформируйте двухмерный массив из неповторяющихся двузначных чисел (размер массива не более 50 элементов). 
//Напишите программу, которая будет построчно выводить массив.

// Интервал генерации чисел
int startInterval = 10;
int endInterval = 100;

int[,] GenerateNewMatrix(int M, int N)
{
    bool Contains(int[,] arr, int value)
    {
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                if (arr[i, j] == value) return true;

            }
        }
        return false;
    }

    Random rnd = new Random();
    int[,] matrix = new int[M, N];
    int tmp;
    for (int i = 0; i < M; i++)
    {
        for (int j = 0; j < N; j++)
        {
            tmp = rnd.Next(startInterval, endInterval);
             while (Contains(matrix, tmp))
            {
                tmp = rnd.Next(startInterval, endInterval);
            }
            matrix[i,j] = tmp;

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

Console.Write("Введите количество строк: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int N = Convert.ToInt32(Console.ReadLine());
int[,] matrixNumbers = GenerateNewMatrix(M, N);
PrintMatrix(matrixNumbers);

