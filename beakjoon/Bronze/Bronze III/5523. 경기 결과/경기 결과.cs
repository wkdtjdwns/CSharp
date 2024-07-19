int t = int.Parse(Console.ReadLine());
int aWin = 0; int bWin = 0;
for (int i = 0; i < t; i++)
{
    string[] ab = Console.ReadLine().Split(" ");
    int a = int.Parse(ab[0]);
    int b = int.Parse(ab[1]);

    if (a > b) { aWin++; }
    else if (a < b) { bWin++; }
}

Console.WriteLine(aWin + " " + bWin);
