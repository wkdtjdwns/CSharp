# [심준의 병역판정검사](https://www.acmicpc.net/problem/25285)

| 시간 제한 | 메모리 제한 | 제출 | 정답 | 맞힌 사람 | 정답 비율 |
| --- | --- | --- | --- | --- | --- |
| 2 초 | 1024 MB | 1821 | 887 | 756 | 52.102% |

## 문제

병역판정검사는 병역의무자들의 상태를 검사해 징병 여부와 징병 시 어느 방향으로 복무를 시키는 게 좋을지 판정하는 검사로, 남성들은 만 19세가 되는 해에 모두 병역판정검사를 받는다. 신체 등급이 1급부터 3급인 사람은 현역 입영 대상, 4급은 보충역, 5급은 전시근로역, 6급은 병역면제 처분을 받는다.

올해 20살이 된 준이와 친구들은 병역판정검사를 받아야 한다. 준이와 친구들은 매우 건강하기 때문에 다른 질병의 유무와 관계 없이 신장 및 체중으로만 신체 등급이 결정된다. 준이와 친구들의 신장과 체중이 주어지면 아래 표를 참고해 신체 등급을 알려주자.

| ↓신장(cm), 등급 → | 1급 | 2급 | 3급 | 4급 | 5급 | 6급 |
| --- | --- | --- | --- | --- | --- | --- |
| 140.1 미만 |  |  |  |  |  | 체중과
관계없이
6급 |
| 140.1 이상 146 미만 |  |  |  |  | 체중과관계없이5급 |  |
| 146 이상 159 미만 |  |  |  | 체중과관계없이4급 |  |  |
| 159 이상 161 미만 |  |  | 16.0 이상 35.0 미만 | 16.0 미만또는35.0 이상 |  |  |
| 161 이상 204 미만 | 20.0 이상 25.0 미만 | 18.5 이상 20.0 미만또는25.0 이상 30.0 미만 | 16.0 이상 18.5 미만또는30.0 이상 35.0 미만 | 16.0 미만또는35.0 이상 |  |  |
| 204 이상 |  |  |  | 체중과관계없이4급 |  |  |

## 입력

첫째 줄에 병역판정검사를 받는 사람의 수 T 가 주어진다. (1 ≤ T ≤ 200)

둘째 줄부터 T개의 줄에 키와 몸무게가 각각 cm, kg 단위로 주어진다.

입력으로 주어지는 수는 모두 200 이하의 양의 정수이다.

## 출력

각 사람의 신체 등급을 한 줄에 하나씩 순서대로 출력한다.

## 예제 입력 1

```
6
175 65
175 60
175 49
175 48
145 50
140 45

```

## 예제 출력 1

```
1
2
3
4
5
6

```

키 175cm, 몸무게 49kg인 사람은 BMI 49 / 1.752 = 16.0으로 3급 판정을 받는다.

## 힌트

C, C++, Java에서 정수를 정수로 나눈 결과는 정수이므로 float와 double 같은 실수 자료형을 이용해 BMI를 계산해야 한다.
