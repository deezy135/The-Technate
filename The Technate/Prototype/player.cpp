#include "player.h"
#include <iostream>

bool Player::init(Engine *engine, BuildingManager *bm, ResourceManager *rm, Map *map) {
	name = "Player 1";
	this->input = engine->getInput();
	this->bm = bm;
	this->rm = rm;
	this->map = map;
	camera.setSize(640, 480);
	camera.moveTo(100, 100);
	selPlace = false;
	SDL_Color color = { 13, 13, 13, 255 };

	moneyLabel.init(FontID::Roboto, ColorManager::ColorID::Translucent, 500, 10, "$");

	for (int i = 0; i < Resource::Type::Total; i++) {
		res[i].setQuantity(0);
		res[i].setType(Resource::Type(i));
		resCount[i].init(FontID::Roboto, ColorManager::ColorID::Black1, 35, 50 + i * 30, " ");
	}

	button1.init(FontID::SansSerif, ColorManager::ColorID::White,
		ColorManager::ColorID::Translucent, 100, 160, "Hello World!");
	textbox1.init(FontID::SansSerif, ColorManager::ColorID::White,
		ColorManager::ColorID::Translucent, 100, 260, 200, 20, "Hello World!");
	return true;
}

void Player::setMoney(int money) {
	this->money = money;
}

void Player::addResource(Resource::Type type, float quantity) {
	res[type].addQuantity(quantity);
}

void Player::update() {
	
	if (input->getKey1()) {
		selPlace = true;
		selType = Building::Type::Admin;
	}
	else if (input->getKey2()) {
		selPlace = true;
		selType = Building::Type::Warehouse;
	}
	else if (input->getKey3()) {
		selPlace = true;
		selType = Building::Type::Extract;
	}
	else if (input->getKey4()) {
		selPlace = true;
		selType = Building::Type::Process;
	}
	else if (input->getKey5()) {
		selPlace = true;
		selType = Building::Type::Airport;
	}
	else if (input->getKey6()) {
		selPlace = true;
		selType = Building::Type::Seaport;
	}
	if (selPlace && input->getMbLeft()) {
		selPlace = false;
		int tx = (input->getMX()*camera.getRect()->w / 640 + camera.getRect()->x) / 64;
		int ty = (input->getMY()*camera.getRect()->h / 480 + camera.getRect()->y) / 64;
		buildings.push_back(bm->create(this, selType, tx, ty));
		std::cout << buildings.size() << std::endl;
		map->placeBuilding(bm->getTexture(selType), tx, ty);
	}
	else if (!selPlace && input->getMbLeft()) {
		if (camera.getDragging()) {
			camera.update(input->getMX(), input->getMY());
		}
		else {
			camera.setDragging(true);
			camera.setDraggingXY(input->getMX(), input->getMY());
		}
	}
	else {
		if (camera.getDragging()) {
			camera.setDragging(false);
		}
		camera.update(5, input->getW(), input->getS(), input->getA(), input->getD());
	}
	camera.update(input->getMwY());

	moneyLabel.update();

	for (int i = 0; i < Resource::Type::Total; i++) {
		resCount[i].update();
	}
	button1.handleInput();
	textbox1.handleInput();

	button1.update();
	textbox1.update();
}

void Player::updateLogics() {
	for (int i = 0; i < buildings.size(); i++) {
		buildings[i]->updateLogics();
	}
	for (int i = 0; i < Resource::Type::Total; i++) {
		resCount[i].setText(std::to_string(res[i].getQuantity()).c_str());
	}
}

void Player::close() {
	input = NULL;
	name.clear();
	moneyLabel.destroy();
	for (int i = 0; i < Resource::Type::Total; i++) {
		resCount[i].destroy();
	}
}

Camera * Player::getCamera() {
	return &camera;
}

void Player::render() {
	if (selPlace) {
		bm->render(selType, &camera, input->getMX(), input->getMY());
	}
	
	moneyLabel.render(350, 10);
	rm->render(Resource::Type::Wood, 10, 50);
	rm->render(Resource::Type::Iron, 10, 80);
	rm->render(Resource::Type::Steel, 10, 110);
	for (int i = 0; i < Resource::Type::Total; i++) {
		resCount[i].render();
	}

	button1.render();
	textbox1.render();
}
