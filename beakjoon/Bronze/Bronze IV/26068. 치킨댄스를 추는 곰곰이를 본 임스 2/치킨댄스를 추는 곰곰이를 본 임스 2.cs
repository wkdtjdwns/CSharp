int n = int.Parse(Console.ReadLine());
int cnt = 0;

for (int i = 0; i < n; i++)
{
    string[] dx = Console.ReadLine().Split("-");
    
    if (int.Parse(dx[1]) <= 90)
    {
        cnt++;
    }
}

Console.WriteLine(cnt);
