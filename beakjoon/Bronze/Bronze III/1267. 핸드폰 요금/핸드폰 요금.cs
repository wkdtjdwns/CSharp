int n = int.Parse(Console.ReadLine());
string[] t = Console.ReadLine().Split(" ");
int[] nums = new int[n];
int y = 0;
int m = 0;

for (int i = 0; i < n; i++)
{
    nums[i] = int.Parse(t[i]);
    y += (nums[i] / 30 + 1) * 10;
    m += (nums[i] / 60 + 1) * 15;
}

if (m < y) { Console.WriteLine("M " + m); }
else if (m > y) { Console.WriteLine("Y " + y); }
else if (m == y) { Console.WriteLine("Y M " + m); }
