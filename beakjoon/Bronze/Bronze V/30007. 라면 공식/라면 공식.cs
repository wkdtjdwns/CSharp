int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    string[] input = Console.ReadLine().Split(" ");
    int a = int.Parse(input[0]);
    int b = int.Parse(input[1]);
    int x = int.Parse(input[2]);

    Console.WriteLine(a * (x - 1) + b);
}
