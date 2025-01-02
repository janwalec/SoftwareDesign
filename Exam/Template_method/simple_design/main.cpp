#include <iostream>
#include "AbstractClass.h"
#include "ConcreteClass1.h"

int main() {
	AbstractClass* a = new ConcreteClass1();
	a->TemplateMethod();
	delete a;
	//hello world
	return 0;
}
