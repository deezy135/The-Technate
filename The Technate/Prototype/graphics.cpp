#include "graphics.h"
#include "log.h"

Graphics::Graphics(){
	wnd = NULL;
	rnd = NULL;
	
	wndTitle = "The Technate prototype";
	wndX = SDL_WINDOWPOS_CENTERED, wndY = SDL_WINDOWPOS_CENTERED;
	wndW = 640, wndH = 480;
	wndFlags = SDL_WINDOW_SHOWN | SDL_WINDOW_RESIZABLE;

	rndFlags = SDL_RENDERER_ACCELERATED | SDL_RENDERER_PRESENTVSYNC;
}

bool Graphics::init() {
	wnd = SDL_CreateWindow(wndTitle.c_str(), wndX, wndY, wndW, wndH, wndFlags);
	if (wnd == NULL) {
		Log::showError(SDL_GetError());
		return false;
	}
	rnd = SDL_CreateRenderer(wnd, -1, rndFlags);
	if (rnd == NULL) {
		Log::showError(SDL_GetError());
		SDL_DestroyWindow(wnd);
		return false;
	}
	//SDL_SetHint(SDL_HINT_RENDER_SCALE_QUALITY, "linear");
	tm.setRenderer(rnd);
	if (!tm.loadTextures()) {
		Log::showError(ErrorMsg::LoadTextures);
		SDL_DestroyRenderer(rnd);
		SDL_DestroyWindow(wnd);
		return false;
	}
	fm.setRenderer(rnd);
	if (!fm.loadFonts()) {
		Log::showError("Fonts have not been initialized");
		tm.freeTextures();
		SDL_DestroyRenderer(rnd);
		SDL_DestroyWindow(wnd);
		return false;
	}

	return true;
}

void Graphics::update() {
	SDL_RenderPresent(rnd);
	SDL_RenderClear(rnd);
}

void Graphics::close() {
	tm.freeTextures();
	SDL_DestroyRenderer(rnd);
	SDL_DestroyWindow(wnd);
}

TextureManager * Graphics::getTextureManager() {
	return &tm;
}

FontManager * Graphics::getFontManager() {
	return &fm;
}

SDL_Renderer * Graphics::getRenderer() {
	return rnd;
}

Graphics::~Graphics() {
	wnd = NULL;
	rnd = NULL;
}