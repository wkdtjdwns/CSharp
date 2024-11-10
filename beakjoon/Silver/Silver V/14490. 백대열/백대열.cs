int HighYakSu(int a, int b)
{
    int r = a % b;
    if (r == 0)
    {
        return b;
    }

    return HighYakSu(b, r);
}

string[] nm = Console.ReadLine().Split(":");
int n = int.Parse(nm[0]);
int m = int.Parse(nm[1]);
int temp = n;

n /= HighYakSu(n, m);
m /= HighYakSu(temp, m);

Console.WriteLine($"{n}:{m}");
