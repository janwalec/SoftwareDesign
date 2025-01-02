#include "bubble.hpp"

using namespace std;

vector<int> BubbleSort::sort(vector<int> unsorted) {
	int size = unsorted.size();
	int temp;
	for (int i = 0; i < size - 1; i++){
		for (int j = 0; j + i < size; j++) {
			if(unsorted[j] > unsorted[j + 1]) {
				temp = unsorted[j];
				unsorted[j] = unsorted[j+1];
				unsorted[j+1] = temp;
			}
		}
	}
	return unsorted;
}
