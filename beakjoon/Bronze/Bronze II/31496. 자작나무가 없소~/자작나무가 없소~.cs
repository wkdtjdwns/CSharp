string[] ns = Console.ReadLine().Split(" ");
int n = int.Parse(ns[0]);
string str = ns[1];
int result = 0;
for (int i = 0; i < n; i++)
{
    string[] a = Console.ReadLine().Split(" ");
    string[] b = a[0].Split("_");
    if (b.Contains(str))
    {
        result += int.Parse(a[1]);
    }
}

Console.WriteLine(result);
