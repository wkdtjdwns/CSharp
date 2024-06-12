string[] input = Console.ReadLine().Split(" ");
int a = int.Parse(input[0]);
int b = int.Parse(input[1]);
int c = int.Parse(input[2]);

int d =  int.Parse(Console.ReadLine());

c += d;
b += c / 60;
c %= 60;

a += b / 60;
b %= 60;
a %= 24;

Console.WriteLine(a + " " + b + " " + c);
