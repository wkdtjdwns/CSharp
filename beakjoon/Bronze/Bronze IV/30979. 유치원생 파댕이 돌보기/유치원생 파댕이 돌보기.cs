int t = int.Parse(Console.ReadLine());
int n = int.Parse(Console.ReadLine());
string[] f = Console.ReadLine().Split(" ");

int total = 0;
foreach (string taste in f)
{
    total += int.Parse(taste);
}

Console.WriteLine((total >= t) ? "Padaeng_i Happy" : "Padaeng_i Cry");
