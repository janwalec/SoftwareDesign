#ifndef BUBBLE_H
#define BUBBLE_H

#include "ISort.hpp"
#include <vector>

class BubbleSort : public ISort {
public:
	using ISort::ISort;
	std::vector<int> sort(std::vector<int> unsorted) override;
};

#endif
