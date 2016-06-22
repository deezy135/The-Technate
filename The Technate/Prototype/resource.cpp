#include "resource.h"

void Resource::setType(Type type) {
	this->type = type;
}

void Resource::setMax(float max) {
	this->max = max;
}

void Resource::setSpeed(float speed) {
	this->speed = speed;
}

void Resource::setQuantity(float quantity) {
	this->quantity = quantity;
}

void Resource::addQuantity(float quantity) {
	this->quantity += quantity;
}

Resource::Type Resource::getType() {
	return type;
}

float Resource::getMax() {
	return max;
}

float Resource::getQuantity() {
	return quantity;
}
