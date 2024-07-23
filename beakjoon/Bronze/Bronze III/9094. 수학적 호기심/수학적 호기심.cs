int t = int.Parse(Console.ReadLine());
for (int i = 0; i < t; i++)
{
    string[] nm = Console.ReadLine().Split(" ");
    int n = int.Parse(nm[0]);
    int m = int.Parse(nm[1]);

    int cnt = 0;
    for (int a = 1; a < n; a++)
    {
        for (int b = (a + 1); b < n; b++)
        {
            if (((a * a) + (b * b) + m) % (a * b) == 0) 
            {
                cnt++;
            }
        }
    }

    Console.WriteLine(cnt);
}
