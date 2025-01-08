

a.out: arraygen.o bubble.o main.o isort.o shell.o fullrandom.o nearlysorted.o
	g++ $^ -o $@

main.o: main.cpp
	g++ -c $^ -o $@

arraygen.o: ArrayGen.cpp
	g++ -c $^ -o $@

isort.o: ISort.cpp
	g++ -c $^ -o $@

bubble.o: bubble.cpp
	g++ -c $^ -o $@

shell.o: shellsort.cpp
	g++ -c $^ -o $@

fullrandom.o: FullRandom.cpp
	g++ -c $^ -o $@

nearlysorted.o: NearlySorted.cpp
	g++ -c $^ -o $@


clean:
	rm -f *.o a.out
