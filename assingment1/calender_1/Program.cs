Console.Write("Enter month(Press 1 for Jan, 2 for Feb, 12 for Dec......): ");
int month = Convert.ToInt16(Console.ReadLine());
Console.Write("Enter year: ");
int year = Convert.ToInt16(Console.ReadLine());
Console.Write("Enter Day of week(Press 1 for Mon, 2 for Tue, 7 for Sun......): ");
int startDay = Convert.ToInt16(Console.ReadLine());

int numDays = DateTime.DaysInMonth(year, month);

Console.WriteLine("      Calendar       ");
Console.WriteLine(" S  M  Tu W Th  F  S");

for (int i = 1; i <= startDay; i++)
{
    Console.Write("   ");
}
for (int day = 1; day <= numDays; day++)
{
    Console.Write($"{day,2} ");
    if ((day + startDay) % 7 == 0 || day == numDays)
    {
        Console.WriteLine();
    }
}