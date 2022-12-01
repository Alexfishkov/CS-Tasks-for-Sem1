Console.Clear();
Console.WriteLine("Определяем, какое из двух введённых числе Max, а какое Min");
Console.Write("Введите первое число=>");
int firstnumber = Int32.Parse(Console.ReadLine());
Console.Write("Введите второе число=>");
int secondnumber = Int32.Parse(Console.ReadLine());
if (secondnumber == firstnumber)
{
    Console.WriteLine("Числа равны, Min=Max");
}
else if (secondnumber > firstnumber)
{
    Console.WriteLine("Max= " + secondnumber + " Min= " + firstnumber);
}
else
{
    Console.WriteLine("Max= " + firstnumber + " Min= " + secondnumber);
}
