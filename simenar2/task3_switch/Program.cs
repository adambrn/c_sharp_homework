Console.Write("Введите день недели в числовом формате(1-7): ");
int num = Convert.ToInt32(Console.ReadLine());
switch (num)
{
    case 6:
    case 7:
        Console.WriteLine("выходной");
        break;
    case 1:
    case 2:
    case 3:
    case 4:
    case 5:
        Console.WriteLine("не выходной");
        break;
    default:
        Console.WriteLine("Не верный день");
        break;
}