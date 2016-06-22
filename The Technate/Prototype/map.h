#pragma once
#include "constants.hpp"
#include "texturemanager.h"
#include "texture.h"
#include "camera.h"
#include "building.h"

class Map {
public:
	enum Tile { Land, Water, Hill, Total };
	static const int MAX_WIDTH;
	bool init(TextureManager * tm);
	void update();
	void placeBuilding(Texture* buildingTex, int tx, int ty);
	void render(Camera * camera);
	void close();
private:
	Tile field[MaxMapHeight][MaxMapWidth];
	Texture tile[Tile::Total];
	Texture tex;
	
	int tileW, tileH;
	int rows, cols;
};