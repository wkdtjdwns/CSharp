using System.Text;

int GetSquare(int a) { return a * a; }

int n = int.Parse(Console.ReadLine());
StringBuilder sb = new StringBuilder();
for (int i = 1; i <= n; ++i)
{
    string[] nums = Console.ReadLine().Split(' ');
    int a = int.Parse(nums[0]);
    int b = int.Parse(nums[1]);
    int c = int.Parse(nums[2]);

    sb.Append($"Scenario #{i}:\n");
    sb.Append((2 * GetSquare(Math.Max(Math.Max(a, b), c)) == (GetSquare(a) + GetSquare(b) + GetSquare(c))) ? "yes\n" : "no\n");
    if (i < n) sb.Append('\n');
}

Console.Write(sb);
