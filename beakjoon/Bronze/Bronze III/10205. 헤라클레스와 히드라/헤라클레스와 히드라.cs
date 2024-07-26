int k = int.Parse(Console.ReadLine());
for (int i = 1; i <= k; i++)
{
    int h = int.Parse(Console.ReadLine());
    string str = Console.ReadLine();

    foreach (char c in str)
    {
        if (c == 'c') { h++; }
        else { h--; }
    }

    Console.WriteLine("Data Set " + i + ":");
    Console.WriteLine(h + "\n");
}
