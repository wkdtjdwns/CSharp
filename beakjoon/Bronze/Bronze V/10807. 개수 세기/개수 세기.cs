string N = Console.ReadLine();
string[] nums = Console.ReadLine().Split(" ");
string V = Console.ReadLine();

int cnt = 0;
foreach (string num in nums)
{
    if (num.Equals(V))
    {
        cnt++;
    }
}

Console.WriteLine(cnt);
