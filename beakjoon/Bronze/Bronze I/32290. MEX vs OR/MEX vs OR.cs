string[] lrx = Console.ReadLine().Split(" ");
int l = int.Parse(lrx[0]);
int r = int.Parse(lrx[1]);
int x = int.Parse(lrx[2]);

HashSet<int> result = new HashSet<int>();
for (int i = l; i <= r; i++)
{
    result.Add(i | x);
}

int mex = 0;
while (result.Contains(mex))
{
    mex++;
}

Console.WriteLine(mex);
