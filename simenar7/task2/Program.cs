// Напишите программу, которая на вход принимает позиции (две) элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Интервал генерации чисел
int startInterval = 0;
int endInterval = 100;

// Размерность массива
int N = 5;
int M = 6;

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
Console.Write("Введите позицию элемента через пробел: ");
string ? inputData = Console.ReadLine();
int positionI = Convert.ToInt32(inputData.Split(' ')[0]);
int positionJ = Convert.ToInt32(inputData.Split(' ')[1]);
int[,] arrayNumbers = GenerateNewArray(N, M);
PrintArray(arrayNumbers);

if (positionI < arrayNumbers.GetLength(0) && positionJ < arrayNumbers.GetLength(1)) 
{
    Console.WriteLine($"Элемент массива [{positionI},{positionJ}] равен: {arrayNumbers[positionI,positionJ]}");
    }
else {
    Console.Write("Такой элемент массива отсутствует");
    }