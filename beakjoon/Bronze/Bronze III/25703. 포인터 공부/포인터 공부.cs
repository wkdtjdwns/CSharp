int n = int.Parse(Console.ReadLine());
Console.WriteLine("int a;");
Console.WriteLine("int *ptr = &a;");
for (int i = 2; i <= n; i++)
{
    Console.Write("int ");
    for (int j = 0; j < i; j++)
    {
        Console.Write("*");
    }

    Console.WriteLine("ptr" + i + " = &ptr" + (i - 1 == 1 ? "" : i - 1) + ";");
}
