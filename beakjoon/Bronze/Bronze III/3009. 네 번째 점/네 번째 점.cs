string[] xy = Console.ReadLine().Split(" ");
int[] xy1 = { int.Parse(xy[0]), int.Parse(xy[1]) };

xy = Console.ReadLine().Split(" ");
int[] xy2 = { int.Parse(xy[0]), int.Parse(xy[1]) };

xy = Console.ReadLine().Split(" ");
int[] xy3 = { int.Parse(xy[0]), int.Parse(xy[1]) };

int x = 0;
int y = 0;

if (xy1[0] == xy2[0]) { x = xy3[0]; }
else if (xy1[0] == xy3[0]) { x = xy2[0]; }
else { x = xy1[0]; }

if (xy1[1] == xy2[1]) { y = xy3[1]; }
else if (xy1[1] == xy3[1]) { y = xy2[1]; }
else { y = xy1[1]; }

Console.WriteLine(x + " " + y); 
