#pragma once
#include "building.h"
#include "adminbuilding.h"
#include "texturemanager.h"
#include "camera.h"

class BuildingManager {
public:
	bool init(TextureManager * tm);
	Building create(Building::Type type);
	void render(Building::Type type, int x, int y);
	void render(Building::Type type, Camera *cam, int mx, int my);
	Texture *getTexture(Building::Type type);
private:
	Texture adminTex;
	Texture warehouseTex;
	Texture extractTex;
	Texture processTex;
	Texture airportTex;
	Texture seaportTex;
};