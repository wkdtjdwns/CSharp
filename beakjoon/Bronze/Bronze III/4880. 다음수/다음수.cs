while (true)
{
    string[] abc = Console.ReadLine().Split(" ");
    int a = int.Parse(abc[0]);
    int b = int.Parse(abc[1]);
    int c = int.Parse(abc[2]);
    if (a == 0 && b == 0 && c == 0) { break; }

    if (b - a == c - b) { Console.WriteLine("AP " + (c + b - a)); }
    else if (b / a == c / b) { Console.WriteLine("GP " + (c * b / a)); }
}
