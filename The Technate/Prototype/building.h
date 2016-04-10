#pragma once
#include "texture.h"

class Building {
public:
	enum Type { Admin, Warehouse, Extract, Process, Airport, Seaport };
	virtual void render(int x, int y);
	virtual Type getType();
protected:
	Type type;
	Texture *tex;
	int x, y;
};