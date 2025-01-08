#include "Car.hpp"
#include "IVehicle.hpp"
#include <iostream>

Car::Car() : IVehicle() {

}


void Car::drive() {
	std::cout << "Driving a car\n";
}
