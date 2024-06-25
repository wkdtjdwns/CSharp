int n = int.Parse(Console.ReadLine());
int total = 0;

string[] abc = Console.ReadLine().Split(" ");
foreach (string nums in abc)
{
    total += Math.Min(int.Parse(nums), n);
}

Console.WriteLine(total);
