while (true)
{
    string[] input = Console.ReadLine().Split(" ");
    string name = input[0];
    int age = int.Parse(input[1]);
    int weight = int.Parse(input[2]);
    if (name.Equals("#") && (age + weight) == 0)
    {
        break;
    }

    if (age > 17 || weight >= 80)
    {
        Console.WriteLine(name + " Senior");
    }

    else
    {
        Console.WriteLine(name + " Junior");
    }
}
