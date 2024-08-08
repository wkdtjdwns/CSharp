string[] lrb = Console.ReadLine().Split(" ");
int l = int.Parse(lrb[0]);
int r = int.Parse(lrb[1]);
int b = int.Parse(lrb[2]);

int sum = l + r + b;
int temp = b - Math.Abs(l - r);

Console.WriteLine(temp >= 0 ? sum - temp % 2 : sum - Math.Abs(temp));
