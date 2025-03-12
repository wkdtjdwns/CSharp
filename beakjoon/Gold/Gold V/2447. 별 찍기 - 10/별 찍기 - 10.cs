// 골드부터는 풀이 과정을 주석으로 달아두려고 함. (되도록이면)
// 해당 문제는 분할 정복을 활용해서 풀 것임.

using System.Text;

int n = int.Parse(Console.ReadLine());
char[,] board = new char[n, n]; // 별을 찍을 보드

// 재귀함수 시작
Star(0, 0, n, false);

StringBuilder sb = new StringBuilder();
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        sb.Append(board[i, j]);
    }

    sb.AppendLine();
}

Console.WriteLine(sb);

void Star(int x, int y, int n, bool isBlank)
{
    // 공백이여야 하면 공백 찍기
    if (isBlank)
    {
        for (int i = x; i < x + n; i++)
        {
            for (int j = y; j < y + n; j++)
            {
                board[i, j] = ' ';
            }
        }

        return;
    }

    // 더 이상 블록을 쪼갤 수 없으면 별을 찍고 끝냄.
    if (n == 1)
    {
        board[x, y] = '*';
        return;
    }

    int size = n / 3; // 한 블록의 사이즈
    /*
     * 1번째 n: 27 -> size = 9
     * 2번째 n: 9 -> size = 3
     * 3번째 n: 3 -> size = 1
     * 4번째 n: 1 -> return
     */

    int cnt = 0; // 별 개수 누적 합
    for (int i = x; i < x + n; i += size)
    {
        for (int j = y; j < y + n; j += size)
        {
            cnt++;
            if (cnt == 5)
            {
                /*
                 * cnt가 5면 3 X 3 블록에서 중앙에 해당하는 부분임 -> 공백!
                 * O O O
                 * O X <- 이 부분이 cnt가 5일 때의 부분!
                 */

                Star(i, j, size, true);
            }

            else
            {
                Star(i, j, size, false);
            }
        }
    }
}
