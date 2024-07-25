int t = int.Parse(Console.ReadLine());
for (int i = 0; i < t; i++)
{
    string[] nd = Console.ReadLine().Split(" ");
    int n = int.Parse(nd[0]);
    int d = int.Parse(nd[1]);
    
    int cnt = 0;
    for (int j = 0; j < n; j++)
    {
        string[] vfc = Console.ReadLine().Split(" ");
        int v = int.Parse(vfc[0]);
        int f = int.Parse(vfc[1]);
        int c = int.Parse(vfc[2]);

        if (v * f / c >= d)
        {
            cnt++;
        }
    }

    Console.WriteLine(cnt);
}
