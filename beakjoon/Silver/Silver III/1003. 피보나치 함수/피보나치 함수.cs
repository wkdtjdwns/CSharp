int[,] nums = new int[41, 2];

void Fibonacci(int n)
{
    if (nums[n, 0] == 0 && nums[n, 1] == 0)
    {
        Fibonacci(n - 1);
        Fibonacci(n - 2);
        nums[n, 0] = nums[n - 1, 0] + nums[n - 2, 0];
        nums[n, 1] = nums[n - 1, 1] + nums[n - 2, 1];
    }
}

nums[0, 0] = 1;
nums[0, 1] = 0;
nums[1, 0] = 0;
nums[1, 1] = 1;

int t = int.Parse(Console.ReadLine());
while (t-- > 0)
{
    int n = int.Parse(Console.ReadLine());

    Fibonacci(n);
    Console.WriteLine(nums[n, 0] + " " + nums[n, 1]);
}
