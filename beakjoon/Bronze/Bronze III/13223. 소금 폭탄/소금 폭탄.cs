string[] cur = Console.ReadLine().Split(":");
int curH = int.Parse(cur[0]);
int curM = int.Parse(cur[1]);
int curS = int.Parse(cur[2]);
int curSecond = curH * 3600 + curM * 60 + curS;

string[] salt = Console.ReadLine().Split(":");
int saltH = int.Parse(salt[0]);
int saltM = int.Parse(salt[1]);
int saltS = int.Parse(salt[2]);
int saltSecond = saltH * 3600 + saltM * 60 + saltS;

int need = saltSecond - curSecond;
if (need <= 0)
{
    need += 24 * 3600;
}

Console.WriteLine((need / 3600).ToString("00") + ":" + ((need % 3600) / 60).ToString("00") + ":" + (need % 60).ToString("00"));
