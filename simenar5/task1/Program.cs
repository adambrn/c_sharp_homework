// Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.

Console.Write("Введите размер массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
int count = 0;
for (int i = 0; i < n; i++)
{
    array[i] = new Random().Next(1,1000);
    
}
for (int i = 0; i < n; i++)
{
   Console.Write(array[i] + " ");
    if (array[i] % 2 == 0)
    {
        count++;
    } 
}
Console.WriteLine();
Console.Write("Число четных элементов: " + count);