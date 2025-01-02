#include "AbstractClass.h"
#include <iostream>

AbstractClass::AbstractClass() {}

void AbstractClass::TemplateMethod() {
	MethodA();
	MethodB();
	MethodX();
	MethodY();
}

void AbstractClass::MethodX() {
	std::cout << "methodX called" << std::endl;
}

void AbstractClass::MethodY() {
	std::cout << "methodY called" << std::endl;
}
