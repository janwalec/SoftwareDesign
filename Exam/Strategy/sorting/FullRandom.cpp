#include "FullRandom.hpp"
#include <vector>
#include <cstdlib>
#include <ctime>
using namespace std;

vector<int> FullRandom::generate(int x, int seed) {
	srand(std::time(NULL));
	vector<int> tab(x);
	
	for (int i = 0; i < x; i++) {
		tab[i] = rand() % seed + 1;
	}

	return tab;

}

