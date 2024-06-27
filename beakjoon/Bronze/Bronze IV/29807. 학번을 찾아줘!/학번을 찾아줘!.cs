using System;

int t = int.Parse(Console.ReadLine());
string[] input = Console.ReadLine().Split(" ");
int[] scores = new int[t];
for (int i = 0; i < t; i++)
{
    scores[i] = int.Parse(input[i]);
}

int result = 0;
if (t == 1)
{
    result += scores[0] * 508;
}

else if (t == 2)
{
    result += scores[0] * 508;
    result += scores[1] * 212;
}

else if (t == 3)
{
    if (scores[0] > scores[2])
    {
        result += (scores[0] - scores[2]) * 508;
    }

    else
    {
        result += (scores[2] - scores[0]) * 108;
    }

    result += scores[1] * 212;
}

else if (t == 4)
{
    if (scores[0] > scores[2])
    {
        result += (scores[0] - scores[2]) * 508;
    }

    else
    {
        result += (scores[2] - scores[0]) * 108;
    }

    if (scores[1] > scores[3])
    {
        result += (scores[1] - scores[3]) * 212;
    }

    else
    {
        result += (scores[3] - scores[1]) * 305;
    }
}

else if (t == 5)
{
    if (scores[0] > scores[2])
    {
        result += (scores[0] - scores[2]) * 508;
    }

    else
    {
        result += (scores[2] - scores[0]) * 108;
    }

    if (scores[1] > scores[3])
    {
        result += (scores[1] - scores[3]) * 212;
    }

    else
    {
        result += (scores[3] - scores[1]) * 305;
    }

    result += scores[4] * 707;
}

result *= 4763;
Console.WriteLine(result);
