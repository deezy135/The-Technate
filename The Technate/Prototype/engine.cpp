#include "engine.h"
#include "log.h"
#include <SDL_image.h>

Engine::Engine() {

}

bool Engine::init() {
	if (SDL_Init(SDL_INIT_VIDEO) < 0) {
		Log::showError(SDL_GetError());
		return false;
	}
	if (!(IMG_Init(IMG_INIT_PNG | IMG_INIT_JPG) & (IMG_INIT_PNG | IMG_INIT_JPG))) {
		Log::showError(SDL_GetError());
		SDL_Quit();
		return false;
	}
	if (TTF_Init() == -1) {
		SDL_Quit();
		IMG_Quit();
		return false;
	}
	if (!graphics.init()) {
		Log::showError(ErrorMsg::EngineInit);
		TTF_Quit();
		IMG_Quit();
		SDL_Quit();
		return false;
	}
	if (!input.init()) {
		graphics.close();
		TTF_Quit();
		IMG_Quit();
		SDL_Quit();
		return false;
	}
	return true;
}

Input * Engine::getInput() {
	return &input;
}

Graphics * Engine::getGraphics() {
	return &graphics;
}

void Engine::updateInput() {
	input.update();
}

void Engine::updateGraphics() {
	graphics.update();
}

void Engine::close(){
	graphics.close();
	input.close();
	TTF_Quit();
	IMG_Quit();
	SDL_Quit();
}

Engine::~Engine() {
}