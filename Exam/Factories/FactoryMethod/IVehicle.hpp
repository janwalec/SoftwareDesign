#ifndef IVEHICLE_H
#define IVEHICLE_H

#include <iostream>

class IVehicle {
public:
	explicit IVehicle() {};
	virtual void drive() = 0;
};

#endif
