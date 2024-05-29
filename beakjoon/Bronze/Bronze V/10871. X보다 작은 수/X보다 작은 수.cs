string[] input = Console.ReadLine().Split(" ");
int N = int.Parse(input[0]);
int X = int.Parse(input[1]);

string[] nums = Console.ReadLine().Split(" ");

for (int i = 0; i < nums.Length ; i++)
{
    if ( X > int.Parse(nums[i]) )
    {
        Console.Write(nums[i] + " ");
    }
}
