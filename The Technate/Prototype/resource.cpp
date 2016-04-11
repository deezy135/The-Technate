#include "resource.h"

void Resource::setTexture(Texture * texture) {
	tex = texture;
}

void Resource::setName(char * name) {
	this->name = name;
}

void Resource::setQuantity(int quantity) {
	this->quantity = quantity;
}

void Resource::render(int x, int y) {
	tex->render(x, y);
}

const char * Resource::getName() {
	return name.c_str();
}

int Resource::getQuantity() {
	return quantity;
}

void Resource::addQuantity(int add) {
	quantity += add;
}
