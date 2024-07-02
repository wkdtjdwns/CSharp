string[] whxy = Console.ReadLine().Split(" ");
int x = int.Parse(whxy[0]);
int y = int.Parse(whxy[1]);
int w = int.Parse(whxy[2]);
int h = int.Parse(whxy[3]);

Console.WriteLine(Math.Min(Math.Min(Math.Min(x, y), w - x), h - y));
