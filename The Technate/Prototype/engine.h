#pragma once
#include <SDL.h>
#include "graphics.h"
#include "input.h"

class Engine {
public:
	Engine();
	~Engine();
	bool init();
	Input * getInput();
	Graphics * getGraphics();
	void updateInput();
	void updateGraphics();
	void close();
private:
	Graphics graphics;
	Input input;
};