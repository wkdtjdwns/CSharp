# [HEADING TO WORLD FINALS](https://www.acmicpc.net/problem/10981)

| 시간 제한 | 메모리 제한 | 제출 | 정답 | 맞힌 사람 | 정답 비율 |
| --- | --- | --- | --- | --- | --- |
| 1 초 | 128 MB | 772 | 329 | 234 | 43.494% |

## 문제

보통 한국 대학생 프로그래밍 경시대회(ACM-ICPC Daejeon Regional)에서는 상위 2개의 대학이 세계 대회 격인 ACM-ICPC World Finals 에 참가할 수 있는 자격을 얻는다. ICPC대회는 많은 문제를 풀 수록, 푼 문제 수가 같으면 Penalty가 작을 수록 순위가 높다. 각 대학별 가장 순위가 높은 1팀만 World Finals에 진출할 수 있다.

N개의 팀이 참가한 ICPC Regional에서 K개의 대학이 World Finals 에 진출할 수 있다고 할 때 그 영광의 팀들은 어디일지 출력하자.

## 입력

첫 줄에, 팀 수 N과 World Finals에 진출할 대학의 수인 K가 주어진다. (1 ≤ N ≤ 100000, 1 ≤ K ≤ 100)

그 다음 N개의 줄에는 참가한 각 팀의 정보가 다음 형식으로 주어진다. (대학명 팀이름 푼문제수 페널티)

대학명과 팀이름은 한 단어로 주어지며, 길이는 30을 넘지 않는다. 임의의 두 팀은 푼 문제수 혹은 페널티가 다름이 보장된다.

## 출력

World Finals에 진출할 K개의 팀 이름을 높은 순위부터 한 줄에 하나씩 출력한다. 입력으로 주어지는 팀 목록에는 적어도 K개의 대학이 있음을 보장한다.

## 예제 입력 1

```
10 2
KAIST OriGoGi 10 1184
Seoul_Univ Wook_Norris 8 594
Yonsei_Univ Underwood 8 806
Seoul_Univ cpp 10 1148
Korea_Univ Let_Myungwoo_go_WF 10 1323
Seoul_Univ crazy_bus_driver 8 1065
Peking_Univ Nornir 8 837
Seoul_Univ KimChiWarrior 8 836
Hanyang_Univ StyleShare 8 1109
POSTECH CHOCOLATE 8 1085

```

## 예제 출력 1

```
cpp
OriGoGi

```

## 예제 입력 2

```
10 3
KAIST OriGoGi 10 1184
Seoul_Univ Wook_Norris 8 594
Yonsei_Univ Underwood 8 806
Seoul_Univ cpp 10 1148
Korea_Univ Let_Myungwoo_go_WF 10 1323
Seoul_Univ crazy_bus_driver 8 1065
Peking_Univ Nornir 8 837
Seoul_Univ KimChiWarrior 8 836
Hanyang_Univ StyleShare 8 1109
POSTECH CHOCOLATE 8 1085

```

## 예제 출력 2

```
cpp
OriGoGi
Let_Myungwoo_go_WF
```
