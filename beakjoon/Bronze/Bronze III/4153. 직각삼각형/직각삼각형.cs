while (true)
{
    string[] abc = Console.ReadLine().Split(" ");
    int a = int.Parse(abc[0]);
    int b = int.Parse(abc[1]);
    int c = int.Parse(abc[2]);

    if (a + b + c == 0) { break; }
    if (a * a + b * b == c * c) { Console.WriteLine("right"); }
    else if (b * b + c * c == a * a) { Console.WriteLine("right"); }
    else if (c * c + a * a == b * b) { Console.WriteLine("right"); }
    else { Console.WriteLine("wrong"); }
}
