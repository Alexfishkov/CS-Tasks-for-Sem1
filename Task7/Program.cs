Console.Clear();
Console.WriteLine("Указываем последнюю цифру введённого Вами числа");
Console.Write("Введите ваше число>");
int number = Int32.Parse(Console.ReadLine());
int lastfigure = (number%10);
Console.WriteLine("Последней цифрой Вашего числа является: " + lastfigure);

