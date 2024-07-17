while (true)
{
    string[] bn = Console.ReadLine().Split(" ");
    int b = int.Parse(bn[0]);
    int n = int.Parse(bn[1]);

    int num1 = 0;
    int num2 = 0;

    if (b == 0 && n == 0) { break; }

    int a = 0;
    while (true)
    {
        if (Math.Pow(a, n) <= b)
        {
            num1 = a;
        }

        else if (Math.Pow(a, n) > b)
        {
            num2 = a;
            break;
        }

        a++;
    }

    int result = (Math.Abs(Math.Pow(num1, n) - b) <= Math.Abs(Math.Pow(num2, n) - b)) ? num1 : num2;

    Console.WriteLine(result);
}
