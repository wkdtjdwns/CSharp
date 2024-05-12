while (true)
{
    int blocks = 0;
    int n = int.Parse(Console.ReadLine());
    if (n == 0) break;

    blocks = n * (n + 1) / 2;

    Console.WriteLine(blocks);
}
