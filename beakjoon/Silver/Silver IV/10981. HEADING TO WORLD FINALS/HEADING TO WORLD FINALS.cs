string[] nk = Console.ReadLine().Split(" ");
int n = int.Parse(nk[0]);
int k = int.Parse(nk[1]);

List<(string university, string team, int solved, int penalty)> teams = new List<(string, string, int, int)>();
for (int i = 0; i < n; i++)
{
    string[] teamInfo = Console.ReadLine().Split(" ");
    teams.Add((teamInfo[0], teamInfo[1], int.Parse(teamInfo[2]), int.Parse(teamInfo[3])));
}

List<(string university, string team, int solved, int penalty)> topTeams = teams
    .GroupBy(t => t.university)
    .Select(g => g.OrderByDescending(t => t.solved).ThenBy(t => t.penalty).First())
    .ToList();

IEnumerable<(string university, string team, int solved, int penalty)> result = topTeams
    .OrderByDescending(t => t.solved)
    .ThenBy(t => t.penalty)
    .Take(k);

foreach (var team in result)
{
    Console.WriteLine(team.team);
}
