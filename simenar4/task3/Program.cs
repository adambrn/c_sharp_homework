/* Назовём число «интересным» если его произведение цифр делится на их сумму. 
Напишите программу, которая заполняет массив на N «интересных» случайных целых чисел. 
(Каждый эл-т массива должен быть сгенерирован случайно) */

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
int GetDigit(int num, int n)
{
    int m = AmountDigit(num);
    return num / Convert.ToInt32(Math.Pow(10, m - n)) % 10;
}
bool IsInterestingNum(int num)
{
    int multi = 1;
    int sum = 0;
    for (int i = 0; i < AmountDigit(num); i++)
    {
        multi *= GetDigit(num, i + 1);
        sum += GetDigit(num, i + 1);
    }
    return multi % sum == 0;
}
bool WithZero(int num)
{
    bool flag = false;
    for (int i = 0; i < AmountDigit(num); i++)
    {
        if (GetDigit(num, i + 1) == 0) flag = true;
    }
    return flag;

}
Console.Write("Введите размер массива: ");
int n = Convert.ToInt32(Console.ReadLine());

int[] array = new int[n];
for (int i = 0; i < n; i++)
{
    int temp = new Random().Next();
    while (!(IsInterestingNum(temp)) || WithZero(temp))
    {
        temp = new Random().Next();
    }
    array[i] = temp;
}
for (int i = 0; i < n; i++)
{
    Console.Write(array[i] + " ");
}