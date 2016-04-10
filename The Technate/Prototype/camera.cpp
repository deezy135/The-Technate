#include "camera.h"
#include <iostream>

void Camera::init() {
	dragX = dragY = 0;
	camDragX = camDragY = 0;
}

void Camera::move(int x, int y) {
	static int xx = rect.x, yy = rect.y;
	rect.x += x, rect.y += y;
	if (rect.x < 0) rect.x = 0;
	if (rect.y < 0) rect.y = 0;
	if (rect.x + rect.w > 64 * 25) rect.x = 64 * 25 - rect.w;
	if (rect.y + rect.h > 64 * 25) rect.y = 64 * 25 - rect.h;
	if (rect.x != xx || rect.y != yy) {
		xx = rect.x, yy = rect.y;
		std::cout << xx << " " << yy << std::endl;
	}
}

void Camera::moveTo(int x, int y) {
	rect.x = x, rect.y = y;
}

SDL_Rect * Camera::getRect() {
	return &rect;
}

void Camera::setSize(int w, int h) {
	rect.w = w, rect.h = h;
}

void Camera::setDragging(bool value) {
	dragging = value;
}

bool Camera::getDragging() {
	return dragging;
}

void Camera::setDraggingXY(int x, int y) {
	dragX = x, dragY = y;
	camDragX = rect.x, camDragY = rect.y;
}

void Camera::update(int speed, bool up, bool down, bool left, bool right) {
	if (up)		move(0, -speed);
	if (down)	move(0, speed);
	if (left)	move(-speed, 0);
	if (right)	move(speed, 0);
}

void Camera::update(int mx, int my) {
	if (dragging) {
		rect.x = camDragX + (dragX - mx)* rect.w / 640;
		rect.y = camDragY + (dragY - my)* rect.h / 480;
		if (rect.x < 0) rect.x = 0;
		if (rect.y < 0) rect.y = 0;
		if (rect.x + rect.w > 64 * 25) rect.x = 64 * 25 - rect.w;
		if (rect.y + rect.h > 64 * 25) rect.y = 64 * 25 - rect.h;
	}
}

void Camera::update(int mwy) {
	if (mwy == 0) return;
	if (mwy < 0) {
		rect.x -= 32, rect.y -= 32;
		rect.h += 64 * rect.h / rect.w;
		rect.w += 64;
		if (rect.h > 64 * 25 || rect.w > 64 * 25) {
			rect.h -= 64 * rect.h / rect.w;
			rect.w -= 64;
		}
	}
	else if (mwy > 0) {
		rect.x += 32, rect.y += 32;
		rect.h -= 64 * rect.h / rect.w;
		rect.w -= 64;
		if (rect.h < 64 || rect.w < 64) {
			rect.x -= 32, rect.y -= 32;
			rect.h += 64 * rect.h / rect.w;
			rect.w += 64;
		}
	}
	if (rect.x < 0) rect.x = 0;
	if (rect.y < 0) rect.y = 0;
	if (rect.x + rect.w > 64 * 25) rect.x = 64 * 25 - rect.w;
	if (rect.y + rect.h > 64 * 25) rect.y = 64 * 25 - rect.h;
}
