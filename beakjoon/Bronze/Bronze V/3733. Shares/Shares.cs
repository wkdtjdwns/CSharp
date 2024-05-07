List<string> inputList = new List<string>();

while (true)
{
    string input = Console.ReadLine();

    if (string.IsNullOrEmpty(input)) break;

    inputList.Add(input);
}

for (int i = 0; i < inputList.Count; i++)
{
    string[] split = inputList[i].Split();

    int N = int.Parse(split[0]);
    int S = int.Parse(split[1]);

    Console.WriteLine(S / (N + 1));
}
