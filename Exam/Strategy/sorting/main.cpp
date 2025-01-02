#include <iostream>
#include "ArrayGen.hpp"
#include "ISort.hpp"
#include "bubble.hpp"
#include "shellsort.hpp"

using namespace std;

bool isSorted(vector<int> a) {
	int now = -1;
	for (int i : a) {
		if(now == -1) {
			now = 1;
			continue;
		}
		if (now > i) 
			return false;
		now = i;
	}
	return true;
}

using namespace std;
int main(void) {
	ArrayGen* a = new ArrayGen();
	vector arr = a->generate(10, 100);
	ISort* sorter1 = new BubbleSort();
	ISort* sorter2 = new ShellSort();

	a->printVector(arr);	
	cout << "sorted?:" << isSorted(arr) << endl;
	a->printVector(sorter1->sort(arr));
	cout << "sorted?:" << isSorted(arr) << endl;


	a->printVector(sorter2->sort(arr));
	
	
	delete a;
	delete sorter1;
	delete sorter2;
	return 0;
}
