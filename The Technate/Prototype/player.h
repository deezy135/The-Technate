#pragma once
#include <string>
#include <vector>
#include "input.h"
#include "camera.h"
#include "building.h"
#include "buildingmanager.h"
#include "resourcemanager.h"
#include "map.h"
#include "label.h"
#include "engine.h"
#include "resource.h"
#include "button.h"
#include "textbox.h"

class Player {
public:
	bool init(Engine *engine, BuildingManager *bm, ResourceManager *rm, Map *map);
	void setMoney(int money);
	void addResource(Resource::Type type, float quantity);
	void update();
	void updateLogics();
	void close();
	Camera * getCamera();
	void render();
private:
	Map *map;
	std::string name;
	Input *input;
	Camera camera;
	BuildingManager *bm;
	ResourceManager *rm;
	std::vector<Building*> buildings;
	Building::Type selType;
	bool selPlace;
	int money;
	//Resource money;
	Label moneyLabel;
	Resource res[Resource::Type::Total];
	Label resCount[Resource::Type::Total];
	Button button1;
	Textbox textbox1;
};