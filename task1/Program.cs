Console.Clear();
Console.Write("Введите трёхзначное число: ");
int num=int.Parse(Console.ReadLine());
Console.Write("Вторая цифра числа "+ num + ": ");
Console.Write(num/10%10);