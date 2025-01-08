#ifndef ARRAYGEN_H
#define ARRAYGEN_H
#include <vector>

class ArrayGen {
public:
	explicit ArrayGen();
	virtual std::vector<int> generate(int x, int seed) = 0;
	void printVector(std::vector<int> arr);
};

#endif
