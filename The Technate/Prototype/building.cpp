#include "building.h"

void Building::render(int x, int y) {
	tex->render(x, y);
}

Building::Type Building::getType() {
	return type;
}

