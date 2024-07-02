string[] xy = Console.ReadLine().Split(" ");
int x = int.Parse(xy[0]);
int y = int.Parse(xy[1]);

int xw = (x - 1) / 4;
int yw = (y - 1) / 4;

int xh = (x - 1) % 4;
int yh = (y - 1) % 4;

Console.WriteLine(Math.Abs(xw - yw) + Math.Abs(xh - yh));
