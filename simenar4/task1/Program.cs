// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B. Не использовать функцию Math.Pow()
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите степень: ");
int degree = Convert.ToInt32(Console.ReadLine());
int result = 1;
for (int i = 0; i < degree; i++)
{
    result *= num;
}
Console.WriteLine($"{num} в степени {degree} равно: {result}");