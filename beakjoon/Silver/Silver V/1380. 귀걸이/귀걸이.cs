int scenario = 0;
while (true)
{
    int n = int.Parse(Console.ReadLine());
    if (n == 0)
    {
        return;
    }

    else
    {
        scenario++;
    }

    List<string> girls = new List<string>();
    for (int i = 0; i < n; i++)
    {
        girls.Add(Console.ReadLine());
    }

    List<int> isNum = new List<int>();
    for (int i = 0; i < n * 2 - 1; i++)
    {
        string[] nums = Console.ReadLine().Split();
        int num = int.Parse(nums[0]);

        if (isNum.Contains(num))
        {
            isNum.Remove(num);
        }
        else
        {
            isNum.Add(num);
        }
    }

    int resultgirl = isNum[0];
    Console.WriteLine($"{scenario} {girls[resultgirl - 1]}");
}
