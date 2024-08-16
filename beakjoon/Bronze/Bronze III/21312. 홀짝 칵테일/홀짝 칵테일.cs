string[] abc = Console.ReadLine().Split(" ");
int result = 1;
bool check = true;

for (int i = 0; i < 3; i++)
{
    int n = int.Parse(abc[i]);
    if (n % 2 == 1)
    {
        check = false;
        result *= n;
    }
}

if (check)
{
    Console.WriteLine(int.Parse(abc[0]) * int.Parse(abc[1]) * int.Parse(abc[2]));
}

else
{
    Console.WriteLine(result);
}
