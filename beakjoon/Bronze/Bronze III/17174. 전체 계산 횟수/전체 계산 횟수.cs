string[] nm = Console.ReadLine().Split(" ");
int n = int.Parse(nm[0]);
int m = int.Parse(nm[1]);
int cnt = n;
int check = n;
while (check >= m)
{
    cnt += check / m;
    check /= m;
}

Console.WriteLine(cnt);
