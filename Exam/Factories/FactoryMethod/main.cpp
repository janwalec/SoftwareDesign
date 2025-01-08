#include <iostream>
#include "IVehicle.hpp"
#include "Factory.hpp"
using namespace std;

int main(void) {
	Factory a;
	IVehicle* v1 = a.produce("car");
	IVehicle* v2 = a.produce("bike");
	v1->drive();
	v2->drive();

	delete v1;
	delete v2;
	
	return 0;
}	
