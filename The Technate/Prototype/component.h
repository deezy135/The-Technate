#pragma once
#include "SDL.h"

class Component {
public:
	virtual Uint32 getID();
	virtual void setLocation(int x, int y);

	virtual void handleInput() = 0;
	virtual void render() = 0;
	virtual void render(int x, int y) = 0;
	virtual void update() = 0;
protected:
	Uint32 ID;
	SDL_Rect rect;
};