string input;
while ((input = Console.ReadLine()) != null)
{
    string[] abc =  input.Split(" ");
    int a = int.Parse(abc[0]);
    int b = int.Parse(abc[1]);
    int c = int.Parse(abc[2]);

    Console.WriteLine((Math.Max(b - a, c - b) - 1));
}
