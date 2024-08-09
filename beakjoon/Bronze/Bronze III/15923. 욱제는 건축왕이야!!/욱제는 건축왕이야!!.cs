int n = int.Parse(Console.ReadLine());
int[,] points = new int[n, 2];
for (int i = 0; i < n; i++)
{
    string[] point = Console.ReadLine().Split(" ");
    points[i, 0] = int.Parse(point[0]);
    points[i, 1] = int.Parse(point[1]);
}

int result = 0;
for (int i = 0; i < n; i++)
{
    int x1 = points[i, 0]; int x2 = points[(i + 1) % n, 0];
    int y1 = points[i, 1]; int y2 = points[(i + 1) % n, 1];

    result += Math.Abs(x2 - x1) + Math.Abs(y2 - y1);
}

Console.WriteLine(result);
