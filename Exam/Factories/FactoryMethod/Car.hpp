#ifndef CAR_H
#define CAR_H
#include "IVehicle.hpp"

class Car : public IVehicle {
public:
	Car();
	void drive() override;
};


#endif
