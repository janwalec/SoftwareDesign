#ifndef FULLRANDOM_H
#define FULLRANDOM_H
#include "ArrayGen.hpp"
#include <vector>

class FullRandom : public ArrayGen {
	using ArrayGen::ArrayGen;
	std::vector<int> generate(int x, int seed) override;
	
		
	

};


#endif
