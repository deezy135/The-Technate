#pragma once
//#include "player.h"
#include "camera.h"
#include "building.h"
#include "adminbuilding.h"
#include "extractbuilding.h"
#include "processbuilding.h"
#include "texturemanager.h"

class Player;

class BuildingManager {
public:
	bool init(TextureManager * tm);
	Building* create(Player *player, Building::Type type, int x, int y);
	void render(Building::Type type, int x, int y);
	void render(Building::Type type, Camera *cam, int mx, int my);
	Texture *getTexture(Building::Type type);
	void close();
private:
	Texture tex[Building::Type::Total];
};