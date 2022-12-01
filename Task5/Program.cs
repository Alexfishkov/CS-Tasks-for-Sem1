Console.Clear();
Console.WriteLine("Распечатываем все значения целых чисел от -N до N");
Console.Write("Введите N=>");
int n = Int32.Parse(Console.ReadLine());
int i = -n;
while (i <= n)
{
    Console.Write(i + ", ");
    i++;
}
Console.WriteLine();

