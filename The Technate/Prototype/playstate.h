#pragma once
#include "state.h"
#include "player.h"
#include "map.h"
#include "timer.h"
#include "label.h"

class PlayState : public State {
public:
	virtual bool init(Engine * engine);
	virtual StateEvent update();
	virtual void close();
private:
	Uint32 logicPerSecond;
	Uint32 physicsPerSecond;
	Uint32 graphicsPerSecond;
	Timer logicTimer;
	Timer physicsTimer;
	Timer graphicsTimer;
	Player player;
	Map map;
	BuildingManager bm;
	Input * input;
	Label fps;
};