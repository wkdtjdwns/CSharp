string[] ymd = Console.ReadLine().Split("-");
int year = int.Parse(ymd[0]);
int month = int.Parse(ymd[1]);
int day = int.Parse(ymd[2]);

int n = int.Parse(Console.ReadLine());
day += n;
while (day > 30)
{
    day -= 30;
    month += 1;
}

while (month > 12)
{
    month -= 12;
    year += 1;
}

Console.WriteLine($"{year:D4}-{month:D2}-{day:D2}");
