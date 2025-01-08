# Foldery i pliki
SRC_DIR = src
OBJ_DIR = obj
SRC = main.cpp Car.cpp Bike.cpp Factory.cpp# file1.cpp file2.cpp
OBJ = ${SRC:%.cpp=${OBJ_DIR}/%.o}
OUT = program

# Kompilator i flagi
CXX = g++
CXXFLAGS = -Wall -g

# Reguła domyślna
all: ${OUT}

# Tworzenie a.out z wszystkich plików obiektowych
${OUT}: ${OBJ}
	${CXX} ${OBJ} -o ${OUT}

# Reguła dla każdego pliku obiektowego
${OBJ_DIR}/%.o: %.cpp | ${OBJ_DIR}
	${CXX} ${CXXFLAGS} -c $< -o $@

${OBJ_DIR}:
	mkdir -p ${OBJ_DIR}

clean:
	rm -rf ${OBJ_DIR} ${OUT}
