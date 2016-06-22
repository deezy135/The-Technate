#include "building.h"
#include "player.h"

void Building::setPlayer(Player * player) {
	this->player = player;
}

void Building::setType(Type type) {
	this->type = type;
}

void Building::setPosition(int x, int y) {
	this->x = x;
	this->y = y;
}

void Building::update() {

}

void Building::render(int x, int y) {
	tex->render(x, y);
}

Building::Type Building::getType() {
	return type;
}

