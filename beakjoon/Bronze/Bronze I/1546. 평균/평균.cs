int n = int.Parse(Console.ReadLine());
string[] numsInput = Console.ReadLine().Split(" ");
double[] nums = new double[n];
for (int i = 0; i < n; i++)
{
    nums[i] = double.Parse(numsInput[i]);
}

double m = nums[0];
for (int i = 1; i < n; i++)
{
    m = Math.Max(nums[i], m);
}

double avg = 0;
for (int i = 0; i < n; i++)
{
    nums[i] = nums[i] / m * 100;
    avg += nums[i];
}

Console.WriteLine(avg / n);
