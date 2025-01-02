#ifndef ABSTRACTCLASS_H
#define ABSTRACTCLASS_H

class AbstractClass {
public:
	explicit AbstractClass();
	void TemplateMethod();
protected:
	virtual void MethodA() = 0;
	virtual	void MethodB() = 0;
private:
	void MethodX();
	void MethodY();
};

#endif
