int t = int.Parse(Console.ReadLine());
for (int i = 0; i < t; i++)
{
    string[] n = Console.ReadLine().Split(" ");
    int sum = 0;
    foreach (string s in n)
    {
        sum += int.Parse(s);
    }

    Console.WriteLine(sum);
}
