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

    int k, q; int time = 0; cin >> k >> q;
    while (q--)
    {
        int t; char result; cin >> t >> result;
        time += t;
        if (time >= 210)
        {
            cout << k;
            break;
        }

        if (result == 'T')
        {
            k++;
            if (k == 9) {
                k = 1;
            }
        }
    }

    return 0;
}
