Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
int result = number / 100 % 10;

if (result>0)
{
    Console.WriteLine($"Третий разряд числа {number} равен = {result}");
}
else
{
    if (number/1000 > 0)
    {
        Console.WriteLine($"Третий разряд числа {number} равен = 0");
    }
    else
    {
        Console.WriteLine($"У числа {number} третьего разряда нет");
    }
}
