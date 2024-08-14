string[] nt = Console.ReadLine().Split(" ");
int n = int.Parse(nt[0]);
int t = int.Parse(nt[1]);
int cnt = 0;
int x = 1;

for (int i = 0; i < t; i++)
{
    cnt += x;
    if (cnt == 2 * n)
    {
        x = -1;
    }

    if (cnt == 1)
    {
        x = 1;
    }
}

Console.Write(cnt);
