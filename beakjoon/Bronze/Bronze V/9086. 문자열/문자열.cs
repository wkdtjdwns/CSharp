int T = int.Parse(Console.ReadLine());

for (int i = 0; i < T; i++)
{
    string str = Console.ReadLine();
    char start = str[0];
    char end = str[str.Length - 1];

    Console.WriteLine($"{start}{end}");
}
