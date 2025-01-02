#ifndef SHELL_H
#define SHELL_H
#include <vector>
#include "ISort.hpp"


class ShellSort : public ISort {
	using ISort::ISort;
	std::vector<int> sort(std::vector<int> unsorted) override;

};


#endif
