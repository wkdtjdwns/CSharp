while (true)
{
    string[] ab = Console.ReadLine().Split(" ");
    int a = int.Parse(ab[0]);
    int b = int.Parse(ab[1]);
    if (a + b == 0) { break; }

    if (a % b == 0) { Console.WriteLine("multiple"); }
    else if (b % a == 0) { Console.WriteLine("factor"); }
    else { Console.WriteLine("neither"); }
}
