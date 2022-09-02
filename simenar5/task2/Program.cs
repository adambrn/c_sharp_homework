//Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму четных элементов, стоящих на нечётных позициях (позиция - индекс элемента в массиве).
Console.Write("Введите размер массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
int sum = 0;
for (int i = 0; i < n; i++)
{
    array[i] = new Random().Next();
    Console.Write(array[i] + " ");
    
}
for (int i = 1; i < n; i+=2)
{
    if (array[i] % 2 == 0)
    {
        sum +=array[i];
    }
}
Console.WriteLine();
Console.Write("Сумма: " + sum);