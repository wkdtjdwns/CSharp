int n = int.Parse(Console.ReadLine());
string str = Console.ReadLine();
int cnt = 0;
for (int i = 0; i < n / 2; i++)
{
    if (str[i] != str[n - 1 - i])
    {
        cnt++;
    }
}

Console.WriteLine(cnt);
