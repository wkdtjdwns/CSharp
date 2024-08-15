string[] msx = Console.ReadLine().Split(" ");
int m = int.Parse(msx[0]);
int seed = int.Parse(msx[1]);
int x1 = int.Parse(msx[2]);
int x2 = int.Parse(msx[3]);

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < m; j++)
    {
        if ((i * seed + j) % m == x1 && (i * x1 + j) % m == x2)
        {
            Console.WriteLine(i + " " + j);
            return;
        }
    }
}
