Console.Clear();
Console.WriteLine("Определяем, является ли первое число квадратом второго");
Console.Write("Введите первое число=>");
int firstnumber = Int32.Parse(Console.ReadLine());
Console.Write("Введите второе число=>");
int secondnumber = Int32.Parse(Console.ReadLine());
if ((secondnumber * secondnumber) == firstnumber)
{
    Console.WriteLine("Первое число является квадратом второго");
}
else
{
    Console.WriteLine("Первое число не является квадратом второго");
}
