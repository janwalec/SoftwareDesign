#ifndef ARRAYGEN_H
#define ARRAYGEN_H
#include <vector>

class ArrayGen {
public:
	ArrayGen();
	std::vector<int> generate(int x, int seed);
	void printVector(std::vector<int> arr);
};

#endif
