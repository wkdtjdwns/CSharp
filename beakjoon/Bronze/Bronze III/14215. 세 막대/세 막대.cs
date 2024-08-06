string[] abc = Console.ReadLine().Split(" ");
int[] abcValues = {
    int.Parse(abc[0]),
    int.Parse(abc[1]),
    int.Parse(abc[2])
};

Array.Sort(abcValues);
if (abcValues[0] + abcValues[1] > abcValues[2])
{
    Console.Write(abcValues[0] + abcValues[1] + abcValues[2]);
}

else
{
    Console.Write((abcValues[0] + abcValues[1]) * 2 - 1);
}
