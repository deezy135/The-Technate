#pragma once
#include <string>
#include <vector>
#include "input.h"
#include "camera.h"
#include "building.h"
#include "buildingmanager.h"
#include "map.h"
#include "label.h"
#include "engine.h"

class Player {
public:
	bool init(Engine *engine, BuildingManager *bm, Map *map);
	void update();
	void close();
	Camera * getCamera();
	void render();
private:
	Map *map;
	std::string name;
	Input * input;
	Camera camera;
	BuildingManager *bm;
	std::vector<Building> buildings;
	Building::Type selType;
	bool selPlace;
	Label money;
};