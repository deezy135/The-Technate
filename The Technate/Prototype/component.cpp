#include "component.h"

Uint32 Component::getID() {
	return ID;
}

void Component::setLocation(int x, int y) {
	rect.x = x;
	rect.y = y;
}
