while (true)
{
    string[] input = Console.ReadLine().Split();

    int num1 = int.Parse(input[0]);
    int num2 = int.Parse(input[1]);

    if (num1 + num2 == 0) break;

    if (num1 > num2) Console.WriteLine("Yes");
    else Console.WriteLine("No");
}
