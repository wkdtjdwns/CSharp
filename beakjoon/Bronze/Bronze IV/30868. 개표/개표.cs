int t = int.Parse(Console.ReadLine());
for (int i = 0; i < t; i++)
{
    string result = "";
    int n = int.Parse(Console.ReadLine());
    for (int j = 0; j < n / 5; j++)
    {
        result += "++++ ";
    }

    for (int k = 0; k < n % 5; k++)
    {
        result += "|";
    }

    Console.WriteLine(result);
}
