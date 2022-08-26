// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. 
int AmountDigit(int num)
{
    int amount = 0;
    while (num > 0)
    {
        amount++;
        num /= 10;
    }
    return amount;
}
int ReverseNumber(int num)
{
    int temp = 0;
    while (num > 0)
    {
        temp *= 10;
        temp += num % 10;
        num /= 10;
    }
    return temp;
}
Console.Write("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
while (AmountDigit(number) != 5)
{
    Console.Write("Введите ПЯТИЗНАЧНОЕ число: ");
    number = Convert.ToInt32(Console.ReadLine());
}
if (number == ReverseNumber(number))
{
    Console.WriteLine(number + " - полиндром");
}
else
{
    Console.WriteLine(number + " - не полиндром");
}