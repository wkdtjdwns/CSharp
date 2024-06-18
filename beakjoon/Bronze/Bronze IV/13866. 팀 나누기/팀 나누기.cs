string[] abcd = Console.ReadLine().Split(" ");
int a = int.Parse(abcd[0]);
int b = int.Parse(abcd[1]);
int c = int.Parse(abcd[2]);
int d = int.Parse(abcd[3]);

Console.WriteLine(Math.Abs((a + d) - (b + c)));
