#include "NearlySorted.hpp"
#include <vector>
using namespace std;

vector<int> NearlySorted::generate(int x, int seed) {
	vector<int> tab(x);
	
	for (int i = 0; i < x; i++) {
		tab[i] = i;
	}	

	if(x > 2) {
		int temp = tab[0];
		tab[0] = tab[x -1];
		tab[x - 1] = temp;
	}

	return tab;

}
