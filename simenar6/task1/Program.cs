//Программа запрашивает натуральное число M, пользователь вводит с клавиатуры M чисел. 
//Посчитайте, сколько чисел больше 0 ввёл пользователь.
Console.Write("Введите количество чисел :");
int M =Convert.ToInt32(Console.ReadLine());
int num,count = 0;
for (int i = 0; i < M; i++)
{
   Console.Write($"Введите {i+1}-е число :"); 
   num =Convert.ToInt32(Console.ReadLine());
   if (num > 0)
    {
        count++;
    }
}
Console.WriteLine($"Вы ввели чисел больше 0: {count}");
