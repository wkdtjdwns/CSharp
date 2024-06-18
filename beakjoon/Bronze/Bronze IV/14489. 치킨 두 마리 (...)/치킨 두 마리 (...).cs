string[] ab = Console.ReadLine().Split(" ");
int a = int.Parse(ab[0]);
int b = int.Parse(ab[1]);
int c = int.Parse(Console.ReadLine());

int result = ((a + b) >= (c * 2)) ? (a + b) - (c * 2) : (a + b);
Console.WriteLine(result);
