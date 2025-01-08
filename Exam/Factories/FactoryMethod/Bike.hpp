#ifndef BIKE_H
#define BIKE_H
#include "IVehicle.hpp"


class Bike : public IVehicle {
public:
	using IVehicle::IVehicle;
	void drive() override;
};

#endif
