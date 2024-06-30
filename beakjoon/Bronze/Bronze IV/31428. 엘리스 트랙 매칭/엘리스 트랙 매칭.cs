int n = int.Parse(Console.ReadLine());
string[] name = Console.ReadLine().Split(" ");
string str = Console.ReadLine();

int cnt = 0;
foreach (string s in name)
{
    if (s.Equals(str))
    {
        cnt++;
    }
}

Console.WriteLine(cnt);
