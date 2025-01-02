#ifndef CONCRETECLASS_H
#define CONCRETECLASS_H
#include "AbstractClass.h"

class ConcreteClass1 : public AbstractClass {
	using AbstractClass::AbstractClass;
	void MethodA() override;
	void MethodB() override;

};



#endif
