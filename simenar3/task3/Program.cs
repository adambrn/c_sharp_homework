//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
int degree = 3;
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
for (int i = 0; i < n; i++)
{
    array[i] = Convert.ToInt32(Math.Pow(i + 1, degree));
}

for (int i = 0; i < n; i++)
{
    Console.Write(array[i]);
    Console.Write(" ");
}