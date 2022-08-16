Console.Write("Введите номер дня недели: ");
int number = int.Parse(Console.ReadLine());
string answer = "нет";

if (0 < number && number< 8)
{
    if (number == 6 || number == 7)
    {
        answer = "да";
    }
    Console.WriteLine(answer);
}
else
{
    Console.WriteLine("Дня недели с таким номером не существует.");
}
