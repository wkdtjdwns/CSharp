while (true)
{
    string input = Console.ReadLine();
    if (input == null) {
        break;
    }

    string[] ab = input.Split();

    int a = int.Parse(ab[0]);
    int b = int.Parse(ab[1]);

    Console.WriteLine(a + b);
}
