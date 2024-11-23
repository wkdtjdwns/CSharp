int x = int.Parse(Console.ReadLine());
int stick = 64;
int result = 0;

while (x > 0)
{
    if (stick > x)
    {
        stick /= 2;
    }

    else
    {
        x -= stick;
        result++;
    }
}

Console.WriteLine(result);
