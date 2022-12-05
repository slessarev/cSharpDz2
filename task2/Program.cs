Console.Clear();
Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());
if (num < 100) Console.Write("Третьей цифры у числа " + num + " нет.");
else
{
    while (num > 1000) num = num / 10;
    Console.Write("Третья цифра у введенного числа: " + num % 10);
}
