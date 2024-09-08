int getResult(int a, int b)
{
    while (b != 0)
    {
        int temp = a % b;
        a = b;
        b = temp;
    }

    return a;
}

string[] ab = Console.ReadLine().Split(" ");
int a = int.Parse(ab[0]);
int b = int.Parse(ab[1]);

int result = getResult(a, b);
Console.WriteLine(result);
Console.WriteLine(a * b / result);
