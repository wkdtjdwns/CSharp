# [내접사각형 만들기](https://www.acmicpc.net/problem/17177)

| 시간 제한 | 메모리 제한 | 제출 | 정답 | 맞힌 사람 | 정답 비율 |
| --- | --- | --- | --- | --- | --- |
| 1 초 | 512 MB | 705 | 398 | 352 | 57.423% |

## 문제

어떤 사각형의 네 꼭짓점이 원과 접할 때 이 사각형이 원에 내접한다고 한다. 세 선분의 길이가 주어지고 그중 가장 긴 선분의 길이가 내접할 원의 지름과 같을 때, 나머지 한 선분의 길이를 구하여라.

## 입력

첫 번째 줄에 세 변의 길이를 나타내는 세 정수 *a, b, c*가 주어진다. (1 ≤ *a, b, c* ≤ 100) 세 선분은 내림차순으로 주어진다.

## 출력

첫째 줄에 나머지 한 변의 길이를 출력한다. 원에 내접하는 사각형을 만들 수 없다면 -1을 출력한다. 단, 정답은 정수로 나오는 케이스만 주어진다.

## 예제 입력 1

```
2 1 1

```

## 예제 출력 1

```
1

```

## 예제 입력 2

```
1 1 1

```

## 예제 출력 2

```
-1

```

## 예제 입력 3

```
72 42 23

```

## 예제 출력 3

```
42

```

## 힌트

톨레미의 정리에 따르면 다음과 같이 원에 내접한 사각형은 마주 보는 두 쌍의 변의 곱의 합이 두 대각선의 곱과 같다.

![image](https://upload.acmicpc.net/8b70f09f-8fcb-4586-a960-6727a8b6883e/-/preview/)

![image](https://upload.acmicpc.net/06cf225b-0767-4de3-a176-528d45773366/-/preview/)
