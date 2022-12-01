Console.Clear();
Console.WriteLine("Определяем чётность введённого Вами числа");
Console.Write("Введите ваше число>");
int number = Int32.Parse(Console.ReadLine());
if ((number % 2) != 0)
{
    Console.WriteLine("Введённое число является нечётным");
}
else
{
    Console.WriteLine("Введённое число является чётным");
}
