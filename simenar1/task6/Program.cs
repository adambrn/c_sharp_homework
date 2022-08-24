//Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());


if(a % 2 == 0) 
{
    Console.Write("Число - ");
    Console.Write(a);
    Console.Write(" чётное");
}
else
{
    Console.Write("Число - ");
    Console.Write(a);
    Console.Write(" нечётное");
}
