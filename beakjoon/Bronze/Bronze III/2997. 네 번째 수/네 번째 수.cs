string[] nums = Console.ReadLine().Split(" ");
int[] abc = new int[3];
for (int i = 0; i < 3; i++) { abc[i] = int.Parse(nums[i]); }
Array.Sort(abc);

int n = abc[1] - abc[0];
int n2 = abc[2] - abc[1];

if (n == n2) { Console.WriteLine(abc[2] + n); }
else if (n < n2) { Console.WriteLine(abc[1] + n); }
else { Console.WriteLine(abc[0] + n2); } 
