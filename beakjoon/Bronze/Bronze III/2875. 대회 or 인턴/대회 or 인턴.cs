string[] nmk = Console.ReadLine().Split(" ");
int n = int.Parse(nmk[0]);
int m = int.Parse(nmk[1]);
int k = int.Parse(nmk[2]);
int result = 0;

while (n >= 2 && m >= 1 && (n + m) - k >= 3)
{
    result++;
    n -= 2;
    m--;
}

Console.WriteLine(result);
