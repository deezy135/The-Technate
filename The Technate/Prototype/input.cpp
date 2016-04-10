#include "input.h"

Input::Input() {
}

bool Input::init() {
	clear();
	arrowUp = false;
	arrowDown = false;
	arrowLeft = false;
	arrowRight = false;
	w = false;
	a = false;
	s = false;
	d = false;
	mbLeft = false;
	mbRight = false;
	mbMiddle = false;
	mx = my = 0;
	mwY = 0;
	key1 = false;
	key2 = false;
	key3 = false;
	key4 = false;
	key5 = false;
	key6 = false;
	key7 = false;
	key8 = false;
	key9 = false;
	key0 = false;
	return true;
}

void Input::update() {
	clear();
	while (SDL_PollEvent(&ev)) {
		switch (ev.type) {
		case SDL_QUIT: quit = true; break;
		case SDL_MOUSEMOTION:
			mx = ev.motion.x;
			my = ev.motion.y;
			break;
		case SDL_MOUSEBUTTONDOWN:
			switch (ev.button.button) {
			case SDL_BUTTON_LEFT: mbLeft = true; break;
			case SDL_BUTTON_RIGHT: mbRight = true; break;
			case SDL_BUTTON_MIDDLE: mbMiddle = true; break;
			}
			break;
		case SDL_MOUSEBUTTONUP:
			switch (ev.button.button) {
			case SDL_BUTTON_LEFT: mbLeft = false; break;
			case SDL_BUTTON_RIGHT: mbRight = false; break;
			case SDL_BUTTON_MIDDLE: mbMiddle = false; break;
			}
			break;
		case SDL_MOUSEWHEEL:
			mwY = ev.wheel.y;
			break;
		case SDL_KEYDOWN:
			switch (ev.key.keysym.sym) {
			case SDLK_F5: f5 = true; break;
			case SDLK_RETURN: enter = true; break;
			case SDLK_UP: arrowUp = true; break;
			case SDLK_DOWN: arrowDown = true; break;
			case SDLK_LEFT: arrowLeft = true; break;
			case SDLK_RIGHT: arrowRight = true; break;
			case SDLK_w: w = true; break;
			case SDLK_a: a = true; break;
			case SDLK_s: s = true; break;
			case SDLK_d: d = true; break;
			case SDLK_1: key1 = true; break;
			case SDLK_2: key2 = true; break;
			case SDLK_3: key3 = true; break;
			case SDLK_4: key4 = true; break;
			case SDLK_5: key5 = true; break;
			case SDLK_6: key6 = true; break;
			case SDLK_7: key7 = true; break;
			case SDLK_8: key8 = true; break;
			case SDLK_9: key9 = true; break;
			case SDLK_0: key0 = true; break;
			}
			break;
		case SDL_KEYUP:
			switch (ev.key.keysym.sym) {
			//case SDLK_F5: f5 = false; break;
			//case SDLK_RETURN: enter = false; break;
			case SDLK_UP: arrowUp = false; break;
			case SDLK_DOWN: arrowDown = false; break;
			case SDLK_LEFT: arrowLeft = false; break;
			case SDLK_RIGHT: arrowRight = false; break;
			case SDLK_w: w = false; break;
			case SDLK_a: a = false; break;
			case SDLK_s: s = false; break;
			case SDLK_d: d = false; break;
			case SDLK_1: key1 = false; break;
			case SDLK_2: key2 = false; break;
			case SDLK_3: key3 = false; break;
			case SDLK_4: key4 = false; break;
			case SDLK_5: key5 = false; break;
			case SDLK_6: key6 = false; break;
			case SDLK_7: key7 = false; break;
			case SDLK_8: key8 = false; break;
			case SDLK_9: key9 = false; break;
			case SDLK_0: key0 = false; break;
			}
		}
	}
}

void Input::close() {
	quit = false;

}

bool Input::getQuit() {
	return quit;
}

bool Input::getArrowUp() {
	return arrowUp;
}

bool Input::getArrowDown() {
	return arrowDown;
}

bool Input::getArrowLeft() {
	return arrowLeft;
}

bool Input::getArrowRight() {
	return arrowRight;
}

bool Input::getW() {
	return w;
}

bool Input::getA() {
	return a;
}

bool Input::getS() {
	return s;
}

bool Input::getD() {
	return d;
}

bool Input::getF5() {
	return f5;
}

bool Input::getEnter() {
	return enter;
}

bool Input::getMbLeft() {
	return mbLeft;
}

bool Input::getMbRight() {
	return mbRight;
}

bool Input::getMbMiddle() {
	return mbMiddle;
}

int Input::getMX() {
	return mx;
}

int Input::getMY() {
	return my;
}

int Input::getMwY() {
	return mwY;
}

bool Input::getKey1() {
	return key1;
}

bool Input::getKey2() {
	return key2;
}

bool Input::getKey3() {
	return key3;
}

bool Input::getKey4() {
	return key4;
}

bool Input::getKey5() {
	return key5;
}

bool Input::getKey6() {
	return key6;
}

bool Input::getKey7() {
	return key7;
}

bool Input::getKey8() {
	return key8;
}

bool Input::getKey9() {
	return key9;
}

bool Input::getKey0() {
	return key0;
}

void Input::clear() {
	quit = false;
	enter = false;
	f5 = false;
	mwY = 0;
	/*arrowUp = false;
	arrowDown = false;
	arrowLeft = false;
	arrowRight = false;*/
}

Input::~Input() {
}