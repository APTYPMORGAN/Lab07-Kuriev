string[] days = { "Пн", "Вт", "Ср", "Чт", "Пт", "Сб", "Вс" };
for (int i = days.Length - 1; i >= 0; i--)
{
    Console.WriteLine($"{i}: {days[i]}");
}
double[] temps = { 20, 15, 8, 5, -5, -2, 0 };

foreach (double temp in temps)
{
    Console.Write($"{temp} ");
}