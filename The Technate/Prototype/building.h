#pragma once
#include "texture.h"
//#include "player.h"
class Player;
class Building {
public:
	enum Type { Admin, Warehouse, Extract, Process, Airport, Seaport, Total };
	
	virtual void setPlayer(Player *player);
	virtual void setType(Type type);
	virtual void setPosition(int x, int y);
	virtual void update();
	virtual void updateLogics() = 0;
	virtual void updatePhysics() = 0;
	virtual void render(int x, int y);
	virtual Type getType();
protected:
	Player *player;
	Type type;
	Texture *tex;
	int x, y;
};