double result = double.Parse(Console.ReadLine());
while (true)
{
    double n = double.Parse(Console.ReadLine());
    if (n == 999) { break; }

    Console.WriteLine((n - result).ToString("F2"));
    result = n;
}
