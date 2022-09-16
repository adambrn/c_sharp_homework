//Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
int A(int n, int m)
{
    if (n == 0)
        return m + 1;
    else
        if ((n != 0) && (m == 0))
        return A(n - 1, 1);
    else
        return A(n - 1, A(n, m - 1));
}
Console.Write("Введите n: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write($"A({n},{m}) = " + A(n,m));