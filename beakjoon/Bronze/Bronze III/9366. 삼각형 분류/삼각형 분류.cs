int t = int.Parse(Console.ReadLine());
int[] abcValue = new int[3];
for (int i = 1; i <= t; i++)
{
    string[] abc = Console.ReadLine().Split(" ");
    for (int j = 0; j < 3; j++)
    {
        abcValue[j] = int.Parse(abc[j]);
    }

    Array.Sort(abcValue);
    Console.Write($"Case #{i}: ");
    if (abcValue[0] + abcValue[1] <= abcValue[2])
    {
        Console.WriteLine("invalid!");
    }

    else if (abcValue[0] == abcValue[1] && abcValue[0] == abcValue[2])
    {
        Console.WriteLine("equilateral");
    }

    else if (abcValue[0] == abcValue[1] || abcValue[0] == abcValue[2] || abcValue[1] == abcValue[2])
    {
        Console.WriteLine("isosceles");
    }

    else
    {
        Console.WriteLine("scalene");
    }
}
