#ifndef ISORT_H
#define ISORT_H

#include <vector>

class ISort {
public:
	explicit ISort();
	virtual std::vector<int> sort(std::vector<int> unsorted) = 0;
};

#endif
