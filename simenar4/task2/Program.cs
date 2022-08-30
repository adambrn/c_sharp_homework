// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе, которые являются делителями этого числа. 
//(для получения цифр числа операцию приведения числа к строке не использовать)
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int temp = num;
int sum = 0;
int digit = 0;
while (temp > 0)
{
    digit = temp % 10;
    if (digit != 0)
    {
        if (num % digit == 0)
        {
            sum += digit;
        }
    }
    temp /= 10;
}
Console.WriteLine("Результат: " + sum);