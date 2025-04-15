string[] md = Console.ReadLine().Split(" ");
int m = int.Parse(md[0]);
int d = int.Parse(md[1]);

string[] days = { "MON", "TUE", "WED", "THU", "FRI", "SAT", "SUN" };
int[] monthDays = { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

int n = 0;
for (int i = 0; i < m; i++)
{
    n += monthDays[i];
}

n += d - 1;
Console.WriteLine(days[n % 7]);
