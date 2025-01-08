#ifndef NEARLY_H
#define NEARLY_H
#include "ArrayGen.hpp"
#include <vector>

class NearlySorted : public ArrayGen {
	using ArrayGen::ArrayGen;
 	std::vector<int> generate(int x, int seed) override;	
};	


#endif
