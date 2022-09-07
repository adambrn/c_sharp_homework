/* Найдите сумму произведений пар чисел в одномерном целочисленном массиве. 
Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
Если кол-во элементов нечетное, то элемент посередине не учитывать.
Результат сложения вывести на экран. */
//int[] array = {1, 3, 8, 3, 2};
//int[] array = {8, 3, 4, 2};
Console.Write("Введите размер массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
for (int i = 0; i < n; i++)
{
    array[i] = new Random().Next(1,100);
    Console.Write(array[i] + " ");
}
Console.WriteLine();
//основная часть
int sum = 0;
for (int i = 0; i < array.Length/2; i++)
{
    sum +=array[i] * array[array.Length - 1 - i];
}
Console.WriteLine($"Результат: {sum}");