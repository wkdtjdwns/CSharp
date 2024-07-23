int n = int.Parse(Console.ReadLine());
for (int i = 1; i <= n; i++)
{
    string str = Console.ReadLine();
    Console.WriteLine("String #" + i);

    foreach (char c in str)
    {
        char alpha = (char)(c + 1);

        if (alpha > 90) { alpha -= (char)26; }
        Console.Write(alpha);
    }

    Console.WriteLine("\n");
}
