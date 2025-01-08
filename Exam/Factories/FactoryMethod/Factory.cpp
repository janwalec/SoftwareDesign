#include "Factory.hpp"
#include "IVehicle.hpp"
#include "Car.hpp"
#include "Bike.hpp"
#include <iostream>

Factory::Factory() {
}

IVehicle* Factory::produce(std::string name) {
	if(name == "car")
		return new Car();
	if(name == "bike")
		return new Bike();
	return nullptr;
}
