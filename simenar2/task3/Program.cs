//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
void CheckDay(int day)
{
    if (day == 6 || day == 7)
    {
        Console.WriteLine("выходной");
    }
    else
    {
        Console.WriteLine("не выходной");
    }
}

Console.Write("Введите день недели в числовом формате(1-7): ");
int num = Convert.ToInt32(Console.ReadLine());
while (num < 1 || num > 7)
{
    Console.WriteLine("Не верный день");
    Console.Write("Повторите ввод в числовом формате(1-7): ");
    num = Convert.ToInt32(Console.ReadLine());
}
CheckDay(num);