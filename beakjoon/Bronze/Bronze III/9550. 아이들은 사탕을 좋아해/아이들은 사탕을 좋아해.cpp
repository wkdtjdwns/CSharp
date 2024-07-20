#include <iostream>
#include <algorithm>
#include <string>
#include <vector>
#include <cmath>
#define ll long long
#define fastIo ios_base::sync_with_stdio(0); cin.tie(0); cout.tie(0);
using namespace std;

int main() {
	fastIo;
	
	int t, n, k, temp, cnt; cin >> t;
	for (int i = 0; i < t; ++i) {
		cin >> n >> k;
		cnt = 0;
		for (int j = 0; j < n; ++j) {
			cin >> temp;
			while (temp >= k) {
				cnt++;
				temp -= k;
			}
		}

		cout << cnt << "\n";
	}

    return 0;
}
