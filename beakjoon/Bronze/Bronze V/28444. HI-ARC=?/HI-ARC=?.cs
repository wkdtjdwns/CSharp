string[] input = Console.ReadLine().Split(" ");
int h = int.Parse(input[0]);
int i = int.Parse(input[1]);
int a = int.Parse(input[2]);
int r = int.Parse(input[3]);
int c = int.Parse(input[4]);

Console.WriteLine((h * i) - (a * r * c));
