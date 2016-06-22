#pragma once
#include <SDL.h>
#include <string>
#include "texturemanager.h"
#include "fontmanager.h"
#include "colormanager.h"

class Graphics {
public:
	Graphics();
	~Graphics();
	bool init();
	void update();
	void close();
	TextureManager * getTextureManager();
	FontManager * getFontManager();
	ColorManager * getColorManager();
	SDL_Renderer *getRenderer();
private:
	SDL_Window *wnd;
	SDL_Renderer *rnd;

	TextureManager tm;
	FontManager fm;
	ColorManager cm;
	
	std::string wndTitle;
	int wndX, wndY;
	int wndW, wndH;
	Uint32 wndFlags;

	Uint32 rndFlags;
};