// Напишите программу, которая заполнит спирально двумерный массив 4 на 4. 
Console.Write("Введите количество строк: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int N = Convert.ToInt32(Console.ReadLine());
int counter = 1, direction, passedColumn = 0, passedRow = 0, currentColumn = 0, currentRow = 0;
int tmp = 0;
int[,] matrix = new int[M, N];
for (int k = 0; k < M * N; k++)
{
    if (counter == N * M + 1) break;
    direction = k % 4;
    if (direction == 0)
    {
        for (int j = passedColumn; j < N - passedColumn; j++)
        {
            matrix[currentRow, j] = counter;
            tmp = j;
            counter++;
        }
        currentColumn = tmp;
        passedRow++;
    }
    else if (direction == 1)
    {
        for (int i = passedRow; i < M - passedRow + 1; i++)
        {
            matrix[i, currentColumn] = counter;
            tmp = i;
            counter++;
        }
        currentRow = tmp;
        passedColumn++;
    }
    else if (direction == 2)
    {
        for (int j = currentColumn - 1; j > passedColumn  - 2; j--)
        {
            matrix[currentRow, j] = counter;
            tmp = j;
            counter++;
        }
        currentColumn = tmp;           
    }
    else if (direction == 3)
    {
        for (int i = currentRow - 1; i > passedRow - 1; i--)
        {
            matrix[i, currentColumn] = counter;
            tmp = i;
            counter++;
        }
        currentRow = tmp;   
    }
}

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        Console.Write($"{matrix[i, j]} \t");

    }
    Console.WriteLine();
}