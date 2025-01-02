#include "shellsort.hpp"
#include <vector>

using namespace std;

vector<int> ShellSort::sort(vector<int> unsorted) {
	int size = unsorted.size();
	int temp;

	for(int gap = size/2; gap > 0; gap /= 2) {
		for (int i = gap; i < size; i += 1) {
            		int temp = unsorted[i];
            		int j;            
            		for (j = i; j >= gap && unsorted[j - gap] > temp; j -= gap)
                		unsorted[j] = unsorted[j - gap];
            
           	 	unsorted[j] = temp;
		}		
	}
	return unsorted;
}
