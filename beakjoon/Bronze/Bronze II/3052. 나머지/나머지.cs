List<int> list = new List<int>();
int cnt = 0;
for (int i = 0; i < 10; i++)
{
    int n = int.Parse(Console.ReadLine());
    if (!list.Contains(n % 42))
    {
        cnt++;
        list.Add(n % 42);
    }
}

Console.WriteLine(cnt);
