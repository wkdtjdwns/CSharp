string str = Console.ReadLine();
int[] alpha = new int[26];

foreach (char c in str)
{
    alpha[c - 'a']++;
}

for  (int i = 0; i < alpha.Length; i++)
{
    Console.Write(alpha[i] + " ");
}
