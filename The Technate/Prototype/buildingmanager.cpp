#include "buildingmanager.h"

bool BuildingManager::init(TextureManager * tm) {
	adminTex.setRenderer(tm->getRenderer());
	warehouseTex.setRenderer(tm->getRenderer());
	extractTex.setRenderer(tm->getRenderer());
	processTex.setRenderer(tm->getRenderer());
	airportTex.setRenderer(tm->getRenderer());
	seaportTex.setRenderer(tm->getRenderer());

	adminTex.setTexture(tm->getTexture(TexID::AdminB));
	warehouseTex.setTexture(tm->getTexture(TexID::WarehouseB));
	extractTex.setTexture(tm->getTexture(TexID::ExtractB));
	processTex.setTexture(tm->getTexture(TexID::ProcessB));
	airportTex.setTexture(tm->getTexture(TexID::AirportB));
	seaportTex.setTexture(tm->getTexture(TexID::SeaportB));

	SDL_Rect rect = { 0, 0, 64, 64 };
	adminTex.setRect(&rect);
	warehouseTex.setRect(&rect);
	extractTex.setRect(&rect);
	processTex.setRect(&rect);
	airportTex.setRect(&rect);
	seaportTex.setRect(&rect);
	return true;
}

Building BuildingManager::create(Building::Type type) {
	switch (type) {
	case Building::Type::Admin:
		return Adminbuilding();
	/*case Building::Type::Warehouse:
		return Warehousebuilding();
	case Building::Type::Extract:
		return Extractbuilding();
	case Building::Type::Process:
		return Processbuilding();
	case Building::Type::Airport:
		return Airportbuilding();
	case Building::Type::Seaport:
		return Seaportbuilding();*/
	}
	return Building();
}

void BuildingManager::render(Building::Type type, int x, int y) {
	switch (type) {
	case Building::Type::Admin:
		adminTex.render(x, y);
		break;
	/*case Building::Type::Warehouse:
	case Building::Type::Extract:
	case Building::Type::Process:
	case Building::Type::Airport:
	case Building::Type::Seaport:*/
	}
}

void BuildingManager::render(Building::Type type, Camera * cam, int mx, int my) {
	int x, y, w, h;
	int cx = cam->getRect()->x, cy = cam->getRect()->y;
	int cw = cam->getRect()->w, ch = cam->getRect()->h;
	w = 64 * 640 / cw;
	h = 64 * 480 / ch;
	x = ((cx + mx*cw / 640) / 64 * 64 - cx) * 640 / cw;
	y = ((cy + my*ch / 480) / 64 * 64 - cy) * 480 / ch;
	SDL_Rect r = { x, y, w, h };
	switch (type) {
	case Building::Type::Admin:
		adminTex.setRect(&r);
		adminTex.render(x, y);
		break;
		/*case Building::Type::Warehouse:
		case Building::Type::Extract:
		case Building::Type::Process:
		case Building::Type::Airport:
		case Building::Type::Seaport:*/
	}
}

Texture * BuildingManager::getTexture(Building::Type type) {
	switch (type) {
	case Building::Type::Admin:
		return &adminTex;
		case Building::Type::Warehouse:
		return &warehouseTex;
		case Building::Type::Extract:
		return &extractTex;
		case Building::Type::Process:
		return &processTex;
		case Building::Type::Airport:
		return &airportTex;
		case Building::Type::Seaport:
		return &seaportTex;
	}
	return NULL;
}
