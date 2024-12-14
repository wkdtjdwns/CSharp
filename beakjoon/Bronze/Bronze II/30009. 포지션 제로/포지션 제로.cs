int n = int.Parse(Console.ReadLine());
string[] xyr = Console.ReadLine().Split(" ");
int x = int.Parse(xyr[0]);
int y = int.Parse(xyr[1]);
int r = int.Parse(xyr[2]);

int a = 0;
int b = 0;

for (int i = 0; i < n; i++)
{
    int t = int.Parse(Console.ReadLine());
    int distance = Math.Abs(t - x);

    if (distance < r)
    {
        a++;
    }

    else if (distance == r)
    {
        b++;
    }
}

Console.WriteLine(a + " " + b);
