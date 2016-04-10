#pragma once
#include "state.h"
#include "player.h"
#include "map.h"

class PlayState : public State {
public:
	virtual bool init(Engine * engine);
	virtual StateEvent update();
	virtual void close();
private:
	Player player;
	Map map;
	BuildingManager bm;
	Input * input;
};