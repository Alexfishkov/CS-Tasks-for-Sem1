Console.Clear();
Console.WriteLine("Выводим все чётные числа в промежутке от 1 до введённого Вами положительного числа");
Console.Write("Введите Ваше число=>");
int yournumber = Int32.Parse(Console.ReadLine());
int i = 1;
while (i <= yournumber)
{
    if ((i % 2) == 0)
    {
        Console.Write(i + " ");
    }
    i++;
}
Console.WriteLine(" ");