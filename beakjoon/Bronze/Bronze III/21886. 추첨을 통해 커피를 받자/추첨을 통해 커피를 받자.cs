int num = 100;
int sum = 0;
string[] scores = Console.ReadLine().Split(" ");
for (int i = 0; i < 9; i++)
{
    int n = int.Parse(scores[i]);
    if (i % 2 == 0 && i != 0)
    {
        num += 100;
    }

    sum += n;
    if (n > num)
    {
        Console.WriteLine("hacker");
        return;
    }
}

Console.WriteLine(sum < 100 ? "none" : "draw");
