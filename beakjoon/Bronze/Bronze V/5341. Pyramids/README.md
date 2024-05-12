# [Pyramids [다국어]](https://www.acmicpc.net/problem/5341)

| 시간 제한 | 메모리 제한 | 제출 | 정답 | 맞힌 사람 | 정답 비율 |
| --- | --- | --- | --- | --- | --- |
| 1 초 | 128 MB | 4943 | 3501 | 3298 | 71.993% |

## 문제

A pyramid of blocks is constructed by first building a base layer of n blocks and then adding n-1 blocks to the next layer. This process is repeated until the top layer only has one block.

![image](https://github.com/wkdtjdwns/CSharp/assets/128266768/6f27faee-6177-4710-b4fa-c4d5967387c0)

You must calculate the number of blocks needed to construct a pyramid given the size of the base. For example, a pyramid that has a base of size 4 will need a total of 10 blocks.

## 입력

The input will be a sequence of integers, one per line. The end of input will be signaled by the integer 0, and does not represent the base of a pyramid. All integers, other than the last (zero), are positive.

## 출력

For each positive integer print the total number of blocks needed to build the pyramid with the specified base.

## 예제 입력 1

```
4
6
0
```

## 예제 출력 1

```
10
21
```
