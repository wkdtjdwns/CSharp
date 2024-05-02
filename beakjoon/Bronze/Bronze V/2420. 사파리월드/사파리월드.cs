string[] input = Console.ReadLine().Split(' ');

long N = long.Parse(input[0]);
long M = long.Parse(input[1]);

Console.WriteLine(Math.Abs(N - M));
