int t = int.Parse(Console.ReadLine());
for (int i = 0; i < t; i++)
{
    string[] rs = Console.ReadLine().Split(" ");
    int r = int.Parse(rs[0]);
    string s = rs[1];

    foreach (char c in s)
    {
        for (int j = 0; j < r; j++)
        {
            Console.Write(c);
        }
    }

    Console.WriteLine();
}
