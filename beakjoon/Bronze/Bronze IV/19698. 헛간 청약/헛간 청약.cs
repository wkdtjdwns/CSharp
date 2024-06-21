string[] nwhl = Console.ReadLine().Split(" ");
int n = int.Parse(nwhl[0]);
int w = int.Parse(nwhl[1]);
int h = int.Parse(nwhl[2]);
int l = int.Parse(nwhl[3]);

int result = (w / l) * (h / l);
Console.WriteLine(result > n ? n : result);
