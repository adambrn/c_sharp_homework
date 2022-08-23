//Напишите программу, которая принимает на вход случайно сгенерированное трёхзначное число и на выходе показывает вторую цифру этого 
int GetDigit(int num, int n)
{
    return num / Convert.ToInt32(Math.Pow(10, n-1)) % 10;
}
int number = new Random().Next(100,1000);
Console.WriteLine(number);
Console.WriteLine(GetDigit(number, 2));