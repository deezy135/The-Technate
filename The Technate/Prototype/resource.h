#pragma once
#include <string>
#include "texture.h"

class Resource {
public:
	void setTexture(Texture* texture);
	void setName(char *name);
	void setQuantity(int quantity);
	void render(int x, int y);
	const char* getName();
	int getQuantity();
	void addQuantity(int add);
private:
	Texture *tex;
	std::string name;
	int quantity;
};