string[] axyz = Console.ReadLine().Split(" ");
int ax = int.Parse(axyz[0]);
int ay = int.Parse(axyz[1]);
int az = int.Parse(axyz[2]);

string[] cxyz = Console.ReadLine().Split(" ");
int cx = int.Parse(cxyz[0]);
int cy = int.Parse(cxyz[1]);
int cz = int.Parse(cxyz[2]);

Console.WriteLine( (cx - az) + " " + (cy / ay) + " " + (cz - ax) );
