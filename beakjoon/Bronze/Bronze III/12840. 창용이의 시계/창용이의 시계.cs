string[] hms = Console.ReadLine().Split(" ");
int h = int.Parse(hms[0]);
int m = int.Parse(hms[1]);
int s = int.Parse(hms[2]);
int cur = h * 3600 + m * 60 + s;

int q = int.Parse(Console.ReadLine());
for (int i = 0; i < q; i++)
{
    string[] tx = Console.ReadLine().Split(" ");
    int t = int.Parse(tx[0]);

    if (t == 3)
    {
        Console.WriteLine((cur / 3600) + " " + ((cur / 60) % 60) + " " + cur % 60);
    }

    else if (t == 1)
    {
        int x = int.Parse(tx[1]);
        cur = (cur + x) % 86400;
    }

    else
    {
        int x = int.Parse(tx[1]);
        cur = (cur - x) % 86400;

        while (cur < 0)
        {
            cur += 86400;
        }
    }
}
