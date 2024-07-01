string myCode = Console.ReadLine().Substring(0, 5);
int n = int.Parse(Console.ReadLine());

int cnt = 0;
for (int i = 0; i < n; i++)
{
    string code = Console.ReadLine().Substring(0, 5);
    if (myCode.Equals(code))
    {
        cnt++;
    }
}

Console.WriteLine(cnt);
