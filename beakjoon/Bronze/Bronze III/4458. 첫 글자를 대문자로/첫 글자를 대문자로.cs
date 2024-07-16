int t = int.Parse(Console.ReadLine());
for (int i = 0; i < t; i++)
{
    string str = Console.ReadLine();
    Console.Write(str[0].ToString().ToUpper());
    for (int j = 1; j < str.Length; j++)
    {
        Console.Write(str[j]);
    }

    Console.WriteLine();
}
