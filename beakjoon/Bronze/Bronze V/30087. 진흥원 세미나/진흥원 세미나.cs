var seminars = new Dictionary<string, string>();
seminars.Add("Algorithm", "204");
seminars.Add("DataAnalysis", "207");
seminars.Add("ArtificialIntelligence", "302");
seminars.Add("CyberSecurity", "B101");
seminars.Add("Network", "303");
seminars.Add("Startup", "501");
seminars.Add("TestStrategy", "105");

int n = int.Parse(Console.ReadLine());
for (int i = 0; i < n; i++)
{
    string s = Console.ReadLine();
    Console.WriteLine(seminars[s]);
}
