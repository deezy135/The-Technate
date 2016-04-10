#pragma once
#include <SDL_ttf.h>
#include <SDL.h>
#include <string>

class Label {
public:
	void init(SDL_Renderer *rnd, TTF_Font *font,
		SDL_Color color, int x, int y, const char *text);
	void setRenderer(SDL_Renderer *rnd);
	void setFont(TTF_Font *font);
	void setColor(SDL_Color color);
	void setPosition(int x, int y);
	void setText(const char *text);
	void render();
	void render(int x, int y);
	void create();
	void destroy();
private:
	SDL_Rect rect;
	SDL_Color color;
	TTF_Font *font;
	SDL_Renderer *rnd;
	SDL_Texture *tex;
	std::string text;
};