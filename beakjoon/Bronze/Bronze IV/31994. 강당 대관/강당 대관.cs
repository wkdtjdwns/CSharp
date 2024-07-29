Dictionary<string, int> seminars = new Dictionary<string, int>();
int max = 0;
for (int i = 0; i < 7; i++)
{
    string[] seminar = Console.ReadLine().Split(" ");
    seminars.Add(seminar[0], int.Parse(seminar[1]));
    max = Math.Max(max, int.Parse(seminar[1]));
}

Console.WriteLine(seminars.FirstOrDefault(x => x.Value == max).Key);
