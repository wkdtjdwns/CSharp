string[] nlh = Console.ReadLine().Split(" ");
int n = int.Parse(nlh[0]);
int l = int.Parse(nlh[1]);
int h = int.Parse(nlh[2]);

int[] nums = Array.ConvertAll(Console.ReadLine().Split(" "), int.Parse);
Array.Sort(nums);

double result = 0;
for (int i = l; i < n - h; i++)
{
    result += nums[i];
}

Console.WriteLine(result / (n - l - h));
