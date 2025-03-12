// 골드부터는 풀이 과정을 주석으로 달아두려고 함. (되도록이면)

string[] nrc = Console.ReadLine().Split(" ");
int n = int.Parse(nrc[0]);
int r = int.Parse(nrc[1]);
int c = int.Parse(nrc[2]);

int result = 0;

// 해당 문제는 보드를 4개의 사분면으로 나눠서 분할정복해 풀이하려고 함.
Search(0, 0, (int)Math.Pow(2, n));

void Search(int x, int y, int n)
{
    // 목표 지점 찾음
    if (x == c && y == r)
    {
        Console.WriteLine(result);
        return;
    }

    // 목표 지점이 n사분면에 포함 됨
    if (c < x + n && c >= x && r < y + n && r >= y)
    {
        // 그럼 그 n사분면을 4개의 사분면으로 다시 쪼개서 탐색함. (재귀함수)

        Search(x, y, n / 2);                    // 1사분면
        Search(x + n / 2, y, n / 2);            // 2사분면
        Search(x, y + n / 2, n / 2);            // 3사분면
        Search(x + n / 2, y + n / 2, n / 2);    // 4사분면
    }

    // 포함 되지 않으면 다른 면으로 이동 (이동 거리 = n * n)
    else
    {
        result += n * n;
    }
}
