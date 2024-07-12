string[] abcd = Console.ReadLine().Split(" ");
int a = int.Parse(abcd[0]);
int b = int.Parse(abcd[1]);
int c = int.Parse(abcd[2]);
int d = int.Parse(abcd[3]);
int[] deliver = new int[3];
int[] result = new int[3];

string[] delivers = Console.ReadLine().Split(" ");
for (int i = 0; i < 3; i++)
{
    
    deliver[i] = int.Parse(delivers[i]);
    int dog1 = deliver[i] % (a + b);
    int dog2 = deliver[i] % (c + d);

    if (dog1 <= a && dog1 != 0)
    {
        result[i]++;
    }

    if (dog2 <= c && dog2 != 0)
    {
        result[i]++;
    }
}

for (int i = 0; i < 3; i++)
{
    Console.WriteLine(result[i]);
}
