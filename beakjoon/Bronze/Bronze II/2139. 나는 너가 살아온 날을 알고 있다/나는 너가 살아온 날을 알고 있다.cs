int[] days = { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30 };

while (true)
{
    string[] dmy = Console.ReadLine().Split(" ");
    int d = int.Parse(dmy[0]);
    int m = int.Parse(dmy[1]);
    int y = int.Parse(dmy[2]);

    if (d == 0 && m == 0 && y == 0)
    {
        break;
    }

    DateTime date = new DateTime(y, m, d);
    DateTime sy = new DateTime(y, 1, 1);
    TimeSpan timeSpan = date - sy;

    Console.WriteLine(timeSpan.Days + 1);
}
