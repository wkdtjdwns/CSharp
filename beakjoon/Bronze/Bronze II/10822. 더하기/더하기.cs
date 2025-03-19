string[] s = Console.ReadLine().Split(",");
int result = 0;
for (int i = 0; i < s.Length; i++)
{
    result += int.Parse(s[i]);
}

Console.WriteLine(result);
