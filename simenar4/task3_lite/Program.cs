Console.Write("Введите размер массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int itemCount = 0;
int sum, multi, digit, temp, item;

int[] array = new int[n];
while (itemCount < n)
{
    item = new Random().Next();
    temp = item;
    sum = 0;
    multi = 1;
    
    while (temp != 0)
    {
        digit = temp % 10;
        sum += digit;
        multi *= digit;
        temp /= 10; 
    }
    
    if (multi != 0 && multi % sum == 0)
    {
        array[itemCount] = item;
        Console.Write(array[itemCount] + " ");
        itemCount++;
    }
    
}