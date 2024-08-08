string[] nab = Console.ReadLine().Split(" ");
int n = int.Parse(nab[0]);
int a = int.Parse(nab[1]) - 1;
int b = int.Parse(nab[2]) - 1;

int[,] seats = new int[n, n];
for (int i = 0; i < n; i++)
{
    string[] seat = Console.ReadLine().Split(" ");
    for (int j = 0; j < n; j++)
    {
        seats[i, j] = int.Parse(seat[j]);
    }
}

int target = seats[a, b];
for (int i = 0; i < n; i++)
{
    if (seats[a, i] > target || seats[i, b] > target)
    {
        Console.WriteLine("ANGRY");
        return;
    }
}

Console.WriteLine("HAPPY");
