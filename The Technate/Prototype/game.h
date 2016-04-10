#pragma once
#include "engine.h"
#include "state.h"
#include "playstate.h"
#include "menustate.h"

class Game {
public:
	Game();
	~Game();
	bool init(Engine * engine);
	void run();
	void close();
private:
	Engine * eng;
	State * state;
	PlayState play;
	MenuState menu;

};