#ifndef FACTORY_H
#define FACTORY_H
#include "IVehicle.hpp"
#include <iostream>


class Factory {
public:
	Factory();
	IVehicle* produce(std::string name);
};


#endif
