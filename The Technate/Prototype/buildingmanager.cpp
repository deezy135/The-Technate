#include "buildingmanager.h"
#include "player.h"

bool BuildingManager::init(TextureManager * tm) {
	for (int i = 0; i < Building::Type::Total; i++) {
		tex[i].setImage(tm, TexID(TexID::AdminB + i));
		tex[i].setSize(64, 64);
	}
	return true;
}

Building* BuildingManager::create(Player *player, Building::Type type, int x, int y) {
	Building *building = NULL;
	switch (type) {
	case Building::Admin:
	{
		building = new AdminBuilding();
		building->setPlayer(player);
		building->setPosition(x, y);
		building->setType(type);
	}
	break;
	case Building::Process:
	{
		building = new ProcessBuilding();
		building->setPlayer(player);
		building->setPosition(x, y);
		building->setType(type);
	}
	break;
	case Building::Extract:
	{
		building = new ExtractBuilding();
		building->setPlayer(player);
		building->setPosition(x, y);
		building->setType(type);
		((ExtractBuilding*)building)->setOutput(0, Resource::Type::Wood, 2.f / 20.f, 10.f);
	}
	break;
	}
	return building;
}

void BuildingManager::render(Building::Type type, int x, int y) {
	tex[type].render(x, y);
}

void BuildingManager::render(Building::Type type, Camera *cam, int mx, int my) {
	int x, y, w, h;
	int cx = cam->getRect()->x, cy = cam->getRect()->y;
	int cw = cam->getRect()->w, ch = cam->getRect()->h;
	w = 64 * 640 / cw;
	h = 64 * 480 / ch;
	x = ((cx + mx*cw / 640) / 64 * 64 - cx) * 640 / cw;
	y = ((cy + my*ch / 480) / 64 * 64 - cy) * 480 / ch;
	
	tex[type].setSize(w, h);
	tex[type].setLocation(x, y);
	tex[type].render();
}

Texture * BuildingManager::getTexture(Building::Type type) {
	return &tex[type];
}

void BuildingManager::close() {
	for (int i = 0; i < Building::Type::Total; i++) {
		tex[i].destroy();
	}
}
