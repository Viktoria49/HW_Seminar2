Console.Write("Введите трёхзначное число: ");
int number = int.Parse(Console.ReadLine());
int result = number / 10 % 10;
Console.WriteLine($"Вторая цифра числа {number} равна = {result}");
