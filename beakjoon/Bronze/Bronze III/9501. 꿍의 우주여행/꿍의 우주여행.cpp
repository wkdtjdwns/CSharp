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

    int t; cin >> t;
    while (t--)
    {
        int n, d, result = 0; cin >> n >> d;
        while (n--)
        {
            int vi, fi, ci; cin >> vi >> fi >> ci;
            
            if (vi * fi / ci >= d) {
                result++;
            }
        }

        cout << result << '\n';
    }

    return 0;
}
