#include "ArrayGen.hpp"
#include <cstdlib>
#include <ctime>
#include <iostream>

using namespace std;

ArrayGen::ArrayGen() {}

vector<int> ArrayGen::generate(int x, int seed) {
	srand(std::time(NULL));
	vector<int> tab(x);
	
	for (int i = 0; i < x; i++) {
		tab[i] = rand() % seed + 1;
	}

	return tab;

}

void ArrayGen::printVector(vector<int> arr) {
	for (int i : arr) 
		cout << i << ' ';
	cout << endl;
}
