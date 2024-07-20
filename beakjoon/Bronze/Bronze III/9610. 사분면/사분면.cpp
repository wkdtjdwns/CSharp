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

	int n, x, y; cin >> n;
	int result[5] = {};
	for (int i = 0; i < n; i++) {
		cin >> x >> y;

		if (x > 0 && y > 0) result[0]++;
		else if (x < 0 && y > 0) result[1]++;
		else if (x < 0 && y < 0) result[2]++;
		else if (x > 0 && y < 0) result[3]++;
		else result[4]++;

	}

	for (int i = 0; i < 4; i++) {
		cout << "Q" << i + 1 << ": " << result[i] << "\n";
	}

	cout << "AXIS: " << result[4] << "\n";

    return 0;
}
