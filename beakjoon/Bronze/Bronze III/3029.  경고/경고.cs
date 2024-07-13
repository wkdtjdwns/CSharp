string[] time1 = Console.ReadLine().Split(":");
string[] time2 = Console.ReadLine().Split(":");

int hour = int.Parse(time2[0]) - int.Parse(time1[0]);
int min = int.Parse(time2[1]) - int.Parse(time1[1]);
int sec = int.Parse(time2[2]) - int.Parse(time1[2]);

while (sec < 0)
{
    sec += 60;
    min--;
}

while (min < 0)
{
    min += 60;
    hour--;
}

while (hour < 0) { hour += 24; }

if (hour == 0 && min == 0 && sec == 0) { hour = 24; }

Console.WriteLine(hour.ToString("00") + ":" + min.ToString("00") + ":" +  sec.ToString("00"));
