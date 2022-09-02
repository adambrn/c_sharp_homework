//Задайте массив натуральных чисел. Найдите разницу между максимальным и минимальным элементов массива.
Console.Write("Введите размер массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
for (int i = 0; i < n; i++)
{
    array[i] = new Random().Next();
    Console.Write(array[i] + " ");
}
int min = array[0];
int max = array[0];
for (int i = 1; i < n; i++)
{
    if (array[i] > max) max = array[i];
    if (array[i] < min) min = array[i];
}
Console.WriteLine();
Console.Write("Разница: ");
Console.WriteLine(max-min);