#include "player.h"
#include <iostream>
bool Player::init(Engine *engine, BuildingManager *bm, Map *map) {
	
	name = "Player 1";
	this->input = engine->getInput();
	this->bm = bm;
	this->map = map;
	camera.setSize(640, 480);
	camera.moveTo(100, 100);
	selPlace = false;
	SDL_Color color = { 82, 193, 76, 255 };
	moneyLabel.init(engine->getGraphics()->getRenderer(),
		engine->getGraphics()->getFontManager()->getFont(FontID::Roboto),
		color, 500, 10, " ");
	moneyTex.setRenderer(engine->getGraphics()->getRenderer());
	moneyTex.setTexture(engine->getGraphics()->getTextureManager()->getTexture(TexID::MoneyR));
	SDL_Rect rect = { 0, 0, 32, 32 };
	moneyTex.setRect(&rect);
	money.setName("Money ");
	money.setQuantity(1000);
	money.setTexture(&moneyTex);
	moneyLabel.setText(money.getName());
	return true;
}

void Player::update() {
	if (input->getArrowUp()) {
		money.addQuantity(5);
		moneyLabel.append(std::to_string(money.getQuantity()).c_str());
	}
	else if (input->getArrowDown()) {
		money.addQuantity(-5);
		moneyLabel.append(std::to_string(money.getQuantity()).c_str());
	}
	if (input->getKey1()) {
		selPlace = true;
		selType = Building::Type::Admin;
	}
	if (selPlace && input->getMbLeft()) {
		selPlace = false;
		buildings.push_back(bm->create(selType));
		std::cout << buildings.size() << std::endl;
		map->placeBuilding(bm->getTexture(selType),
			(input->getMX()*camera.getRect()->w/640 + camera.getRect()->x) / 64,
			(input->getMY()*camera.getRect()->h/480 + camera.getRect()->y) / 64);
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
}

void Player::close() {
	input = NULL;
	name.clear();
	moneyLabel.destroy();
}

Camera * Player::getCamera() {
	return &camera;
}

void Player::render() {
	if (selPlace) {
		bm->render(selType, &camera, input->getMX(), input->getMY());
	}
	money.render(300, 10);
	moneyLabel.render(350, 10);
}
