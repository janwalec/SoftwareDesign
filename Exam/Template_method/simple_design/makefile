

a.out: abstr.o concr.o main.o
	g++ $^ -o $@

concr.o: ConcreteClass1.cpp
	g++ -c $^ -o $@

abstr.o: AbstractClass.cpp
	g++ -c $^ -o $@

main.o: main.cpp
	g++ -c $^ -o $@

clean:
	rm -f *.o a.out
