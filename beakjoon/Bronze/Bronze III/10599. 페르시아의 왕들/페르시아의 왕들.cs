while (true)
{
    string[] abcd = Console.ReadLine().Split(" ");
    int a = int.Parse(abcd[0]);
    int b = int.Parse(abcd[1]);
    int c = int.Parse(abcd[2]);
    int d = int.Parse(abcd[3]);

    if (a == 0 && b == 0 && c == 0 && d == 0) { break; }
    Console.WriteLine((c - b) + " " + (d - a));
}
