while (true)
{
    string[] ab = Console.ReadLine().Split(" ");
    int a = int.Parse(ab[0]);
    int b = int.Parse(ab[1]);

    if (a == 0 && b == 0) { break; }

    Console.WriteLine(a / b + " " + a % b + " / " + b);
}
