#pragma once
#include <SDL.h>

class Camera {
public:
	void init();
	void move(int x, int y);
	void moveTo(int x, int y);
	SDL_Rect * getRect();
	void setSize(int w, int h);
	void setDragging(bool value);
	bool getDragging();
	void setDraggingXY(int x, int y);
	void update(int speed, bool up, bool down, bool left, bool right);
	void update(int mx, int my);
	void update(int mwy);

private:
	SDL_Rect rect;
	bool dragging;
	int dragX, dragY;
	int camDragX, camDragY;
};