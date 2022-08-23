//Напишите программу, которая выводит третью цифру случайно сгенерированного числа (от 1 до 65536) или сообщает, что третьей цифры нет.
int GetDigit(int num, int n)
{
    return num / Convert.ToInt32(Math.Pow(10, n-1)) % 10;
}
int number = new Random().Next(1, 65537);
Console.WriteLine(number);
if (number < 100)
{
    Console.WriteLine("Третьей цифры нет");
}
else
{
    Console.WriteLine(GetDigit(number, 3));
}