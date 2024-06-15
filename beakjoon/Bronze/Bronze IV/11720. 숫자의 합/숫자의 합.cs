int n = int.Parse(Console.ReadLine());
string nums = Console.ReadLine();

int sum = 0;
for  (int i = 0; i < n; i++)
{
    sum += int.Parse(nums[i].ToString());
}

Console.WriteLine(sum);
