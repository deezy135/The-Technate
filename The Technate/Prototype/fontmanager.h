#pragma once
#include <SDL_ttf.h>

class FontManager {
public:
	static const int MaxFonts = 10;
	void setRenderer(SDL_Renderer *rnd);
	bool loadFonts();
	bool loadFont(const char *filename);
	void freeFonts();
	void freeFont();
	TTF_Font *getFont(int i);

private:
	Uint32 fonts;
	TTF_Font *font[MaxFonts];
	SDL_Renderer *rnd;
};