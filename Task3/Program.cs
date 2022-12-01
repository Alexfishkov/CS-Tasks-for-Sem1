Console.Clear();
Console.WriteLine("Определяем по введённому номеру дня недели его название");
string[] dweeks = { "понедельник", "вторник", "среда", "четверг", "пятница", "суббота", "воскресенье" };
Console.Write("Введите номер дня недели (от 1 до 7)=>");
int yournumber = Int32.Parse(Console.ReadLine());
int daynumber = yournumber-1;
Console.WriteLine("Это " + dweeks[daynumber]);
