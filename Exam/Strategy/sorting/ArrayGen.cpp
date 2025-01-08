#include "ArrayGen.hpp"
#include <iostream>

using namespace std;

ArrayGen::ArrayGen() {}


void ArrayGen::printVector(vector<int> arr) {
	for (int i : arr) 
		cout << i << ' ';
	cout << endl;
}
